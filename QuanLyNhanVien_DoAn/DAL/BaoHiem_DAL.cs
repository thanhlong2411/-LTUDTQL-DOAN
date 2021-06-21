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
