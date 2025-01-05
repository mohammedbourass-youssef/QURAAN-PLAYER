using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnessLogicLayer;
using Guna.UI2.WinForms;
using QURAAN_PLAYER.Properties;

namespace QURAAN_PLAYER
{
    public partial class frmFavorite : Form
    {
        public frmFavorite()
        {
            InitializeComponent();
        }
        public delegate void DataBackHandler(object sender, int SuratID);
        public event DataBackHandler dataBack;
        void _CreateButtons()
        {
            DataTable dt = clsFavorite.GetAllRecord();
            int buttonHeight = 45;
            int buttonWidth = 740;
            int margin = 10;
            int i = 0;
            int pictureBoxWidth = 40;
            int pictureBoxHeight = 40;
            clsSurat surat;
            foreach (DataRow row in dt.Rows)
            {
                 surat = clsSurat.Find(int.Parse(Convert.ToString(row["SuratID"])));
                // Create and configure the button
                Guna2Button button = new Guna2Button
                {
                    Name = $"button{i + 1}",
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(200, (buttonHeight + margin) * i + margin),
                    FillColor = Color.FromArgb(37, 37, 37),
                    RightToLeft = RightToLeft.Yes,
                    Text = "\t\t\t\t" + "سورة" + " " + surat.Name + "   |  تلاوة الشيخ " + surat.reader.GetFullName() + "\t\t\t\t",
                    TextAlign = HorizontalAlignment.Right,
                    Font = new Font("Cascadia Mono", 20, FontStyle.Bold),
                    BorderRadius = 10,
                    Tag = surat.suratID.ToString()
                };
                button.Click += (sender, e) =>
                {
                    dataBack?.Invoke(this,surat.suratID);
                };

                // Create and configure the PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point(button.Location.X + button.Width + 3, button.Location.Y + (button.Height - pictureBoxHeight) / 2),

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
                    if (int.Parse(pictureBox.Tag.ToString()) == 0)
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
        private void frmFavorite_Load(object sender, EventArgs e)
        {
            _CreateButtons();
        }
    }
}
