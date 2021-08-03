using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class TangLuong_BLL
    {
        TangLuong_DAL TangLuong_DAL = new TangLuong_DAL();
        public DataTable TangLuong_Select()
        {
            return TangLuong_DAL.TangLuong_Select();
        }
        public int TangLuong_Insert(string MaNV, string HoTen, string GioiTinh, string ChucVu, int LuongCBCu, int LuongCBMoi, int PhuCapMoi, int PhuCapCu, string LyDo)
        {
            return TangLuong_DAL.TangLuong_Insert(MaNV, HoTen,GioiTinh,ChucVu,LuongCBCu,LuongCBMoi,PhuCapMoi,PhuCapCu,LyDo);
        }
        public int TangLuong_Update(string MaNV, string HoTen, string GioiTinh, string ChucVu, int LuongCBCu, int LuongCBMoi, int PhuCapMoi, int PhuCapCu, string LyDo)
        {
            return TangLuong_DAL.TangLuong_Update(MaNV, HoTen, GioiTinh, ChucVu, LuongCBCu, LuongCBMoi, PhuCapMoi, PhuCapCu, LyDo);
        }
        public int TangLuong_Delete(string MaNV)
        {
            return TangLuong_DAL.TangLuong_Delete(MaNV);
        }
        public string SinhMa(string Bang, string Ma)
        {
            return TangLuong_DAL.SinhMa(Bang, Ma);
        }
    }
}
