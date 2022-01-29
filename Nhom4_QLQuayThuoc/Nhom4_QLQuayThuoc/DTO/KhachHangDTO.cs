using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom4_QLQuayThuoc.DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO(string MaKH, string TenKH, DateTime NgaySinh, string DiaChi, string SoDT, string BenhAn)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.BenhAn = BenhAn;

        }
        public KhachHangDTO(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.DiaChi = row["DiaChi"].ToString();
            this.SoDT = row["SoDT"].ToString();
            this.BenhAn = row["BenhAn"].ToString();
        }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string BenhAn { get; set; }
    }
}

