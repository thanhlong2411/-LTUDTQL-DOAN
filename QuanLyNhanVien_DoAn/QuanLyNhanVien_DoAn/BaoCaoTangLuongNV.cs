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
    public partial class BaoCaoTangLuongNV : Form
    {
        TangLuong_BLL TangLuong_BLL = new TangLuong_BLL();
        public BaoCaoTangLuongNV()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BaoCaoBangTangLuongNV rpt = new BaoCaoBangTangLuongNV();
            rpt.SetDataSource(TangLuong_BLL.TangLuong_Select());
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
