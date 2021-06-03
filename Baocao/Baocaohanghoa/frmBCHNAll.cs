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
    public partial class frmBCHNAll : Form
    {
        public frmBCHNAll()
        {
            InitializeComponent();
        }

        private void frmBCHNAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTHHDataSet.BC_HANGNHAP' table. You can move, or remove it, as needed.
            this.bC_HANGNHAPTableAdapter.Fill(this.qLVTHHDataSet.BC_HANGNHAP);

            this.rvBCHNAll.RefreshReport();
            //rvBCHNAll.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
