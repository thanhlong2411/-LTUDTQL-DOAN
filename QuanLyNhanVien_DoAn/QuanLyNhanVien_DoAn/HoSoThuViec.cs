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
    public partial class HoSoThuViec : UserControl
    {
        HoSoThuViec_BLL HoSoThuViec_BLL = new HoSoThuViec_BLL();
        PhongBan_BLL PhongBan_BLL = new PhongBan_BLL();
        public HoSoThuViec()
        {
            InitializeComponent();
        }

        private void HoSoThuViec_Load(object sender, EventArgs e)
        {
            cbmaphong.DataSource = PhongBan_BLL.PhongBan_Select();
            cbmaphong.DisplayMember = "TenPhong";
            cbmaphong.ValueMember = "MaPhong";
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            data.DataSource = HoSoThuViec_BLL.HoSoThuViec_Select();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            HoSoThuViec_BLL.HoSoThuViec_Insert(cbmaphong.Text, txtmanhanvien.Text, txthoten.Text, DateTime.Parse(datetime.Value.ToString()), txtgioitinh.Text, txtdiachi.Text, txttrinhdo.Text, txtvitritv.Text);
            butshow_Click(sender, e);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            HoSoThuViec_BLL.HoSoThuViec_Update(cbmaphong.Text, txtmanhanvien.Text, txthoten.Text, DateTime.Parse(datetime.Value.ToString()), txtgioitinh.Text, txtdiachi.Text, txttrinhdo.Text, txtvitritv.Text);
            butshow_Click(sender, e);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn Chăc Chắn Muốn Xóa", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (key == System.Windows.Forms.DialogResult.Yes)
            {
                HoSoThuViec_BLL.HoSoThuViec_Delete(txtmanhanvien.Text);
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
            cbmaphong.Text = data[0, dong].Value.ToString();
            txtmanhanvien.Text = data[1, dong].Value.ToString();
            txthoten.Text = data[2, dong].Value.ToString();
            datetime.Value = DateTime.Parse(data[3, dong].Value.ToString());
            txtgioitinh.Text = data[4, dong].Value.ToString();
            txtdiachi.Text = data[5, dong].Value.ToString();
            txttrinhdo.Text = data[6, dong].Value.ToString();
            txtvitritv.Text = data[7, dong].Value.ToString();

        }
    }
}
