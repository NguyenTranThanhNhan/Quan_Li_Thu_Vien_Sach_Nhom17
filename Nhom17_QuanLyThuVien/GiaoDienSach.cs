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
        private XuLySach xlSach = new XuLySach();
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
            
        }
        private void HienThiDanhSach(List<Sach> ds)
        {
            xlSach.SelectionSortTheoMa();
            DaTaSach.DataSource = null;
            DaTaSach.DataSource = ds;
        }
        private void ClearInputFields()
        {
            MaSach.Clear();
            TenSach.Clear();
            TacGia.Clear();
            NhaXB.Clear();
            cbbTheLoai.Text = "";
            SoLuong.Clear();
            //NgaySX.Value = DateTime.Now;
            NgaySX.ResetText();
            MaSach.Focus();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void GiaoDienSach_Shown(object sender, EventArgs e)
        {
            MaSach.Focus();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
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
            if(string.IsNullOrWhiteSpace(MaSach.Text) || string.IsNullOrWhiteSpace(TenSach.Text) ||
               string.IsNullOrWhiteSpace(TacGia.Text) || string.IsNullOrWhiteSpace(NhaXB.Text) ||
               string.IsNullOrWhiteSpace(cbbTheLoai.Text) || string.IsNullOrWhiteSpace(SoLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sach s = new Sach(MaSach.Text, TenSach.Text, TacGia.Text, NhaXB.Text, cbbTheLoai.Text, int.Parse(SoLuong.Text), NgaySX.Value.Year);
            bool kqthem = xlSach.ThemSach(s);
            if (kqthem == true)
            {
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlSach.LayDanhSach());
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại! Mã sách đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maSach = MaSach.Text;
            var xlPMT = CXuLyPhieuMuonTra.Instance;
            foreach (var pmt in xlPMT.LayDSM())
            {
                if (pmt.MaSach == maSach && pmt.TrangThai == false)
                {
                    MessageBox.Show("Không thể xóa sách vì có phiếu mượn chưa trả.","thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
            string maSach = MaSach.Text;
            string tenSach = TenSach.Text;
            string tacGia = TacGia.Text;
            string nhaXB = NhaXB.Text;
            string theLoai = cbbTheLoai.Text;
            int soLuong = int.Parse(SoLuong.Text);
            int namXB = NgaySX.Value.Year;
            Sach s = new Sach(maSach, tenSach, tacGia, nhaXB, theLoai, soLuong, namXB);
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
                NgaySX.Value = new DateTime(s.NamXuatBan, 1, 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string maCanTim = MaSach.Text.Trim();

            if (string.IsNullOrEmpty(maCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sach kq = xlSach.LinearSearchTheoMa(maCanTim);

            if (kq != null)
            {
                TenSach.Text = kq.TenSach;
                TacGia.Text = kq.TacGia;
                NhaXB.Text = kq.NhaXuatBan;
                cbbTheLoai.Text = kq.TheLoai;
                SoLuong.Text = kq.SoLuong.ToString();
                NgaySX.Value = new DateTime(kq.NamXuatBan, 1, 1);
                DaTaSach.DataSource = null;
                DaTaSach.DataSource = new List<Sach> { kq };

                MessageBox.Show("Đã tìm thấy sách có mã: " + maCanTim, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã: " + maCanTim, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
