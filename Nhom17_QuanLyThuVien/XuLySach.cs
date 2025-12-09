using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
namespace Nhom17_QuanLyThuVien
{
    public class XuLySach
    {
        private List<Sach> dsSach;
        private static XuLySach instance;
        public static XuLySach Instance
        {
            get
            {
                if (instance == null)
                    instance = new XuLySach();
                return instance;
            }
        }
        public XuLySach()
        {
            this.dsSach = new List<Sach>();
        }
        public XuLySach(List<Sach> dsSach)
        {
            this.dsSach = dsSach;
        }
        public List<Sach> DSSach
        {
            get { return dsSach; }
            set { dsSach = value; }
        }
        private string filename = "dsqlSach.dat";
        public void DocFile()
        {
            FileDocGhi.DocDuLieu(filename, out dsSach);
        }
        public void GhiFile()
        {
            FileDocGhi.GhiDuLieu(filename, dsSach);

        }
        public List<Sach> LayDanhSach()
        {
            return dsSach;
        }
        private bool kttrungma(string maSach)
        {
            foreach (Sach s in dsSach)
            {
                if (s.MaSach == maSach)
                    return true;
            }
            return false;
        }
        // kiem tra ton tai ma sach trong phieu
        public Sach TimSach(string ma)
        {
            return dsSach.FirstOrDefault(s => s.MaSach == ma);
        }

        public bool GiamSoLuong(string ma, int sl)
        {
            var sach = TimSach(ma);
            if (sach != null && sach.SoLuongCon >= sl && sl > 0)
            {
                sach.SoLuongCon -= sl;
                this.GhiFile();
                return true;
            }
            return false;
        }

