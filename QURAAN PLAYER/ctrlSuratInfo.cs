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
    public partial class ctrlSuratInfo : UserControl
    {
        public int index {
            get { return int.Parse(lblIndex.Text); } 
            set {
                lblIndex.Text = Convert.ToString(value);
            } 
        }
        public string suratName
        {
            get { return lblName.Text; }
            set
            {
                lblName.Text = value;
               
            }
        }

        public static ctrlSuratInfo lastSelected = null;

        //my new event 
        public event Action<int> OnClick;
        protected virtual void CopleteCalculete(int Sum)
        {
            Action<int> handler = OnClick;
            if (handler != null)
                handler(Sum);
        }

        public ctrlSuratInfo()
        {
            
            InitializeComponent();
            suratName = "";
            index = 0;
        }
        public void ResetColors()
        {
            lblName.ForeColor = Color.White;
            lblIndex.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            panel1.BackColor = Color.White;
        }

        private void ctrlSuratInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(76, 76, 76);
        }

        private void ctrlSuratInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(37, 37, 37);
        }

        public void ChangeColor()
        {
            lblName.ForeColor = Color.FromArgb(233, 56, 0);
            lblIndex.ForeColor = Color.FromArgb(233, 56, 0);
            label1.ForeColor = Color.FromArgb(233, 56, 0);
            panel1.BackColor = Color.FromArgb(233, 56, 0);
        }
        private void lblIndex_Click_1(object sender, EventArgs e)
        {
            if(lastSelected != null)
            {
                lastSelected.ResetColors();
            }
            this.ChangeColor();
            int Sum = 0;
            if (OnClick != null)
                CopleteCalculete(Sum);
            lastSelected = this;
        }
      
    }
}
