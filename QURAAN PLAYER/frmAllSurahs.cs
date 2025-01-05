using BusnessLogicLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace QURAAN_PLAYER
{
    public partial class frmAllSurahs : Form
    {
        public delegate void DataBackHandler(object sender, int SuratID);
        public event DataBackHandler dataBack;
        List<Guna2Button> buttonList = new List<Guna2Button>();
        public frmAllSurahs()
        {
            InitializeComponent();
        }
        void _playsurat(object sender, int SuratID)
        {
            dataBack?.Invoke(this, SuratID);
        }
        void _CreateButtons()
        {
            buttonList.Clear();
            pnlbody.Controls.Clear();
            DataTable dt = SurahsNames.GetAllSurahsNames();
            int buttonHeight = 126;
            int buttonWidth = 164;
            int marginy = 30;
            int marginx = 50;
            int i = 0;
            int counter = 0;
            int k = 0;
            foreach (DataRow row in dt.Rows)
            {
                Guna2Button button = new Guna2Button
                {
                    Name = $"button{i + 1}",
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point((buttonWidth + marginx) * i + marginx, (buttonHeight + marginy) * k + marginy),
                    FillColor = Color.FromArgb(76, 76, 76),
                    RightToLeft = RightToLeft.Yes,
                    Text = Convert.ToString(row["SuratName"])+"  ترتيتبها" + Convert.ToString(row["SuratID"])  +Convert.ToString(row["types"]) + "عدد ايات " + Convert.ToString(row["numberofayate"])+"  ",
                    TextAlign = HorizontalAlignment.Right,
                    Font = new Font("Segoe UI", 15, FontStyle.Bold),
                    BorderRadius = 20,
                    Tag = Convert.ToString(row["SuratID"])
                };
                i++;
                counter++;
                if (counter == 5)
                {
                    i = 0;
                    k++;
                    counter = 0;
                }
                button.Click += (sender, e) =>
                {
                    this.Hide();
                    frmAllReadersOfSurah frm = new frmAllReadersOfSurah(int.Parse(Convert.ToString(button.Tag)));
                    frm.TopLevel = false;
                    clsGlobalFrms.pnlbody.Controls.Add(frm);
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.dataBack += _playsurat;
                    frm.Show();
                };
                pnlbody.Controls.Add(button);
                buttonList.Add(button);
            }
        }
        void _MakeTheButonInvesible()
        {
            foreach(Guna2Button button in buttonList)
            {
                button.Visible = false;
            }
        }
        void _MakeTheButonvesible()
        {
            foreach (Guna2Button button in buttonList)
            {
                button.Visible = true;
            }
        }
        void _Search()
        {
            int buttonHeight = 126;
            int buttonWidth = 164;
            int marginy = 30;
            int marginx = 50;
            int i = 0;
            int counter = 0;
            int k = 0;
            foreach (Guna2Button button in buttonList)
            {
                string buttonTextNormalized = button.Text.Normalize(NormalizationForm.FormD);
                string searchTextNormalized = txtSearch.Text.Normalize(NormalizationForm.FormD);

                if (CultureInfo.InvariantCulture.CompareInfo.IndexOf(buttonTextNormalized, searchTextNormalized, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0)
                {
                    button.Visible = true;
                    button.Location = new Point((buttonWidth + marginx) * i + marginx, (buttonHeight + marginy) * k + marginy);
                    i++;
                    counter++;
                    if (counter == 5)
                    {
                        i = 0;
                        k++;
                        counter = 0;
                    }
                } 
                else
                    button.Visible = false;
                
            }
        }
        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAllSurahs_Load(object sender, EventArgs e)
        {
            _CreateButtons();
            clsGlobalFrms.AllSurahs = this;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                _CreateButtons();
            }
            else
            {
                _Search();
            }
        }
    }
}
