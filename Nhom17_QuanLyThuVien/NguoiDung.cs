using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    internal class NguoiDung
    {
        private string maND;
        private string hoTenND;
        private string lop;
        private string sdt;
        private string email;
        private DateTime ngayDangKy;
        public NguoiDung()
        {
            this.maND = "";
            this.hoTenND = "";
            this.lop = "";
            this.sdt = "";
            this.email = "";
            this.ngayDangKy = DateTime.Now;
        }
        public NguoiDung(string maND, string hoTenND, string lop,string sdt,string email, DateTime ngayDangKy)
        {
            this.maND = maND;
            this.hoTenND = hoTenND;
            this.lop = lop;
            this.sdt = sdt;
            this.email = email;
            this.ngayDangKy = ngayDangKy;
        }
        public string MaND { get => maND; set => maND = value; }
        public string HoTenND { get => hoTenND; set => hoTenND = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        
    }
}
