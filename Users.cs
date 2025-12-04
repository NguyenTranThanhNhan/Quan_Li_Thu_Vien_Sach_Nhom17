using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    public class Users
    {
        private string userName;
        private string password;
       

        public string UserName { get => userName; set => userName=value; }
        public string Password { get => password; set => password=value; }
       
       

        public Users(string name, string pass) {
            this.UserName = name;
            this.Password = pass;
            
        }
    }
}
