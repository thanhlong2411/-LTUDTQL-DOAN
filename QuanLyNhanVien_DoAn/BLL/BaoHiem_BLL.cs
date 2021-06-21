using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class BaoHiem_BLL
    {
        BaoHiem_DAL BaoHiem_DAL = new BaoHiem_DAL();
        public DataTable BaoHiem_Select()
        {
            return BaoHiem_DAL.PhongBan_Select();
        }
        public int BaoHiem_Insert(string MaNV, string MaSoBH, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            return BaoHiem_DAL.BaoHiem_Insert(MaNV, MaSoBH, NgayCap, NgayHetHan, NoiCap);
        }
        public int BaoHiem_Update(string MaNV, string MaSoBH, DateTime NgayCap, DateTime NgayHetHan, string NoiCap)
        {
            return BaoHiem_DAL.BaoHiem_Update(MaNV, MaSoBH, NgayCap, NgayHetHan, NoiCap);
        }
        public int BaoHiem_Delete(string MaSoBH)
        {
            return BaoHiem_DAL.BaoHiem_Delete(MaSoBH);
        }
    }
}
