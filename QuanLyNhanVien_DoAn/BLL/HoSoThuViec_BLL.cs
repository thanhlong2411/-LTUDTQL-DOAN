using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class HoSoThuViec_BLL
    {
        HoSoThuViec_DAL HoSoThuViec_DAL = new HoSoThuViec_DAL();
        public DataTable HoSoThuViec_Select()
        {
            return HoSoThuViec_DAL.HoSoThuViec_Select();
        }
        public int HoSoThuViec_Insert(string MaPhong, string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string HocVan, string ViTriThuViec)
        {
            return HoSoThuViec_DAL.HoSoThuViec_Insert(MaPhong, MaNV,HoTen,NgaySinh,GioiTinh,DiaChi,HocVan,ViTriThuViec);
        }
        public int HoSoThuViec_Update(string MaPhong, string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string HocVan, string ViTriThuViec)
        {
            return HoSoThuViec_DAL.HoSoThuViec_Update(MaPhong, MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, HocVan, ViTriThuViec);
        }
        public int HoSoThuViec_Delete(string MaNV)
        {
            return HoSoThuViec_DAL.HoSoLamViec_Delete(MaNV);
        }
        public string SinhMa(string Bang, string Ma)
        {
            return HoSoThuViec_DAL.SinhMa(Bang, Ma);
        }
    }
}
