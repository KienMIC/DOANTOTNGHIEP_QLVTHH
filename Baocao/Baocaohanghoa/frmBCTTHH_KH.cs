using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Baocao.Baocaohanghoa
{
    public partial class frmBCTTHH_KH : Form
    {
        public frmBCTTHH_KH()
        {
            InitializeComponent();
        }

        private void frmBCTTHH_KH_Load(object sender, EventArgs e)
        {
            this.sp_viewHHTHEOKHTableAdapter.Fill(this.bCHH_THEOKH_PARA.sp_viewHHTHEOKH, frmBaoCaoThongTinHH.MaKH);
            this.rvBCHH_KHACHHANG.RefreshReport();
            rvBCHH_KHACHHANG.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
