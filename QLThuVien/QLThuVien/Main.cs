using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnSGK_Click(object sender, EventArgs e)
        {
            SachGiaoKhoa frmSGK = new SachGiaoKhoa();
            frmSGK.ShowDialog();
        }

        private void mnSTk_Click(object sender, EventArgs e)
        {
            SachThamKhao frmSTK = new SachThamKhao();
            frmSTK.ShowDialog();
        }
    }
}
