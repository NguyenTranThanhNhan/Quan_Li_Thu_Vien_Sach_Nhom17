using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    public class HienThiDSMuonTra
    {
        public string MaPhieu { get; set; }
        public string MaTV { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTraDuKien { get; set; }

        // Dữ liệu Detail (Sẽ hiển thị trên mọi dòng chi tiết)
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongMuon { get; set; }
    }
}
