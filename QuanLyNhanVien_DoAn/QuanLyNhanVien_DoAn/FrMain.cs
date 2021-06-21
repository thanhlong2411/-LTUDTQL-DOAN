using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhanVien_DoAn
{
    public partial class FrMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.TTNhanVienCB ctnhanvien = new QuanLyNhanVien_DoAn.TTNhanVienCB();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(ctnhanvien);
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.UserControl1 tklslv = new QuanLyNhanVien_DoAn.UserControl1();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }
        private void buttonItem13_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.BoPhan tklslv = new QuanLyNhanVien_DoAn.BoPhan();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.PhongBan tklslv = new QuanLyNhanVien_DoAn.PhongBan();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.BaoHiem tklslv = new QuanLyNhanVien_DoAn.BaoHiem();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.TienLuong tklslv = new QuanLyNhanVien_DoAn.TienLuong();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.TimKiem tklslv = new QuanLyNhanVien_DoAn.TimKiem();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            BaoCaoNhanSu fr = new BaoCaoNhanSu();
            fr.ShowDialog();
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabTraCuu_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            BaoCaoLuongNhanVien fr = new BaoCaoLuongNhanVien();
            fr.ShowDialog();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            FrDangNhap fr = new FrDangNhap();
            fr.ShowDialog();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_DoAn.HoSoThuViec tklslv = new QuanLyNhanVien_DoAn.HoSoThuViec();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            BaoCaoTangLuongNV fr = new BaoCaoTangLuongNV();
            fr.ShowDialog();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            FormDoiMK fr = new FormDoiMK();
            fr.ShowDialog();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
