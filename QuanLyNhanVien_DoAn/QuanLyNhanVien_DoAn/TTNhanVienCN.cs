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
using System.IO;
using System.Data.SqlClient;
using DAL;

namespace QuanLyNhanVien_DoAn
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True");
        //TTNhanVienCN_BLL TTNhanVienCN_BLL = new TTNhanVienCN_BLL();
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        public UserControl1( TaiKhoan acc)
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
        void LoadData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From ThongTinNhanVienCN1", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            data.DataSource = dt;
            con.Close();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadData();
            cbmanv.DataSource = TTNhanVienCB_BLL.TTNhanVienCB_Select();
            cbmanv.DisplayMember = "MaNV";
            cbmanv.ValueMember = "MaNV";

        }
        byte[] ImageToByteArray(Image img1)
        {
            MemoryStream m = new MemoryStream();
            img1.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
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

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txthoten.Text = ((DataRowView)cbmanv.SelectedItem)[3].ToString();
        }


        private void butshow_Click(object sender, EventArgs e)
        {
            //data.DataSource = TTNhanVienCN_BLL.TTNhanVienCN_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pictureBox1.Image);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ThongTinNhanVienCN1 values(@MaNV,@HoTen,@DiaChi,@QueQuan,@SDT,@TrinhDoNN,@HocVan,@email,@HinhAnh)", con);
            cmd.Parameters.Add("@MaNV", cbmanv.Text);
            cmd.Parameters.Add("@HoTen", txthoten.Text);
            cmd.Parameters.Add("@DiaChi", txtdiachi.Text);
            cmd.Parameters.Add("@QueQuan", txtquequan.Text);
            cmd.Parameters.Add("@SDT", txtsdt.Text);
            cmd.Parameters.Add("@TrinhDoNN", txttdnn.Text);
            cmd.Parameters.Add("@HocVan", txthocvan.Text);
            cmd.Parameters.Add("@email", txtemail.Text);
            cmd.Parameters.Add("@HinhAnh", b);

            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Lưu về cơ sở dư liệu đã thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //TTNhanVienCN_BLL.TTNhanVienCN_Insert(cbmanv.Text, txthoten.Text,txtdiachi.Text,txtquequan.Text,txtsdt.Text,txttdnn.Text,txthocvan.Text,txtemail.Text);
            //butshow_Click(sender, e);
        }
        private void butsua_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pictureBox1.Image);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ThongTinNhanVienCN1 SET HoTen=@HoTen,DiaChi=@DiaChi,QueQuan=@QueQuan,SDT=@SDT,TrinhDoNN=@TrinhDoNN,HocVan=@HocVan,email=@email,HinhAnh=@HinhAnh where MaNV=@MaNV", con);
            cmd.Parameters.Add("@MaNV", cbmanv.Text);
            cmd.Parameters.Add("@HoTen", txthoten.Text);
            cmd.Parameters.Add("@DiaChi", txtdiachi.Text);
            cmd.Parameters.Add("@QueQuan", txtquequan.Text);
            cmd.Parameters.Add("@SDT", txtsdt.Text);
            cmd.Parameters.Add("@TrinhDoNN", txttdnn.Text);
            cmd.Parameters.Add("@HocVan", txthocvan.Text);
            cmd.Parameters.Add("@email", txtemail.Text);
            cmd.Parameters.Add("@HinhAnh", b);

            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Lưu về cơ sở dư liệu đã thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //TTNhanVienCN_BLL.TTNhanVienCN_Update(cbmanv.Text, txthoten.Text, txtdiachi.Text, txtquequan.Text, txtsdt.Text, txttdnn.Text, txthocvan.Text, txtemail.Text);
            //butshow_Click(sender, e);
        }
        Image ImageToByteArray(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       

        private void butxoa_Click(object sender, EventArgs e)
        {
            //DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (key == System.Windows.Forms.DialogResult.Yes)
            //{
            //    TTNhanVienCN_BLL.TTNhanVienCN_Delete(cbmanv.Text);
            //    butshow_Click(sender, e);
            //}

            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                byte[] b = ImageToByteArray(pictureBox1.Image);
                string SQL;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I7BIPV1\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True");
                SQL = " Delete from ThongTinNhanVienCN1  where MaNV = N'" + cbmanv.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                LoadData();
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = data.CurrentCell.RowIndex;
            cbmanv.Text = data.Rows[r].Cells[0].Value.ToString();
            txthoten.Text = data.Rows[r].Cells[1].Value.ToString();
            txtdiachi.Text = data.Rows[r].Cells[2].Value.ToString();
            txtquequan.Text = data.Rows[r].Cells[3].Value.ToString();
            txtsdt.Text = data.Rows[r].Cells[4].Value.ToString();
            txttdnn.Text = data.Rows[r].Cells[5].Value.ToString();
            txthocvan.Text = data.Rows[r].Cells[6].Value.ToString();
            txtemail.Text = data.Rows[r].Cells[7].Value.ToString();
            byte[] b = (byte[])data.Rows[r].Cells[8].Value;
            pictureBox1.Image = ImageToByteArray(b);
        }
    }
}
