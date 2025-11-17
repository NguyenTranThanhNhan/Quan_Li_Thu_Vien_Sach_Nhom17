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
    public partial class Muon_Tra : Form
    {
        private XuLyMuonTra xl = new XuLyMuonTra();
        private void HienThi(List<MuonTra> dsMT)
        {
            DaTaMuonTra.DataSource = null;
            DaTaMuonTra.DataSource = dsMT;
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Muon_Tra_Load(object sender, EventArgs e)
        {
            xl.DocFile();
            HienThi(xl.LayDSM());
        }
        private void Muon_Tra_Shown(object sender, EventArgs e)
        {
            txtMaSach.Focus();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPT.Text.Trim();
            string maND = txtTV.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            string soluong = txtSoLuong.Text.Trim();
            DateTime ngayMuon = dpkNgayMuon.Value;
            DateTime ngayTra = dpkNgayTra.Value;

            string err;
            bool kq = xl.ThemMuonTra(maPM, maND, maSach, soluong, ngayMuon, ngayTra, out err);

            if (kq)
            {
                MessageBox.Show("Mượn sách thành công!");
                HienThi(xl.LayDSM());
            }
            else
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            string err;

            if (xl.TraSach(txtMaPT.Text, out err))
            {
                MessageBox.Show("Trả sách thành công!");
                HienThi(xl.LayDSM());
            }
            else
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {

        }

        private void Tim_Click(object sender, EventArgs e)
        {

        }
    }
}
