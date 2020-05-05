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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void chaoMungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchaomung c1 = new frmchaomung();
            c1.Show();

        }

        private void tinhTongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhtong c2 = new FrmTinhtong();
            c2.Show();
        }

        private void tínhTổngbt1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhtong_bt1 c3 = new FrmTinhtong_bt1();
            c3.Show();
        }
    }
}
