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

namespace QURAAN_PLAYER
{
    public partial class frmAllReaders : Form
    {
        public frmAllReaders()
        {
            InitializeComponent();
        }
        void _CreateSexRecommendation()
        {
            DataTable dt = clsReader.GetTopSexReaders();
            int pictureBoxWidth = 169;
            int pictureBoxHeight = 170;
            int margin = 10;
            int labelHeight = 30;
            int i = 0;
            int k = 0;
            int b = 0;
            foreach (DataRow row in dt.Rows)
            {
                // Create PictureBox
                Guna2PictureBox pictureBox = new Guna2PictureBox
                {
                    Name = $"pictureBox{i + 1}",
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point((pictureBoxWidth + 30 + margin) * i + margin, (pictureBoxHeight + 30 + margin) * k +margin),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(15, 15, 15),
                    Image = Image.FromFile(Convert.ToString(row["PicturePath"])),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderRadius = 30,
                    Tag = Convert.ToString(row["ReaderID"])
                };
                b++;
                i++;
                if (b == 5)
                {
                    i = 0;
                    b = 0;
                    k++;
                }
               
                pictureBox.SendToBack();
                pnlRecommandation.Controls.Add(pictureBox);  // Add PictureBox to the container
                // Create Label
                Label label = new Label
                {
                    Name = $"label{i + 1}",
                    Text = Convert.ToString(row["FirstName"]) + " " + Convert.ToString(row["LastName"]),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(pictureBoxWidth - 1, labelHeight + 15),
                    Location = new Point(pictureBox.Left, pictureBox.Bottom - 30),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(130, 128, 128, 128),
                    Font = new Font("Cascadia Mono", 20, FontStyle.Bold)
                };
                label.Visible = true;
                pictureBox.Click += (sender, e) =>
                {

                };
                label.Click += (sender, e) =>
                {

                };
                pnlRecommandation.Controls.Add(label);  // Add Label to the container
                label.BringToFront();
              
            }
        }
        private void frmAllReaders_Load(object sender, EventArgs e)
        {
            _CreateSexRecommendation();
        }
    }
}
