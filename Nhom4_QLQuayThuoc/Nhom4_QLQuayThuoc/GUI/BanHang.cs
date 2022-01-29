using System;
using System.IO;
using System.Windows.Forms;
using Nhom4_QLQuayThuoc.DAL;
using Nhom4_QLQuayThuoc.DTO;
namespace Nhom4_QLQuayThuoc
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        void LoadListBH()
        {
            DGVThongKeBH.DataSource = BanHangDAL.Instance.GetListPhieuBH();
        }

        private void rdThemBH_CheckedChanged(object sender, EventArgs e)
        {
            string IDDongBan = (txtMaPhieuBH.Text);
            string MaNCC = (txtMaNCCBH.Text);
            string LoaiThuocBan = cbbLoaiThuocBanBH.Text;
            int TongBan = int.Parse(txtSoLuongBH.Text);
            decimal DonGiaBan = int.Parse(txtGiaTienBH.Text);
            decimal TongTien = int.Parse(txtThanhTienBH.Text);


            try
            {
                if (BanHangDAL.Instance.InsertBH(IDDongBan, MaNCC, LoaiThuocBan, TongBan, DonGiaBan, TongTien))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadListBH();
                    txtGiaTienBH.Text = txtMaNCCBH.Text = txtMaPhieuBH.Text = txtSoLuongBH.Text = cbbLoaiThuocBanBH.Text = txtThanhTienBH.Text = "";
                    rdThemBH.Checked = false;
                }

                else
                    MessageBox.Show("Có lỗi khi thêm đơn hàng");
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng kiểm tra lại!!!");
                txtGiaTienBH.Text = txtMaNCCBH.Text = txtMaPhieuBH.Text = txtSoLuongBH.Text = cbbLoaiThuocBanBH.Text = txtThanhTienBH.Text = "";
                rdThemBH.Checked = false;
            }
        }

        private void rdXoaBH_CheckedChanged(object sender, EventArgs e)
        {
            if (DGVThongKeBH.SelectedRows.Count > 0)
            {
                try
                {
                    int dem = DGVThongKeBH.SelectedRows.Count;
                    foreach (DataGridViewRow item in this.DGVThongKeBH.SelectedRows)
                    {
                        dem -= 1;
                        BanHangDAL.Instance.DeleteBH(item.Cells[0].Value.ToString());
                        if (dem <= 0)
                        {
                            LoadListBH();
                            MessageBox.Show("Xoá đơn hàng thành công!");
                            txtGiaTienBH.Text = txtMaNCCBH.Text = txtMaPhieuBH.Text = txtSoLuongBH.Text = cbbLoaiThuocBanBH.Text = txtThanhTienBH.Text = "";
                            rdXoaBH.Checked = false;
                        }

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hệ thống đang bảo trì. Vui lòng quay lại sau!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xoá!", "Chú ý");
                txtGiaTienBH.Text = txtMaNCCBH.Text = txtMaPhieuBH.Text = txtSoLuongBH.Text = cbbLoaiThuocBanBH.Text = txtThanhTienBH.Text = "";
                rdXoaBH.Checked = false;
            }
        }

        private void rdSuaBH_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string IDDongBan = (txtMaPhieuBH.Text);
                string MaNCC = (txtMaNCCBH.Text);
                string LoaiThuocBan = cbbLoaiThuocBanBH.Text;
                int TongBan = int.Parse(txtSoLuongBH.Text);
                double DonGiaBan = double.Parse(txtGiaTienBH.Text);
                double TongTien = double.Parse(txtThanhTienBH.Text);

                if (BanHangDAL.Instance.UpdateBH(IDDongBan, MaNCC, LoaiThuocBan, TongBan, DonGiaBan, TongTien))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadListBH();
                    txtGiaTienBH.Text = txtMaNCCBH.Text = txtMaPhieuBH.Text = txtSoLuongBH.Text = cbbLoaiThuocBanBH.Text = txtThanhTienBH.Text = "";
                    rdSuaBH.Checked = false;
                }

                else
                    MessageBox.Show("Có lỗi khi sửa đơn hàng");
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng kiểm tra lại!!!");
                txtGiaTienBH.Text = txtMaNCCBH.Text = txtMaPhieuBH.Text = txtSoLuongBH.Text = cbbLoaiThuocBanBH.Text = txtThanhTienBH.Text = "";
                rdSuaBH.Checked = false;
            }
        }

        private void btnAnBH_Click(object sender, EventArgs e)
        {
            DGVThongKeBH.DataSource = "";
        }

        private void btnHienBH_Click(object sender, EventArgs e)
        {
            LoadListBH();
        }

        private void btnLuuBH_Click(object sender, EventArgs e)
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
                
                fileName = Application.StartupPath + @"\BH.txt";
            }
            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);
                streamWriter.WriteLine(String.Format("{0,-5}", txtMaPhieuBH.Text)
                   + String.Format("{0,-10}", DGVThongKeBH.Columns[0].HeaderText)
                   + String.Format("{0,-10}", DGVThongKeBH.Columns[1].HeaderText)
                   + String.Format("{0,-10}", DGVThongKeBH.Columns[2].HeaderText)
                   + String.Format("{0,-10}", DGVThongKeBH.Columns[3].HeaderText)
                   + String.Format("{0,-20}", DGVThongKeBH.Columns[4].HeaderText)
                   + String.Format("{0,-20}", DGVThongKeBH.Columns[5].HeaderText));
                for (int i = 0; i <= DGVThongKeBH.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-5}", txtMaPhieuBH.Text)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[0].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[1].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[2].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[3].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[4].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                for (int i = 0; i < DGVThongKeBH.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-5}", txtMaPhieuBH.Text)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[0].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[1].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[2].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[3].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[4].Value)
                        + String.Format("{0,-10}", DGVThongKeBH.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
        }

        private void btnThoatBH_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BÁN LẺ
        void LoadListBL()
        {
            DGVThongKeBL.DataSource = BanHangDAL.Instance.GetListPhieuBL();
        }

        private void rdThemBL_CheckedChanged(object sender, EventArgs e)
        {
            //if (txtMaPhieuBH.Text == "" || txtMaNCCBH.Text == "" || cbbLoaiThuocBanBH.SelectedItem == "" ||
            //    txtSoLuongBH.Text == "" || txtGiaTienBH.Text == "" || txtThanhTienBH.Text == "")
            //{
                try
                {
                    string IDDongBan = (txtMaPhieuBL.Text);
                    string MaNCC = (txtMaNCCBL.Text);
                    string LoaiThuocBan = txtLoaiThuocBL.Text;
                    int TongBan = int.Parse(txtSoLuongBL.Text);
                    decimal DonGiaBan = int.Parse(txtGiaTienBL.Text);
                    decimal TongTien = int.Parse(txtThanhTienBL.Text);
                    if (BanHangDAL.Instance.InsertBL(IDDongBan, MaNCC, LoaiThuocBan, TongBan, DonGiaBan, TongTien))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadListBL();
                        txtThanhTienBL.Text = txtSoLuongBL.Text = txtMaPhieuBL.Text = txtMaNCCBL.Text = txtGiaTienBL.Text = txtLoaiThuocBL.Text = "";
                        rdThemBL.Checked = false;
                    }

                    else
                        MessageBox.Show("Có lỗi khi thêm đơn hàng");
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng kiểm tra lại!!");
                    txtThanhTienBL.Text = txtSoLuongBL.Text = txtMaPhieuBL.Text = txtMaNCCBL.Text = txtGiaTienBL.Text = txtLoaiThuocBL.Text = "";
                    rdThemBL.Checked = false;
                }  
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng điền thông tin trước khi Thêm");
            //}    
        }

        private void rdXoaBL_CheckedChanged(object sender, EventArgs e)
        {
            if (DGVThongKeBL.SelectedRows.Count > 0)
            {
                try
                {
                    int dem = DGVThongKeBL.SelectedRows.Count;
                    foreach (DataGridViewRow item in this.DGVThongKeBL.SelectedRows)
                    {
                        dem -= 1;
                        BanHangDAL.Instance.DeleteBL(item.Cells[0].Value.ToString());
                        if (dem <= 0)
                        {
                            LoadListBL();
                            MessageBox.Show("Xoá đơn hàng thành công!");
                            txtThanhTienBL.Text = txtSoLuongBL.Text = txtMaPhieuBL.Text = txtMaNCCBL.Text = txtGiaTienBL.Text = txtLoaiThuocBL.Text = "";
                            rdXoaBL.Checked = false;
                        }

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hệ thống đang bảo trì. Vui lòng quay lại sau!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xoá!", "Chú ý");
                txtThanhTienBL.Text = txtSoLuongBL.Text = txtMaPhieuBL.Text = txtMaNCCBL.Text = txtGiaTienBL.Text = txtLoaiThuocBL.Text = "";
                rdXoaBL.Checked = false;
            }
        }

        private void rsSuaBL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string IDDongBan = (txtMaPhieuBL.Text);
                string MaNCC = (txtMaNCCBL.Text);
                string LoaiThuocBan = txtLoaiThuocBL.Text;
                int TongBan = int.Parse(txtSoLuongBL.Text);
                double DonGiaBan = double.Parse(txtGiaTienBL.Text);
                double TongTien = double.Parse(txtThanhTienBL.Text);

                if (BanHangDAL.Instance.UpdateBH(IDDongBan, MaNCC, LoaiThuocBan, TongBan, DonGiaBan, TongTien))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadListBL();
                    txtGiaTienBL.Text = txtMaNCCBL.Text = txtMaPhieuBL.Text = txtSoLuongBL.Text = txtLoaiThuocBL.Text = txtThanhTienBL.Text = "";
                    rsSuaBL.Checked = false;
                }

                else
                    MessageBox.Show("Có lỗi khi sửa đơn hàng");
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng kiểm tra lại!!!");
                txtGiaTienBL.Text = txtMaNCCBL.Text = txtMaPhieuBL.Text = txtSoLuongBL.Text = txtLoaiThuocBL.Text = txtThanhTienBL.Text = "";
                rsSuaBL.Checked = false;
            }
        }

        private void btnHienBL_Click(object sender, EventArgs e)
        {
            LoadListBL();
        }

        private void btnAnBL_Click(object sender, EventArgs e)
        {
            DGVThongKeBL.DataSource = "";
        }

        private void btnLuuBL_Click(object sender, EventArgs e)
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
                fileName = "D:\\BL.txt";
            }
            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);
                streamWriter.WriteLine(String.Format("{0,-5}", txtMaPhieuBL.Text)
                   + String.Format("{0,-10}", DGVThongKeBL.Columns[0].HeaderText)
                   + String.Format("{0,-10}", DGVThongKeBL.Columns[1].HeaderText)
                   + String.Format("{0,-10}", DGVThongKeBL.Columns[2].HeaderText)
                   + String.Format("{0,-10}", DGVThongKeBL.Columns[3].HeaderText)
                   + String.Format("{0,-20}", DGVThongKeBL.Columns[4].HeaderText)
                   + String.Format("{0,-20}", DGVThongKeBL.Columns[5].HeaderText));
                for (int i = 0; i <= DGVThongKeBL.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-5}", txtMaPhieuBL.Text)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[0].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[1].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[2].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[3].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[4].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                for (int i = 0; i < DGVThongKeBL.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-5}", txtMaPhieuBL.Text)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[0].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[1].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[2].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[3].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[4].Value)
                        + String.Format("{0,-10}", DGVThongKeBL.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
        }

        private void btnThoatBL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVThongKeBH_Click(object sender, EventArgs e)
        {
            if (DGVThongKeBH.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.DGVThongKeBH.SelectedRows)
                {
                    txtMaPhieuBH.Text = item.Cells[0].Value.ToString();
                    txtMaNCCBH.Text = item.Cells[1].Value.ToString();
                    cbbLoaiThuocBanBH.Text = item.Cells[2].Value.ToString();
                    txtSoLuongBH.Text = item.Cells[3].Value.ToString();
                    txtGiaTienBH.Text = item.Cells[4].Value.ToString();
                    txtThanhTienBH.Text = item.Cells[5].Value.ToString();
                }
            }
        }

        private void DGVThongKeBL_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DGVThongKeBL.SelectedRows)
            {
                txtMaPhieuBL.Text = item.Cells[0].Value.ToString();
                txtMaNCCBL.Text = item.Cells[1].Value.ToString();
                txtLoaiThuocBL.Text = item.Cells[2].Value.ToString();
                txtSoLuongBL.Text = item.Cells[3].Value.ToString();
                txtGiaTienBL.Text = item.Cells[4].Value.ToString();
                txtThanhTienBL.Text = item.Cells[5].Value.ToString();
            }
        }
    }
}
