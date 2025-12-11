using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace Nhom17_QuanLyThuVien
{
    [Serializable]
    internal class FileDocGhi
    {
        public static bool GhiDuLieu<T>(string filename, T duLieu)
        {
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, duLieu);
                }
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Lỗi ghi file: " + err.Message);
                return false;
            }
        }
        public static bool DocDuLieu<T>(string filename, out T duLieu) where T : new()
        {
            duLieu = new T();
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File dữ liệu '{filename}' chưa tồn tại, tạo đối tượng mới.");
                return false;
            }
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    duLieu = (T)bf.Deserialize(fs);
                }
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"❌ Lỗi đọc file '{filename}': {err.Message}. Dữ liệu mới sẽ được sử dụng.");
                return false;
            }
        }
    }
}

