using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace QuanLyNhanVien_DoAn
{
    public partial class FrMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrMain()
        {
            InitializeComponent();
        }
        private TaiKhoan account;
        public FrMain(TaiKhoan acc)
        {
            InitializeComponent();
            account = acc;
            ChangeAccount();

        }
        void ChangeAccount()
        {
            ribbonTabChucNang.Enabled = account.Type == 1;
            ribbonTabQuanLy.Enabled = account.Type == 1;
               ribbonBar6.Text += $" ({account.DisplayName})";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            this.Width = 850;
            this.Height = 620;
            QuanLyNhanVien_DoAn.TTNhanVienCB ctnhanvien = new QuanLyNhanVien_DoAn.TTNhanVienCB(account);
            panel_show.Controls.Clear();
            panel_show.Controls.Add(ctnhanvien);
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            this.Width = 970;
            this.Height = 655;
            QuanLyNhanVien_DoAn.UserControl1 tklslv = new QuanLyNhanVien_DoAn.UserControl1(account);
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }
        private void buttonItem13_Click(object sender, EventArgs e)
        {
            this.Width = 690;
            this.Height = 610;
            QuanLyNhanVien_DoAn.BoPhan tklslv = new QuanLyNhanVien_DoAn.BoPhan();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            this.Width = 720;
            this.Height = 580;
            QuanLyNhanVien_DoAn.PhongBan tklslv = new QuanLyNhanVien_DoAn.PhongBan();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            this.Width = 780;
            this.Height = 620;
            QuanLyNhanVien_DoAn.BaoHiem tklslv = new QuanLyNhanVien_DoAn.BaoHiem(account);
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem11_Click(object sender, EventArgs e)

        {
            this.Width = 780;
            this.Height = 620;
            QuanLyNhanVien_DoAn.TienLuong tklslv = new QuanLyNhanVien_DoAn.TienLuong(account);
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }
        private void buttonItem18_Click(object sender, EventArgs e)
        {
            this.Width = 760;
            this.Height = 590;
            QuanLyNhanVien_DoAn.TimKiem tklslv = new QuanLyNhanVien_DoAn.TimKiem();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            BaoCaoNhanSu fr = new BaoCaoNhanSu();
            fr.ShowDialog();
        }
        private void buttonItem20_Click(object sender, EventArgs e)
        {
            BaoCaoLuongNhanVien fr = new BaoCaoLuongNhanVien();
            fr.ShowDialog();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            this.Width = 780;
            this.Height = 600;
            QuanLyNhanVien_DoAn.HoSoThuViec tklslv = new QuanLyNhanVien_DoAn.HoSoThuViec();
            panel_show.Controls.Clear();
            panel_show.Controls.Add(tklslv);
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            BaoCaoTangLuongNV fr = new BaoCaoTangLuongNV();
            fr.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
