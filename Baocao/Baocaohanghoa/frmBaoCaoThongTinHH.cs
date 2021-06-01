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
    public partial class frmBaoCaoThongTinHH : Form
    {
        public frmBaoCaoThongTinHH()
        {
            InitializeComponent();
        }
        public static string MaLoai = "", MaKH = "";
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        public void cb_LoaiHang()
        {
            sql = "SELECT MaLoai,TenLoai FROM LOAI_HANGHOA";
            cbLoaiHang.DataSource = cls.getData(sql);
            cbLoaiHang.ValueMember = "MaLoai";
            cbLoaiHang.DisplayMember = "TenLoai";
        }

        public void cb_KhachHang()
        {
            sql = "SELECT MaKH,TenKH FROM KHACH_HANG";
            cbKhachHang.DataSource = cls.getData(sql);
            cbKhachHang.ValueMember = "MaKH";
            cbKhachHang.DisplayMember = "TenKH";
        }

        private void frmBaoCaoThongTinHH_Load(object sender, EventArgs e)
        {
            cb_KhachHang();
            cb_LoaiHang();
        }

        private void btnLapBC_Click(object sender, EventArgs e)
        {
            if (rbFullBC.Checked)
            {
                FrmBaocaoTTHHAll f1 = new FrmBaocaoTTHHAll();
                f1.ShowDialog();
            }
            else if (rbCatBC.Checked)
            {
                MaLoai = cbLoaiHang.SelectedValue.ToString();
                frmBCTTHH_Loai f1 = new frmBCTTHH_Loai();
                f1.ShowDialog();
            }
            else if (rbKHBC.Checked)
            {
                MaKH = cbKhachHang.SelectedValue.ToString();
                frmBCTTHH_KH f1 = new frmBCTTHH_KH();
                f1.ShowDialog();
            }
        }
    }
}
