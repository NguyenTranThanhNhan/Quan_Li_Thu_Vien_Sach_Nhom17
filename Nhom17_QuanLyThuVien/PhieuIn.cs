using Microsoft.Reporting.WinForms;
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
    public partial class PhieuIn : Form
    {
        public DataTable dtThongTin { get; set; }
        public DataTable dtDanhSach { get; set; }
        public PhieuIn()
        {
            InitializeComponent();
        }

        private void PhieuIn_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "Reports\\PhieuMuon.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            var rds1 = new ReportDataSource("ThongTinPhieu", dtThongTin);
            var rds2 = new ReportDataSource("DanhSachMuon", dtDanhSach);

            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds2);

            this.reportViewer1.RefreshReport();
        }
    }
}

