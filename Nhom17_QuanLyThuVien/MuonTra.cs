using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    public class MuonTra
    {
        private string maMuonTra;
        private string maTV;
        private string maSach;
        private int SoLuong;
        private string sdt;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        private bool trangThai; // true: đã trả, false: chưa trả
        
        //properties
        public string MaMuonTra { get => maMuonTra; set => maMuonTra = value; }
        public string MaThanhVien { get => maTV; set => maTV = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public int Soluong { get => SoLuong; set => SoLuong=value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string Sdt { get => sdt; set => sdt=value; }


        // constructor
        public MuonTra()
        {
            this.maMuonTra = "";
            this.maTV = "";
            this.maSach = "";
            this.Soluong = 0;
            this.sdt ="";
            this.ngayMuon = DateTime.Now;
            this.ngayTra = DateTime.Now;
            this.trangThai = false;
        }
        public MuonTra(string maMuonTra, string maTV, string maSach, int soluong, string sdt, DateTime ngayMuon, DateTime ngayTra, bool trangThai)
        {
            this.maMuonTra = maMuonTra;
            this.maTV = maTV;
            this.maSach = maSach;
            this.Soluong = soluong;
            this.sdt = sdt;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
            this.trangThai = trangThai;
        }

    }
}
