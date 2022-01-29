using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom4_QLQuayThuoc.DTO;

namespace Nhom4_QLQuayThuoc.DAL
{
    public class BanHangDAL
    {
        private static BanHangDAL instance;
        public static BanHangDAL Instance
        {
            get { if (instance == null) instance = new BanHangDAL(); return instance; }
            private set { instance = value; }
        }
        private BanHangDAL() { }
        public List<BanHangDTO> GetListPhieuBH()
        {
            List<BanHangDTO> list = new List<BanHangDTO>();
            string query = "SELECT * FROM dbo.CHITIETPHIEUBAN ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanHangDTO banhang = new BanHangDTO(item);
                list.Add(banhang);
            }
            return list;
        }
        public List<BanHangDTO> GetListPhieuBL()
        {
            List<BanHangDTO> listBL = new List<BanHangDTO>();
            string query1 = "SELECT * FROM dbo.CHITIETPHIEUBAN ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1);
            foreach (DataRow item in data.Rows)
            {
                 BanHangDTO banhang = new BanHangDTO(item);
                listBL.Add(banhang);
            }
            return listBL;
        }
        //Bán hàng theo đơn
        public bool InsertBH(string IDDongBan, string MaNCC, string LoaiThuocBan, int TongBan, decimal DonGiaBan, decimal TongTien)
        {
            string chuoithem = "INSERT into dbo.CHITIETPHIEUBAN(IDDongBan,MaNCC,LoaiThuocBan,TongBan,TongTien,DonGiaBan) " +
                "values(N'" + IDDongBan + "', N'" + MaNCC + "', N'" + LoaiThuocBan + "',N'" + TongBan + "',N'" + DonGiaBan + "',N'" + TongTien + "' )";
            int result = DataProvider.Instance.ExecuteNonQuery(chuoithem);

            return result > 0;
        }
        public bool UpdateBH(string IDDongBan, string MaNCC, string LoaiThuocBan, int TongBan, double DonGiaBan, double TongTien)
        {
            string chuoisua = "UPDATE dbo.CHITIETPHIEUBAN SET MaNCC='" + MaNCC + "',LoaiThuocBan='" + LoaiThuocBan + "',TongBan='" + TongBan + "',DonGiaBan='" + DonGiaBan + "',TongTien='" + TongTien + "'" +
                " WHERE IDDongBan='" + IDDongBan + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(chuoisua);
            return result > 0;

        }
        public bool DeleteBH(string IDDongBan)
        {
            string chuoisua = "DELETE FROM dbo.CHITIETPHIEUBAN WHERE IDDongBan='" + IDDongBan + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(chuoisua);
            return result > 0;

        }
        //Bán hàng lẻ
        public bool InsertBL(string IDDongBan, string MaNCC, string LoaiThuocBan, int TongBan, decimal DonGiaBan, decimal TongTien)
        {
            string chuoithemBL = "INSERT into dbo.CHITIETPHIEUBAN(IDDongBan,MaNCC,LoaiThuocBan,TongBan,TongTien,DonGiaBan) " +
                "values(N'" + IDDongBan + "', N'" + MaNCC + "', N'" + LoaiThuocBan + "',N'" + TongBan + "',N'" + DonGiaBan + "',N'" + TongTien + "' )";
            int result = DataProvider.Instance.ExecuteNonQuery(chuoithemBL);

            return result > 0;
        }
        public bool UpdateBL(string IDDongBan, string MaNCC, string LoaiThuocBan, int TongBan, decimal DonGiaBan, decimal TongTien)
        {
            string chuoisuaBL = "UPDATE dbo.CHITIETPHIEUBAN SET MaNCC='" + MaNCC + "',LoaiThuocBan='" + LoaiThuocBan + "',TongBan='" + TongBan + "',DonGiaBan='" + DonGiaBan + "',TongTien='" + TongTien + "'" +
                " WHERE IDDongBan='" + IDDongBan + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(chuoisuaBL);
            return result > 0;

        }
        public bool DeleteBL(string IDDongBan)
        {
            string chuoisuaBL = "DELETE FROM dbo.CHITIETPHIEUBAN WHERE IDDongBan='" + IDDongBan + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(chuoisuaBL);
            return result > 0;

        }

    }
}
