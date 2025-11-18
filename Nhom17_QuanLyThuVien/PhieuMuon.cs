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
    public partial class PhieuMuon : Form
    {
        private XuLyThanhVien xlTV = XuLyThanhVien.Instance;
        private XuLySach xlSach = XuLySach.Instance;
        private CXuLyPhieuMuonTra xlMuon = CXuLyPhieuMuonTra.Instance;

        int index = -1;
        public PhieuMuon()
        {
            InitializeComponent();
        }

        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            //instance goi pai doc file de hien thi(ghi) len class muontra
            xlTV.DocFile();
            xlSach.DocFile();
            xlMuon.DocFile();
            dpkNgayMuon.Value = DateTime.Today;
            dpkNgayTra.Value = dpkNgayMuon.Value.AddDays(7);
            HienThiDanhSach(xlMuon.LayDSM());
        }
        private void HienThiDanhSach(List<MuonTra> ds)
        {
            xlMuon.SelectionSortTheoMa();
            DaTaMuonTra.DataSource = null;
            DaTaMuonTra.DataSource = ds;
        }
        private void ClearInputFields()
        {
            txtMaPT.Clear();
            txtMaSach.Clear();
            txtTV.Clear();
            txtSDT.Clear();
            txtSoLuong.Clear();
            dpkNgayMuon.Value = DateTime.Today;
            dpkNgayTra.Value = dpkNgayMuon.Value.AddDays(7);

            txtMaPT.Focus();
        }
      
        private void btnMuon_Click(object sender, EventArgs e)
        {
            string maTV = txtTV.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            int soLuong = int.Parse(txtSoLuong.Text.Trim());
            string maPM = txtMaPT.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            DateTime ngayMuon = dpkNgayMuon.Value;
            DateTime ngayTra = dpkNgayTra.Value;
            bool type = rbtnMuon.Checked;
            if(string.IsNullOrEmpty(maPM) || string.IsNullOrEmpty(maTV) || string.IsNullOrEmpty(maSach) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(txtSoLuong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 1. Kiểm tra thành viên
            var tv = XuLyThanhVien.Instance.TimTV(maTV);
            if (tv == null)
            {
                MessageBox.Show("Thành viên chưa đăng ký!");
                return;
            }

            // 2. Kiểm tra sách
            var sach = xlSach.TimSach(maSach);
            if (sach == null)
            {
                MessageBox.Show("Sách không tồn tại!");
                return;
            }

            // 3. Kiểm tra số lượng sách
            if (sach.SoLuong < soLuong)
            {
                MessageBox.Show("Không đủ số lượng sách để mượn!");
                return;
            }
            bool kq = xlMuon.ThemMuonTra(new MuonTra( maPM, maTV, maSach, soLuong, sdt, ngayMuon, ngayTra, type));

            if (kq)
            {
                sach.SoLuong -= soLuong;
                xlSach.GhiFile();
                MessageBox.Show("Mượn sách thành công!");
                rbtnMuon.Checked = true;
                HienThiDanhSach(xlMuon.LayDSM());
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Mượn sách thất bai !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTra_Click(object sender, EventArgs e)
        {
            string mapt = txtMaPT.Text.Trim();

            if (xlMuon.TraSach(mapt))
            {
                MessageBox.Show("Trả sách thành công!");
                rbtnTra.Checked = true;
                xlSach.GhiFile();
                HienThiDanhSach(xlMuon.LayDSM());
                ClearInputFields() ;
            }
            else
            {
                MessageBox.Show("Trả sách thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPT.Text.Trim();
            string maTV = txtTV.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            int soluong = int.Parse(txtSoLuong.Text.Trim());
            DateTime ngayMuon = dpkNgayMuon.Value;
            DateTime ngayTra = dpkNgayTra.Value;
            bool type = rbtnMuon.Checked;

            MuonTra mt = new MuonTra(maPM, maTV, maSach, soluong, sdt, ngayMuon, ngayTra, !type);
            bool trangThai = rbtnTra.Checked;
            MuonTra mtMoi = new MuonTra(maPM, maTV, maSach, soluong, sdt, ngayMuon, ngayTra, trangThai);
            bool kqsua = xlMuon.SuaPhieuMuonTra(mtMoi);

            if (kqsua)
            {
                xlSach.GhiFile();
                MessageBox.Show("Sửa phiếu mượn/trả thành công!");
                HienThiDanhSach(xlMuon.LayDSM());
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Sửa phiếu thất bại! Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            string maCanTim = txtMaPT.Text.Trim();

            if (string.IsNullOrEmpty(maCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MuonTra mt = xlMuon.LinearSearchTheoMa(maCanTim);

            if (mt != null)
            {
                txtMaPT.Text = mt.MaMuonTra;
                txtMaSach.Text = mt.MaSach;
                txtTV.Text = mt.MaThanhVien;
                txtSDT.Text = mt.Sdt;
                txtSoLuong.Text = mt.Soluong.ToString();
                dpkNgayMuon.Value = mt.NgayMuon;
                dpkNgayTra.Value = mt.NgayTra;
                
                DaTaMuonTra.DataSource = null;
                DaTaMuonTra.DataSource = new List<MuonTra> { mt };

                MessageBox.Show("Đã tìm thấy sách có mã: " + maCanTim, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã: " + maCanTim, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlMuon.LayDSM());
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DaTaMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= xlMuon.DSMuonTra.Count)
                    return;   // Không làm gì nếu click ra ngoài

                index = e.RowIndex;

                MuonTra mt = xlMuon.DSMuonTra[index];

                txtMaPT.Text = mt.MaMuonTra;
                txtMaSach.Text = mt.MaSach;
                txtTV.Text = mt.MaThanhVien;
                txtSDT.Text = mt.Sdt;
                txtSoLuong.Text = mt.Soluong.ToString();
                dpkNgayMuon.Value = mt.NgayMuon;
                dpkNgayTra.Value = mt.NgayTra;
                if (mt.TrangThai == false)
                {
                    rbtnMuon.Checked = true;
                    rbtnTra.Checked = false;
                }
                else // mt.TrangThai == true (Đã trả)
                {
                    rbtnMuon.Checked = false;
                    rbtnTra.Checked = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn xóa sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                string mapt = txtMaPT.Text;
                bool kqxoa = xlMuon.XoaPM(mapt);
                if (kqxoa == true)
                {
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(xlMuon.LayDSM());
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại! Không tìm thấy mã sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dpkNgayTra_ValueChanged(object sender, EventArgs e)
        {
            dpkNgayTra.Value = dpkNgayMuon.Value.AddDays(7);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach(xlMuon.LayDSM());
            ClearInputFields();
        }
    }
}
