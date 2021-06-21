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