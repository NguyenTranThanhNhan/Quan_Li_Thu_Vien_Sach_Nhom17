using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    public class ThanhVien
    {
        private string maTV;
        private string tenTV;
        private string sdt;
        private string email;
        private DateTime NgaySinh;
        private DateTime NgayDK;
        private string can;
        private string phai;


        public ThanhVien() : this("", "", "", "", DateTime.Today, DateTime.Today, "", "")
        {
        }
        public ThanhVien(string MaThanhVien, string TenThanhVien, string SDT, string email, DateTime NgayThangNamSinh, DateTime NgayDangKy, string YeuCau, string Phai)
        {
            this.maTV = MaThanhVien;
            this.tenTV = TenThanhVien;
            this.sdt = SDT;
            this.Email = email;
            this.NgaySinh = NgayThangNamSinh;
            this.NgayDK = NgayDangKy;
            this.can = YeuCau;
            this.phai = Phai;
        }
        public string MaThanhVien { get => maTV; set => maTV = value; }
        public string TenThanhVien { get => tenTV; set => tenTV = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public DateTime NgayThangNamSinh { get => NgaySinh; set => NgaySinh = value; }
        public DateTime NgayDangKy { get => NgayDK; set => NgayDK = value; }
        public string YeuCau { get => can; set => can = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Email { get => email; set => email=value; }
    }
}
