using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class TienLuong_BLL
    {
        TienLuong_DAL TienLuong_DAL = new TienLuong_DAL();
        public DataTable BanLuong_Select()
        {
            return TienLuong_DAL.BanLuong_Select();
        }
        public int BanLuong_Insert(string MaLuong, string MaNV ,string HoTen,string GioiTinh,string ChucVu, string ChucDanh, int LuongCB, int PhuCapChucVu)
        {
            return TienLuong_DAL.BangLuong_Insert(MaLuong, MaNV,HoTen,GioiTinh, ChucVu,ChucDanh,LuongCB,PhuCapChucVu);
        }
        public int BanLuong_Update(string MaLuong,string MaNV, string HoTen,string GioiTinh,string ChucVu, string ChucDanh, int LuongCB, int PhuCapChucVu)
        {
            return TienLuong_DAL.BangLuong_Update(MaLuong,MaNV,HoTen,GioiTinh, ChucVu, ChucDanh, LuongCB, PhuCapChucVu);
        }
        public int BanLuong_Delete(string MaLuong)
        {
            return TienLuong_DAL.BanLuong_Delete(MaLuong);
        }
    }
}