        public bool TangSoLuong(string ma, int sl)
        {
            var sach = TimSach(ma);
            if (sach != null && sl > 0)
            {
                sach.SoLuongCon += sl;
                this.GhiFile();
                return true;
            }
            return false;
        }
        public bool ThemSach(Sach s)
        {
            if (kttrungma(s.MaSach))
            {
                Console.WriteLine("Mã sách đã tồn tại, không thể thêm.");
                return false;
            }
            else
            {
                dsSach.Add(s);
                GhiFile();
                return true;
            }
        }
        public bool XoaSach(string maSach)
        {
            Sach s = LinearSearchTheoMa(maSach);
            if (s != null)
            {
                dsSach.Remove(s);
                GhiFile();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TimViTriTheoMa(string maSach)
        {
            for (int i = 0; i < dsSach.Count; i++)
            {
                if (dsSach[i].MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
        public bool SuaSach(Sach sachMoi)
        {
            int vitri = dsSach.FindIndex(s => s.MaSach == sachMoi.MaSach);
            if (vitri != -1)
            {
                dsSach[vitri] = sachMoi;
                GhiFile();
                return true;
            }
            else
                return false;
        }


        // --- Sắp xếp theo mã sách (ISBN) - Selection Sort ---
        public void SelectionSortTheoMa()
        {
            for (int i = 0; i < dsSach.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < dsSach.Count; j++)
                {
                    //  StringComparison.OrdinalIgnoreCase : so sánh chuỗi
                    if (string.Compare(dsSach[j].MaSach, dsSach[min].MaSach, StringComparison.OrdinalIgnoreCase) < 0)
                        min = j;
                }
                if (min != i)
                {
                    Sach temp = dsSach[i];
                    dsSach[i] = dsSach[min];
                    dsSach[min] = temp;
                }
            }
            GhiFile();
        }

        // --- Sắp xếp theo tên sách - Bubble Sort ---
        public void BubbleSortTheoTen()
        {
            for (int i = 0; i < dsSach.Count - 1; i++)
            {
                for (int j = 0; j < dsSach.Count - i - 1; j++)
                {
                    //  StringComparison.OrdinalIgnoreCase : so sánh chuỗi
                    if (string.Compare(dsSach[j].TenSach, dsSach[j + 1].TenSach, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Sach temp = dsSach[j];
                        dsSach[j] = dsSach[j + 1];
                        dsSach[j + 1] = temp;
                    }
                }
            }
            GhiFile();
        }
        // --- Tìm kiếm tuyến tính theo mã sách ---
        public Sach LinearSearchTheoMa(string ma)
        {
            foreach (Sach s in dsSach)
            {
                if (s.MaSach.Equals(ma, StringComparison.OrdinalIgnoreCase))
                    return s;
            }
            return null;
        }

        // --- Tìm kiếm nhị phân theo tên sách ---
        public Sach BinarySearchTheoTen(string ten)
        {
            // Đảm bảo danh sách được sắp xếp theo tên trước
            BubbleSortTheoTen();

            int left = 0, right = dsSach.Count - 1;
            while (left <= right)
            {
                //  StringComparison.OrdinalIgnoreCase : so sánh chuỗi
                int mid = (left + right) / 2;
                int cmp = string.Compare(dsSach[mid].TenSach, ten, StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                    return dsSach[mid];
                else if (cmp < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
        public List<Sach> LayDanhSachSapXepTheoMa()
        {
            SelectionSortTheoMa();
            return dsSach;
        }

        public List<Sach> LayDanhSachSapXepTheoTen()
        {
            BubbleSortTheoTen();
            return dsSach;
        }
        public string LayMaSoTheLoai(string tenTheLoai)
        {
            switch (tenTheLoai)
            {
                case "Sách lịch sử": return "01";
                case "Sách văn học viễn tưởng": return "02";
                case "Sách văn hóa xã hội": return "03";
                case "Sách khoa học công nghệ": return "04";
                case "Sách kỹ năng tư duy": return "05";
                case "Sách Tiểu Thuyết": return "06";
                case "Sách kinh doanh": return "07";
                case "Sách kinh dị": return "08";
                default: return "99"; // Mã mặc định cho các thể loại khác
            }
        }
        private string TinhCheckDigit(string ma12ChuSo)
        {
            if (ma12ChuSo.Length != 12) return "0";

            long sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit = ma12ChuSo[i] - '0';
                sum += (i % 2 == 0) ? digit : digit * 3;
            }
            int soDu = (int)(sum % 10);
            // Công thức tính Check Digit: (10 - số dư) MOD 10

            return ((10 - soDu) % 10).ToString();
        }
        //public string TaoMaISBNTheoTheLoai(string maTheLoaiSo) // maTheLoaiSo là "01", "07", ...
        //{
        //    string tienToKhongGach = "97860458"; // 8 ký tự
        //    string tienToHoanChinh = tienToKhongGach + maTheLoaiSo; // 10 ký tự (VD: 9786045801)
        //    int soMax = 0;

        //    // 1. TÌM SỐ THỨ TỰ LỚN NHẤT
        //    foreach (Sach s in dsSach)
        //    {
        //        // Loại bỏ gạch ngang để tìm kiếm tiền tố và STT
        //        string maSachDaLuu = s.MaSach.Replace("-", "");

        //        if (maSachDaLuu.StartsWith(tienToHoanChinh) && maSachDaLuu.Length == 13)
        //        {
        //            try
        //            {
        //                // Cắt 2 chữ số STT (bắt đầu từ vị trí 10, dài 2 ký tự)
        //                string phanSoStr = maSachDaLuu.Substring(tienToHoanChinh.Length, 2);

        //                if (int.TryParse(phanSoStr, out int soHienTai))
        //                {
        //                    if (soHienTai > soMax)
        //                    {
        //                        soMax = soHienTai;
        //                    }
        //                }
        //            }
        //            catch { }
        //        }
        //    }

        //    int soTiepTheo = soMax + 1;
        //    string soThuTuMoi = soTiepTheo.ToString("D2"); // Dùng "D2" (Ví dụ: 1 -> "01")

        //    // 2. TÍNH CHỮ SỐ KIỂM TRA
        //    string ma12ChuSo = tienToHoanChinh + soThuTuMoi; // 12 ký tự (VD: 978604580101)
        //    string checkDigit = TinhCheckDigit(ma12ChuSo);

        //    // 3. ĐỊNH DẠNG MÃ 17 KÝ TỰ CÓ GẠCH NGANG
        //    // ma12ChuSo.Substring(8, 4) là "0101" (Mã TL (2) + STT (2))
        //    string maISBNHoanChinh = ma12ChuSo.Substring(0, 3) + "-" +
        //                             ma12ChuSo.Substring(3, 3) + "-" +
        //                             ma12ChuSo.Substring(6, 2) + "-" +
        //                             ma12ChuSo.Substring(8, 4) + "-" + checkDigit;

        //    return maISBNHoanChinh;
        //}
        private string FormatISBN(string isbn13)
        {
            return $"{isbn13.Substring(0, 3)}-{isbn13.Substring(3, 3)}-{isbn13.Substring(6, 2)}-{isbn13.Substring(8, 4)}-{isbn13[12]}";
        }

        // Hàm tạo mã sách theo thể loại
        public string TaoMaISBNTheoTheLoai(string maTheLoai)
        {
            string prefix = "97860458" + maTheLoai;   // 10 chữ số đầu :9786045801

            // Tìm số thứ tự lớn nhất (2 số cuối trước check digit)
            int maxSTT = dsSach
                .Select(s => s.MaSach.Replace("-", ""))
                .Where(m => m.StartsWith(prefix) && m.Length == 13)
                .Select(m => int.Parse(m.Substring(10, 2)))
                .DefaultIfEmpty(0)
                .Max();

            int sttMoi = maxSTT + 1; // 4 
            string stt2 = sttMoi.ToString("D2"); //04

            // Tạo 12 chữ số đầu
            string ma12 = prefix + stt2; // 978604580104

            // Tính chữ số kiểm tra
            string check = TinhCheckDigit(ma12);

            string isbn13 = ma12 + check;

            return FormatISBN(isbn13);
        }
        public bool KiemTraISBNHopLe(string maISBNCoHoacKhongDau)
        {
            // Loại bỏ dấu gạch ngang để có chuỗi 13 chữ số
            string soISBN13ChuSo = maISBNCoHoacKhongDau.Replace("-", "").Trim();

            // 1. Kiểm tra độ dài phải là 13 chữ số
            if (soISBN13ChuSo.Length != 13 || !long.TryParse(soISBN13ChuSo.Substring(0, 12), out _))
                return false;

            // 2. Kiểm tra Check Digit
            // Lấy 12 ký tự đầu tiên
            string ma12ChuSo = soISBN13ChuSo.Substring(0, 12);
            // Lấy ký tự cuối cùng (Check Digit nhập)
            string checkDigitNhap = soISBN13ChuSo.Substring(12, 1);

            // Tính Check Digit thực tế
            string checkDigitThucTe = TinhCheckDigit(ma12ChuSo);

            return checkDigitNhap.Equals(checkDigitThucTe, StringComparison.Ordinal);
        }

        // cach khac 
        public string TaoMaSachTheoTheLoaiTimestamp(string maTL)
        {
            string time = DateTime.Now.ToString("yyyyMMdd");
            return $"{maTL}-{time}";
        }
    }
}
