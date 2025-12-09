using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom17_QuanLyThuVien
{
    public partial class PhieuMuon : Form
    {
        private XuLySach xlSach = XuLySach.Instance;
        private XuLyThanhVien xlThanhVien = XuLyThanhVien.Instance;
        private CXuLyPhieuMuonTra xlMuonTra = CXuLyPhieuMuonTra.Instance;
        private bool isExit = false;
        public PhieuMuon()
        {
            InitializeComponent();
        }



        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            xlThanhVien.DocFile();
            xlSach.DocFile();
            xlMuonTra.DocFile();
            var dsSach = xlSach.LayDanhSach();
            cbbTV.DataSource = xlThanhVien.LayDanhSach();
            cbbTV.DisplayMember = "MaThanhVien";
            cbbTV.ValueMember = "MaThanhVien";
            cbbMaSach1.DataSource = dsSach.Select(s => s).ToList();
            cbbMaSach2.DataSource = dsSach.Select(s => s).ToList();
            cbbMaSach3.DataSource = dsSach.Select(s => s).ToList();

            cbbMaSach1.DisplayMember = cbbMaSach2.DisplayMember = cbbMaSach3.DisplayMember = "MaSach";
            cbbMaSach1.ValueMember = cbbMaSach2.ValueMember = cbbMaSach3.ValueMember = "MaSach";
            dpkNgayMuon.Value = DateTime.Today;
            dpkNgayTra.Value = dpkNgayMuon.Value.AddDays(7);
            cbbTV.SelectedIndex = -1;
            cbbMaSach1.SelectedIndex = -1;
            cbbMaSach2.SelectedIndex = -1;
            cbbMaSach3.SelectedIndex = -1;
            txtmaphieu.Text = xlMuonTra.TaoMaPhieuTuDong();
            HienThiDanhSach(xlMuonTra.LayDSM());
            ClearInputFields();
        }
        private void HienThiDanhSach(List<MuonTra> ds)
        {
            var dsHienThi = xlMuonTra.TaoDanhSachHienThi(ds);
            DaTaMuonTra.DataSource = dsHienThi;
        }
        private void ClearInputFields()
        {
            txtmaphieu.Text = xlMuonTra.TaoMaPhieuTuDong();
            cbbTV.SelectedIndex = -1;
            txttentv.Clear();
            txtsdt.Clear();
            dpkNgayMuon.Value = DateTime.Today;
            dpkNgayTra.Value = DateTime.Today.AddDays(7);
            txttongsl.Text = "0";
            txtgiahan.Text = "0";
            rbtnMuon.Checked = false;
            rbtnTra.Checked = false;
            ClearControlsSachDetail();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            string maTV = cbbTV.Text;
            string maPhieu = txtmaphieu.Text;
            if (string.IsNullOrWhiteSpace(maTV) || xlThanhVien.TimTV(maTV) == null)
            {
                MessageBox.Show("Vui lòng chọn Mã Thành Viên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ChiTietSachMuon> chiTietList = new List<ChiTietSachMuon>();

            GetChiTiet(cbbMaSach1, num1, chiTietList, maPhieu);
            GetChiTiet(cbbMaSach2, num2, chiTietList, maPhieu);
            GetChiTiet(cbbMaSach3, num3, chiTietList, maPhieu);
            int tongSLMuon = int.Parse(txttongsl.Text);
            if (chiTietList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 cuốn sách để mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MuonTra Phieumoi = new MuonTra
            {
                MaPhieu = maPhieu,
                MaTV = maTV,
                NgayMuon = dpkNgayMuon.Value.Date,
                NgayTraDuKien = dpkNgayTra.Value.Date,
                TongSoLuongMuon = tongSLMuon,
                SoLanGiaHan = 0,
                TrangThai = MuonTra.TrangThaiPhieu.ChuaTra,
                DanhSachChiTiet = chiTietList
            };
            if (xlMuonTra.ThemPhieuMuon(Phieumoi))
            {
                MessageBox.Show("Mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(xlMuonTra.LayDSM());
                
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string maPhieuCanSua = txtmaphieu.Text;
            if (string.IsNullOrWhiteSpace(maPhieuCanSua) || xlMuonTra.TimPhieuMuonTraTheoMa(maPhieuCanSua) == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần sửa từ danh sách.", "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbbTV.Text) || xlThanhVien.TimTV(cbbTV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn Mã Thành Viên hợp lệ.", "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ChiTietSachMuon> chiTietListMoi = new List<ChiTietSachMuon>();
            GetChiTiet(cbbMaSach1, num1, chiTietListMoi, maPhieuCanSua);
            GetChiTiet(cbbMaSach2, num2, chiTietListMoi, maPhieuCanSua);
            GetChiTiet(cbbMaSach3, num3, chiTietListMoi, maPhieuCanSua);

            int tongSLMoi = int.Parse(txttongsl.Text);

            if (chiTietListMoi.Count == 0)
            {
                MessageBox.Show("Phiếu phải có ít nhất 1 cuốn sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MuonTra duLieuMoi = new MuonTra
            {
                MaPhieu = maPhieuCanSua,
                MaTV = cbbTV.Text,
                NgayMuon = dpkNgayMuon.Value.Date,
                NgayTraDuKien = dpkNgayTra.Value.Date,
                TongSoLuongMuon = tongSLMoi,
                SoLanGiaHan = int.Parse(txtgiahan.Text),
                TrangThai = MuonTra.TrangThaiPhieu.ChuaTra,
                DanhSachChiTiet = chiTietListMoi
            };
            if (xlMuonTra.SuaPhieuMuon(maPhieuCanSua, duLieuMoi))
            {
                HienThiDanhSach(xlMuonTra.LayDSM());
            }
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            string giatriCanTim = txttimmp.Text.Trim();
            if (string.IsNullOrEmpty(giatriCanTim))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm vào ô tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MuonTra phieuGoc = xlMuonTra.TimPhieuMuonTraTheoMa(giatriCanTim);
            if (phieuGoc != null)
            {
                LoadPhieuDetails(phieuGoc);
                List<MuonTra> dsPhieuTimDuoc = new List<MuonTra> { phieuGoc };
                List<HienThiDSMuonTra> dsHienThi = xlMuonTra.TaoDanhSachHienThi(dsPhieuTimDuoc);
                HienThiDanhSach(dsPhieuTimDuoc);
                txttimmp.Clear();
                return;
            }
            string matv= xlThanhVien.TimMaTheoTen(giatriCanTim);
            if (!string.IsNullOrEmpty(matv))
            {

                var dsPhieuChuaTra = xlMuonTra.LayDSM().Where(p => p.MaTV == matv && p.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra).ToList();

                if (dsPhieuChuaTra.Any())
                {
                    HienThiDanhSach(dsPhieuChuaTra);
                    ClearInputFields();
                    MessageBox.Show($"Danh sách các cuốn sách {giatriCanTim} đang mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Thành viên {giatriCanTim} không có cuốn sách nào đang mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(new List<MuonTra>());
                }
                return;
            }

            MessageBox.Show($"Không tìm thấy phiếu mượn có mã: {giatriCanTim} hoặc thành viên có tên tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
            HienThiDanhSach(xlMuonTra.LayDSM());

        }
        private void LoadPhieuDetails(MuonTra phieu)
        {
            txtmaphieu.Text = phieu.MaPhieu;
            cbbTV.Text = phieu.MaTV;
            cbbTV_SelectedIndexChanged(cbbTV, EventArgs.Empty);
            dpkNgayMuon.Value = phieu.NgayMuon;
            dpkNgayTra.Value = phieu.NgayTraDuKien;
            txtgiahan.Text = phieu.SoLanGiaHan.ToString();
            txttongsl.Text = phieu.TongSoLuongMuon.ToString();
            if (phieu.TrangThai == MuonTra.TrangThaiPhieu.DaTra)
            {
                rbtnTra.Checked = true;
                rbtnMuon.Checked = false;
            }
            else
            {
                rbtnTra.Checked = false;
                rbtnMuon.Checked = true;
            }
            ClearControlsSachDetail();
            var chiTiet1 = phieu.DanhSachChiTiet.ElementAtOrDefault(0);
            if (chiTiet1 != null)
            {
                cbbMaSach1.SelectedIndexChanged -= cbbMaSach1_SelectedIndexChanged;

                cbbMaSach1.Text = chiTiet1.MaSach;
                cbbMaSach1_SelectedIndexChanged(cbbMaSach1, EventArgs.Empty);
                cbbMaSach1.SelectedIndexChanged += cbbMaSach1_SelectedIndexChanged;
                num1.Value = chiTiet1.SlMuon;
            }

            var chiTiet2 = phieu.DanhSachChiTiet.ElementAtOrDefault(1);
            if (chiTiet2 != null)
            {
                cbbMaSach2.SelectedIndexChanged -= cbbMaSach2_SelectedIndexChanged;
                cbbMaSach2.Text = chiTiet2.MaSach;
                cbbMaSach2_SelectedIndexChanged(cbbMaSach2, EventArgs.Empty);
                
                cbbMaSach2.SelectedIndexChanged += cbbMaSach2_SelectedIndexChanged;
                num2.Value = chiTiet2.SlMuon;
            }

            var chiTiet3 = phieu.DanhSachChiTiet.ElementAtOrDefault(2);
            if (chiTiet3 != null)
            {
                cbbMaSach3.SelectedIndexChanged -= cbbMaSach3_SelectedIndexChanged;
                cbbMaSach3.Text = chiTiet3.MaSach;
                cbbMaSach3_SelectedIndexChanged(cbbMaSach3, EventArgs.Empty);
                
                cbbMaSach3.SelectedIndexChanged += cbbMaSach3_SelectedIndexChanged;
                num3.Value = chiTiet3.SlMuon;
            }
            bool isChuaTra = (phieu.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra);

            Sua.Enabled = isChuaTra;
            btnGiaHan.Enabled = isChuaTra;
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                isExit = true;
                this.Close();
                new MainThuVien().Show();
            }
        }
        private void ClearControlsSachDetail()
        {
            cbbMaSach1.SelectedIndex = -1;
            num1.Value = 0;
            txtten1.Clear();
            txtsl1.Clear();
            cbbMaSach2.SelectedIndex = -1;
            num2.Value = 0;
            txtten2.Clear();
            txtsl2.Clear();
            cbbMaSach3.SelectedIndex = -1;
            num3.Value = 0;
            txtten3.Clear();
            txtsl3.Clear();
        }
        private void FillSachDetail(List<ChiTietSachMuon> ds) {
            
            cbbMaSach1.SelectedIndexChanged -= cbbMaSach1_SelectedIndexChanged;
            cbbMaSach2.SelectedIndexChanged -= cbbMaSach2_SelectedIndexChanged;
            cbbMaSach3.SelectedIndexChanged -= cbbMaSach3_SelectedIndexChanged;

            var ct1 = ds.ElementAtOrDefault(0);
            var ct2 = ds.ElementAtOrDefault(1);
            var ct3 = ds.ElementAtOrDefault(2);

            if (ct1 != null)
            {
                cbbMaSach1.SelectedValue = ct1.MaSach;
                num1.Value = ct1.SlMuon;
            }
            else
            {
                cbbMaSach1.SelectedIndex = -1;
                num1.Value = 0;
            }

            if (ct2 != null)
            {
                cbbMaSach2.SelectedValue = ct2.MaSach;
                num2.Value = ct2.SlMuon;
            }
            else
            {
                cbbMaSach2.SelectedIndex = -1;
                num2.Value = 0;
            }

            if (ct3 != null)
            {
                cbbMaSach3.SelectedValue = ct3.MaSach;
                num3.Value = ct3.SlMuon;
            }
            else
            {
                cbbMaSach3.SelectedIndex = -1;
                num3.Value = 0;
            }

            cbbMaSach1.SelectedIndexChanged += cbbMaSach1_SelectedIndexChanged;
            cbbMaSach2.SelectedIndexChanged += cbbMaSach2_SelectedIndexChanged;
            cbbMaSach3.SelectedIndexChanged += cbbMaSach3_SelectedIndexChanged;

            cbbMaSach1_SelectedIndexChanged(cbbMaSach1, EventArgs.Empty);
            cbbMaSach2_SelectedIndexChanged(cbbMaSach2, EventArgs.Empty);
            cbbMaSach3_SelectedIndexChanged(cbbMaSach3, EventArgs.Empty);
        }

        private void DaTaMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DaTaMuonTra.Rows.Count)
                return;

            var item = DaTaMuonTra.Rows[e.RowIndex].DataBoundItem as HienThiDSMuonTra;
            if (item == null) return;

            var phieuGoc = xlMuonTra.TimPhieuMuonTraTheoMa(item.MaPhieu);
            if (phieuGoc == null) return;

            txtmaphieu.Text = phieuGoc.MaPhieu;

            try
            {
                cbbTV.SelectedValue = phieuGoc.MaTV;
            }
            catch
            {
                cbbTV.Text = phieuGoc.MaTV;
            }

            var tv = xlThanhVien.TimTV(phieuGoc.MaTV);
            if (tv != null)
            {
                txttentv.Text = tv.TenThanhVien;
                txtsdt.Text = tv.SDT;
            }
            else
            {
                txttentv.Clear();
                txtsdt.Clear();
            }

            dpkNgayMuon.Value = phieuGoc.NgayMuon;
            dpkNgayTra.Value = phieuGoc.NgayTraDuKien;

            txtgiahan.Text = phieuGoc.SoLanGiaHan.ToString();
            txttongsl.Text = phieuGoc.TongSoLuongMuon.ToString();

            if (phieuGoc.TrangThai == MuonTra.TrangThaiPhieu.DaTra)
            {
                rbtnTra.Checked = true;
                rbtnMuon.Checked = false;
            }
            else
            {
                rbtnTra.Checked = false;
                rbtnMuon.Checked = true;
            }

            FillSachDetail(phieuGoc.DanhSachChiTiet);
            bool isChuaTra = (phieuGoc.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra);
            Sua.Enabled = isChuaTra;
            btnGiaHan.Enabled = isChuaTra;
            btnMuon.Enabled = isChuaTra;
        }
        private void GetChiTiet(ComboBox cbbMaSach, NumericUpDown nudSLMuon, List<ChiTietSachMuon> chiTietList, string maPhieu)
        {
            int sl = (int)nudSLMuon.Value;
            string maS = cbbMaSach.Text;

            if (!string.IsNullOrWhiteSpace(maS) && sl > 0)
            {
                Sach sachChon = xlSach.TimSach(maS);
                
                if (sachChon != null)
                {
                    ChiTietSachMuon ct = new ChiTietSachMuon(maPhieu, maS, sachChon.TenSach, sachChon.TacGia, sl);
                    chiTietList.Add(ct);
                }
                else
                {
                    MessageBox.Show($"Mã sách '{maS}' không hợp lệ hoặc không tồn tại.", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dpkNgayTra_ValueChanged(object sender, EventArgs e)
        {
            dpkNgayTra.Value = dpkNgayMuon.Value.AddDays(7);
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            HienThiDanhSach(xlMuonTra.LayDSM());
            ClearInputFields();
            btnMuon.Enabled = true;
        }

        private void cbbMaSach1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSach1.SelectedItem is Sach sach)
            {
                txtten1.Text = sach.TenSach;
                txtsl1.Text = sach.SoLuongCon.ToString();
            }
            else
            {
                txtten1.Clear();
                txtsl1.Clear();
            }
        }

        private void cbbTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTV.SelectedItem is ThanhVien tv)
            {
                txttentv.Text = tv.TenThanhVien;
                txtsdt.Text = tv.SDT;
            }
        }

        private void cbbMaSach2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSach2.SelectedItem is Sach sach)
            {
                txtten2.Text = sach.TenSach;
                txtsl2.Text = sach.SoLuongCon.ToString();
            }
            else
            {
                txtten2.Clear();
                txtsl2.Clear();
            }
        }

        private void cbbMaSach3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSach3.SelectedItem is Sach sach)
            {
                txtten3.Text = sach.TenSach;
                txtsl3.Text = sach.SoLuongCon.ToString();
            }
            else
            {
                txtten3.Clear();
                txtsl3.Clear();
            }
        }
        private void num_ValueChanged(object sender, EventArgs e)
        {
            int tongSL = (int)num1.Value + (int)num2.Value + (int)num3.Value;
            txttongsl.Text = tongSL.ToString();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            string maPhieu = txtmaphieu.Text;

            if (string.IsNullOrWhiteSpace(maPhieu))
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để gia hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xlMuonTra.GiaHanPhieu(maPhieu))
            {
                MuonTra phieuDaSua = xlMuonTra.TimPhieuMuonTraTheoMa(maPhieu);
                if (phieuDaSua != null)
                {
                    txtgiahan.Text = phieuDaSua.SoLanGiaHan.ToString();
                    dpkNgayTra.Value = phieuDaSua.NgayTraDuKien;
                }

                HienThiDanhSach(xlMuonTra.LayDSM());
            }
        }

        private void btnthoattra_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                isExit = true;
                this.Close();
                new MainThuVien().Show();
            }
        }
        private void HienThiDSPhieuChuaTra()
        {
            var dsDangMuon = xlMuonTra.LayDSM().Where(p => p.TrangThai == MuonTra.TrangThaiPhieu.ChuaTra).ToList();
            
            var dsHienThi= xlMuonTra.TaoDanhSachHienThi(dsDangMuon);

            dgvTraSach.DataSource = dsHienThi;
        }
        private void ClearControlsTraSach()
        {
            txtmptra.Clear();
            txtmatvtra.Clear();
            txttentvtra.Clear();
            txtsdttra.Clear();
            txttongsltra.Clear();
            txtslghtra.Clear();
            txtmpt.Clear();
            dtpngaymuon.Value = DateTime.Today;
            dtpngaytra.Value = DateTime.Today;
            ClearSachDetailTraSach();
        }
        private void ClearSachDetailTraSach()
        {
            txtMaSach1tra.Clear();
            txtTenSach1tra.Clear();
            txtsl1tra.Clear();

            txtMaSach2tra.Clear();
            txtTenSach2tra.Clear();
            txtsl2tra.Clear();

            txtMaSach3tra.Clear();
            txtTenSach3tra.Clear();
            txtsl3tra.Clear();
        }
        private void FillSachDetailTraSach(List<ChiTietSachMuon> chiTietList)
        {
            ClearSachDetailTraSach();
            if (chiTietList == null || chiTietList.Count == 0)
            {
                return;
            }

            if (chiTietList.Count >= 1)
            {
                var sach1 = chiTietList[0];
                txtMaSach1tra.Text = sach1.MaSach;
                txtTenSach1tra.Text = sach1.TenSach;
                txtsl1tra.Text = sach1.SlMuon.ToString();
            }

            if (chiTietList.Count >= 2)
            {
                var sach2 = chiTietList[1];
                txtMaSach2tra.Text = sach2.MaSach;
                txtTenSach2tra.Text = sach2.TenSach;
                txtsl2tra.Text = sach2.SlMuon.ToString();
            }

            if (chiTietList.Count >= 3)
            {
                var sach3 = chiTietList[2];
                txtMaSach3tra.Text = sach3.MaSach;
                txtTenSach3tra.Text = sach3.TenSach;
                txtsl3tra.Text = sach3.SlMuon.ToString();
            }
        }
        private void LoadPhieuDetailsTraSach(MuonTra phieu)
        {
            txtmatvtra.Text = phieu.MaTV;
            txtmpt.Text = phieu.MaPhieu;
            var tv = xlThanhVien.TimTV(phieu.MaTV);
            if (tv != null)
            {
                txttentvtra.Text = tv.TenThanhVien;
                txtsdttra.Text = tv.SDT;
            }
            else
            {
                txttentvtra.Text = "";
                txtsdttra.Text = "";
            }
            txttongsltra.Text = phieu.TongSoLuongMuon.ToString();
            dtpngaymuon.Value = phieu.NgayMuon;
            dtpngaytra.Value = phieu.NgayTraDuKien;
            txtslghtra.Text = phieu.SoLanGiaHan.ToString();
            FillSachDetailTraSach(phieu.DanhSachChiTiet);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Quản lý Trả Sách")
            {
                HienThiDSPhieuChuaTra();
                ClearControlsTraSach();
            }
            else if (tabControl1.SelectedTab.Text == "Quản lý Mượn Sách")
            {
                HienThiDanhSach(xlMuonTra.LayDSM());
                ClearInputFields();
            }
        }

        private void btntimtra_Click(object sender, EventArgs e)
        {
            string maPhieuCanTim = txtmptra.Text.Trim();
            MuonTra phieuTimThay = xlMuonTra.TimPhieuMuonTraTheoMa(maPhieuCanTim);
            if (phieuTimThay != null)
            {
                List<MuonTra> dsKetQua = new List<MuonTra> { phieuTimThay };
                dgvTraSach.DataSource = xlMuonTra.TaoDanhSachHienThi(dsKetQua);
                LoadPhieuDetailsTraSach(phieuTimThay);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy phiếu mượn có mã: {maPhieuCanTim}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControlsTraSach();
                HienThiDSPhieuChuaTra();
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            string maPhieu = txtmpt.Text;

            if (string.IsNullOrWhiteSpace(maPhieu))
            {
                MessageBox.Show("Vui lòng tìm kiếm phiếu cần trả trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult kq = MessageBox.Show($"Bạn có chắc chắn muốn trả sách cho phiếu {maPhieu}?", "Xác Nhận Trả Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                if (xlMuonTra.TraSach(maPhieu))
                {
                    HienThiDSPhieuChuaTra();
                    ClearControlsTraSach();
                }
            }
        }

        private void dgvTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvTraSach.Rows.Count)
                return;
            var itemClicked = dgvTraSach.Rows[e.RowIndex].DataBoundItem as HienThiDSMuonTra;

            if (itemClicked == null) return;

            string maPhieu = itemClicked.MaPhieu;

            MuonTra phieuGoc = xlMuonTra.TimPhieuMuonTraTheoMa(maPhieu);

            if (phieuGoc != null)
            {
                LoadPhieuDetailsTraSach(phieuGoc);
            }
        }

        private void btnbacktra_Click(object sender, EventArgs e)
        {
            ClearControlsTraSach();
            HienThiDSPhieuChuaTra();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string maPhieuIn = txtmaphieu.Text.Trim();
            MuonTra phieuIn = xlMuonTra.TimPhieuMuonTraTheoMa(maPhieuIn);
            if(phieuIn.TrangThai == MuonTra.TrangThaiPhieu.DaTra)
            {
                MessageBox.Show("Phiếu mượn đã trả không thể in.", "Lỗi In Ấn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dtThongTin = new DataTable();
            dtThongTin.Columns.Add("MaPhieu", typeof(string));
            dtThongTin.Columns.Add("MaTV", typeof(string));
            dtThongTin.Columns.Add("TenTV", typeof(string));
            dtThongTin.Columns.Add("SDT", typeof(string));
            dtThongTin.Columns.Add("NgayMuon", typeof(DateTime));
            dtThongTin.Columns.Add("NgayTra", typeof(DateTime));
            dtThongTin.Columns.Add("SoLuongMuon", typeof(int));



            DataRow r = dtThongTin.NewRow();
            r["MaPhieu"] = txtmaphieu.Text;
            r["MaTV"] = cbbTV.SelectedValue?.ToString() ?? cbbTV.Text.Trim();
            r["TenTV"] = txttentv.Text;
            r["SDT"] = txtsdt.Text;
            r["NgayMuon"] = dpkNgayMuon.Value;
            r["NgayTra"] = dpkNgayTra.Value;
            r["SoLuongMuon"] = int.Parse(txttongsl.Text);


            dtThongTin.Rows.Add(r);

            DataTable dtDanhSach;

            if (DaTaMuonTra.DataSource is DataTable)
            {
                dtDanhSach = ((DataTable)DaTaMuonTra.DataSource).Copy();
            }
            else
            {
                var bs = DaTaMuonTra.DataSource as BindingSource;
                if (bs != null && bs.DataSource is DataTable)
                {
                    dtDanhSach = ((DataTable)bs.DataSource).Copy();
                }
                else
                {
                    dtDanhSach = new DataTable();
                    dtDanhSach.Columns.Add("MaSach", typeof(string));
                    dtDanhSach.Columns.Add("TenSach", typeof(string));
                    dtDanhSach.Columns.Add("SoLuong", typeof(int));

                    string maPhieuDangIn = txtmaphieu.Text.Trim();
                    foreach (DataGridViewRow row in DaTaMuonTra.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string maPhieuRow = row.Cells[0].Value?.ToString();

                        if (maPhieuRow != maPhieuDangIn)
                            continue;
                        var dr = dtDanhSach.NewRow();
                        dr["MaSach"] = row.Cells[4].Value?.ToString() ?? "";
                        dr["TenSach"] = row.Cells[5].Value?.ToString() ?? "";
                        int soLuong = 0;
                        Int32.TryParse(row.Cells[6].Value?.ToString(), out soLuong);
                        dr["SoLuong"] = soLuong;
                        dtDanhSach.Rows.Add(dr);
                    }
                }
            }

            PhieuIn frm = new PhieuIn();
            frm.dtThongTin = dtThongTin;
            frm.dtDanhSach = dtDanhSach;
            frm.ShowDialog();
            ClearInputFields();
        }

        private void PhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit) return;
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                new MainThuVien().Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
