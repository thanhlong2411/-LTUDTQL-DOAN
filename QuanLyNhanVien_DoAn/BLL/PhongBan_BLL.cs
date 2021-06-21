using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
   public class PhongBan_BLL
    {
        PhongBan_DAL PhongBan_DAL = new PhongBan_DAL();
        public DataTable PhongBan_Select()
        {
            return PhongBan_DAL.PhongBan_Select();
        }
        public int PhongBan_Insert(string MaBoPhan, string MaPhong,string TenPhong)
        {
            return PhongBan_DAL.PhongBan_Insert(MaBoPhan, MaPhong, TenPhong);
        }
        public int PhongBan_Update(string MaBoPhan, string MaPhong, string TenPhong)
        {
            return PhongBan_DAL.PhongBan_Update(MaBoPhan, MaPhong, TenPhong);
        }
        public int PhongBan_Delete(string MaPhong)
        {
            return PhongBan_DAL.PhongBan_Delete(MaPhong);
        }
    }
}
