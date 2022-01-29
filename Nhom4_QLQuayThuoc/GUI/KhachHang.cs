using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom4_QLQuayThuoc.DAL;

namespace Nhom4_QLQuayThuoc
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void LoadListKH()
        {
            DGVThongTinKH.DataSource = KhachHangDAL.Instance.GetListKhachHang();
        }

        private void btnXemKH_Click(object sender, EventArgs e)
        {
            LoadListKH();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

            if (txtMaKH.Text != "")
            {
                string MaKH = txtMaKH.Text;
                string TenKH = txtTenKH.Text;
                string NgaySinh = dTPNgaySinhKH.Value.ToString("yyyy/MM/dd");
                string DiaChi = txtDiaChiKH.Text;
                string SoDT = txtDienThoai.Text;
                string BenhAn = txtBenhAn.Text;
                if (KhachHangDAL.Instance.Insert(MaKH, TenKH, NgaySinh, DiaChi, SoDT, BenhAn))
                {
                    MessageBox.Show("Thêm thông tin khách hàng thành công");
                    LoadListKH();
                    txtMaKH.Text = txtTenKH.Text = txtDiaChiKH.Text = txtDienThoai.Text = txtBenhAn.Text = "";
                    txtMaKH.Focus();
                }
            }
            else
                MessageBox.Show("Có lỗi khi thêm thông tin khách hànng, vui lòng kiểm tra thông tin");
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "")
            {
                string MaKH = txtMaKH.Text;
                string TenKH = txtTenKH.Text;
                string NgaySinh = dTPNgaySinhKH.Value.ToString("yyyy/MM/dd");
                string DiaChi = txtDiaChiKH.Text;
                string SoDT = txtDienThoai.Text;
                string BenhAn = txtBenhAn.Text;
                if (KhachHangDAL.Instance.Update(MaKH, TenKH, NgaySinh, DiaChi, SoDT, BenhAn))
                {
                    MessageBox.Show("Sửa thông tin khách hàng thành công");
                    LoadListKH();
                    txtMaKH.Text = txtTenKH.Text = txtDiaChiKH.Text = txtDienThoai.Text = txtBenhAn.Text = "";
                    txtMaKH.Focus();
                }
            }
            else
                MessageBox.Show("Có lỗi khi sửa thông tin khách hànng, vui lòng kiểm tra thông tin đã nhập ");
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (this.DGVThongTinKH.SelectedRows.Count > 0)
            {
                try
                {
                    int dem = DGVThongTinKH.SelectedRows.Count;

                    foreach (DataGridViewRow item in this.DGVThongTinKH.SelectedRows)
                    {
                        dem -= 1;
                        KhachHangDAL.Instance.Delete(item.Cells[0].Value.ToString());
                        if (dem <= 0)
                        {

                            MessageBox.Show("Xóa thông tin khách hàng thành công");
                            LoadListKH();
                            txtMaKH.Text = txtTenKH.Text = txtDiaChiKH.Text = txtDienThoai.Text = txtBenhAn.Text = "";
                            txtMaKH.Focus();
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thông tin khách hàng bị lỗi");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thông tin khách hànng");
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "")
            {
                DGVThongTinKH.DataSource = KhachHangDAL.Instance.TimKiemTheoTen(txtTenKH.Text);
                txtTenKH.Text = "";
                txtTenKH.Focus();
            }
            else
            {
                MessageBox.Show("Có lỗi khi tìm kiếm thông tin khách hànng");
            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string fileName = "";
            saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            else
            {
                fileName = @"D:\Filelog.txt ";
            }

            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);
                streamWriter.WriteLine(String.Format("{0,-5}", txtMaKH.Text)
                    + String.Format("{0,-10}", DGVThongTinKH.Columns[0].HeaderText)
                    + String.Format("{0,-30}", DGVThongTinKH.Columns[1].HeaderText)
                    + String.Format("{0,-30}", DGVThongTinKH.Columns[2].HeaderText)
                    + String.Format("{0,-30}", DGVThongTinKH.Columns[3].HeaderText)
                    + String.Format("{0,-20}", DGVThongTinKH.Columns[4].HeaderText)
                    + String.Format("{0,-30}", DGVThongTinKH.Columns[5].HeaderText));


                for (int i = 0; i < DGVThongTinKH.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-5}", txtMaKH.Text)
                   + String.Format("{0,-10}", DGVThongTinKH.Rows[i].Cells[0].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[1].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[2].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[3].Value)
                   + String.Format("{0,-20}", DGVThongTinKH.Rows[i].Cells[4].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                for (int i = 0; i < DGVThongTinKH.Rows.Count; i++)
                {
                    streamWriter.WriteLine(string.Format(String.Format("{0,-5}", txtMaKH.Text))
                   + String.Format("{0,-10}", DGVThongTinKH.Rows[i].Cells[0].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[1].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[2].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[3].Value)
                   + String.Format("{0,-20}", DGVThongTinKH.Rows[i].Cells[4].Value)
                   + String.Format("{0,-30}", DGVThongTinKH.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
        }

        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số !");
            }
        }

        private void DGVThongTinKH_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text;
            string TenKH = txtTenKH.Text;
            string NgaySinh = dTPNgaySinhKH.Value.ToString("yyyy/MM/dd");
            string DiaChi = txtDiaChiKH.Text;
            string SoDT = txtDienThoai.Text;
            string BenhAn = txtBenhAn.Text;
            if (DGVThongTinKH.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.DGVThongTinKH.SelectedRows)
                {
                    txtMaKH.Text = item.Cells[0].Value.ToString();
                    txtTenKH.Text = item.Cells[1].Value.ToString();
                    dTPNgaySinhKH.Text = item.Cells[2].Value.ToString();
                    txtDiaChiKH.Text = item.Cells[3].Value.ToString();
                    txtDienThoai.Text = item.Cells[4].Value.ToString();
                    txtBenhAn.Text = item.Cells[5].Value.ToString();

                }

            }
        }
    }
}
