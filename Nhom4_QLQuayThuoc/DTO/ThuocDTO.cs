using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom4_QLQuayThuoc.DTO
{
    public class ThuocDTO
    {
        public ThuocDTO(DataRow Rows)
        {
            this.MaNCC = Rows["MaNCC"].ToString();
            this.TenThuoc = Rows["TenThuoc"].ToString();
            this.MaThuoc = Rows["MaThuoc"].ToString();
            this.NamSanXuat = (DateTime)Rows["NamSanXuat"];
            this.HanSuDung = (DateTime)Rows["HanSuDung"];
        }

        public string MaNCC { get; set; }
        public string TenThuoc { get; set; }
        public DateTime NamSanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        public string MaThuoc { get; set; }
    }
}
