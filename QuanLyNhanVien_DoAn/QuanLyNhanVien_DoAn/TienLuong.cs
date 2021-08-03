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
    public partial class TienLuong : UserControl
    {
        double ThucLinh;
        TienLuong_BLL TienLuong_BLL = new TienLuong_BLL();
        TangLuong_BLL TangLuong_BLL = new TangLuong_BLL();
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        DataTable Luong = new DataTable();
        public TienLuong(TaiKhoan acc)
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
            butthem1.Enabled = account.Type == 1;
            butsua1.Enabled = account.Type == 1;
            butxoa1.Enabled = account.Type == 1;
        }
        private TaiKhoan account;
        #region Tiền Lương
    private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = TienLuong_BLL.BanLuong_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            TienLuong_BLL.BanLuong_Insert(txtmaluong.Text,cbmanv1.Text,txthoten1.Text,txtgioitinh1.Text, txtchucvu.Text,txtchucdanh.Text,int.Parse(txtluongcb.Text),int.Parse(txtphucapcv.Text));
            butshow_Click(sender, e);
            //int LCB = int.Parse(txtluongcb.Text);
            //int PhuCap = int.Parse(txtphucapcv.Text);
            //ThucLinh = LCB + PhuCap;
            //Luong.Rows.Add(txtmaluong.Text, cbmanv1.Text, txthoten1.Text, txtgioitinh1.Text, txtchucvu.Text, txtchucdanh.Text, int.Parse(txtluongcb.Text), int.Parse(txtphucapcv.Text), ThucLinh);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            TienLuong_BLL.BanLuong_Update(txtmaluong.Text,cbmanv1.Text,txthoten1.Text,txtgioitinh1.Text ,txtchucvu.Text, txtchucdanh.Text, int.Parse(txtluongcb.Text), int.Parse(txtphucapcv.Text));
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                TienLuong_BLL.BanLuong_Delete(txtmaluong.Text);
                butshow_Click(sender, e);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = data.CurrentRow.Index;
            txtmaluong.Text = data[0, dong].Value.ToString();
            cbmanv1.Text = data[1, dong].Value.ToString();
            txthoten1.Text = data[2, dong].Value.ToString();
            txtgioitinh.Text = data[3, dong].Value.ToString();
            txtchucvu.Text = data[4 ,dong].Value.ToString();
            txtchucdanh.Text = data[5, dong].Value.ToString();
            txtluongcb.Text = data[6, dong].Value.ToString();
            txtphucapcv.Text = data[7, dong].Value.ToString();
        }
        #endregion

        #region Tăng Lương
        private void butshow1_Click(object sender, EventArgs e)
        {
            data1.DataSource = TangLuong_BLL.TangLuong_Select();
        }
        private void butthem1_Click(object sender, EventArgs e)
        {
            TangLuong_BLL.TangLuong_Insert(cbmanv.Text, txthoten.Text, txtgioitinh.Text, txtchucvu.Text, int.Parse(txtluongcbcutl.Text), int.Parse(txtluongcbmoitl.Text), int.Parse(txtphucapmoitl.Text), int.Parse(txt1phucapcutl.Text), txtlydo.Text);
            butshow1_Click(sender, e);
        }

        private void butsua1_Click(object sender, EventArgs e)
        {
            TangLuong_BLL.TangLuong_Update(cbmanv.Text, txthoten.Text, txtgioitinh.Text, txtchucvu.Text, int.Parse(txtluongcbcutl.Text), int.Parse(txtluongcbmoitl.Text), int.Parse(txtphucapmoitl.Text), int.Parse(txt1phucapcutl.Text), txtlydo.Text);
            butshow1_Click(sender, e);
        }

        private void butxoa1_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                TangLuong_BLL.TangLuong_Delete(cbmanv.Text);
                butshow1_Click(sender, e);
            }
        }

        
        #endregion

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txthoten.Text = ((DataRowView)cbmanv.SelectedItem)[2].ToString();
            txtgioitinh.Text = ((DataRowView)cbmanv.SelectedItem)[3].ToString();
            txtchucvutl.Text = ((DataRowView)cbmanv.SelectedItem)[4].ToString();
            txtchucdanhtl.Text = ((DataRowView)cbmanv.SelectedItem)[5].ToString();
            txtluongcbcutl.Text = ((DataRowView)cbmanv.SelectedItem)[6].ToString();
            txt1phucapcutl.Text = ((DataRowView)cbmanv.SelectedItem)[7].ToString();

        }

        private void cbmanv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txthoten1.Text = ((DataRowView)cbmanv1.SelectedItem)[3].ToString();
            txtgioitinh1.Text = ((DataRowView)cbmanv1.SelectedItem)[5].ToString();
            txtchucvu.Text = ((DataRowView)cbmanv1.SelectedItem)[6].ToString();
            txtchucdanh.Text = ((DataRowView)cbmanv1.SelectedItem)[7].ToString();
            
        }
        private void TienLuong_Load(object sender, EventArgs e)
        {
            cbmanv.DataSource = TienLuong_BLL.BanLuong_Select();
            cbmanv.DisplayMember = "MaNV";
            cbmanv.ValueMember = "MaNV";


            cbmanv1.DataSource = TTNhanVienCB_BLL.TTNhanVienCB_Select();
            cbmanv1.DisplayMember = "MaNV";
            cbmanv1.ValueMember = "MaNV";

            //data.DataSource = TienLuong_BLL.BanLuong_Select();


            //Luong = new DataTable();
            //Luong.Columns.Add("Mã Lương", typeof(string));
            //Luong.Columns.Add("Mã Nhân Viên", typeof(string));
            //Luong.Columns.Add("Họ Tên", typeof(string));
            //Luong.Columns.Add("Giới Tính", typeof(string));
            //Luong.Columns.Add("Chức Vụ", typeof(string));
            //Luong.Columns.Add("Chức Danh", typeof(string));
            //Luong.Columns.Add("Lương Cơ Bản", typeof(string));
            //Luong.Columns.Add("Phụ Cấp", typeof(string));
            //Luong.Columns.Add("Thực Lĩnh", typeof(string));
            //data.DataSource = Luong;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            txtmaluong.Text = TienLuong_BLL.SinhMa("BangLuong", "MaLuong");
            txtmaluong.Enabled = false;
        }
    }

}
