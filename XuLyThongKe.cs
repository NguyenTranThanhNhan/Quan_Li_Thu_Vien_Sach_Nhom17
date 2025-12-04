using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Nhom17_QuanLyThuVien
{
    public class XuLyThongKe
    {
        private List<MuonTra> _danhSachPhieuMuonTra;
        private List<ThongKe> dsThongKe;
        private static XuLyThongKe instance;
        public static XuLyThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new XuLyThongKe();
                return instance;
            }
        }
        public XuLyThongKe()
        {
            this.dsThongKe = new List<ThongKe>();
        }
        public XuLyThongKe(List<ThongKe> dsTK)
        {
            this.dsThongKe = dsTK;
        }
        private string filename = "dsThongke.dat";
        public void DocFile()
        {
            FileDocGhi.DocDuLieu(filename, out dsThongKe);
        }
        public void GhiFile()
        {
            FileDocGhi.GhiDuLieu(filename, dsThongKe);

        }
      
        public XuLyThongKe(List<MuonTra> data)
        {
            _danhSachPhieuMuonTra = data;
            dsThongKe = new List<ThongKe>();
        }

        public List<ThongKe> ThongKeTheoNgay(DateTime? ngayBatDau, DateTime? ngayKetThuc)
        {
            // 1. Lọc các phiếu mượn theo khoảng thời gian
            var phieuMuonDaLoc = _danhSachPhieuMuonTra
                .Where(p =>
                    (!ngayBatDau.HasValue || p.NgayMuon.Date >= ngayBatDau.Value.Date) &&
                    (!ngayKetThuc.HasValue || p.NgayMuon.Date <= ngayKetThuc.Value.Date)
                )
                .ToList();

            var ketQuaThongKe = new List<ThongKe>();

            // 2. Duyệt qua từng phiếu và từng chi tiết sách
            foreach (var phieu in phieuMuonDaLoc)
            {
                if (phieu.DanhSachChiTiet != null)
                {
                    foreach (var chiTiet in phieu.DanhSachChiTiet)
                    {
                        string tenTVHienThi = phieu.TenTV;

                       
                        if (string.IsNullOrEmpty(tenTVHienThi) && !string.IsNullOrEmpty(phieu.MaTV))
                        {
                            var tvGoc = XuLyThanhVien.Instance.TimTV(phieu.MaTV);
                            if (tvGoc != null)
                            {
                                tenTVHienThi = tvGoc.TenThanhVien;
                            }
                        }
                        string tacGiaHienThi = chiTiet.TacGia;
                        if (string.IsNullOrEmpty(tacGiaHienThi))
                        {
                            var sach = XuLySach.Instance.TimSach(chiTiet.MaSach);
                            if (sach != null) tacGiaHienThi = sach.TacGia;
                        }
                        ketQuaThongKe.Add(new ThongKe
                        {
                            NgayMuon = phieu.NgayMuon,
                            TenTV = tenTVHienThi,
                            MaPhieu = phieu.MaPhieu,
                            MaSach = chiTiet.MaSach,
                            TenSach = chiTiet.TenSach,
                            TacGia = tacGiaHienThi,
                            SoluongMuon = chiTiet.SlMuon.ToString(),
                            TrangThai = (ThongKe.TrangThaiPhieu)phieu.TrangThai
                        });
                    }
                }
            }

            return ketQuaThongKe;
        }
        public List<ThongKe> ThongKeTheoLoai(string loaiThoiGian)
        {
            DateTime today = DateTime.Today;
            DateTime? start = null;
            DateTime? end = today;

            switch (loaiThoiGian.ToLower())
            {
                case "ngày":
                case "day":
                    start = today;
                    break;
                case "tuần":
                case "week":
                    // Tính toán ngày đầu tuần (Giả sử bắt đầu từ Thứ Hai)
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                    start = today.AddDays(-1 * diff);
                    end = today;
                    break;
                case "tháng":
                case "month":
                    start = new DateTime(today.Year, today.Month, 1);
                    end = today;
                    break;
                case "năm":
                case "year":
                    start = new DateTime(today.Year, 1, 1);
                    end = today;
                    break;
                case "tất cả":
                default:
                    // Không đặt ngày bắt đầu và kết thúc
                    start = null;
                    end = null;
                    break;
            }

            return ThongKeTheoNgay(start, end);
        }

    }
}
