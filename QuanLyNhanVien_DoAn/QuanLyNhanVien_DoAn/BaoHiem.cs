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
using DAL;

namespace QuanLyNhanVien_DoAn
{
    public partial class BaoHiem : UserControl
    {
        BaoHiem_BLL BaoHiem_BLL = new BaoHiem_BLL();
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        public BaoHiem( TaiKhoan acc)
        {
            InitializeComponent();
            account = acc;
            ChangeAccount();
        }
        void ChangeAccount()
        {
            butthem.Enabled = account.Type == 1;
            butsua.Enabled = account.Type == 1;
            butxoa.Enabled = account.Type == 1;

        }
        private TaiKhoan account;
        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = BaoHiem_BLL.BaoHiem_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            BaoHiem_BLL.BaoHiem_Insert(cbmanv.Text, txtmabaohiem.Text, DateTime.Parse(datatimengaycap.Value.ToString()), DateTime.Parse(datatimengayhethan.Value.ToString()), txtnoicap.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            BaoHiem_BLL.BaoHiem_Update(cbmanv.Text, txtmabaohiem.Text, DateTime.Parse(datatimengaycap.Value.ToString()), DateTime.Parse(datatimengayhethan.Value.ToString()), txtnoicap.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                BaoHiem_BLL.BaoHiem_Delete(txtmabaohiem.Text);
                butshow_Click(sender, e);
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            cbmanv.Text = data[0, dong].Value.ToString();
            txtmabaohiem.Text = data[1, dong].Value.ToString();
            datatimengaycap.Value = DateTime.Parse(data[2, dong].Value.ToString());
            datatimengayhethan.Value = DateTime.Parse(data[3, dong].Value.ToString());
            txtnoicap.Text = data[4, dong].Value.ToString();
            
        }

        private void BaoHiem_Load(object sender, EventArgs e)
        {
            cbmanv.DataSource = TTNhanVienCB_BLL.TTNhanVienCB_Select();
            cbmanv.DisplayMember = "MaNV";
            cbmanv.ValueMember = "MaNV";
        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            txtmabaohiem.Text = BaoHiem_BLL.SinhMa("BaoHiem", "MaSoBH");
            txtmabaohiem.Enabled = false;
        }
    }
}
