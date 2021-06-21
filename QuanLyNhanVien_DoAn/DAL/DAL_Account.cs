using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class DAL_Account
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable Account_Select( string Username , string Password)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@Username"; value[0] = Username;
            name[1] = "@Password"; value[1] = Password;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Account", name, value, 2);
        }
        public DataTable Account_Select1()
        {
            return thaotac.SQL_Laydulieu("Select_Account1");
        }

        public int Account_Insert(string Username, string Password, string HoTen)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "Username"; value[0] = Username;
            name[1] = "@Password"; value[1] = Password;
            name[2] = "@HoTen"; value[2] = HoTen;
            return thaotac.SQL_Thuchien("Insert_Account", name, value, 3);
        }
        public int Account_Update(string Username, string Password, string HoTen)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "Username"; value[0] = Username;
            name[1] = "@Password"; value[1] = Password;
            name[2] = "@HoTen"; value[2] = HoTen;
            return thaotac.SQL_Thuchien("Update_Account", name, value, 3);
        }
    }
}
