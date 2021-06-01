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
    public partial class FrmBaocaohangxuat : Form
    {
        public FrmBaocaohangxuat()
        {
            InitializeComponent();
        }
        public static DateTime TuNgay, DenNgay;
        private void FrmBaocaohangxuat_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLapBC_Click(object sender, EventArgs e)
        {
            if (rbFullBC.Checked)
            {
                frmBCHXAll f1 = new frmBCHXAll();
                f1.ShowDialog();
            }
            else if (rbDateBC.Checked)
            {
                TuNgay = dtpTuNgay.Value;
                DenNgay = dtpDenNgay.Value;
                frmBCHXDate f1 = new frmBCHXDate();
                f1.ShowDialog();
            }
        }
    }
}
