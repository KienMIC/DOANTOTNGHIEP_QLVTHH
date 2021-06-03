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
    public partial class frmBCTTHH_Loai : Form
    {
        public frmBCTTHH_Loai()
        {
            InitializeComponent();
        }

        private void frmBCTTHH_Loai_Load(object sender, EventArgs e)
        {
            this.sp_viewHHTHEOLOAITableAdapter.Fill(this.bCHH_THEOLOAI_PARA.sp_viewHHTHEOLOAI, frmBaoCaoThongTinHH.MaLoai);
            this.rvBCHH_THEOLOAI.RefreshReport();
            //rvBCHH_THEOLOAI.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
