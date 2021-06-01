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
    public partial class frmLichSuViTri : Form
    {
        public frmLichSuViTri()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
        public void taiDuLieu()
        {
            sql = "SELECT * FROM LS_VITRI";
            dgvLichSu.DataSource = cls.getData(sql);
            dgvLichSu.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void frmLichSuViTri_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            taiDuLieu();
        }
    }
}
