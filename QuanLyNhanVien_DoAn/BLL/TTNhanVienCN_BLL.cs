using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class TTNhanVienCN_BLL
    {
        TTNhanVienCN_DAL TTNhanVienCN_DAL = new TTNhanVienCN_DAL();
        public DataTable TTNhanVienCN_Select()
        {
            return TTNhanVienCN_DAL.TTNhanVienCN_Select();
        }
        public int TTNhanVienCN_Insert(string MaNV, string HoTen,string DiaChi,string QueQuan,string SDT,string TrinhDoNN,string HocVan ,string email)
        {
            return TTNhanVienCN_DAL.TTNhanVienCN_Insert(MaNV,HoTen,DiaChi,QueQuan,SDT,TrinhDoNN,HocVan,email );
        }
        public int TTNhanVienCN_Update(string MaNV, string HoTen, string DiaChi, string QueQuan, string SDT, string TrinhDoNN, string HocVan,string email)
        {
            return TTNhanVienCN_DAL.TTNhanVienCN_Update(MaNV, HoTen, DiaChi, QueQuan, SDT, TrinhDoNN, HocVan,email);
        }
        public int TTNhanVienCN_Delete(string MaNV)
        {
            return TTNhanVienCN_DAL.TTNhanVienCN_Delete(MaNV);
        }
    }
}
