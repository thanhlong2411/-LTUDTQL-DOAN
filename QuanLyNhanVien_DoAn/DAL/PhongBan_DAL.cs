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
