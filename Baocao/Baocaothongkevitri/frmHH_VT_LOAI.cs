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
    public partial class frmHH_VT_LOAI : Form
    {
        public frmHH_VT_LOAI()
        {
            InitializeComponent();
        }

        private void frmHH_VT_LOAI_Load(object sender, EventArgs e)
        {
            this.sp_viewVTHHTHEOLOAITableAdapter.Fill(this.dS_VITRI_HANGHOA_LOAI_PARA.sp_viewVTHHTHEOLOAI, FrmThongkehanghoataicacvitri.MaLoai);
            this.rvHH_VT_LOAI.RefreshReport();
            //rvHH_VT_LOAI.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
