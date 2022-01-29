using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom4_QLQuayThuoc.DTO;

namespace Nhom4_QLQuayThuoc.DAL
{
    public class ThuocDAL
    {
        private static ThuocDAL instance;
        public static ThuocDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThuocDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<ThuocDTO> GetListThuoc()
        {
            List<ThuocDTO> list = new List<ThuocDTO>();
            string query = "SELECT * FROM THUOC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThuocDTO thuoc = new ThuocDTO(item);
                list.Add(thuoc);
            }
            return list;
        }

        public List<ThuocDTO> TimKiemTheoTen(string tenThuoc)
        {
            List<ThuocDTO> list = new List<ThuocDTO>();
            string query = string.Format("SELECT * FROM Thuoc WHERE TenThuoc like '%" + tenThuoc + "%'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThuocDTO thuoc = new ThuocDTO(item);
                list.Add(thuoc);
            }
            return list;
        }
        public List<ThuocDTO> TimKiemTheoNSX(string namSanXuat)
        {
            List<ThuocDTO> list1 = new List<ThuocDTO>();
            string query = string.Format("SELECT * FROM Thuoc WHERE NamSanXuat LIKE '%" + namSanXuat + "%'");
            DataTable data0 = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data0.Rows)
            {
                ThuocDTO thuoc = new ThuocDTO(item);
                list1.Add(thuoc);
            }
            return list1;
        }
        public List<ThuocDTO> TimKiemTheoHSD(string hanSuDung)
        {
            List<ThuocDTO> list = new List<ThuocDTO>();
            string query = string.Format("SELECT * FROM Thuoc WHERE HanSuDung LIKE '%" + hanSuDung + "%'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThuocDTO thuoc = new ThuocDTO(item);
                list.Add(thuoc);
            }
            return list;
        }

        public bool Delete(string MaThuoc)
        {
            string Delete = ("delete from THUOC where MaThuoc = '" + MaThuoc + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(Delete);
            return result > 0;
        }

        public bool Insert(string MaThuoc, string MaNCC, string TenThuoc, string NamSanXuat, string HanSuDung)
        {
            string Insert = "insert into Thuoc(MaThuoc,MaNCC,TenThuoc,NamSanXuat,HanSuDung) values('" + MaThuoc + "','" + MaNCC + "','" + TenThuoc + "','" + NamSanXuat + "','" + HanSuDung + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(Insert);
            return result > 0;
        }

        public bool Update(string MaNCC, string MaThuoc)
        {
            string update = "update Thuoc set MaNCC='" + MaNCC + "' where MaThuoc='" + MaThuoc + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(update);
            return result > 0;
        }
        public bool Update2(string TenThuoc, string MaThuoc)
        {
            string update2 = "update Thuoc set TenThuoc='" + TenThuoc + "' where MaThuoc='" + MaThuoc + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(update2);
            return result > 0;
        }

    }
}
