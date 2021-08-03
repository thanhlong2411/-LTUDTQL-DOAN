using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class TTNhanVienCB_BLL
    {
        TTNhanVienCB_DAL TTNhanVienCB_DAL = new TTNhanVienCB_DAL();
        public DataTable TTNhanVienCB_Select()
        {
            return TTNhanVienCB_DAL.TTNhanVienCB_Select();
        }
        public DataTable ThongTinNhanVienCB_SelectWhereHoTen(string HoTen)
        {
            return TTNhanVienCB_DAL.ThongTinNhanVienCB_SelectWhereHoTen(HoTen);
        }
        public DataTable ThongTinNhanVienCB_SelectWhereMaNV(string MaNV)
        {
            return TTNhanVienCB_DAL.ThongTinNhanVienCB_SelectWhereMaNV(MaNV);
        }
        public DataTable ThongTinNhanVienCB_SelectWhereGioiTinh(string GioiTinh)
        {
            return TTNhanVienCB_DAL.ThongTinNhanVienCB_SelectWhereGioiTinh(GioiTinh);
        }
        public DataTable ThongTinNhanVienCB_SelectWhereChucVu(string ChucVu)
        {
            return TTNhanVienCB_DAL.ThongTinNhanVienCB_SelectWhereChucVu(ChucVu);
        }
        public int TTNhanVienCB_Insert(string MaNV, string MaBoPhan, string MaPhong, string HoTen, DateTime NgaySinh, string GioiTinh, string ChucVu, string ChucDanh)
        {
            return TTNhanVienCB_DAL.TTNhanVienCB_Insert(MaNV,MaBoPhan,MaPhong,HoTen,NgaySinh,GioiTinh,ChucVu,ChucDanh);
        }
        public int TTNhanVienCB_Update(string MaNV, string MaBoPhan, string MaPhong, string HoTen, DateTime NgaySinh, string GioiTinh, string ChucVu, string ChucDanh)
        {
            return TTNhanVienCB_DAL.TTNhanVienCB_Update(MaNV, MaBoPhan, MaPhong, HoTen, NgaySinh, GioiTinh, ChucVu, ChucDanh);
        }
        public int TTNhanVienCB_Delete(string MaNV)
        {
            return TTNhanVienCB_DAL.TTNhanVienCB_Delete(MaNV);
        }
        public string SinhMa(string Bang,string Ma)
        {
            return TTNhanVienCB_DAL.SinhMa(Bang, Ma);
        }
    }
}
