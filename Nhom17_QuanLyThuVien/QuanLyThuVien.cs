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
    public partial class QuanLyThuVien : Form
    {
        public QuanLyThuVien()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
             private void Sach_Click(object sender, EventArgs e)
        {
            GiaoDienSach s = new GiaoDienSach();
            s.Show();
        }

        private void ThanhVien_Click(object sender, EventArgs e)
        {
            GiaoDienQLThanhVien tv = new GiaoDienQLThanhVien();
            tv.Show();
        }

        private void MuonTra_Click(object sender, EventArgs e)
        {
            Muon_Tra mt =new Muon_Tra();
            mt.Show();
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
