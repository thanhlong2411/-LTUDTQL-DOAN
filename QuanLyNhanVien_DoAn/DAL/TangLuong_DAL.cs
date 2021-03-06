using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class TangLuong_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable TangLuong_Select()
        {
            return thaotac.SQL_Laydulieu("Select_TangLuong");
        }
        private string LayMaLonNhat(string Bang, string Ma)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Bang"; value[0] = Bang;
            name[1] = "@Ma"; value[1] = Ma;
            return thaotac.SQL_LayMaLonNhat("LayMaLonNhat", name, value, 2);
        }
        public string SinhMa(string Bang, string Ma)
        {
            string MaMoi, MaCu;
            MaCu = LayMaLonNhat(Bang, Ma);
            string TienTo;
            int HauTo;
            TienTo = MaCu.Substring(0, 2);
            HauTo = int.Parse(MaCu.Substring(2).ToString());
            HauTo++;
            if (HauTo < 10)
            {
                MaMoi = string.Concat(TienTo, "00", HauTo.ToString());
            }
            else
            {
                if (HauTo < 100)
                    MaMoi = string.Concat(TienTo, "0", HauTo.ToString());
                else
                    MaMoi = string.Concat(TienTo, HauTo.ToString());
            }
            return MaMoi;
        }

        public int TangLuong_Insert(string MaNV, string HoTen, string GioiTinh, string ChucVu, int LuongCBCu,int LuongCBMoi,int PhuCapMoi,int PhuCapCu,string LyDo)
        {
            name = new string[9];
            value = new object[9];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@GioiTinh"; value[2] = GioiTinh;
            name[3] = "@ChucVu"; value[3] = ChucVu;
            name[4] = "@LuongCBCu"; value[4] = LuongCBCu;
            name[5] = "@LuongCBMoi"; value[5] = LuongCBMoi;
            name[6] = "@PhuCapMoi"; value[6] = PhuCapMoi;
            name[7] = "@PhuCapCu"; value[7] = PhuCapCu;
            name[8] = "@LyDo"; value[8] = LyDo;
            return thaotac.SQL_Thuchien("Insert_TangLuong", name, value, 9);
        }
        public int TangLuong_Update(string MaNV, string HoTen, string GioiTinh, string ChucVu, int LuongCBCu, int LuongCBMoi, int PhuCapMoi, int PhuCapCu, string LyDo)
        {
            name = new string[9];
            value = new object[9];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@GioiTinh"; value[2] = GioiTinh;
            name[3] = "@ChucVu"; value[3] = ChucVu;
            name[4] = "@LuongCBCu"; value[4] = LuongCBCu;
            name[5] = "@LuongCBMoi"; value[5] = LuongCBMoi;
            name[6] = "@PhuCapMoi"; value[6] = PhuCapMoi;
            name[7] = "@PhuCapCu"; value[7] = PhuCapCu;
            name[8] = "@LyDo"; value[8] = LyDo;
            return thaotac.SQL_Thuchien("Update_TangLuong", name, value, 9);
        }
        public int TangLuong_Delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;
            return thaotac.SQL_Thuchien("Delete_TangLuong", name, value, 1);
        }
    }
}
