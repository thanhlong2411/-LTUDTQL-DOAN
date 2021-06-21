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
    public partial class TTNhanVienCB : UserControl
    {
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        BoPhan_BLL BoPhan_BLL = new BoPhan_BLL();
        PhongBan_BLL PhongBan_BLL = new PhongBan_BLL();
        public TTNhanVienCB()
        {
            InitializeComponent();
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = TTNhanVienCB_BLL.TTNhanVienCB_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            TTNhanVienCB_BLL.TTNhanVienCB_Insert(txtmanv.Text, cbmabophan.Text, txtmaphong.Text, txthoten.Text, DateTime.Parse(datengaysinh.Value.ToString()), txtgioitinh.Text, txtchucvu.Text, txtchucdanh.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            TTNhanVienCB_BLL.TTNhanVienCB_Update(txtmanv.Text, cbmabophan.Text, txtmaphong.Text, txthoten.Text, DateTime.Parse(datengaysinh.Value.ToString()), txtgioitinh.Text, txtchucvu.Text, txtchucdanh.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                TTNhanVienCB_BLL.TTNhanVienCB_Delete(txtmanv.Text);
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
            txtmanv.Text = data[0, dong].Value.ToString();
            cbmabophan.Text = data[1, dong].Value.ToString();
            txtmaphong.Text = data[2, dong].Value.ToString();
            txthoten.Text = data[3, dong].Value.ToString();
            datengaysinh.Value = DateTime.Parse(data[4, dong].Value.ToString());
            txtgioitinh.Text = data[5, dong].Value.ToString();
            txtchucvu.Text = data[6, dong].Value.ToString();
            txtchucdanh.Text = data[7, dong].Value.ToString();
        }

        private void datengaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TTNhanVienCB_Load(object sender, EventArgs e)
        {
            cbmabophan.DataSource = PhongBan_BLL.PhongBan_Select();
            cbmabophan.DisplayMember = "MaBoPhan";
            cbmabophan.ValueMember = "MaBoPhan";
        }

        private void cbmabophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmaphong.Text = ((DataRowView)cbmabophan.SelectedItem)[1].ToString();
        }
    }
}
