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
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
