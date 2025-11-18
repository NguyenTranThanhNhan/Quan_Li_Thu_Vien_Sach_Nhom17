using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom17_QuanLyThuVien
{
    public class CXuLyPhieuMuonTra
    {
        private List<MuonTra> dsMuonTra;
        private static CXuLyPhieuMuonTra _instance;
        public static CXuLyPhieuMuonTra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CXuLyPhieuMuonTra();
                return _instance;
            }
        }

        private string filename = "muontra.dat";
        private CXuLyPhieuMuonTra() { 
               dsMuonTra = new List<MuonTra>();
               //DocFile();
        }

        public CXuLyPhieuMuonTra(List<MuonTra> dsMuonTra)
        {
            this.dsMuonTra = dsMuonTra;
        }
        public List<MuonTra> DSMuonTra
        {
            get { return dsMuonTra; }
            set { dsMuonTra = value; }
        }
        public void DocFile()
        {
            FileDocGhi.DocDuLieu(filename, out dsMuonTra);
        }

        public void GhiFile()
        {
            FileDocGhi.GhiDuLieu(filename, dsMuonTra);
        }

        public List<MuonTra> LayDSM() { 
            return dsMuonTra; 
        }

       
        private bool KiemTraTrungMa(string maPM)
        {
            foreach (var mt in dsMuonTra)
                if (mt.MaMuonTra == maPM)
                    return true;
            return false;
        }  

        public bool KiemTraQuaHan(string maND)
        {
            foreach (var mt in dsMuonTra)
            {
                if (mt.MaThanhVien == maND && mt.TrangThai == false)
                {
                    if (DateTime.Now > mt.NgayTra)    // quá hạn
                        return true;
                }
            }
            return false;
        }
     
        public bool ThemMuonTra(MuonTra m)
        {

            {
                if (m == null)
                {
                    Console.WriteLine("Phiếu mượn không hợp lệ!");
                    return false;
                }

                if (KiemTraTrungMa(m.MaMuonTra))
                {
                    Console.WriteLine("Mã phiếu mượn đã tồn tại!");
                    return false;
                }

                if (KiemTraQuaHan(m.MaThanhVien))
                {
                    Console.WriteLine("Người này đang có phiếu mượn QUÁ HẠN. Không được phép mượn thêm!");
                    return false;
                }
                m.TrangThai = false;

                dsMuonTra.Add(m);
                GhiFile();
                return true;
            }
        }

       
        public bool TraSach(string maPM)
        {
           var xlSach = XuLySach.Instance;

            MuonTra mt = dsMuonTra.Find(x => x.MaMuonTra == maPM);

            if (mt == null)
            {
                Console.WriteLine("Không tìm thấy mã phiếu mượn.");
                return false;
            }
            if (mt.TrangThai == true)
            {
                MessageBox.Show("Phiếu này đã trả rồi!");
                return false;
            }
            var sach = xlSach.TimSach(mt.MaSach);
            if (sach != null)
            {
                sach.SoLuong += mt.Soluong;
            }
            mt.TrangThai = true; // đánh dấu đã trả
            GhiFile();
            return true;
        }
        public bool SuaPhieuMuonTra(MuonTra mtMoi)
        {

            var xlSach = XuLySach.Instance;
            int vitri = dsMuonTra.FindIndex(mt => mt.MaMuonTra == mtMoi.MaMuonTra);

            if (vitri == -1) return false;

            MuonTra mtCu = dsMuonTra[vitri];
            var sachCu = xlSach.TimSach(mtCu.MaSach);
            if (sachCu != null)
            {
                if (mtCu.TrangThai == false)
                    sachCu.SoLuong += mtCu.Soluong;
                else
                    sachCu.SoLuong -= mtCu.Soluong;
            }
            var sachMoi = xlSach.TimSach(mtMoi.MaSach);

            // Đảm bảo sách mới tồn tại
            if (sachMoi == null)
            {
                // Nếu sách mới không tồn tại, hoàn lại trạng thái sách cũ và báo lỗi
                if (sachCu != null)
                {
                    sachCu.SoLuong -= (mtCu.TrangThai == false ? mtCu.Soluong : -mtCu.Soluong);
                }
                return false;
            }

            if (mtMoi.TrangThai == false) // Mới là MƯỢN
            {
                if (sachMoi.SoLuong < mtMoi.Soluong)
                {
                    // Không đủ sách, hoàn lại trạng thái sách cũ và báo lỗi
                    if (sachCu != null)
                    {
                        sachCu.SoLuong -= (mtCu.TrangThai == false ? mtCu.Soluong : -mtCu.Soluong);
                    }
                    MessageBox.Show("Không đủ số lượng sách trong kho để cập nhật phiếu mượn!");
                    return false;
                }
                sachMoi.SoLuong -= mtMoi.Soluong; // Trừ số lượng khỏi kho
            }
            else // Mới là TRẢ
            {
                sachMoi.SoLuong += mtMoi.Soluong; // Cộng số lượng vào kho
            }
            dsMuonTra[vitri] = mtMoi;
            GhiFile();
            return true;
        }
        public bool XoaPM(string maPM)
        {
            var xlSach = XuLySach.Instance;
            MuonTra mt = LinearSearchTheoMa(maPM);
            if (mt != null)
            {
                var sach = xlSach.TimSach(mt.MaSach);
                if (sach != null)
                {
                    sach.SoLuong += mt.Soluong;
                }
                dsMuonTra.Remove(mt);
                GhiFile();
                return true;
            }
            else
            {
                return false;
            }
        }
        public MuonTra Tim(string maPM)
        {
            return dsMuonTra.Find(x => x.MaMuonTra == maPM);
        }
        public MuonTra LinearSearchTheoMa(string ma)
        {
            foreach (MuonTra mt in dsMuonTra)
            {
                if (mt.MaMuonTra.Equals(ma, StringComparison.OrdinalIgnoreCase))
                    return mt;
            }
            return null;
        }
        public void SelectionSortTheoMa()
        {
            for (int i = 0; i < dsMuonTra.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < dsMuonTra.Count; j++)
                {
                    //  StringComparison.OrdinalIgnoreCase : so sánh chuỗi
                    if (string.Compare(dsMuonTra[j].MaMuonTra, dsMuonTra[min].MaMuonTra, StringComparison.OrdinalIgnoreCase) < 0)
                        min = j;
                }
                if (min != i)
                {
                    MuonTra temp = dsMuonTra[i];
                    dsMuonTra[i] = dsMuonTra[min];
                    dsMuonTra[min] = temp;
                }
            }
            GhiFile();
        }
    }
}
