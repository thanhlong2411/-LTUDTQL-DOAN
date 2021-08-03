using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class PhongBan_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable PhongBan_Select()
        {
            return thaotac.SQL_Laydulieu("Select_PhongBan");
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

        public int PhongBan_Insert(string MaBoPhan, string MaPhong, string TenPhong)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            name[1] = "@MaPhong"; value[1] = MaPhong;
            name[2] = "@TenPhong";value[2] = TenPhong;
            return thaotac.SQL_Thuchien("Insert_PhongBan", name, value, 3);
        }
        public int PhongBan_Update(string MaBoPhan, string MaPhong,string TenPhong)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            name[1] = "@MaPhong"; value[1] = MaPhong;
            name[2] = "@TenPhong"; value[2] = TenPhong;

            return thaotac.SQL_Thuchien("Update_PhongBan", name, value, 3);
        }
        public int PhongBan_Delete(string MaPhong)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaPhong"; value[0] = MaPhong;
            return thaotac.SQL_Thuchien("Delete_PhongBan", name, value, 1);
        }
    }
}
