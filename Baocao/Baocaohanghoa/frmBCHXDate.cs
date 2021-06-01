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
    public partial class frmBCHXDate : Form
    {
        public frmBCHXDate()
        {
            InitializeComponent();
        }

        private void frmBCHXDate_Load(object sender, EventArgs e)
        {
            this.sp_viewBCHXTableAdapter.Fill(this.bCHX_PARA.sp_viewBCHX, FrmBaocaohangxuat.TuNgay, FrmBaocaohangxuat.DenNgay);
            this.rvBCHNDate.RefreshReport();
            rvBCHNDate.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
