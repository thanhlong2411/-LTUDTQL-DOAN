using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyNhanVien_DoAn
{
    public partial class TimKiem : UserControl
    {
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        DataTable dt;
        public TimKiem()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text.Trim() == "") || (textBox1.Text.Trim() == "Nhập vào từ khóa tìm kiếm"))
            {
                MessageBox.Show("bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dt = new DataTable();
                if(rdhoten.Checked==true)
                {
                    dt = TTNhanVienCB_BLL.ThongTinNhanVienCB_SelectWhereHoTen(textBox1.Text.Trim());
                }
                if (rdmanv.Checked == true)
                {
                    dt = TTNhanVienCB_BLL.ThongTinNhanVienCB_SelectWhereMaNV(textBox1.Text.Trim());
                }
                if (rdgioitinh.Checked == true)
                {
                    dt = TTNhanVienCB_BLL.ThongTinNhanVienCB_SelectWhereGioiTinh(textBox1.Text.Trim());
                }
                if (rdchucvu.Checked == true)
                {
                    dt = TTNhanVienCB_BLL.ThongTinNhanVienCB_SelectWhereChucVu(textBox1.Text.Trim());
                }
                if (dt.Rows.Count>0)
                {
                    data.DataSource = dt;
                }    
                else
                {
                    MessageBox.Show("Không Tìm Thấy Từ Khóa Cần Tìm!!!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    TimKiem_Load(null, null);
                }    
            }
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            data.DataSource = TTNhanVienCB_BLL.TTNhanVienCB_Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
