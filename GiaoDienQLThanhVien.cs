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
    public partial class GiaoDienQLThanhVien : Form
    {
        public GiaoDienQLThanhVien()
        {
            InitializeComponent();
        }
        private XuLyThanhVien xlThanhVien = XuLyThanhVien.Instance;
        private int vitri = -1;

        private void GiaoDienQLThanhVien_Load(object sender, EventArgs e)
        {
            xlThanhVien.DocFile();
            HienThiDSThanhVien(xlThanhVien.LayDanhSach());
            MaTV.Text = xlThanhVien.TaoMaThanhVien();
        }
        private void ClearInputFields()
        {
            MaTV.Text = xlThanhVien.TaoMaThanhVien();
            TenTV.Clear();
            SDTTV.Clear();
            txtEmail.Clear();
            NgaySinh.Value = DateTime.Today;
            NgayDangKy.Value = DateTime.Today;
            CanYeuCau.Clear();
            
            MaTV.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void GiaoDienQLThanhVien_Shown(object sender, EventArgs e)
        {
            MaTV.Focus();
        }

        private void HienThiDSThanhVien(List<ThanhVien> tv)
        {
            xlThanhVien.SelectionSortTheoMa();
            DaTaThanhVien.DataSource = tv;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            string maTV = MaTV.Text;
            string tenTV = TenTV.Text;
            string sdt = SDTTV.Text;
            string email = txtEmail.Text;
            DateTime ngaysinh = NgaySinh.Value;
            DateTime ngaydk = NgayDangKy.Value;
            string yeucau = CanYeuCau.Text;
            string Phai = "";
            if (Nam.Checked)
                Phai = "Nam";
            else
                Phai = "Nữ";

            int tuoi=DateTime.Today.Year - ngaysinh.Year;
            if(DateTime.Today < ngaysinh.AddYears(tuoi))
            {
                tuoi--;
            }

            if(tuoi < 16)
            {
                MessageBox.Show("tuoi khong hop de doc sach ");
                return;
            }

            if(string.IsNullOrEmpty(maTV) || string.IsNullOrEmpty(tenTV) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(sdt, @"^[0-9]{9,11}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập từ 9 đến 11 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!xlThanhVien.KiemTraEmail(email))
            {
                return;
            }
            ThanhVien tv = new ThanhVien(maTV, tenTV, sdt, email, ngaysinh, ngaydk, yeucau, Phai);
            bool them = xlThanhVien.ThemTV(tv);
            if (them == true)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDSThanhVien(xlThanhVien.DSThanhVien);
                ClearInputFields();
            }
            else
                MessageBox.Show("Thêm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa !?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    bool xoa = xlThanhVien.XoaTV(MaTV.Text);
            if (xoa == true)
            {

                MessageBox.Show("Đã xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDSThanhVien(xlThanhVien.DSThanhVien);
                ClearInputFields();
            }
            else
                    MessageBox.Show("Chưa xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string maTV = MaTV.Text;
            string tenTV = TenTV.Text;
            string sdt = SDTTV.Text;
            string email = txtEmail.Text;
            DateTime ngaysinh = NgaySinh.Value;
            DateTime ngaydk = NgayDangKy.Value;
            string yeucau = CanYeuCau.Text;
            string Phai = "";
            if (Nam.Checked)
                Phai = "Nam";
            else
                Phai = "Nữ";
            ThanhVien tv = new ThanhVien(maTV, tenTV, sdt, email, ngaysinh, ngaydk, yeucau, Phai);

            bool kq = xlThanhVien.SuaTV(tv);
                if(kq)
            {
                MessageBox.Show("Sửa thành công !");
                HienThiDSThanhVien(xlThanhVien.LayDanhSach());
                ClearInputFields();
            }
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            string Tim = txttvtim.Text;

            if (string.IsNullOrEmpty(Tim))
            {
                MessageBox.Show("Vui lòng nhập mã thành viên để tìm kiếm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThanhVien kq = xlThanhVien.LinearSearchTheoMa(Tim);

            if (kq != null)
            {
                MaTV.Text = kq.MaThanhVien;
                TenTV.Text = kq.TenThanhVien;
                SDTTV.Text = kq.SDT.ToString();
                txtEmail.Text = kq.Email;
                NgaySinh.Value = kq.NgayThangNamSinh;
                NgayDangKy.Value = kq.NgayDangKy;
                DaTaThanhVien.DataSource = null;
                DaTaThanhVien.DataSource = new List<ThanhVien> { kq };

                MessageBox.Show("Đã tìm thấy : " + Tim, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy : " + Tim, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDSThanhVien(xlThanhVien.LayDanhSach());
                
            }
        }
        private void DaTaThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }
            vitri = e.RowIndex;
            ThanhVien tv = xlThanhVien.LayDanhSach()[vitri];

            MaTV.Text = tv.MaThanhVien;
            TenTV.Text = tv.TenThanhVien;
            SDTTV.Text = tv.SDT.ToString();
            txtEmail.Text = tv.Email;
            NgaySinh.Value = tv.NgayThangNamSinh;
            NgayDangKy.Value = tv.NgayDangKy;
            CanYeuCau.Text = tv.YeuCau;
            string Phai = tv.Phai;
            if (Phai.Equals("Nam"))
                Nam.Checked = true;
            else
                Nu.Checked = true;
        }
        private void btnquaylai_Click(object sender, EventArgs e)
        {
             HienThiDSThanhVien(xlThanhVien.LayDanhSach());
             ClearInputFields();
            
        }
        

        private void SDTTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       



        //private void btnMuon_Click(object sender, EventArgs e)
        //{
        //    DialogResult kq = MessageBox.Show("Bạn có muốn mượn sách !?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (kq == DialogResult.Yes)
        //    {
        //       string maTV = MaTV.Text;
        //        string sdt =SDTTV.Text;

        //        PhieuMuon pm = new PhieuMuon(maTV,sdt);
        //        pm.Show();
        //        this.Hide();

        //    }
        //}
    }
}
