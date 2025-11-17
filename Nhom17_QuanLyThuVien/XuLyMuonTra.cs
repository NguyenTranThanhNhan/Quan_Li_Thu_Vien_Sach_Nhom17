using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom17_QuanLyThuVien
{
    public class XuLyMuonTra
    {
        private List<MuonTra> dsMuonTra;
        private string filename = "muontra.dat";

        public XuLyMuonTra()
        {
            dsMuonTra = new List<MuonTra>();
        }

        public void DocFile()
        {
            FileDocGhi.DocDuLieu(filename, out dsMuonTra);
        }

        public void GhiFile()
        {
            FileDocGhi.GhiDuLieu(filename, dsMuonTra);
        }

        public List<MuonTra> LayDSM()
        {
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
                if (mt.MaND == maND && mt.TrangThai == false)
                {
                    if (DateTime.Now > mt.NgayTra)    // quá hạn
                        return true;
                }
            }
            return false;
        }

       
        public bool ThemMuonTra(string maPM, MuonTra m, out string err)
        {
            err = "";
            if (KiemTraTrungMa(m.MaMuonTra))
            {
                err = "Mã phiếu mượn đã tồn tại!";
                return false;
            }

            if (KiemTraQuaHan(m.MaND))
            {
                err = "Người này đang có phiếu mượn QUÁ HẠN. Không được phép mượn thêm!";
                return false;
            }

            dsMuonTra.Add(m);
            GhiFile();
            return true;
        }
        public bool TraSach(string maPM, out string err)
        {
            err = "";

            MuonTra mt = dsMuonTra.Find(x => x.MaMuonTra == maPM);

            if (mt == null)
            {
                err = "Không tìm thấy mã phiếu mượn.";
                return false;
            }

            mt.TrangThai = true; // đánh dấu đã trả
            GhiFile();
            return true;
        }

        public MuonTra Tim(string maPM)
        {
            return dsMuonTra.Find(x => x.MaMuonTra == maPM);
        }
    }
}
