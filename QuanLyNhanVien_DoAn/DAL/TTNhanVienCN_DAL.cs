using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class TTNhanVienCN_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable TTNhanVienCN_Select()
        {
            return thaotac.SQL_Laydulieu("Select_ThongTinNhanVienCN");
        }

        public int TTNhanVienCN_Insert(string MaNV, string HoTen,string DiaChi,string QueQuan,string SDT,string TrinhDoNN,string HocVan,string email)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@DiaChi"; value[2] = DiaChi;
            name[3] = "@QueQuan"; value[3] = QueQuan;
            name[4] = "@SDT"; value[4] = SDT;
            name[5] = "@TrinhDoNN"; value[5] = TrinhDoNN;
            name[6] = "@HocVan"; value[6] = HocVan;
            name[7] = "@email"; value[7] = email;

            return thaotac.SQL_Thuchien("Insert_ThongTinNhanVienCN", name, value, 8);
        }
        public int TTNhanVienCN_Update(string MaNV, string HoTen, string DiaChi, string QueQuan, string SDT, string TrinhDoNN, string HocVan,string email)
        {
            name = new string[8];
            value = new object[8];
            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@DiaChi"; value[2] = DiaChi;
            name[3] = "@QueQuan"; value[3] = QueQuan;
            name[4] = "@SDT"; value[4] = SDT;
            name[5] = "@TrinhDoNN"; value[5] = TrinhDoNN;
            name[6] = "@HocVan"; value[6] = HocVan;
            name[7] = "@email"; value[7] = email;
            return thaotac.SQL_Thuchien("Update_ThongTinNhanVienCN", name, value, 8);
        }
        public int TTNhanVienCN_Delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = MaNV;
            return thaotac.SQL_Thuchien("Delete_ThongTinNhanVienCN", name, value, 1);
        }
    }
}
