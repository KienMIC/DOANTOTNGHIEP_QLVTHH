using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1.Quanlyvitrihanghoa
{
    public partial class frmThemMauSac : Form
    {
        public frmThemMauSac()
        {
            InitializeComponent();
        }
        public string sql = "", color_str = "";
        int R, G, B;
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_themCL '" + color_str + "','" + cbHangHoa.SelectedValue.ToString() + "'";
            if (cls.Them_sua_xoa(sql))
                DevExpress.XtraEditors.XtraMessageBox.Show("Thêm thành công!","Thông báo");
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Màu sắc này đã được chọn hoặc hàng hóa này đã được thiết lập màu!", "Thông báo");
            (System.Windows.Forms.Application.OpenForms["frmQuanLyMauSac"] as frmQuanLyMauSac).taiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void cb_HangHoa()
        {
            sql = "SELECT MaHH,TenHH FROM HANG_HOA";
            cbHangHoa.DataSource = cls.getData(sql);
            cbHangHoa.DisplayMember = "TenHH";
            cbHangHoa.ValueMember = "MaHH";
        }
        private void frmThemMauSac_Load(object sender, EventArgs e)
        {
            cb_HangHoa();
        }

        private void btnChonMauSac_Click(object sender, EventArgs e)
        {
            ColorDialog clg = new ColorDialog();
            if (clg.ShowDialog() == DialogResult.OK)
            {
                R = clg.Color.R;
                G = clg.Color.G;
                B = clg.Color.B;
                color_str = R + "," + G + "," + B;
                txtColor.BackColor = Color.FromArgb(R, G, B);
            }
        }
    }
}
