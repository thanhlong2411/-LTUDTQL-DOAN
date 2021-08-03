using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class TTNhanVienCB_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };

        private string LayMaLonNhat(string Bang,string Ma)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Bang"; value[0] = Bang;
            name[1] = "@Ma"; value[1] = Ma;
            return thaotac.SQL_LayMaLonNhat("LayMaLonNhat",name,value,2);
        }
        public string SinhMa(string Bang,string Ma)
        {
            string MaMoi, MaCu;
            MaCu = LayMaLonNhat(Bang, Ma);
            string TienTo;
            int HauTo;
            TienTo = MaCu.Substring(0, 2);
            HauTo = int.Parse(MaCu.Substring(2).ToString());
            HauTo++;
            if(HauTo<10)
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
        public DataTable TTNhanVienCB_Select()
        {
            return thaotac.SQL_Laydulieu("Select_ThongTinNhanVienCB");
        }
        public DataTable ThongTinNhanVienCB_SelectWhereHoTen(string HoTen)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@HoTen"; value[0] = HoTen;
            return thaotac.SQL_LayDuLieu_CoDK("SelectWhereHoTen_ThongTinNhanVienCB", name, value, 1);
        }
        public DataTable ThongTinNhanVienCB_SelectWhereMaNV(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;
            return thaotac.SQL_LayDuLieu_CoDK("SelectWhereMaNV_ThongTinNhanVienCB", name, value, 1);
        }
        public DataTable ThongTinNhanVienCB_SelectWhereGioiTinh(string GioiTinh)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@GioiTinh"; value[0] = GioiTinh;
            return thaotac.SQL_LayDuLieu_CoDK("SelectWhereGioiTinh_ThongTinNhanVienCB", name, value, 1);
        }
        public DataTable ThongTinNhanVienCB_SelectWhereChucVu(string ChucVu)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@ChucVu"; value[0] = ChucVu;
            return thaotac.SQL_LayDuLieu_CoDK("SelectWhereChucVu_ThongTinNhanVienCB", name, value, 1);
        }
        public int TTNhanVienCB_Insert(string MaNV, string MaBoPhan,string MaPhong,string HoTen,DateTime NgaySinh,string GioiTinh,string ChucVu,string ChucDanh)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@MaBoPhan"; value[1] = MaBoPhan;
            name[2] = "@MaPhong"; value[2] = MaPhong;
            name[3] = "@HoTen"; value[3] = HoTen;
            name[4] = "@NgaySinh"; value[4] = NgaySinh;
            name[5] = "@GioiTinh"; value[5] = GioiTinh;
            name[6] = "@ChucVu"; value[6] = ChucVu;
            name[7] = "@ChucDanh"; value[7] = ChucDanh;
            return thaotac.SQL_Thuchien("Insert_ThongTinNhanVienCB", name, value, 8);
        }
        public int TTNhanVienCB_Update(string MaNV, string MaBoPhan, string MaPhong, string HoTen, DateTime NgaySinh, string GioiTinh, string ChucVu, string ChucDanh)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaNV"; value[0] = MaNV;//
            name[1] = "@MaBoPhan"; value[1] = MaBoPhan;
            name[2] = "@MaPhong"; value[2] = MaPhong;
            name[3] = "@HoTen"; value[3] = HoTen;
            name[4] = "@NgaySinh"; value[4] = NgaySinh;
            name[5] = "@GioiTinh"; value[5] = GioiTinh;
            name[6] = "@ChucVu"; value[6] = ChucVu;
            name[7] = "@ChucDanh"; value[7] = ChucDanh;
            return thaotac.SQL_Thuchien("Update_ThongTinNhanVienCB", name, value, 8);
        }
        public int TTNhanVienCB_Delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;
            return thaotac.SQL_Thuchien("Delete_ThongTinNhanVienCB", name, value, 1);
        }
    }
}
