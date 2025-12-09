using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom17_QuanLyThuVien
{
    public partial class GiaoDienSach : Form
    {
        private XuLySach xlSach = XuLySach.Instance;
        private CXuLyPhieuMuonTra xlMuon = CXuLyPhieuMuonTra.Instance;
        private int vitri = -1;
        public GiaoDienSach()
        {
            InitializeComponent();
            // NgaySX.MaxDate = DateTime.Today;
        }

        private void GiaoDienSach_Load(object sender, EventArgs e)
        {
            cbbTheLoai.DataSource = Const.listLoaiSach;
            xlSach.DocFile();
            HienThiDanhSach(xlSach.LayDanhSach());
            if (cbbTheLoai.Items.Count > 0)
            {
                cbbTheLoai.SelectedIndex = 0; // Chọn mục đầu tiên làm mặc định
                TaoMaSachTuDong(); // Tạo mã ngay khi Form load
            }

        }
        private void TaoMaSachTuDong()
        {
            if (cbbTheLoai.SelectedItem != null)
            {
                // Lấy Tên Thể loại đã chọn (Ví dụ: "Sách lịch sử")
                string tenTheLoai = cbbTheLoai.SelectedItem.ToString();

                // Chuyển sang Mã số (Ví dụ: "01")
                string maTheLoaiSo = xlSach.LayMaSoTheLoai(tenTheLoai);

                // Tạo Mã ISBN-13 hoàn chỉnh có dấu gạch ngang
                string maSachMoi = xlSach.TaoMaISBNTheoTheLoai(maTheLoaiSo);

                // Cập nhật lên TextBox Mã Sách
                MaSach.Text = maSachMoi;
            }
        }
        private void HienThiDanhSach(List<Sach> ds)
        {
            xlSach.DocFile();
            xlSach.SelectionSortTheoMa();
            DaTaSach.DataSource = ds;
            DaTaSach.Enabled = true;
        }
        private void ClearInputFields()
        {

            TenSach.Clear();
            TacGia.Clear();
            NhaXB.Clear();
            cbbTheLoai.Text = "";
            SoLuong.Clear();
            txtslconlai.Clear();
            NgaySX.ResetText();
            MaSach.Focus();
            TaoMaSachTuDong();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
                new MainThuVien().Show();
            }
        }
        private void GiaoDienSach_Shown(object sender, EventArgs e)
        {
            MaSach.Focus();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string maISBNCoGachNgang = MaSach.Text;

            // 1. KIỂM TRA TÍNH HỢP LỆ CỦA ISBN (Check Digit + Cấu trúc 13 số)
            // KiemTraISBNHopLe sẽ tự xử lý loại bỏ gạch ngang.
            if (!xlSach.KiemTraISBNHopLe(maISBNCoGachNgang))
            {
                MessageBox.Show("Mã ISBN không hợp lệ! Vui lòng kiểm tra lại cấu trúc mã (978-604-58-XXYY-Z).", "Lỗi ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(SoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên và lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SoLuong.Focus();
                return;
            }
            if (NgaySX.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Năm xuất bản không được lớn hơn năm hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NgaySX.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(MaSach.Text) || string.IsNullOrWhiteSpace(TenSach.Text) ||
               string.IsNullOrWhiteSpace(TacGia.Text) || string.IsNullOrWhiteSpace(NhaXB.Text) ||
               string.IsNullOrWhiteSpace(cbbTheLoai.Text) || string.IsNullOrWhiteSpace(SoLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sach s = new Sach(maISBNCoGachNgang, TenSach.Text, TacGia.Text, NhaXB.Text, cbbTheLoai.Text, int.Parse(SoLuong.Text), NgaySX.Value.Year, int.Parse(SoLuong.Text));
            bool kqthem = xlSach.ThemSach(s);
            if (kqthem == true)
            {
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlSach.LayDanhSach());
                ClearInputFields();
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maSach = MaSach.Text;
            bool coPhieuChuaTra = false;
            foreach (var pmt in xlMuon.LayDSM())
            {
                if (pmt.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra)
                {
                    // Duyệt qua các chi tiết sách trong phiếu đó
                    foreach (var chiTiet in pmt.DanhSachChiTiet)
                    {
                        if (chiTiet.MaSach == maSach)
                        {
                            coPhieuChuaTra = true;
                            break; // Đã tìm thấy, thoát khỏi vòng lặp chi tiết
                        }
                    }
                }
                if (coPhieuChuaTra)
                {
                    break; // Đã tìm thấy phiếu chứa sách chưa trả, thoát khỏi vòng lặp phiếu
                }
            }
            if (coPhieuChuaTra)
            {
                MessageBox.Show("Không thể xóa sách vì có phiếu mượn chưa trả.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult kq = MessageBox.Show("Bạn muốn xóa sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                bool kqxoa = xlSach.XoaSach(MaSach.Text);
                if (kqxoa == true)
                {
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(xlSach.LayDanhSach());
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại! Không tìm thấy mã sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SoLuong.Text, out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên và lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SoLuong.Focus();
                return;
            }
            string maISBNCoGachNgang = MaSach.Text;

            // 1. KIỂM TRA TÍNH HỢP LỆ CỦA ISBN (Check Digit + Cấu trúc 13 số)
            // KiemTraISBNHopLe sẽ tự xử lý loại bỏ gạch ngang.
            if (!xlSach.KiemTraISBNHopLe(maISBNCoGachNgang))
            {
                MessageBox.Show("Mã ISBN không hợp lệ! Vui lòng kiểm tra lại cấu trúc mã (978-604-58-XXYY-Z).", "Lỗi ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string maSach = MaSach.Text;
            string tenSach = TenSach.Text;
            string tacGia = TacGia.Text;
            string nhaXB = NhaXB.Text;
            string theLoai = cbbTheLoai.Text;
            int soLuong = int.Parse(SoLuong.Text);
            int namXB = NgaySX.Value.Year;
            int slconlai = int.Parse(txtslconlai.Text);
            Sach s = new Sach(maISBNCoGachNgang, tenSach, tacGia, nhaXB, theLoai, soLuong, namXB, slconlai);
            bool kqsua = xlSach.SuaSach(s);
            if (kqsua == true)
            {
                MessageBox.Show("Sửa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlSach.LayDanhSach());
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Sửa sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DaTaSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vitri = e.RowIndex;
                Sach s = new Sach();
                s = xlSach.DSSach[vitri];
                MaSach.Text = s.MaSach;
                TenSach.Text = s.TenSach;
                TacGia.Text = s.TacGia;
                NhaXB.Text = s.NhaXuatBan;
                cbbTheLoai.Text = s.TheLoai;
                SoLuong.Text = s.SoLuong.ToString();
                txtslconlai.Text = s.SoLuongCon.ToString();
                NgaySX.Value = new DateTime(s.NamXuatBan, 1, 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string maCanTim = txtmatimkiem.Text.Trim();

            if (string.IsNullOrEmpty(maCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã sách/tên sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sach kqTheoMa = xlSach.LinearSearchTheoMa(maCanTim);
            Sach kqTheoTen = null;
            if (kqTheoMa == null)
            {
                kqTheoTen = xlSach.BinarySearchTheoTen(maCanTim);
            }

            Sach sachTimThay = kqTheoMa ?? kqTheoTen;

            if (sachTimThay != null)
            {
                cbbTheLoai.SelectedIndexChanged -= cbbTheLoai_SelectedIndexChanged;
                MaSach.Text = sachTimThay.MaSach;
                TenSach.Text = sachTimThay.TenSach;
                TacGia.Text = sachTimThay.TacGia;
                NhaXB.Text = sachTimThay.NhaXuatBan;
                cbbTheLoai.Text = sachTimThay.TheLoai;
                SoLuong.Text = sachTimThay.SoLuong.ToString();
                txtslconlai.Text = sachTimThay.SoLuongCon.ToString();
                NgaySX.Value = new DateTime(sachTimThay.NamXuatBan, 1, 1);

                DaTaSach.Enabled = false;
                DaTaSach.DataSource = new List<Sach> { sachTimThay };

                string loaiTimThay = (kqTheoMa != null) ? "mã" : "tên";
                MessageBox.Show($"Đã tìm thấy sách theo {loaiTimThay}: {maCanTim}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã hoặc tên: " + maCanTim, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlSach.LayDanhSach());

            }
        }
        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach(xlSach.LayDanhSach());
            ClearInputFields();
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaoMaSachTuDong();
        }
    }
        
}
