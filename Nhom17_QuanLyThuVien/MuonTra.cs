using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    internal class MuonTra
    {
        private string maMuonTra;
        private string maND;
        private string maSach;
        private string SoLuong;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        private bool trangThai; // true: đã trả, false: chưa trả
        public MuonTra()
        {
            this.maMuonTra = "";
            this.maND = "";
            this.maSach = "";
            this.Soluong ="";
            this.ngayMuon = DateTime.Now;
            this.ngayTra = DateTime.Now;
            this.trangThai = false;
        }
        public MuonTra(string maMuonTra, string maND, string maSach, string soluong, DateTime ngayMuon, DateTime ngayTra, bool trangThai)
        {
            this.maMuonTra = maMuonTra;
            this.maND = maND;
            this.maSach = maSach;
            this.Soluong = soluong;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
            this.trangThai = trangThai;
        }
        public string MaMuonTra { get => maMuonTra; set => maMuonTra = value; }
        public string MaND { get => maND; set => maND = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string Soluong { get => SoLuong; set => SoLuong=value; }
    }
}
