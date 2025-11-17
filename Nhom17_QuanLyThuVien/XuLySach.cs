using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Nhom17_QuanLyThuVien
{
    public class XuLySach
    {
        private List<Sach> dsSach;
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
        private string filename = "Sach.dat";
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
        private bool kttrungma(string maSach) { 
        foreach (Sach s in dsSach)
            {
                if (s.MaSach == maSach)
                    return true;
            }
            return false;
        }
        public bool ThemSach(Sach s) {
            if (kttrungma(s.MaSach)) { 
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
        public bool XoaSach(string maSach) { 
        Sach s= LinearSearchTheoMa(maSach);
            if (s != null)
            {
                dsSach.Remove(s);
                GhiFile();
                return true;
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách với mã đã cho.");
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
    }
}
