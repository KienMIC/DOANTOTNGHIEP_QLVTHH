using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Baocao.Baocaothongkevitri
{
    public partial class frmHH_VT_ALL : Form
    {
        public frmHH_VT_ALL()
        {
            InitializeComponent();
        }

        private void frmHH_VT_ALL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_VITRI_HANGHOA.BC_VITRIHANGHOA' table. You can move, or remove it, as needed.
            this.bC_VITRIHANGHOATableAdapter.Fill(this.dS_VITRI_HANGHOA.BC_VITRIHANGHOA);
            rvHH_VT_ALL.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rvHH_VT_ALL.RefreshReport();
        }
    }
}
