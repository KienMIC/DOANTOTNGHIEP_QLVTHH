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
    public partial class FrmBaocaoTTHHAll : Form
    {
        public FrmBaocaoTTHHAll()
        {
            InitializeComponent();
        }

        private void FrmBaocaohangton_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_HANGHOA.BC_HANGHOA' table. You can move, or remove it, as needed.
            this.bC_HANGHOATableAdapter.Fill(this.dS_HANGHOA.BC_HANGHOA);

            this.reportViewer1.RefreshReport();
            //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
