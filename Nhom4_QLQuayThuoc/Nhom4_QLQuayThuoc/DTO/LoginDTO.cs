using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom4_QLQuayThuoc.DTO
{
    public class LoginDTO
    {
        private static LoginDTO instance;

        public static LoginDTO Instance
        {
            get 
            { if (instance == null) instance = new LoginDTO(); 
              return instance; 
            }
            private set 
            { 
                instance = value; 
            }
        }
        public bool Login1(string userName, string passWord)
        {
            return false;
        }
    }
}
