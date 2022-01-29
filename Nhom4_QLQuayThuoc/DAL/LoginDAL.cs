using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom4_QLQuayThuoc.DAL
{
    public class LoginDAL
    {
        private static LoginDAL instance;
        public static LoginDAL Instance
        {
            get
            {
                if (instance == null) 
                    instance = new LoginDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private LoginDAL() { }
        public bool Login1(string userName, string passWord)
        {            
            string query = "SELECT * FROM[dbo].[DANGNHAP] WHERE Ten = N'" +userName +"' AND MatKhau = N'"+ passWord+ "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count >0;
        }      
        
        
    }
}
