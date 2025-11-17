using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    internal class XuLyThanhVien
    {
        private List<ThanhVien> dsThanhVien;
        public XuLyThanhVien()
        {
            this.dsThanhVien = new List<ThanhVien>();
        }
        public XuLyThanhVien(List<ThanhVien> dsThanhVien)
        {
            this.dsThanhVien = dsThanhVien;
        }
        public List<ThanhVien> DSThanhVien
        {
            get { return this.dsThanhVien.ToList(); }
            set { this.dsThanhVien = value; }
        }

        private string filename = "ThanhVien.dat";
        public void DocFile()
        {
            FileDocGhi.DocDuLieu(filename, out dsThanhVien);
        }
        public void GhiFile()
        {
            FileDocGhi.GhiDuLieu(filename, dsThanhVien);

        }
        public List<ThanhVien> LayDanhSach()
        {
            return dsThanhVien;
        }
        private bool tim(string tv)
        {
            foreach (ThanhVien TV in dsThanhVien)
            {
                if (TV.MaThanhVien == tv)
                    return true;
            }
            return false;

        }
        public bool ThemTV(ThanhVien tv)
        {
            if (tim(tv.MaThanhVien))
            {
                Console.WriteLine("Mã thành viên đã tồn tại, vui lòng nhập lại mã !!");
                return false;
            }
            else
            {
                dsThanhVien.Add(tv);
                GhiFile();
                return true;
            }
        }
        public bool XoaTV(string ma)
        {
            ThanhVien tv=LinearSearchTheoMa(ma);
            if (tv != null)
            {
                dsThanhVien.Remove(tv);
                GhiFile();
                return true;
            }
            else
                return false;
        }

        public bool SuaTV(ThanhVien tv)
        {
            for (int i = 0; i < dsThanhVien.Count; i++)
                if (dsThanhVien[i].MaThanhVien == tv.MaThanhVien)
                {
                    dsThanhVien[i] = tv;
                    GhiFile();
                    return true;
                }
            return false;
        }

        public int TimViTri(string tv)
        {
            for (int i = 0; i < dsThanhVien.Count; i++)
            {
                //  StringComparison.OrdinalIgnoreCase : so sánh chuỗi
                if (dsThanhVien[i].MaThanhVien.Equals(tv, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        // --- Sắp xếp theo mã (ISBN) - Selection Sort ---
        public void SelectionSortTheoMa()
        {
            for (int i = 0; i < dsThanhVien.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < dsThanhVien.Count; j++)
                {
                    //  StringComparison.OrdinalIgnoreCase : so sánh chuỗi
                    if (string.Compare(dsThanhVien[j].MaThanhVien, dsThanhVien[min].MaThanhVien, StringComparison.OrdinalIgnoreCase) < 0)
                        min = j;
                }
                if (min != i)
                {
                    ThanhVien temp = dsThanhVien[i];
                    dsThanhVien[i] = dsThanhVien[min];
                    dsThanhVien[min] = temp;
                }
            }
            GhiFile();
        }

        // --- Sắp xếp theo tên - Bubble Sort ---
        public void BubbleSortTheoTen()
        {
            for (int i = 0; i < dsThanhVien .Count - 1; i++)
            {
                for (int j = 0; j < dsThanhVien.Count - i - 1; j++)
                {
                    if (string.Compare(dsThanhVien[j].MaThanhVien, dsThanhVien[j + 1].TenThanhVien, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        ThanhVien temp = dsThanhVien[j];
                        dsThanhVien[j] = dsThanhVien[j + 1];
                        dsThanhVien [j + 1] = temp;
                    }
                }
            }
            GhiFile();
        }
        // --- Tìm kiếm tuyến tính theo mã  ---
        public ThanhVien LinearSearchTheoMa(string ma)
        {
            foreach (ThanhVien tv in dsThanhVien)
            {
                if (tv.MaThanhVien.Equals(ma, StringComparison.OrdinalIgnoreCase))
                    return tv;
            }
            return null;
        }

        // --- Tìm kiếm nhị phân theo tên sách ---
        public ThanhVien BinarySearchTheoTen(string ten)
        {
            // Đảm bảo danh sách được sắp xếp theo tên trước
            BubbleSortTheoTen();

            int left = 0, right = dsThanhVien.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(dsThanhVien[mid].TenThanhVien, ten, StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                    return dsThanhVien  [mid];
                else if (cmp < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
        public List<ThanhVien> LayDanhSachSapXepTheoMa()
        {
            SelectionSortTheoMa();
            return dsThanhVien;
        }

        public List<ThanhVien> LayDanhSachSapXepTheoTen()
        {
            BubbleSortTheoTen();
            return dsThanhVien;
        }
    }
  }
