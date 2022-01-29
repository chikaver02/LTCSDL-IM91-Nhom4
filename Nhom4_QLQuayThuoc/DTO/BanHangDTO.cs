using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom4_QLQuayThuoc.DTO
{
    public class BanHangDTO
    {
        public string IDDongBan { get; set; }
        public string MaNCC { get; set; }
        public string LoaiThuocBan { get; set; }
        public int TongBan { get; set; }
        public decimal DonGiaBan { get; set; }
        public decimal TongTien { get; set; }
        public BanHangDTO(string IDDongBan, string MaNCC, string LoaiThuocBan, int TongBan, int DonGiaBan, int TongTien)
        {
            this.IDDongBan = IDDongBan;
            this.MaNCC = MaNCC;
            this.LoaiThuocBan = LoaiThuocBan;
            this.TongBan = TongBan;
            this.DonGiaBan = DonGiaBan;
            this.TongTien = TongTien;
        }
        public BanHangDTO(DataRow row)
        {
            this.IDDongBan = row["IDDongBan"].ToString();
            this.MaNCC = row["MaNCC"].ToString();
            this.LoaiThuocBan = row["LoaiThuocBan"].ToString();
            this.TongBan = (int)row["TongBan"];
            this.DonGiaBan = (decimal)row["DonGiaBan"];
            this.TongTien = (decimal)row["TongTien"];
        }
    }
}

