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
        public enum TrangThaiPhieu { ChuaTra = 0, DaTra = 1 }
        private string maPhieu;
        private string maTV;
        private string tenTV;
        private string sdt;
        private DateTime ngayMuon;
        private DateTime ngayTraDuKien;
        private int tongSoLuongMuon;
        private int soLanGiaHan;
        private TrangThaiPhieu trangThai;
        private List<ChiTietSachMuon> danhSachChiTiet;

        public MuonTra()
        {
            this.danhSachChiTiet = new List<ChiTietSachMuon>();
            this.trangThai = TrangThaiPhieu.ChuaTra;
        }
        public string MaPhieu
        {
            get { return this.maPhieu; }
            set { this.maPhieu = value; }
        }

        public string MaTV
        {
            get { return this.maTV; }
            set { this.maTV = value; }
        }

        public string TenTV
        {
            get { return this.tenTV; }
            set { this.tenTV = value; }
        }

        public string SDT
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }

        public DateTime NgayMuon
        {
            get { return this.ngayMuon; }
            set { this.ngayMuon = value; }
        }

        public DateTime NgayTraDuKien
        {
            get { return this.ngayTraDuKien; }
            set { this.ngayTraDuKien = value; }
        }

        public int TongSoLuongMuon
        {
            get { return this.tongSoLuongMuon; }
            set { this.tongSoLuongMuon = value; }
        }

        public int SoLanGiaHan
        {
            get { return this.soLanGiaHan; }
            set { this.soLanGiaHan = value; }
        }

        public TrangThaiPhieu TrangThai
        {
            get { return this.trangThai; }
            set { this.trangThai = value; }
        }

        // Danh sách các chi tiết mượn
        public List<ChiTietSachMuon> DanhSachChiTiet
        {
            get { return this.danhSachChiTiet; }
            set { this.danhSachChiTiet = value; }
        }
}
}
