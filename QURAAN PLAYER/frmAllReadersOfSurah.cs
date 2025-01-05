using BusnessLogicLayer;
using Guna.UI2.WinForms;
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

namespace QURAAN_PLAYER
{
    public partial class frmAllReadersOfSurah : Form
    {
        int _suratID = 0;
        public delegate void DataBackHandler(object sender, int SuratID);
        public event DataBackHandler dataBack;
        Guna2Button CurrentPlayer = null;
        public frmAllReadersOfSurah(int SuratID)
        {
            InitializeComponent();
            _suratID = SuratID;
        }

        void _CreateButtons()
        {
            DataTable dt = clsSurat.GetAllSuratSong(_suratID);
            int buttonHeight = 45;
            int buttonWidth = 740;
            int margin = 10;
            int i = 0;
            int pictureBoxWidth = 40; 
            int pictureBoxHeight = 40;
            foreach (DataRow row in dt.Rows)
            {
                // Create and configure the button
                Guna2Button button = new Guna2Button
                {
                    Name = $"button{i + 1}",
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(200, (buttonHeight + margin) * i + margin),
                    FillColor = Color.FromArgb(37, 37, 37),
                    RightToLeft = RightToLeft.Yes,
                    Text = "\t\t\t\t" + "سورة" + " " + Convert.ToString(row["SuratNAme"]) + "   |  تلاوة الشيخ " + Convert.ToString(row["FullName"]) + "\t\t\t\t",
                    TextAlign = HorizontalAlignment.Right,
                    Font = new Font("Cascadia Mono", 20, FontStyle.Bold),
                    BorderRadius = 10,
                    Tag = Convert.ToString(row["ID"])
                };
                button.Click += (sender, e) =>
                {
                    if (CurrentPlayer != null)
                    {
                        CurrentPlayer.ForeColor = Color.White;
                    }
                    button.ForeColor = Color.FromArgb(233, 56, 0);
                    dataBack?.Invoke(this, int.Parse(button.Tag.ToString().Trim()));
                    CurrentPlayer = button;
                };

                // Create and configure the PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point(button.Location.X+button.Width+3, button.Location.Y + (button.Height - pictureBoxHeight) / 2),
                    
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand, // Optional: makes the PictureBox appear clickable
                    Tag = "0"
                };
                if (clsFavorite.IsExist(int.Parse(button.Tag.ToString())))
                    pictureBox.Image = Resources.icons8_heart_40__1_;
                else
                    pictureBox.Image = Properties.Resources.icons8_heart_40;
                // Optional: Add a click event to the PictureBox (e.g., for marking as favorite)
                pictureBox.Click += (sender, e) =>
                {
                   if (int.Parse(pictureBox.Tag.ToString())==0)
                    {
                        pictureBox.Image = Resources.icons8_heart_40__1_;
                        pictureBox.Tag = "1";
                        clsFavorite.Add(int.Parse(button.Tag.ToString()));
                    }
                   else
                    {
                        pictureBox.Image = Properties.Resources.icons8_heart_40;
                        pictureBox.Tag = "0";
                        clsFavorite.Remove(int.Parse(button.Tag.ToString()));
                    }
                };
                pnlBody.Controls.Add(pictureBox);
                // Add the button and PictureBox to the panel
                pnlBody.Controls.Add(button);
             

                i++;
            }

        }


        private void frmAllReadersOfSurah_Load(object sender, EventArgs e)
        {
            _CreateButtons();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsGlobalFrms.AllSurahs.Show();
            this.Close();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clsGlobalFrms.mainform.btnAllSong_Click(clsGlobalFrms.mainform.btnAllSong, e);
            clsGlobalFrms.AllSurahs.txtSearch.Focus();
            clsGlobalFrms.AllSurahs.txtSearch.Text = txtSearch.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
