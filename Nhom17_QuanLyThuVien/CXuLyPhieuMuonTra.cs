using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom17_QuanLyThuVien
{
    public class CXuLyPhieuMuonTra
    {
        private List<MuonTra> dsMuonTra;
        private static CXuLyPhieuMuonTra _instance;
        public List<PhieuMuon> dsPhieuMuon = new List<PhieuMuon>();
        public List<Sach> dsSach;

        public static CXuLyPhieuMuonTra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CXuLyPhieuMuonTra();
                return _instance;
            }
        }
        private CXuLyPhieuMuonTra() {
            dsSach = new List<Sach>();
            dsPhieuMuon = new List<PhieuMuon>();
            dsMuonTra = new List<MuonTra>();
            DocFile();
        }
        public List<MuonTra> DSMuonTra
        {
            get { return dsMuonTra; }
            set { dsMuonTra = value; }
        }
        private string filename = "dsMuonTra.dat";
        public void DocFile()
        {
            FileDocGhi.DocDuLieu(filename, out dsMuonTra);
        }

        public void GhiFile()
        {
            FileDocGhi.GhiDuLieu(filename, dsMuonTra);
        }

        public List<MuonTra> LayDSM() {
            return dsMuonTra;
        }
        public MuonTra TimPhieuMuonTraTheoMa(string maPhieu)
        {
            foreach (MuonTra mt in dsMuonTra)
            {
                if (mt.MaPhieu == maPhieu)
                    return mt;
            }
            return null;
        }
        public string TaoMaPhieuTuDong()
        {
            int maxNum = 0;
            foreach (var p in dsMuonTra)
            {
                if (p.MaPhieu.StartsWith("MP") && p.MaPhieu.Length > 2)
                {
                    if (int.TryParse(p.MaPhieu.Substring(2), out int currentNum))
                    {
                        if (currentNum > maxNum)
                            maxNum = currentNum;
                    }
                }
            }
            return "MP" + (maxNum + 1).ToString("D3");
        }
        public bool ThemPhieuMuon(MuonTra phieu)
        {
            var xlSach = XuLySach.Instance;
            bool coPhieuChuaTra = this.dsMuonTra.Any(p => p.MaTV == phieu.MaTV && p.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra);

            if (coPhieuChuaTra)
            {
                MessageBox.Show("Độc giả này đang có phiếu mượn chưa trả. Vui lòng trả sách cũ trước khi mượn tiếp!", "Lỗi Quy Tắc Mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (phieu.TongSoLuongMuon < 1 || phieu.TongSoLuongMuon > 3)
            {
                MessageBox.Show("Tổng số lượng sách mượn phải từ 1 đến 3 quyển!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (var chiTiet in phieu.DanhSachChiTiet)
            {
                if (!xlSach.GiamSoLuong(chiTiet.MaSach, chiTiet.SlMuon))
                {
                    MessageBox.Show($"Sách có mã {chiTiet.MaSach} không đủ số lượng tồn kho ({chiTiet.SlMuon} > SL Còn)!", "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RollbackGiamSoLuong(phieu, chiTiet.MaSach);
                    return false;
                }
            }
            
            this.dsMuonTra.Add(phieu);
            this.GhiFile();
            return true;
        }
        private void RollbackGiamSoLuong(MuonTra phieu, string maSachLoi)
        {
            var xlSach = XuLySach.Instance;
            foreach (var chiTiet in phieu.DanhSachChiTiet)
            {
                if (chiTiet.MaSach == maSachLoi)
                    break;
                xlSach.TangSoLuong(chiTiet.MaSach, chiTiet.SlMuon);
            }
        }
        public bool TraSach(string maPhieu)
        {
            MuonTra phieu = TimPhieuMuonTraTheoMa(maPhieu);
            var xlSach = XuLySach.Instance;

            if (phieu == null || phieu.TrangThai == MuonTra.TrangThaiPhieu.DaTra)
            {
                MessageBox.Show("Phiếu không tồn tại hoặc đã được trả trước đó.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (var chiTiet in phieu.DanhSachChiTiet)
            {
                xlSach.TangSoLuong(chiTiet.MaSach, chiTiet.SlMuon);
            }
            phieu.TrangThai = MuonTra.TrangThaiPhieu.DaTra;
            this.GhiFile();

            MessageBox.Show($"Phiếu mượn {maPhieu} đã được trả thành công. Số lượng tồn kho đã được cập nhật.", "Hoàn Tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public bool SuaPhieuMuon(string maPhieuCanSua, MuonTra duLieuMoi)
        {
            MuonTra phieuCu = TimPhieuMuonTraTheoMa(maPhieuCanSua);
            var xlSach = XuLySach.Instance;
            if (phieuCu == null)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phieuCu.TrangThai == MuonTra.TrangThaiPhieu.DaTra)
            {
                MessageBox.Show("Không thể sửa phiếu đã trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (duLieuMoi.TongSoLuongMuon < 1 || duLieuMoi.TongSoLuongMuon > 3)
            {
                MessageBox.Show($"Tổng số lượng sách mượn mới ({duLieuMoi.TongSoLuongMuon}) phải từ 1 đến 3 quyển.", "Lỗi Nghiệp Vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (var chiTietCu in phieuCu.DanhSachChiTiet)
            {
                xlSach.TangSoLuong(chiTietCu.MaSach, chiTietCu.SlMuon);
            }
            foreach (var chiTietMoi in duLieuMoi.DanhSachChiTiet)
            {
                if (!xlSach.GiamSoLuong(chiTietMoi.MaSach, chiTietMoi.SlMuon))
                {
                    MessageBox.Show($"Lỗi tồn kho: Sách mã {chiTietMoi.MaSach} không đủ số lượng tồn kho!", "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RollbackGiamSoLuong(duLieuMoi, chiTietMoi.MaSach);
                    foreach (var chiTietCu in phieuCu.DanhSachChiTiet)
                    {
                        xlSach.GiamSoLuong(chiTietCu.MaSach, chiTietCu.SlMuon);
                    }
                    return false;
                }
            }
            int index = dsMuonTra.FindIndex(p => p.MaPhieu == maPhieuCanSua);
            if (index != -1)
            {
                duLieuMoi.MaPhieu = phieuCu.MaPhieu;
                dsMuonTra[index] = duLieuMoi;
                this.GhiFile();

                MessageBox.Show($"Sửa phiếu mượn {maPhieuCanSua} thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Lỗi nội bộ khi cập nhật danh sách phiếu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool GiaHanPhieu(string maPhieu)
        {
            MuonTra p = TimPhieuMuonTraTheoMa(maPhieu);
            if (p == null)
            {
                MessageBox.Show($"Lỗi: Không tìm thấy phiếu mượn có mã {maPhieu}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (p.TrangThai == MuonTra.TrangThaiPhieu.DaTra)
            {
                MessageBox.Show("Lỗi: Phiếu này đã được trả. Không thể gia hạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (p.SoLanGiaHan >= 3)
            {
                MessageBox.Show("Lỗi: Phiếu đã đạt giới hạn gia hạn (quá 3 lần).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            p.NgayTraDuKien = p.NgayTraDuKien.AddDays(7);
            p.SoLanGiaHan++;
            this.GhiFile();
            MessageBox.Show($"Gia hạn thành công! Ngày trả mới: {p.NgayTraDuKien.ToShortDateString()}", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        public void SelectionSortTheoMa(List<HienThiDSMuonTra> dsHienThi)
        {
            for (int i = 0; i < dsHienThi.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < dsHienThi.Count; j++)
                {
                    if (string.Compare(dsHienThi[j].MaPhieu, dsHienThi[min].MaPhieu, StringComparison.OrdinalIgnoreCase) < 0)
                        min = j;
                }
                if (min != i)
                {
                    HienThiDSMuonTra temp = dsHienThi[i];
                    dsHienThi[i] = dsHienThi[min];
                    dsHienThi[min] = temp;
                }
            }
        }
        public List<HienThiDSMuonTra> TaoDanhSachHienThi(List<MuonTra> dsPhieuGoc)
        {
            var dsHienThi = new List<HienThiDSMuonTra>();
            foreach (var phieu in dsPhieuGoc)
            {
                foreach (var chiTiet in phieu.DanhSachChiTiet)
                {
                    var item = new HienThiDSMuonTra
                    {
                        MaPhieu = phieu.MaPhieu,
                        MaTV = phieu.MaTV,
                        NgayMuon = phieu.NgayMuon.Date,
                        NgayTraDuKien = phieu.NgayTraDuKien.Date,
                        MaSach = chiTiet.MaSach,
                        TenSach = chiTiet.TenSach,
                        SoLuongMuon = chiTiet.SlMuon,
                    };

                    dsHienThi.Add(item);
                }
            }
            SelectionSortTheoMa(dsHienThi);
            return dsHienThi;
        }

    }
}
