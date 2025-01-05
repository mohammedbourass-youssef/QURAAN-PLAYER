using BusnessLogicLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace QURAAN_PLAYER
{
    public partial class frmHome : Form
    {
        public delegate void DataBackHandler(object sender, int SuratID);
        public event DataBackHandler dataBack;



        //dataBack?.Invoke(this, SuratID);
        List<PictureBox> listpictures = new List <PictureBox> ();
         PictureBox chosen_reader= null;
        string _playercontrolname;
         Label chosen_name = null;
        //functions 
        void _CreateSexRecommendation()
        {
            DataTable dt = clsReader.GetTopSexReaders();
            int pictureBoxWidth = 169;
            int pictureBoxHeight = 170;
            int margin = 10;
            int labelHeight = 30;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                // Create PictureBox
                Guna2PictureBox pictureBox = new Guna2PictureBox
                {
                    Name = $"pictureBox{i + 1}",
                    Size = new Size(pictureBoxWidth, pictureBoxHeight),
                    Location = new Point((pictureBoxWidth + 30 + margin) * i + margin, margin),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(15, 15, 15),
                    Image = Image.FromFile(Convert.ToString(row["PicturePath"])),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderRadius = 30,
                    Tag = Convert.ToString(row["ReaderID"])
                };
                if(i==5 || i== 0)
                {
                    listpictures.Add(pictureBox);
                }
                pictureBox.SendToBack();
                pnlRecommandation.Controls.Add(pictureBox);  // Add PictureBox to the container
                // Create Label
                Label label = new Label
                {
                    Name = $"label{i + 1}",
                    Text = Convert.ToString(row["FirstName"]) + " "+Convert.ToString(row["LastName"]),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(pictureBoxWidth - 1, labelHeight + 15),
                    Location = new Point(pictureBox.Left , pictureBox.Bottom-30),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(130, 128, 128, 128),
                    Font = new Font("Cascadia Mono", 20, FontStyle.Bold)
                };
                label.Visible = true;
                pictureBox.Click += (sender, e) =>
                {
                    chosen_name.Enabled = true;
                    chosen_reader.Enabled = true;
                    pnlJumper.Top = label.Bottom;
                    pnlJumper.Left = label.Left;
                    pnlJumper.Size = new Size(label.Width, 6);
                    chosen_reader = pictureBox;
                    chosen_name = label;
                    _ReadersRecomman();
                    _CreateEightRelattedButtons(int.Parse(Convert.ToString(pictureBox.Tag)));
                    pictureBox.Enabled = false;
                    label.Enabled = false;
                };
                label.Click += (sender, e) =>
                {
                    chosen_name.Enabled = true;
                    chosen_reader.Enabled = true;
                    pnlJumper.Top = label.Bottom;
                    pnlJumper.Left = label.Left;
                    pnlJumper.Size = new Size(label.Width, 6);
                    chosen_reader = pictureBox;
                    chosen_name = label;
                    _ReadersRecomman();
                    _CreateEightRelattedButtons(int.Parse(Convert.ToString(pictureBox.Tag)));
                    pictureBox.Enabled = false;
                    label.Enabled = false;
                };
                if (i == 0)
                {
                    pnlJumper.Top = label.Bottom;
                    pnlJumper.Left = label.Left;
                    pnlJumper.Size = new Size(label.Width, 6);
                    chosen_name = label;
                    chosen_reader = pictureBox;
                    _ReadersRecomman();
                    _CreateEightRelattedButtons(int.Parse(Convert.ToString(pictureBox.Tag)));
                    pictureBox.Enabled = false;
                    label.Enabled = false;
                }
                pnlRecommandation.Controls.Add(label);  // Add Label to the container
                label.BringToFront();
                i++;
            }
        }

        void _CreateSexSuratRecommendation()
        {
            DataTable dt = clsSurat.GetSuratTop6();
            int buttonHeight =  45;
            int buttonWidth = 694;    
            int margin = 10;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                Guna2Button button = new Guna2Button
                {
                    Name = $"pictureBox{i + 1}",
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(margin, (buttonHeight + margin) * i + margin),
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
                    for (int j = 0; j < 6; j++)
                    {
                        Guna2Button btn = pnlSuggetionSuar.Controls[$"pictureBox{j + 1}"] as Guna2Button; 
                        if (btn != null)
                        {                           
                            btn.ForeColor = Color.White;                            
                        }
                    }
                    _CancelTheOthers();
                    _playercontrolname = button.Name;
                    button.ForeColor = Color.FromArgb(233, 56, 0);
                    dataBack?.Invoke(this, int.Parse(button.Tag.ToString().Trim()));
                };
                pnlSuggetionSuar.Controls.Add(button);
                i++;
            }
        }
        void _CancelTheOthers()
        {
            Guna2Button btn = pnlSuggetionSuar.Controls[_playercontrolname] as Guna2Button;
            if(btn != null)
            {
                btn.ForeColor = Color.White;
            }
            ctrlSuratInfo ctrl = pnlRelatedSurat.Controls[_playercontrolname] as ctrlSuratInfo;
            if (ctrl != null)
            {
                ctrl.ResetColors();
            }
        }
        void _CreateEightRelattedButtons(int readerID)
        {
            pnlRelatedSurat.Controls.Clear();
            DataTable dt = clsSurat.GetSuratTop5for(readerID);
            int X = 30;
            int Y = 36;
            int margin = 50;
            int i = 1;
            if (dt.Rows.Count == 0)
            {
                //, 14,25pt, style=Bold
                Label label = new Label
                {
                    Name = $"Surat{1}",
                    Location = new Point(35, 149),
                    Size = new Size(240, 25),
                    RightToLeft = RightToLeft.Yes,
                    Text = "اسف لم اضافة اي سور للشيخ،بعد",
                    Font = new Font("Cascadia Mono", 14, FontStyle.Bold),
                    ForeColor = Color.FromArgb(233, 56, 0)
                };
                pnlRelatedSurat.Controls.Add (label);
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    ctrlSuratInfo label = new ctrlSuratInfo
                    {
                        Name = $"Surat{i + 1}",
                        Location = new Point(X, (Y + margin) * i + margin),
                        suratName = Convert.ToString(row["SuratName"]),
                        index = i,
                        Tag = Convert.ToString(row["ID"])
                    };
                    label.OnClick += (b) =>
                    {
                        _CancelTheOthers();
                        _playercontrolname = label.Name;
                        dataBack?.Invoke(this, int.Parse(label.Tag.ToString().Trim()));
                    };
                    pnlRelatedSurat.Controls.Add(label);
                    i++;
                }
            }
        }
        void _ReadersRecomman()
        {
            
            lblreader.Text = chosen_name.Text;
            lblNumber.Text = Convert.ToString(clsReader.NumberOfSurat(int.Parse(chosen_reader.Tag.ToString())));
        }
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            _CreateSexRecommendation();
            _CreateSexSuratRecommendation();
            pnlRecommandation.AutoScroll = true;
            pnlRecommandation.HorizontalScroll.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        private void btnLeftscrol_Click(object sender, EventArgs e)
        {
           
            
           
                pnlRecommandation.ScrollControlIntoView(listpictures[0]);
            
               
        }

        private void btnScrolRight_Click(object sender, EventArgs e)
        {
           
            
            
                pnlRecommandation.ScrollControlIntoView(listpictures[1]);
            
               


        }

        private void pnlRelatedSurat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clsGlobalFrms.mainform.btnAllSong_Click(clsGlobalFrms.mainform.btnAllSong, e);
            clsGlobalFrms.AllSurahs.txtSearch.Focus();
            clsGlobalFrms.AllSurahs.txtSearch.Text = txtSearch.Text;
        }
    }
}
