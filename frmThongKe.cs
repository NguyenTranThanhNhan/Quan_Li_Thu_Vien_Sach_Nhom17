using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom17_QuanLyThuVien
{
    public partial class frmThongKe : Form
    {
        private XuLyThongKe xlThongKe = XuLyThongKe.Instance;
        private XuLySach xlSach = XuLySach.Instance;
        private XuLyThanhVien xlThanhVien = XuLyThanhVien.Instance;
        private CXuLyPhieuMuonTra xlMuonTra = CXuLyPhieuMuonTra.Instance;
        public frmThongKe()
        {
            InitializeComponent();
        }
        private void HienThiThongKe(string loaiThoiGian)
        {
            // 1. Thực hiện thống kê
            List<ThongKe> duLieuHienThi = xlThongKe.ThongKeTheoLoai(loaiThoiGian);


            dgvThongKe.DataSource = null;
            dgvThongKe.DataSource = duLieuHienThi;


            if (dgvThongKe.Columns.Count > 0)
            {
                dgvThongKe.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                dgvThongKe.Columns["TenTV"].HeaderText = "Thành Viên Mượn";
                dgvThongKe.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                dgvThongKe.Columns["MaSach"].HeaderText = "Mã Sách";
                dgvThongKe.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvThongKe.Columns["TacGia"].HeaderText = "Tác Giả";
                dgvThongKe.Columns["SoluongMuon"].HeaderText = "SL Mượn";
                dgvThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvThongKe.Columns["NgayMuon"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            xlThanhVien.DocFile();
            xlSach.DocFile();
            xlMuonTra.DocFile();
            List<MuonTra> danhSachPhieuMuon = xlMuonTra.LayDSM();
            xlThongKe = new XuLyThongKe(danhSachPhieuMuon);

            cbbThongKe.Items.AddRange(new object[] { "--- Tất cả ---", "Ngày", "Tuần", "Tháng", "Năm" });
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
