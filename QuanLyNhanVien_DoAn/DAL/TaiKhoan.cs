using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class TaiKhoan
    {
		private string userName;
		private string displayName;
		private string password;
		private int type;
		public string UserName { get => userName; set => userName = value; }
		public string DisplayName { get => displayName; set => displayName = value; }
		public string Password { get => password; set => password = value; }
		public int Type { get => type; set => type = value; }
		public TaiKhoan(string userName, string displayName, int type, string password = null)
		{
			UserName = userName;
			DisplayName = displayName;
			Password = password;
			Type = type;
		}

		public TaiKhoan(DataRow row)
		{
			UserName = row["userName"].ToString();
			DisplayName = row["displayName"].ToString();
			Type = (int)row["type"];
			Password = row["password"].ToString();
		}
	}
}
