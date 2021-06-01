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
    public partial class FrmThongkehanghoataicacvitri : Form
    {
        public FrmThongkehanghoataicacvitri()
        {
            InitializeComponent();
        }
        public static string sql = "", MaLoai = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public void cb_LoaiHang()
        {
            sql = "SELECT MaLoai,TenLoai FROM LOAI_HANGHOA";
            cbLoaiHang.DataSource = cls.getData(sql);
            cbLoaiHang.ValueMember = "MaLoai";
            cbLoaiHang.DisplayMember = "TenLoai";
        }
        private void FrmThongkehanghoataicacvitri_Load(object sender, EventArgs e)
        {
            cb_LoaiHang();
        }

        private void btnLapBC_Click(object sender, EventArgs e)
        {
            if (rbFullBC.Checked)
            {
                frmHH_VT_ALL f1 = new frmHH_VT_ALL();
                f1.ShowDialog();
            }
            else if (rbCatBC.Checked)
            {
                MaLoai = cbLoaiHang.SelectedValue.ToString();
                frmHH_VT_LOAI f1 = new frmHH_VT_LOAI();
                f1.ShowDialog();
            }
        }
    }
}
