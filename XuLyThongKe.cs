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
        private string filename = "dstk.dat";
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

        public List<ThongKe> ThongKeTheoNgay(DateTime? ngayBatDau, DateTime? ngayKetThuc, string loaiDacBiet)
        {
            DateTime today = DateTime.Today.Date;
            //AsQueryable(): chuyển danh sách thành dạng LinQ
            var phieuMuonDaLoc = _danhSachPhieuMuonTra.AsQueryable();        
            if (loaiDacBiet == "Quá Hạn")
            {
                phieuMuonDaLoc = phieuMuonDaLoc
                    .Where(p =>p.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra &&p.NgayTraDuKien.Date < today);
            }
            else if (loaiDacBiet == "Đến Hạn Hôm Nay")
            {
                phieuMuonDaLoc = phieuMuonDaLoc
                    .Where(p =>p.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra &&p.NgayTraDuKien.Date == today);
            }
            else
            {
                //HasValue: kiểm tra có giá trị hay không hay là null(rỗng)
                phieuMuonDaLoc = phieuMuonDaLoc.Where(p =>(!ngayBatDau.HasValue || p.NgayMuon.Date >= ngayBatDau.Value.Date) &&(!ngayKetThuc.HasValue || p.NgayMuon.Date <= ngayKetThuc.Value.Date));
            }
            // trả ngược lại dạng danh sách list
            var phieuMuonFinal = phieuMuonDaLoc.ToList();
            var ketQuaThongKe = new List<ThongKe>();
            foreach (var phieu in phieuMuonFinal)
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
                            NgayTra = phieu.NgayTraDuKien,
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
            // ? có nghĩa là biến này được phép rỗng
            DateTime? start = null;
            DateTime? end = null;
            string loaiDacBiet = null;

            // Lưu ý: Đặt giờ kết thúc là cuối ngày (23:59:59) để không sót dữ liệu trong ngày hôm nay

            DateTime endOfDay = today.AddDays(1).AddTicks(-1);

            switch (loaiThoiGian.ToLower())
            {
                case "quá hạn":
                case "late":
                    loaiDacBiet = "Quá Hạn";
                    break;

                case "đến hạn hôm nay":
                case "đến hạn":
                    loaiDacBiet = "Đến Hạn Hôm Nay";
                    break;

                case "ngày":
                case "day":
                    start = today;
                    end = endOfDay;
                    break;

                case "tuần":
                case "week":
                    // Thay vì lấy tuần theo lịch (T2-CN), ta lấy 7 ngày gần nhất tính cả hôm nay
                    // Ví dụ: Hôm nay 15/12, start sẽ là 09/12.
                    start = today.AddDays(-6);
                    end = endOfDay;
                    break;

                case "tháng":
                case "month":
                    // tạo ngày mới giữ nguyên năm tháng hiện tại 
                    start = new DateTime(today.Year, today.Month, 1);
                    //Date.AddDays(1).AddTicks(-1) là nhảy 1 ngày và lùi lại 1s (23:59:59)
                    end = start.Value.AddMonths(1).AddDays(-1).Date.AddDays(1).AddTicks(-1); // Cuối ngày cuối tháng
                    break;

                case "năm":
                case "year":
                    start = new DateTime(today.Year, 1, 1);
                    end = new DateTime(today.Year, 12, 31, 23, 59, 59);
                    break;

                case "tất cả":
                default:
                    start = null;
                    end = null;
                    break;
            }

            return ThongKeTheoNgay(start, end, loaiDacBiet);
        }
    }
}
