using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class BoPhan_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable BoPhan_Select()
        {
            return thaotac.SQL_Laydulieu("Select_BoPhan");
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

        public int BoPhan_Insert(string MaBoPhan, string TenBoPhan)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            name[1] = "@TenBoPhan"; value[1] = TenBoPhan;
            return thaotac.SQL_Thuchien("Insert_BoPhan", name, value, 2);
        }
        public int BoPhan_Update(string MaBoPhan, string TenBoPhan)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            name[1] = "@TenBoPhan"; value[1] = TenBoPhan;
            return thaotac.SQL_Thuchien("Update_BoPhan", name, value, 2);
        }
        public int BoPhan_Delete(string MaBoPhan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBoPhan"; value[0] = MaBoPhan;
            return thaotac.SQL_Thuchien("Delete_BoPhan", name, value, 1);
        }
    }
}