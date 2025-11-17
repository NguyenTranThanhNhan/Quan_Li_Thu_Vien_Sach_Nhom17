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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom17_QuanLyThuVien
{
    public partial class MainThuVien : Form
    {
        public bool isExit = true;
        private XuLySach xlSach = new XuLySach();
        private int vitri = -1;
        public event EventHandler LogOut;
        public MainThuVien()
        {
            InitializeComponent();
        }
        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            new GiaoDienSach().Show();
        }

        private void toolStripMuonTra_Click(object sender, EventArgs e)
        {
            new Muon_Tra().Show();
        }

        private void MainThuVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show(
                "Bạn có chắc chắn thoát không ?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
        }

        private void MainThuVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit) 
                Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GiaoDienQLThanhVien().Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GiaoDienSach().Show();
        }
        
        private void MainThuVien_Load(object sender, EventArgs e)
        {
            xlSach.DocFile();
            HienThiDanhSach(xlSach.LayDanhSach());
        }
        private void HienThiDanhSach(List<Sach> ds)
        {
            xlSach.SelectionSortTheoMa();
            dgvListSach.DataSource = null;
            dgvListSach.DataSource = ds;
        }

        private void ClearInputFields()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTenTacGia.Clear();
            txtLoai.Clear();  
            txtMaSach.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maCanTim = txtMaSach.Text.Trim();

            if (string.IsNullOrEmpty(maCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sach kq = xlSach.LinearSearchTheoMa(maCanTim);

            if (kq != null)
            {
                txtTenSach.Text = kq.TenSach;
                txtTenTacGia.Text = kq.TacGia;
                txtLoai.Text = kq.TheLoai;
               
                dgvListSach.DataSource = null;
                dgvListSach.DataSource = new List<Sach> { kq };

                MessageBox.Show("Đã tìm thấy sách có mã: " + maCanTim, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã: " + maCanTim, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlSach.LayDanhSach());
            }
        }

        private void dgvListSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vitri = e.RowIndex;
                Sach s = new Sach();
                s = xlSach.DSSach[vitri];
                txtMaSach.Text = s.MaSach;
                txtTenSach.Text = s.TenSach;
                txtTenTacGia.Text = s.TacGia;
                txtLoai.Text = s.TheLoai;  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThiDanhSach(xlSach.LayDanhSach());
            ClearInputFields();
        }

        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn xóa sách?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                bool kqxoa = xlSach.XoaSach(txtMaSach.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach .Text;
            string tenSach = txtTenSach.Text;
            string tacGia = txtTenTacGia.Text;

            string theLoai = txtLoai.Text;

            Sach s = new Sach(maSach, tenSach, tacGia, "", theLoai, 1, 1900);
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

        
    }
}
