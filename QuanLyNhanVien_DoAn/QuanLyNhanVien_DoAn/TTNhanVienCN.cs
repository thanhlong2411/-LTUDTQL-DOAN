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
    public partial class UserControl1 : UserControl
    {
        TTNhanVienCN_BLL TTNhanVienCN_BLL = new TTNhanVienCN_BLL();
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            cbmanv.DataSource = TTNhanVienCB_BLL.TTNhanVienCB_Select();
            cbmanv.DisplayMember = "MaNV";
            cbmanv.ValueMember = "MaNV";

        }

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txthoten.Text = ((DataRowView)cbmanv.SelectedItem)[3].ToString();
        }


        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = TTNhanVienCN_BLL.TTNhanVienCN_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            TTNhanVienCN_BLL.TTNhanVienCN_Insert(cbmanv.Text, txthoten.Text,txtdiachi.Text,txtquequan.Text,txtsdt.Text,txttdnn.Text,txthocvan.Text,txtemail.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            TTNhanVienCN_BLL.TTNhanVienCN_Update(cbmanv.Text, txthoten.Text, txtdiachi.Text, txtquequan.Text, txtsdt.Text, txttdnn.Text, txthocvan.Text, txtemail.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                TTNhanVienCN_BLL.TTNhanVienCN_Delete(cbmanv.Text);
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
            txthoten.Text = data[1, dong].Value.ToString();
            txtdiachi.Text = data[2, dong].Value.ToString();
            txtquequan.Text = data[3, dong].Value.ToString();
            txtsdt.Text = data[4, dong].Value.ToString();
            txttdnn.Text = data[5, dong].Value.ToString();
            txthocvan.Text = data[6, dong].Value.ToString();
            txtemail.Text = data[7, dong].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                this.Text = openFile.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                this.Text = openFile.FileName;
            }
        }
    }
}
