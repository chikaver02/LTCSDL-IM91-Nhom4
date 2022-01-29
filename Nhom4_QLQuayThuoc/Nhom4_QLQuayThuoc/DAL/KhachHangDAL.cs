using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Nhom4_QLQuayThuoc.DTO;

namespace Nhom4_QLQuayThuoc.DAL
{
    public class KhachHangDAL
    {
        private static KhachHangDAL instance;
        public static KhachHangDAL Instance
        {
            get { if (instance == null) instance = new KhachHangDAL(); return instance; }
            private set { instance = value; }
        }
        private KhachHangDAL() { }

        public List<KhachHangDTO> GetListKhachHang()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            string query = "select *from[dbo].[KHACHHANG]";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(item);
                list.Add(kh);
            }
            return list;
        }

        public bool Insert(string MaKH, string TenKH, string NgaySinh, string DiaChi, string SoDT, string BenhAn)
        {
            string them = "Insert Into [dbo].[KHACHHANG](MaKH, TenKH, NgaySinh, DiaChi, SoDT, BenhAn)" + "values(N'" + MaKH + "',N'" + TenKH + "',N'" + NgaySinh + "',N'" + DiaChi + "',N'" + SoDT + "',N'" + BenhAn + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(them);
            return result > 0;

        }
        public bool Update(string MaKH, string TenKH, string NgaySinh, string DiaChi, string SoDT, string BenhAn)
        {
            string sua = "update [dbo].[KHACHHANG]  set TenKH= N'" + TenKH + "', NgaySinh='" + NgaySinh + "', DiaChi=N'" + DiaChi + "', SoDT=N'" + SoDT + "', BenhAn=N'" + BenhAn + "' where MaKH=N'" + MaKH + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(sua);
            return result > 0;
        }
        public bool Delete(string MaKH)
        {
            string xoa1 = "delete from [dbo].[CHITIETPHIEUMUA] where MaKH='" + MaKH + "'";
            int result1 = DataProvider.Instance.ExecuteNonQuery(xoa1);
            string xoa2 = "delete from [dbo].[KHACHHANG] where MaKH='" + MaKH + "'";
            int result2 = DataProvider.Instance.ExecuteNonQuery(xoa2);
            return result2 > 0;
        }
        public List<KhachHangDTO> TimKiemTheoTen(string TenKH)
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            string timkiem = "select * from [dbo].[KHACHHANG] where TenKH like N'%" + TenKH + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(timkiem);
            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(item);
                list.Add(kh);
            }
            return list;
        }


    }
}

