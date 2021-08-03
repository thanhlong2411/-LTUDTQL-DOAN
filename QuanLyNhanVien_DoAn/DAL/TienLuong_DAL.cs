using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
   public class TienLuong_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable BanLuong_Select()
        {
            return thaotac.SQL_Laydulieu("Select_BangLuong");
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

        public int BangLuong_Insert(string MaLuong, string MaNV, string HoTen,string GioiTinh, string ChucVu, string ChucDanh, int LuongCB, int PhuCapChucVu)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaLuong"; value[0] = MaLuong;
            name[1] = "@MaNV"; value[1] = MaNV;
            name[2] = "@HoTen"; value[2] = HoTen;
            name[3] = "@GioiTinh"; value[3] = GioiTinh;
            name[4] = "@ChucVu"; value[4] = ChucVu;
            name[5] = "@ChucDanh"; value[5] = ChucDanh;
            name[6] = "@LuongCB"; value[6] = LuongCB;
            name[7] = "@PhuCapChucVu"; value[7] = PhuCapChucVu;
            return thaotac.SQL_Thuchien("Insert_BangLuong", name, value, 8);
        }
        public int BangLuong_Update(string MaLuong, string MaNV, string HoTen, string GioiTinh, string ChucVu, string ChucDanh, int LuongCB, int PhuCapChucVu)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaLuong"; value[0] = MaLuong;
            name[1] = "@MaNV";value[1] = MaNV;
            name[2] = "@HoTen"; value[2] = HoTen;
            name[3] = "@GioiTinh"; value[3] = GioiTinh;
            name[4] = "@ChucVu"; value[4] = ChucVu;
            name[5] = "@ChucDanh"; value[5] = ChucDanh;
            name[6] = "@LuongCB"; value[6] = LuongCB;
            name[7] = "@PhuCapChucVu"; value[7] = PhuCapChucVu;
            return thaotac.SQL_Thuchien("Update_BangLuong", name, value, 8);
        }
        public int BanLuong_Delete(string MaLuong)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLuong"; value[0] = MaLuong;
            return thaotac.SQL_Thuchien("Delete_BangLuong", name, value, 1);
        }
    }
}
