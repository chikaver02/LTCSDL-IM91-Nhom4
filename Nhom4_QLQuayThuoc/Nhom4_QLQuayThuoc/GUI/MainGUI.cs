using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom4_QLQuayThuoc
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.MdiParent = this;
            f.Show();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhMucThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuoc f = new Thuoc();
            f.MdiParent = this;
            f.Show();
        }

        private void thongTinKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void theoDonThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang f = new BanHang();
            f.MdiParent = this;
            f.Show();
        }

        private void khongTheoDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang f = new BanHang();
            f.MdiParent = this;
            f.Show();
        }

        private void thuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuoc f = new Thuoc();
            f.MdiParent = this;
            f.Show();
        }

        private void cachSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HuongDanSuDung f = new HuongDanSuDung();
            //f.MdiParent = this;
            //f.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDThu f = new ReportDThu();
            f.MdiParent = this;
            f.Show();
        }
    }
}
