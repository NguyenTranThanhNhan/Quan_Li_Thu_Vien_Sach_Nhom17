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
        private XuLyThanhVien xlThanhVien = new XuLyThanhVien();

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
            new PhieuMuon().Show();
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            new PhieuMuon().Show();
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
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKe().Show();
        }
        private void MainThuVien_Load(object sender, EventArgs e)
        {
            xlSach.DocFile();
            xlThanhVien.DocFile();
            HienThiDanhSachThanhVien(xlThanhVien.LayDanhSachThanhVien());
            
        }
        private void HienThiDanhSach(List<Sach> ds)
        {
            xlSach.SelectionSortTheoMa();
            dgvDST.DataSource = null;
            dgvDST.DataSource = ds;
        }




        private void HienThiDanhSachThanhVien(List<ThanhVien> ds)
        {
            xlThanhVien.LayDanhSachThanhVien();
            dgvDST.DataSource = null;
            dgvDST.DataSource = ds;
        }

        private void ClearInputFields()
        {
            txtMaTv.Clear();
            txtTenTV.Clear();
            txtSDT.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mak=txtSDT.Text.Trim();
            string maCanTim = txtMaTv.Text.Trim();

            if (string.IsNullOrEmpty(maCanTim))
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThanhVien kq = xlThanhVien.LinearSearchTheoMa(maCanTim);

            if (kq != null)
            {
                txtSDT.Text = kq.SDT;
                txtMaTv.Text = kq.MaThanhVien;
                txtTenTV.Text = kq.TenThanhVien;
               
                dgvDST.DataSource = null;
                dgvDST.DataSource = new List<ThanhVien> { kq };

                MessageBox.Show("Đã tìm thấy sách có mã: " + maCanTim, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã: " + maCanTim, "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachThanhVien(xlThanhVien.LayDanhSach());
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
                bool kqxoa = xlSach.XoaSach(txtMaTv.Text);
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
            string ma = txtMaTv .Text;
            string ten = txtTenTV.Text;
            int sdt = int.Parse(txtSDT.Text);




            ThanhVien tv = new ThanhVien(ma, ten," ","", DateTime.Today, DateTime.Today, "", "");
            bool kqsua = xlThanhVien.SuaTV(tv);
            if (kqsua == true)
            {
                MessageBox.Show("Sửa Thành Viên  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachThanhVien( xlThanhVien.LayDanhSach());
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vitri = e.RowIndex;
                Sach s = new Sach();
                ThanhVien tv = new ThanhVien();
                s = xlSach.DSSach[vitri];
                tv = xlThanhVien.DSThanhVien[vitri];
                txtMaTv.Text = tv.MaThanhVien;
                txtTenTV.Text = tv.TenThanhVien;
                txtSDT.Text = tv.SDT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
