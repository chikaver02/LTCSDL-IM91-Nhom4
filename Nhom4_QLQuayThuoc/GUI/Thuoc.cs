using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        #endregion

        public void Xoa234()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void btnXemThuoc_Click(object sender, EventArgs e)
        {
            dGVThongTinThuoc.DataSource = ThuocDAL.Instance.GetListThuoc();
            if (btnLuuThuoc.Enabled == true)
            {//thêm
                LoadThuocform();
                Xoa234();
            }
            if (btnDongYXoaThuoc.Enabled == true)
            {//xóa
                LoadThuocform();
                Xoa234();
            }
            if (btnCapNhatThuoc.Enabled == true)
            {
                LoadThuocform();
                Xoa234();
            }
        }

        private void btnDongThuoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVThongTinThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVThongTinThuoc.CurrentRow.Index;
            textBox3.Text = dGVThongTinThuoc.Rows[i].Cells[0].Value.ToString();
            textBox4.Text = dGVThongTinThuoc.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = dGVThongTinThuoc.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dGVThongTinThuoc.Rows[i].Cells[3].Value.ToString();
            textBox2.Text = dGVThongTinThuoc.Rows[i].Cells[4].Value.ToString();
        }
        void LoadThuocform()
        {
            dGVThongTinThuoc.DataSource = ThuocDAL.Instance.GetListThuoc();

        }

        private void btnDongYXoaThuoc_Click(object sender, EventArgs e)
        {
            string MaThuoc = textBox2.Text;
            if (ThuocDAL.Instance.Delete(MaThuoc))
            {

                MessageBox.Show("Xóa thuốc thành công!");
                btnLuuThuoc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xóa!", "Chú ý!");
            }
        }

        private void btnLuuThuoc_Click(object sender, EventArgs e)
        {
            string MaNCC = (textBox3.Text);
            string MaThuoc = (textBox2.Text);
            string TenThuoc = (textBox4.Text);
            string NamSanXuat = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string HanSuDung = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            try
            {
                if (ThuocDAL.Instance.Insert(MaThuoc, MaNCC, TenThuoc, NamSanXuat, HanSuDung))
                {
                    textBox2.Text = textBox3.Text = textBox4.Text = "";
                    MessageBox.Show("Thêm thuốc thành công!");
                    btnLuuThuoc.Enabled = true;
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại!");
                textBox2.Text = textBox3.Text = textBox4.Text = "";
                btnLuuThuoc.Enabled = true;

            }
        }
        public void CapNhat_MNCC()
        {
            string MaNCC = textBox3.Text;
            string MaThuoc = textBox2.Text;
            try
            {
                if (ThuocDAL.Instance.Update(MaNCC, MaThuoc) && rdNCCThuoc.Checked == true)
                {
                    rdNCCThuoc.Checked = true;
                    textBox3.Text = "";
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception)
            {
                textBox3.Text = "";
                rdNCCThuoc.Checked = true;
                MessageBox.Show("Vui lòng nhập Mã NCC !");
            }
        }
        public void CapNhat_TenThuoc()
        {
            string TenThuoc = textBox4.Text;
            string MaThuoc = textBox2.Text;
            ThuocDAL.Instance.Update2(TenThuoc, MaThuoc);

        }
        private void btnCapNhatThuoc_Click(object sender, EventArgs e)
        {
            CapNhat_MNCC();
            CapNhat_TenThuoc();
        }

        private void btnXemTheoTGThuoc_Click(object sender, EventArgs e)
        {
            DGVBaoCaoThuoc.DataSource = ThuocDAL.Instance.GetListThuoc();
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
