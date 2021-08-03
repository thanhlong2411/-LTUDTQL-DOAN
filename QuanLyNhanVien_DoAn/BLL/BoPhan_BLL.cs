using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BoPhan_BLL
    {
        BoPhan_DAL BoPhan_DAL = new BoPhan_DAL();
        public DataTable BoPhan_Select()
        {
            return BoPhan_DAL.BoPhan_Select();
        }
        public int BoPhan_Insert(string MaBoPhan, string TenBoPhan)
        {
            return BoPhan_DAL.BoPhan_Insert(MaBoPhan, TenBoPhan);
        }
        public int BoPhan_Update(string MaBoPhan, string TenBoPhan)
        {
            return BoPhan_DAL.BoPhan_Update(MaBoPhan, TenBoPhan);
        }
        public int BoPhan_Delete(string MaBoPhan)
        {
            return  BoPhan_DAL.BoPhan_Delete(MaBoPhan);
        }
        public string SinhMa(string Bang, string Ma)
        {
            return BoPhan_DAL.SinhMa(Bang, Ma);
        }
    }
}
