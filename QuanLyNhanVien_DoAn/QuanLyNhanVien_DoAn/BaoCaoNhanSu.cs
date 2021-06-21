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
    public partial class BaoCaoNhanSu : Form
    {
        TTNhanVienCB_BLL TTNhanVienCB_BLL = new TTNhanVienCB_BLL();
        public BaoCaoNhanSu()
        {
            InitializeComponent();
        }


        private void BaoCaoNhanSu_Load_1(object sender, EventArgs e)
        {
            NhanSu rpt = new NhanSu();
            rpt.SetDataSource(TTNhanVienCB_BLL.TTNhanVienCB_Select());
            crystalReportViewer1.ReportSource = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
