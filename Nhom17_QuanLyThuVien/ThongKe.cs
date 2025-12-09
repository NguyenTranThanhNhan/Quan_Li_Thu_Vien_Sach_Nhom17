using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    
    [Serializable]
    public class ThongKe
    {
        public enum TrangThaiPhieu { ChuaTra = 0, DaTra = 1 }
        private string maPhieu;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        private string maSach;
        private string tenSach;
        private string tenTV;
        private string tacGia;
        private string soluongMuon;
        private TrangThaiPhieu trangThai;
        public ThongKe()
        {
            maPhieu ="";
            maSach ="";
            tenSach="";
            tenTV ="";
            tacGia ="";
            soluongMuon ="";
            trangThai = TrangThaiPhieu.ChuaTra;
        }
        public ThongKe(string maPhieu, string maSach, string tenSach, string tenTV, string tacGia, string soluongMuon, TrangThaiPhieu trangThai)
        {
            this.maPhieu = maPhieu;
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tenTV = tenTV;
            this.tacGia = tacGia;
            this.soluongMuon = soluongMuon;
            this.trangThai = trangThai;
        }

        public string MaPhieu { get => maPhieu; set => maPhieu=value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon=value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra=value; }
        public string MaSach { get => maSach; set => maSach=value; }
        public string TenSach { get => tenSach; set => tenSach=value; }
        public string TenTV { get => tenTV; set => tenTV=value; }
        public string TacGia { get => tacGia; set => tacGia=value; }
        public string SoluongMuon { get => soluongMuon; set => soluongMuon=value; }
        public TrangThaiPhieu TrangThai { get => trangThai; set => trangThai=value; }
       
    }
}



