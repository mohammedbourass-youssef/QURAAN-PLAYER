using BusnessLogicLayer;
using NAudio.CoreAudioApi;
using QURAAN_PLAYER.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QURAAN_PLAYER
{
    public partial class ctrlPlayPauseMusic : UserControl
    {
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        MMDevice defaultDevice = null;
        string currentplay = string.Empty;
        TimeSpan reachedtime = TimeSpan.Zero;
        bool paused = true;
        //functions 
        public void LoadInfo()
        {
            
            ChangeSoundPictureLevel();
        }
        public void _SuratToPlay(object sender, int SuratID)
        {
            minute = 0;
            seconde = 0;
            lblTimeCounter.Text = "00:00";
            BarController.Start();
            bar.Value = 0;
            clsSurat surat = clsSurat.Find(SuratID);
            clsSong.Play(surat.path);
            currentplay = "";
            reachedtime = TimeSpan.Zero;
            currentplay = surat.path;
            btnPlayer.Image = Resources.icons8_play_40;
            paused = false;
            //lbl Fill the bar 
            lbltitle.Text = "\t"+"السورة "  + "\t"+surat.Name + "\t" + " | المقرئ الشيخ "+" " + surat.reader.FirstName +" "+ surat.reader.LastName+" ";
            TimeSpan time = clsSong.GetTotalMax();
            DateTime date = DateTime.Today.Add(time);
            if (date.Second < 10)
                lblMAXTime.Text = date.Minute.ToString() + ":0" + date.Second.ToString();
            else
                lblMAXTime.Text = date.Minute.ToString() + ":" + date.Second.ToString();

            bar.Maximum = Convert.ToInt32(time.TotalSeconds);
            secondescounter = 0;
        }
        void ChangeSoundPictureLevel()
        {
            if (SoundController.Value > 50)
            {
                soundPicture.Image = Resources.HighLevel_sound_40__1_;
            }
            else if (SoundController.Value == 0)
            {
                soundPicture.Image = Resources.mute_40;
            }
            else
                soundPicture.Image = Resources.Middle_sound_40__1_;
        }
        private void btnPlayer_Click_1(object sender, EventArgs e)
        {
            if (currentplay != "")
            {
                if (paused)
                {
                    btnPlayer.Image = Resources.icons8_play_40;
                    paused = false;
                    clsSong.Play(currentplay, reachedtime);
                    btnPlayer.Image = Resources.icons8_play_40;
                    paused = false;
                    BarController.Start();
                }
                else
                {
                    btnPlayer.Image = Resources.pause_40;
                    paused = true;
                    reachedtime = clsSong.GetCurrentLength();
                    BarController.Stop();
                    clsSong.Stop();
                }
            }
        }
        public ctrlPlayPauseMusic()
        {
            InitializeComponent();
            defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            SoundController.Value = Convert.ToInt32(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
        }
        private void SoundLevelCheck_Tick_1(object sender, EventArgs e)
        {
            SoundController.Value = Convert.ToInt32(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            ChangeSoundPictureLevel();
        }
        private void BarController_Tick(object sender, EventArgs e)
        {
            TimeSpan time = clsSong.GetCurrentLength();
            
        }
        private void pnlPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SoundController_Scroll_1(object sender, ScrollEventArgs e)
        {
            ChangeSoundPictureLevel();

            float newVolume = SoundController.Value / 100f;
            defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = newVolume;
        }
        int minute = 0;
        int seconde = 0;
        
        int secondescounter = 1;

        private void BarController_Tick_1(object sender, EventArgs e)
        {
            if (seconde < 10)
            {
                lblTimeCounter.Text = minute.ToString() + ":0" + seconde.ToString();
            }
            else
            {
                lblTimeCounter.Text = minute.ToString() + ":" + seconde.ToString();
            }
            if(seconde == 59)
            {
                seconde = 0;
                minute++;
            }
            else
            {
                seconde++;
            }
            if(bar.Value == bar.Maximum || secondescounter > bar.Maximum)
            {
                bar.Value = 0;
                clsSong.Stop();
                BarController.Stop();
                lblTimeCounter.Text = "00:00";
            }
            else
            {
                bar.Value = secondescounter;
                secondescounter++;
            }
 
        }
        private void bar_Scroll(object sender, ScrollEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentplay))
            {
                TimeSpan time = TimeSpan.FromSeconds(bar.Value);
                clsSong.Stop();
                clsSong.Play(currentplay, time);
                secondescounter = Convert.ToInt32(time.TotalSeconds);
                minute = time.Minutes;
                seconde = time.Seconds;
                lblTimeCounter.Text = minute.ToString() + ":" + seconde.ToString();
                BarController.Start();
            }
            else 
                bar.Value = 0;
        }

        private void soundPicture_Click(object sender, EventArgs e)
        {

            if(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar == 0)
            {
                defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = 0.1f;
                soundPicture.Image = Resources.HighLevel_sound_40__1_;
            }
            else 
            {
                defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = 0;
                soundPicture.Image = Resources.mute_40;
                SoundController.Value = 0;
            }

         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
