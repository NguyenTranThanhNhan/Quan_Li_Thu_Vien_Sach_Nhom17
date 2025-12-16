using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    public class ListUser
    {
        private static ListUser instance;
        private List<Users> listAccountUser;
        public List<Users> ListAccountUser { get => listAccountUser; set => listAccountUser=value; }
        public static ListUser Instance {
            get
            { 
                if(instance == null)
                    instance = new ListUser();
                return instance;
                
            }
            set => instance=value; }
        private ListUser() {
            listAccountUser = new List<Users>();
            listAccountUser.Add(new Users("nguyennhan", "00000"));
        }
    }
}
