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
    public partial class FrmBaocaohangnhap : Form
    {
        public FrmBaocaohangnhap()
        {
            InitializeComponent();
        }
        public static DateTime TuNgay, DenNgay;
        private void FrmBaocaohangnhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLapBC_Click(object sender, EventArgs e)
        {
            if (rbFullBC.Checked)
            {
                frmBCHNAll f1 = new frmBCHNAll();
                f1.ShowDialog();
            }
            else if (rbDateBC.Checked)
            {
                TuNgay = dtpTuNgay.Value;
                DenNgay = dtpDenNgay.Value;
                frmBCHNDate f1 = new frmBCHNDate();
                f1.ShowDialog();
            }
        }
    }
}
