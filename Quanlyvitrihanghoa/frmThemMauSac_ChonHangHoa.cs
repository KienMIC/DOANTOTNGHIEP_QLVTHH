using DevExpress.XtraEditors;
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
    public partial class frmThemMauSac_ChonHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmThemMauSac_ChonHangHoa()
        {
            InitializeComponent();
        }
        public static string sql = "", color_str = "", TenHH = "";
        int R, G, B;

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

        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void frmThemMauSac_ChonHangHoa_Load(object sender, EventArgs e)
        {
            TenHH = frmChonHangHoa.TenHH;
            cb_HangHoa();
            cbHangHoa.Enabled = false;
            cbHangHoa.Text = TenHH;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_themCL '" + color_str + "','" + cbHangHoa.SelectedValue.ToString() + "'";
            if (cls.Them_sua_xoa(sql))
                DevExpress.XtraEditors.XtraMessageBox.Show("Thêm thành công!", "Thông báo");
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Màu sắc này đã được chọn hoặc hàng hóa này đã được thiết lập màu!", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cb_HangHoa()
        {
            sql = "SELECT MaHH,TenHH FROM HANG_HOA";
            cbHangHoa.DataSource = cls.getData(sql);
            cbHangHoa.DisplayMember = "TenHH";
            cbHangHoa.ValueMember = "MaHH";
        }
    }
}