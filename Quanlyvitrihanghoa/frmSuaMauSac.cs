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
    public partial class frmSuaMauSac : Form
    {
        public frmSuaMauSac()
        {
            InitializeComponent();
        }

        public string sql = "", color_str = "";
        int R, G, B;
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

        private void frmSuaMauSac_Load(object sender, EventArgs e)
        {
            cb_HangHoa();
            cbHangHoa.Text = frmQuanLyMauSac.TenHH;
            color_str = frmQuanLyMauSac.Color_str;

            String[] argb = color_str.Split(',');
            int[] rgb = new int[3];
            Int32.TryParse(argb[0], out rgb[0]);
            Int32.TryParse(argb[1], out rgb[1]);
            Int32.TryParse(argb[2], out rgb[2]);

            R = rgb[0];
            G = rgb[1];
            B = rgb[2];

            txtColor.BackColor = Color.FromArgb(R, G, B);
        }

        public void cb_HangHoa()
        {
            sql = "SELECT MaHH,TenHH FROM HANG_HOA";
            cbHangHoa.DataSource = cls.getData(sql);
            cbHangHoa.DisplayMember = "TenHH";
            cbHangHoa.ValueMember = "MaHH";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "sp_suaCL '" + color_str + "','" + cbHangHoa.SelectedValue.ToString() + "'";
            if (cls.Them_sua_xoa(sql))
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công!", "Thông báo");
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Màu sắc này đã được chọn hoặc hàng hóa này đã được thiết lập màu!", "Thông báo");
            (System.Windows.Forms.Application.OpenForms["frmQuanLyMauSac"] as frmQuanLyMauSac).taiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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
