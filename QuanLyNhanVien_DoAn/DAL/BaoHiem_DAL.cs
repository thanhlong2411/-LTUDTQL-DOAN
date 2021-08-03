using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class BaoHiem_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable PhongBan_Select()
        {
            return thaotac.SQL_Laydulieu("Select_BaoHiem");
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

        public int BaoHiem_Insert(string MaNV, string MaSoBH,DateTime NgayCap,DateTime NgayHetHan,string NoiCap)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@MaSoBH"; value[1] = MaSoBH;
            name[2] = "@NgayCap"; value[2] = NgayCap;
            name[3] = "@NgayHetHan"; value[3] = NgayHetHan;
            name[4] = "@NoiCap"; value[4] = NoiCap;
            return thaotac.SQL_Thuchien("Insert_BaoHiem", name, value, 5);
        }
        public int BaoHiem_Update(string MaNV, string MaSoBH, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@MaSoBH"; value[1] = MaSoBH;
            name[2] = "@NgayCap"; value[2] = NgayCap;
            name[3] = "@NgayHetHan"; value[3] = NgayHetHan;
            name[4] = "@NoiCap"; value[4] = NoiCap;
            return thaotac.SQL_Thuchien("Update_BaoHiem", name, value, 5);
        }
        public int BaoHiem_Delete(string MaSoBH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaSoBH"; value[0] = MaSoBH;
            return thaotac.SQL_Thuchien("Delete_BaoHiem", name, value, 1);
        }
    }
}
