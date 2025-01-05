using Guna.UI2.WinForms;
using QURAAN_PLAYER.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using BusnessLogicLayer;
namespace QURAAN_PLAYER
{
    public partial class frmmain : Form
    {
        //bools to check where we are 
      
        enum EnIamIn {None, itshome, itsAddReader , itsaddsurat , itsallSurat, itsallreaders,itsfavorate }
        EnIamIn currentposition = EnIamIn.None;
        void _ChangeMenuButtonColor(object sender)
        {
            clsButtonPropritieschange.ChangeToNonClicked(btnADDSURAT, btnHome, btnFavorite, btnAllSong, btnAllReaders);
            clsButtonPropritieschange.ChangeToClicked((Guna2Button)sender);
        }

       
        //constructor 
        public frmmain()
        {
            InitializeComponent();
        }

        //events 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        public void btnHome_Click(object sender, EventArgs e)
        {
            if (currentposition != EnIamIn.itshome)
            {
                _ChangeMenuButtonColor(sender);
                frmHome frm = new frmHome();
                frm.TopLevel = false;
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                frm.dataBack += ctrlPlayPauseMusic1._SuratToPlay;
                currentposition = EnIamIn.itshome;
            }
            
        }

        private void btnADDSURAT_Click(object sender, EventArgs e)
        {
           
            if (currentposition != EnIamIn.itsaddsurat)
            {
                _ChangeMenuButtonColor(sender);
                frmAddSurat frm = new frmAddSurat();
                frm.TopLevel = false;
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                currentposition = EnIamIn.itsaddsurat;
            }
        }
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            _ChangeMenuButtonColor(sender);
            currentposition = EnIamIn.itsAddReader;
        }
        public void btnAllSong_Click(object sender, EventArgs e)
        {
            _ChangeMenuButtonColor(sender);
            if(currentposition != EnIamIn.itsallSurat)
            {
                frmAllSurahs frm = new frmAllSurahs();
                frm.TopLevel = false;
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                frm.dataBack += ctrlPlayPauseMusic1._SuratToPlay;
                currentposition = EnIamIn.itsallSurat;
            }
        }
        private void btnAllReaders_Click(object sender, EventArgs e)
        {
            _ChangeMenuButtonColor(sender);
            
            if (currentposition != EnIamIn.itsallreaders)
            {
                frmAllReaders frm = new frmAllReaders();
                frm.TopLevel = false;
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                currentposition = EnIamIn.itsallreaders;
            }
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            _ChangeMenuButtonColor(sender);

            if (currentposition != EnIamIn.itsfavorate)
            {
                frmFavorite frm = new frmFavorite();
                frm.TopLevel = false;
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                frm.dataBack += ctrlPlayPauseMusic1._SuratToPlay;
                currentposition = EnIamIn.itsfavorate;
            }
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
           ctrlPlayPauseMusic1.LoadInfo();
            btnHome_Click(btnHome, e);
            clsGlobalFrms.pnlbody = pnlBody;
            clsGlobalFrms.mainform = this;
        }
        private void btnPlayer_MouseEnter(object sender, EventArgs e)
        {
            clsButtonPropritieschange.ChangeToClicked((Button)sender);
        }

        private void btnPlayer_MouseLeave(object sender, EventArgs e)
        {
            clsButtonPropritieschange.ChangeToNonClicked((Button)sender);
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlControlBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
