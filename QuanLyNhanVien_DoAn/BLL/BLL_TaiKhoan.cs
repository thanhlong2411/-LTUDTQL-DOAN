using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class BLL_TaiKhoan
    {
		private BLL_TaiKhoan() { }

		private static BLL_TaiKhoan _instance;

		public static BLL_TaiKhoan Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BLL_TaiKhoan();
				}
				return _instance;
			}
		}

		public bool Login(string userName, string password)
		{
			string query = "EXEC USP_Login @userName , @password";
			object[] param = new object[] { userName, password };
			DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
			return result.Rows.Count > 0;
		}

		public bool UpdateAccount(string username, string displayName, string pass, string newPass)
		{
			string query = "EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword";
			object[] param = new object[] { username, displayName, pass, newPass };

			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public DataTable GetListAccount()
		{
			string query = "EXEC USP_GetAllAccount";
			return DataProvider.Instance.ExecuteQuery(query);
		}

		public TaiKhoan GetAccountByUserName(string userName)
		{
			string query = "EXEC USP_GetAccountByUserName @userName";
			object[] param = new object[] { userName };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				return new TaiKhoan(row);
			}

			return null;
		}

		public bool Insert(string userName, string displayName, int type)
		{
			string query = "EXEC USP_CreateAccount @userName , @displayName , @type";
			object[] param = new object[] { userName, displayName, type };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool Update(string userName, string displayName, int type)
		{
			string query = "EXEC USP_UpdateAccountAdmin @userName , @displayName , @type";
			object[] param = new object[] { userName, displayName, type };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool Delete(string userName)
		{
			string query = "EXEC USP_DeleteAccount @userName";
			object[] param = new object[] { userName };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool ResetPassword(string userName)
		{
			string query = "EXEC USP_ResetPassword @userName";
			object[] param = new object[] { userName };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
