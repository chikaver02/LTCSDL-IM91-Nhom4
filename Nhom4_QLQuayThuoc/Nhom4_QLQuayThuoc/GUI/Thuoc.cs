using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom4_QLQuayThuoc.DAL;
using Nhom4_QLQuayThuoc.DTO;

namespace Nhom4_QLQuayThuoc
{
    public partial class Thuoc : Form
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        #region TimKiemTheoTenThuoc

        List<ThuocDTO> TimKiemTheoTen(string TenThuoc)
        {
            List<ThuocDTO> listThuoc = ThuocDAL.Instance.TimKiemTheoTen(TenThuoc);
            return listThuoc;
        }

        private void btnTimKiemThuoc_Click(object sender, EventArgs e)
        {
            if (txtTimKiemThuoc.Text != "")
            {
                dGVThongTinThuoc.DataSource = TimKiemTheoTen(txtTimKiemThuoc.Text);    
            }
            else
            {
                MessageBox.Show("Phải nhập kí tự để tìm kiếm");
            }    
        }

        private void btnXemThuoc_Click(object sender, EventArgs e)
        {
            dGVThongTinThuoc.DataSource = ThuocDAL.Instance.GetListThuoc();
        }
        #endregion

        private void btnXemTheoTGThuoc_Click(object sender, EventArgs e)
        {
            DGVBaoCaoThuoc.DataSource = ThuocDAL.Instance.GetListThuoc();
        }

        private void btnDongThuoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoatTheoTG_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region TimKiemTheoNSX
        List<ThuocDTO> TimKiemTheoNSX(string namSanXuat)
        {
            List<ThuocDTO> listThuoc = ThuocDAL.Instance.TimKiemTheoNSX(namSanXuat);
            return listThuoc;
        }
        private void btnTimNSXThuoc_Click(object sender, EventArgs e)
        {
            if (txtTimNSXThuoc.Text != "")
            {
                DGVBaoCaoThuoc.DataSource = TimKiemTheoNSX(txtTimNSXThuoc.Text);
            }
            else
            {
                MessageBox.Show("Phải nhập kí tự để tìm kiếm");
            }
        }

        private void txtTimNSXThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTimNSXThuoc.Text == "")
            {
                btnTimNSXThuoc.Enabled = false;
            }
            else
            {
                btnTimNSXThuoc.Enabled = true;
            }
            try
            {
                int timNSX;
                timNSX = Int32.Parse(txtTimNSXThuoc.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(" Phải nhập ký tự số!");
            }

        }
        #endregion

        #region TimKiemTheoHSD
        List<ThuocDTO> TimKiemTheoHSD(string namSanXuat)
        {
            List<ThuocDTO> listThuoc = ThuocDAL.Instance.TimKiemTheoHSD(namSanXuat);
            return listThuoc;
        }

        private void btnTimHSDThuoc_Click(object sender, EventArgs e)
        {
            if (txtTimHSDThuoc.Text != "")
            {
                DGVBaoCaoThuoc.DataSource = TimKiemTheoHSD(txtTimHSDThuoc.Text);
            }
            else
            {
                MessageBox.Show("Phải nhập kí tự để tìm kiếm");
            }
        }
        private void txtTimHSDThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTimHSDThuoc.Text == "")
            {
                btnTimHSDThuoc.Enabled = false;
            }
            else
            {
                btnTimHSDThuoc.Enabled = true;
            }
            try
            {
                int timHSD;
                timHSD = Int32.Parse(txtTimHSDThuoc.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(" Phải nhập ký tự số!");
            }
        }
        #endregion
    }
}
