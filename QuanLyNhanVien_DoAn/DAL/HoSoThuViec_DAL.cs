using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HoSoThuViec_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable HoSoThuViec_Select()
        {
            return thaotac.SQL_Laydulieu("Select_HoSoThuViec");
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

        public int HoSoThuViec_Insert(string MaPhong, string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string HocVan, string ViTriThuViec)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaPhong"; value[0] = MaPhong;
            name[1] = "@MaNV"; value[1] = MaNV;
            name[2] = "@HoTen"; value[2] = HoTen;
            name[3] = "@NgaySinh"; value[3] = NgaySinh;
            name[4] = "@GioiTinh"; value[4] = GioiTinh;
            name[5] = "@DiaChi"; value[5] = DiaChi;
            name[6] = "@TDHocVan"; value[6] = HocVan;
            name[7] = "@ViTriThuViec"; value[7] = ViTriThuViec;

            return thaotac.SQL_Thuchien("Insert_HoSoLamViec", name, value, 8);
        }
        public int HoSoThuViec_Update(string MaPhong, string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string HocVan, string ViTriThuViec)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaPhong"; value[0] = MaPhong;
            name[1] = "@MaNV"; value[1] = MaNV;
            name[2] = "@HoTen"; value[2] = HoTen;
            name[3] = "@NgaySinh"; value[3] = NgaySinh;
            name[4] = "@GioiTinh"; value[4] = GioiTinh;
            name[5] = "@DiaChi"; value[5] = DiaChi;
            name[6] = "@TDHocVan"; value[6] = HocVan;
            name[7] = "@ViTriThuViec"; value[7] = ViTriThuViec;

            return thaotac.SQL_Thuchien("Update_HoSoLamViec", name, value, 8);
        }
        public int HoSoLamViec_Delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;
            return thaotac.SQL_Thuchien("Delete_HoSoLamViec", name, value, 1);
        }
    }
}
