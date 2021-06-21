using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace QuanLyNhanVien_DoAn
{
    public partial class FrDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        BLL_Account account_BLL = new BLL_Account();
        
        public FrDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Bạn cần nhập đầy đủ Tài Khoản Và Mật Khẩu!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt = account_BLL.Account_Select(txtTenNguoiDung.Text, txtMatKhau.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Sai Tên Đăng Nhập Hoắc Mật Khẩu!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    this.Hide();
                    FrMain frm = new FrMain();
                    MessageBox.Show("Bạn đã đăng nhập thành công","Đăng Nhập Quyền Admin",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frm.ShowDialog();
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butdangky_Click(object sender, EventArgs e)
        {
            //account_BLL.Account_Insert(txttaikhoandk.Text, txtmkdk.Text, txthotendk.Text);
            if (txttaikhoandk.Text == "" || txtmkdk.Text == ""||txthotendk.Text=="")
                MessageBox.Show("Bạn cần nhập đầy đủ Tài Khoản Và Mật Khẩu!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                account_BLL.Account_Insert(txttaikhoandk.Text, txtmkdk.Text,txthotendk.Text);

                MessageBox.Show("Bạn Đăng Đăng Ký Tài Khoản Thành Công");
            }

            
            
        }

        private void tabControlPanel3_Click(object sender, EventArgs e)
        {

        }

        

        private void butthoatdk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
