using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmTinhtong_bt1 : Form
    {
        public FrmTinhtong_bt1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textxtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.' ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar)) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
        private void textxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.' ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar)) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btntinhtong_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtA.Text);
            double c = Convert.ToDouble(txtB.Text);
            

            
            double tonga = 0;
            for (int  a = 0 ; a <= c ; a++)
                tonga = tonga + a;
            double tongb = 0;
            for (int b = 0; b<=d; b++)
                tongb = tongb + b;
            double tong = 0;
            tong = tonga - tongb +d ;

            lbltinhtong.Text = tong.ToString();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            lbltinhtong.ResetText();
            txtA.ResetText();
            txtB.ResetText();
        }
    }
}
