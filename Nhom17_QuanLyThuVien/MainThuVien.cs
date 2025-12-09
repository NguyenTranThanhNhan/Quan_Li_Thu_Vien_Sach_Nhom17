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
        private XuLyThongKe xlThongKe = XuLyThongKe.Instance;
        private XuLySach xlSach = XuLySach.Instance;
        private XuLyThanhVien xlThanhVien = XuLyThanhVien.Instance;
        private CXuLyPhieuMuonTra xlMuonTra = CXuLyPhieuMuonTra.Instance;

        //private int vitri = -1;
        public event EventHandler LogOut;
        public MainThuVien()
        {
            InitializeComponent();
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
        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhieuMuon().Show();
            this.isExit = false;
            this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GiaoDienQLThanhVien().Show();
            this.isExit = false;
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GiaoDienSach().Show();
            this.isExit = false;
            this.Close();
        }



        private void HienThiThongKe(string loaiThoiGian)
        {

            List<ThongKe> duLieuHienThi = xlThongKe.ThongKeTheoLoai(loaiThoiGian);
            dgvThongKe.DataSource = null;
            dgvThongKe.DataSource = duLieuHienThi;
            if (dgvThongKe.Columns.Count > 0)
            {
                dgvThongKe.Columns["NgayTra"].HeaderText = "Ngày Trả";
                dgvThongKe.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                dgvThongKe.Columns["TenTV"].HeaderText = "Thành Viên Mượn";
                dgvThongKe.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                dgvThongKe.Columns["MaSach"].HeaderText = "Mã Sách";
                dgvThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvThongKe.Columns["TacGia"].HeaderText = "Tác Giả";
                dgvThongKe.Columns["SoluongMuon"].HeaderText = "SL Mượn";
                dgvThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvThongKe.Columns["NgayMuon"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvThongKe.Columns["NgayTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private void MainThuVien_Load(object sender, EventArgs e)
        {
            xlThanhVien.DocFile();
            xlSach.DocFile();
            xlMuonTra.DocFile();
            List<MuonTra> danhSachPhieuMuon = xlMuonTra.LayDSM();
            xlThongKe = new XuLyThongKe(danhSachPhieuMuon);

            cbbThongKe.Items.AddRange(new object[] { "--- Tất cả ---", "Ngày", "Tuần", "Tháng", "Năm", "Quá Hạn", "Đến Hạn Hôm Nay" });
            cbbThongKe.SelectedIndex = 0;

            // Thống kê mặc định khi load form (ví dụ: Tất cả)
            HienThiThongKe("--- Tất cả ---");

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbbThongKe.SelectedItem != null)
            {
                string loaiThoiGian = cbbThongKe.SelectedItem.ToString();
                HienThiThongKe(loaiThoiGian);
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

       
    }
}
