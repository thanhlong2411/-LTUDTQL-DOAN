   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_Account
    {
       DAL_Account account_DAL = new DAL_Account();
        public DataTable Account_Select(string Username,string Password)
        {
            return account_DAL.Account_Select(Username,Password);
        }
        public DataTable Account_Select1()
        {
            return account_DAL.Account_Select1();
        }
        public int Account_Insert(string Username, string Password,string HoTen)
        {
            return account_DAL.Account_Insert(Username, Password,HoTen);
        }
        public int Account_Update(string Username, string Password, string HoTen)
        {
            return account_DAL.Account_Update(Username, Password, HoTen);
        }
    }
}
