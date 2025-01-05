using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QURAAN_PLAYER
{
    internal class clsButtonPropritieschange
    {
        public static void ChangeToClicked(Guna2Button btn)
        {
            btn.FillColor = Color.FromArgb(233, 56, 0);
            
        }
        public static void ChangeToClicked(Button btn)
        {
            btn.BackColor = Color.FromArgb(233, 56, 0);

        }
        public static void ChangeToNonClicked(Button btn)
        {
            btn.BackColor = Color.FromArgb(15, 15, 15);
        }
        public static void ChangeToNonClicked(Guna2Button btn)
        {
            btn.FillColor = Color.FromArgb(15, 15, 15);
        }
        public static void ChangeToNonClicked(Guna2Button btn2, Guna2Button  btn3, Guna2Button btn4, Guna2Button btn5, Guna2Button btn6)
        {
            ChangeToNonClicked(btn2);
            ChangeToNonClicked(btn3);
            ChangeToNonClicked(btn4);
            ChangeToNonClicked(btn5);
            ChangeToNonClicked(btn6);
        }
        

    }
}
