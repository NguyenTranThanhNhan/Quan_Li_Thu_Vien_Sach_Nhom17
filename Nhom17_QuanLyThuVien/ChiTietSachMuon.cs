using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    public class ChiTietSachMuon
    {
        private string maPhieu;
        private string maSach;
        private string tenSach;
        private int slMuon;
        public ChiTietSachMuon() { 
            this.maPhieu = null;
            this.maSach = null;
            this.tenSach = null;
            this.slMuon = 0;
        }
        public ChiTietSachMuon(string maPhieu, string maSach, string tenSach, int slMuon)
        {
            this.maPhieu = maPhieu;
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.slMuon = slMuon;
        }
        public string MaPhieu { 
            get{ return this.maPhieu; }
            set { this.maPhieu = value; }
        }
        public string MaSach
        {
            get { return this.maSach; }
            set { this.maSach = value; }
        }
        public string TenSach
        {
            get { return this.tenSach; }
            set { this.tenSach = value; }
        }
        public int SlMuon
        {
            get { return this.slMuon; }
            set { this.slMuon = value; }
        }

    }
}
