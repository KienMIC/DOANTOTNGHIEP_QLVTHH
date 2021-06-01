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
    public partial class frmBCHNDate : Form
    {
        public frmBCHNDate()
        {
            InitializeComponent();
        }

        private void frmBCHNDate_Load(object sender, EventArgs e)
        {
            this.sp_viewBCHNTableAdapter.Fill(this.bCHN_PARA.sp_viewBCHN,FrmBaocaohangnhap.TuNgay,FrmBaocaohangnhap.DenNgay);
            this.rvBCHNDate.RefreshReport();
            rvBCHNDate.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
