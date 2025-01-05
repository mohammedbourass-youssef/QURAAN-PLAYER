using BusnessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;
using Guna.UI2.WinForms;
using QURAAN_PLAYER.Properties;

namespace QURAAN_PLAYER
{
    public partial class frmAddSurat : Form
    {
        string _audiopath=string.Empty;
        public frmAddSurat()
        {
            InitializeComponent();
        }
        void _FillSuratsName()
        {
            DataTable data = SurahsNames.GetAllSurahsNames();
            foreach (DataRow row in data.Rows)
            {
                cmbSurahsAmes.Items.Add(Convert.ToString(row["SuratName"]));
            }
        }
        void _FillReadersNames()
        {
            DataTable data = clsReader.GetAllReaders();
            clsReader reader;
            foreach (DataRow row in data.Rows)
            {
                reader = clsReader.Find(int.Parse(Convert.ToString(row["ReaderID"])));
                cmbReaders.Items.Add(reader.GetFullName());
            }
        }
        private void frmAddSurat_Load(object sender, EventArgs e)
        {
            _FillSuratsName();
            _FillReadersNames();
            MessageOfAddReader.ToolTipTitle = "رسالة";
            MessageOfAddReader.ToolTipIcon = ToolTipIcon.Warning;
            MessageOfAddReader.SetToolTip(cmbReaders, "ان لم تجد اسم المقرئ،قم اضافته");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3";
            openFileDialog1.InitialDirectory = @"C:\Users\USER\Downloads";
            openFileDialog1.Title = "Select an MP3 file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _audiopath = openFileDialog1.FileName.ToString();
                btnSave.Enabled = true;
                pnlAdd.Enabled = false;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clsGlobalFrms.mainform.btnHome_Click(sender, e);    
            this.Close();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Path to Chrome executable (adjust the path if Chrome is installed elsewhere)
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            // The URL to open
            string url = "https://mp3quran.net/ar";

            // Start Chrome with the URL
            Process.Start(chromePath, url);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbReaders.Text) && !String.IsNullOrEmpty(cmbSurahsAmes.Text) && !String.IsNullOrEmpty(_audiopath))
            {

                if (!clsSurat.IsExist(SurahsNames.GetSuratNameID(cmbSurahsAmes.Text), clsReader.FindID(cmbReaders.Text)))
                {
                    if (!File.Exists("C:\\Quraan\\Mp3\\"))
                    {
                        Directory.CreateDirectory("C:\\Quraan\\Mp3\\"); ;
                    }
                    clsSurat surat = new clsSurat();
                    surat.readerID = clsReader.FindID(cmbReaders.Text.Trim());
                    surat.suratnameID = SurahsNames.GetSuratNameID(cmbSurahsAmes.Text.Trim());
                    string guid = Guid.NewGuid().ToString();
                    surat.path = "C:\\Quraan\\Mp3\\" + guid + ".mp3";

                    if (surat.Save())
                    {
                        File.Copy(_audiopath, surat.path, overwrite: true);
                        MessageBox.Show("تم اضافته بنجاح");
                        File.Delete(_audiopath);
                    }

                }
                else
                    MessageBox.Show("السورة موجودة مسبقا");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnAddReader_Click(btnAdd, e);
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {

            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            //1 -- firstname
            //2 -- secondname
            //3--lastname
            if (e.KeyChar == '\r'&&!string.IsNullOrEmpty(textBox.Text))
            {
                if (int.Parse(textBox.Tag.ToString())==1)
                {
                   txtSecondName.Focus();
                }
                else if(int.Parse(textBox.Tag.ToString()) == 2)
                    txtLastName.Focus();
            }
            else
            {
                if (e.KeyChar != '\b')
                {
                    if (!clsOtils.IsArabicOnly(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                        e.Handled = false;
                }
                else
                    e.Handled = false;
            }
           

           
        }

        private void lkSearchOnline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtFirstName.Text))
            {
                // The search query
                string query = txtFirstName.Text + " " + txtLastName.Text + " صور";

                // The URL to Google search
                string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(query);

                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

                try
                {
                    // Start Chrome with the search URL
                    Process.Start(chromePath, url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR 404 !!! try again later");
                }
            }
        }
        string _picturePath = "";
        private void lkLoadPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.InitialDirectory = @"C:\Users\USER\Downloads";
            openFileDialog1.Title = "Select an Image file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _picturePath = openFileDialog1.FileName.ToString();
                if (!string.IsNullOrEmpty(_picturePath))
                {
                    Profile.ImageLocation = _picturePath;
                    Profile.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
            if (!String.IsNullOrEmpty(_picturePath) && !String.IsNullOrEmpty(txtFirstName.Text) &&!String.IsNullOrEmpty(txtLastName.Text))
            {
                btnSaveReader.Enabled = true;
            }
           
        }

        private void lkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Profile.ImageLocation))
            {
                Profile.ImageLocation = String.Empty;
                Profile.Image = Resources.voidpicture;
            }
        }

        private void btnSaveReader_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_picturePath))
            {
                MessageBox.Show("اضف صورة للشيخ من فضلك");
            }
            else
            {
                if(!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
                {
                    clsReader reader = new clsReader();
                    reader.FirstName = txtFirstName.Text;
                    reader.LastName = txtLastName.Text;

                    if (!File.Exists(@"C:\Quraan\Readers"))
                    {
                        Directory.CreateDirectory(@"C:\Quraan\Readers"); ;
                    }
                    Image image = Image.FromFile(_picturePath);
                    string guid = Guid.NewGuid().ToString();
                    reader.picturepath = @"C:\Quraan\Readers\" + guid + ".png";
                    image.Save(reader.picturepath, ImageFormat.Png);
                    if (reader.Save())
                    {
                        MessageBox.Show("تمت اضافة المقرئ بنجاح");
                        cmbReaders.Items.Clear();
                        _FillReadersNames();
                       cmbReaders.Text = reader.FirstName +" "+reader.LastName;
                    }
                }
            }

        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_picturePath) && !String.IsNullOrEmpty(txtFirstName.Text) &&! String.IsNullOrEmpty(txtLastName.Text))
            {
                btnSaveReader.Enabled = true;
            }
            if (String.IsNullOrEmpty(_picturePath) || String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtLastName.Text))
            {
                btnSaveReader.Enabled = false;
            }
        }

        private void pnlAdd_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                error.SetError(textBox, "حقل مطلوب!!!");
            }
            else
            {
                e.Cancel = false;
                error.SetError(textBox, "");
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clsGlobalFrms.mainform.btnAllSong_Click(clsGlobalFrms.mainform.btnAllSong, e);
            clsGlobalFrms.AllSurahs.txtSearch.Focus();
            clsGlobalFrms.AllSurahs.txtSearch.Text = txtSearch.Text;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAllSuratHelp frm = new frmAllSuratHelp();
            frm.ShowDialog();
        }
    }
}
