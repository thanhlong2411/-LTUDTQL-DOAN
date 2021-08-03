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
    public partial class PhongBan : UserControl
    {
        PhongBan_BLL PhongBan_BLL = new PhongBan_BLL();
        BoPhan_BLL BoPhan_BLL = new BoPhan_BLL();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            cbmabophan.DataSource = BoPhan_BLL.BoPhan_Select();
            cbmabophan.DisplayMember = "MaBoPhan";
            cbmabophan.ValueMember = "MaBoPhan";
        }

        private void cbmabophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenbophan.Text= ((DataRowView)cbmabophan.SelectedItem)[1].ToString();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = PhongBan_BLL.PhongBan_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            PhongBan_BLL.PhongBan_Insert(cbmabophan.Text, txtmaphongban.Text, txttenphongban.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            PhongBan_BLL.PhongBan_Update(cbmabophan.Text, txtmaphongban.Text, txttenphongban.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                PhongBan_BLL.PhongBan_Delete(txtmaphongban.Text);
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
            txtmaphongban.Text = data[1, dong].Value.ToString();
            cbmabophan.Text = data[0, dong].Value.ToString();
            txttenphongban.Text = data[2, dong].Value.ToString();

        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            txtmaphongban.Text = PhongBan_BLL.SinhMa("PhongBan", "MaPhong");
            txtmaphongban.Enabled = false;
        }
    }   
}
