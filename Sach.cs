using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private string nhaXuatBan;
        private string theLoai;
        private int soLuong;
        private int namXuatBan;
        private int soLuongCon;
        public Sach()
        {
            this.maSach = "";
            this.tenSach = "";
            this.tacGia = "";
            this.nhaXuatBan = "";
            this.theLoai = "";
            this.soLuong = 0;
            this.namXuatBan = 0;
            this.soLuongCon = 0;
        }
        public Sach(string maSach, string tenSach, string tacGia, string nhaXuatBan, string theLoai, int soLuong, int namXuatBan,int soLuongCon)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.nhaXuatBan = nhaXuatBan;
            this.theLoai = theLoai;
            this.soLuong = soLuong;
            this.namXuatBan = namXuatBan;
            this.soLuongCon = soLuongCon;
        }
        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public int SoLuongCon { get => soLuongCon; set => soLuongCon = value; }

        //public string TinhTrang
        //{
        //    get
        //    {
        //        if (SoLuongCon <= 0) return "Hết";
        //        return "Còn";
        //    }
        //}

    }
}
