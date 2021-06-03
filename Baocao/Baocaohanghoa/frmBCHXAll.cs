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
    public partial class frmBCHXAll : Form
    {
        public frmBCHXAll()
        {
            InitializeComponent();
        }

        private void frmBCHXAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_BAOCAOPHIEUXUAT.BC_HANGXUAT' table. You can move, or remove it, as needed.
            this.bC_HANGXUATTableAdapter.Fill(this.dS_BAOCAOPHIEUXUAT.BC_HANGXUAT);
            rvBCHXAll.RefreshReport();
            //rvBCHXAll.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

        }
    }
}
