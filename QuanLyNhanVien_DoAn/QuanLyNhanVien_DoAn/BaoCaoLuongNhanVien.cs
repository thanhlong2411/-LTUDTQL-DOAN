using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyNhanVien_DoAn
{
    public partial class BaoCaoLuongNhanVien : Form
    {
        TienLuong_BLL TienLuong_BLL = new TienLuong_BLL();
        public BaoCaoLuongNhanVien()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BaoCaoBangLuong rpt = new BaoCaoBangLuong();
            rpt.SetDataSource(TienLuong_BLL.BanLuong_Select());
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
