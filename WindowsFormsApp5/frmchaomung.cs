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
    public partial class frmchaomung : Form
    {
        public frmchaomung()
        {
            InitializeComponent();
        }

        private void txtsubmit_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == "")
                {
                MessageBox.Show("bạn chưa nhập tên");
                txtTen.Focus();
                return;
            }
            if(txtLop.Text == "")
                {
                MessageBox.Show("bạn chưa nhập lớp");
                txtLop.Focus();
                return;
            }

            MessageBox.Show(" chao mung ban " + txtTen.Text + " học lớp " + txtLop.Text);
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void frmchaomung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ban da bat form frmchaomung");
        }
    }
}
