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
    public partial class BoPhan : UserControl
    {
        BoPhan_BLL BoPhan_BLL = new BoPhan_BLL();
        public BoPhan()
        {
            InitializeComponent();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = BoPhan_BLL.BoPhan_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            BoPhan_BLL.BoPhan_Insert(txtmabophan.Text, txttenbophan.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            BoPhan_BLL.BoPhan_Update(txtmabophan.Text, txttenbophan.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                BoPhan_BLL.BoPhan_Delete(txtmabophan.Text);
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
            txttenbophan.Text = data[1, dong].Value.ToString();
            txtmabophan.Text = data[0, dong].Value.ToString();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            txtmabophan.Text = BoPhan_BLL.SinhMa("BoPhan", "MaBophan");
            txtmabophan.Enabled = false;
        }
    }
}
