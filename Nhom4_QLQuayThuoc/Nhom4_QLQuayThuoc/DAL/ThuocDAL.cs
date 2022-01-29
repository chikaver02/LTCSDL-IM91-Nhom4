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

    }
}
