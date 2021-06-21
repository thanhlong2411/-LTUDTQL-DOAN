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
    public partial class FormDoiMK : DevComponents.DotNetBar.Office2007Form
    {
        BLL_Account account_BLL = new BLL_Account();
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {
            cbtennguoidungdmk.DataSource = account_BLL.Account_Select1();
            cbtennguoidungdmk.DisplayMember = "Ussername";
            cbtennguoidungdmk.ValueMember = "Username";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txthotendmk.Text == "" || txtdmk.Text == "" || txthotendmk.Text == "")
                MessageBox.Show("Bạn cần nhập đầy đủ Tài Khoản Và Mật Khẩu!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                account_BLL.Account_Update(cbtennguoidungdmk.Text, txtdmk.Text, txthotendmk.Text);

                MessageBox.Show("Bạn Đăng Đổi Mật Khẩu Thành Công");
            }
        }

        private void cbtennguoidungdmk_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmkcudmk.Text = ((DataRowView)cbtennguoidungdmk.SelectedItem)[1].ToString();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
