using DoAn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1.SQLClass;



namespace DoAn1.Quanlyvitrihanghoa
{
    public partial class frmVitri : Form
    {
        public String[] Gvalue = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
        public frmVitri()
        {
            InitializeComponent();
            foreach (Control control in panel1.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    TableLayoutPanel table = (TableLayoutPanel)control;
                    LoadLabel_TableCell(table, control.Name);
                }
            }

        }
        public int R = 206, G = 246, B = 203;
        public string color_str = "";
        public string NgayGioHienTai = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        public static string MaVT = "null", MaHH = "", IDColor = "", ToaDo = "", ToaDoBanDau = "";
        public string MaNV = FrmDangnhap.MaNV;
        clsCRUD cRUD = new clsCRUD();
        public DataTable dataTable = new DataTable();

        public void LoadLabel_TableCell(TableLayoutPanel table, String tbname)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    String lbname = "lb_" + tbname[3] + "_" + Math.Abs(j - 4).ToString() + "_" + (i + 1).ToString();

                    Label label = new Label()
                    {
                        Font = new Font("Arial", 8),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.FromArgb(206, 246, 203),
                        Name = lbname,
                    };

                    label.Click += CusClick;
                    label.DoubleClick += CusDoubleClick;
                    label.MouseUp += CusRightClick;


                    table.Controls.Add(label, i, j);

                }
            }

        }

        //date 22/5/2021
        protected void CusClick(object sender, EventArgs e)
        {
            String[] arr = ((Label)sender).Name.Split('_');
            for (int i = 0; i < Gvalue.Length; i++)
            {
                if (arr[1] == Gvalue[i]) cbG.SelectedIndex = i;
            }

            int rs1, rs2;
            Int32.TryParse(arr[2], out rs1);
            Int32.TryParse(arr[3], out rs2);

            cbT.SelectedIndex = rs1 - 1;
            cbN.SelectedIndex = rs2 - 1;

            String pos = arr[1] + "-" + arr[2] + "-" + arr[3];
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[9].ToString() == pos)
                    {
                        DateTime bd = (DateTime)row[5];
                        DateTime kt = (DateTime)row[6];
                        lb_MaHH.Text = "Mã hàng hóa: " + row[0];
                        lb_TenHH.Text = "Tên hàng hóa: " + row[1];
                        lb_loaiHH.Text = "Loại hàng hóa: " + row[3];
                        lb_DVT.Text = "Đơn vị tính: " + row[4];
                        lb_ThoiGian.Text = "Thời gian lưu trữ: " + bd.ToString("dd/MM/yyyy") + " - " + kt.ToString("dd/MM/yyyy");
                        lb_TrangThai.Text = "Trạng thái hàng hóa: " + row[7];
                        lb_Khachhang.Text = "Khách hàng: " + row[8];
                        MaVT = row[11].ToString();
                        MaHH = row[0].ToString();
                        IDColor = row[12].ToString();
                        ToaDoBanDau = row[9].ToString();

                        //KIEN UPDATE: Lay gia tri mau ngay tai o duoc click
                        String[] argb = row[10].ToString().Split(',');
                        int[] rgb = new int[3];
                        try
                        {
                            Int32.TryParse(argb[0], out rgb[0]);
                            Int32.TryParse(argb[1], out rgb[1]);
                            Int32.TryParse(argb[2], out rgb[2]);
                        }
                        catch(Exception ex)
                        {
                            //
                        }
                        R = rgb[0];
                        G = rgb[1];
                        B = rgb[2];

                        //string str = R + "," + G + "," + B;
                        //MessageBox.Show(str);
                        break;
                    }
                    else
                    {
                        lb_MaHH.Text = "Mã hàng hóa: ";
                        lb_TenHH.Text = "Tên hàng hóa: ";
                        lb_loaiHH.Text = "Loại hàng hóa: ";
                        lb_DVT.Text = "Đơn vị tính: ";
                        lb_ThoiGian.Text = "Thời gian lưu trữ: ";
                        lb_TrangThai.Text = "Trạng thái hàng hóa: ";
                        lb_Khachhang.Text = "Khách hàng: ";
                    }
                }
            }
        }

        protected void CusDoubleClick(object sender, EventArgs e)
        {

            ((Label)sender).BackColor = Color.FromArgb(R, G, B); // Click đúp để đổi màu, xác định đối tượng được chọn để set vị trí
        }

        protected void CusRightClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right) // Click phải để xóa vị trí
            {
                //((Label)sender).BackColor = Color.FromArgb(206, 246, 203);
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cRUD.Them_sua_xoa("sp_xoaVT'" + MaVT + "'");
                    cRUD.Them_sua_xoa("sp_xoaCL'" + IDColor + "'");
                    dataTable = cRUD.getData("SELECT * FROM VT_HH_CL");
                    loadData_VT(dataTable, "MaHH");
                }
            }
        }

        //date 30/05/2021
        protected void frmVitri_Load(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM VT_HH_CL";
            dataTable = cRUD.getData(sql);

            loadData_VT(dataTable, "MaHH");
            loadcb();
        }

        //date 30/05/2021
        public void loadData_VT(DataTable table, String headData)
        {
            if (table == null) return;
            reset_VT();

            foreach (DataRow row in table.Rows)
            {
                String[] vitri = row[9].ToString().Split('-');

                TableLayoutPanel TLP = panel1.Controls.Find("tLP" + vitri[0], false).FirstOrDefault() as TableLayoutPanel;
                if (TLP != null)
                {
                    //MessageBox.Show("lb_" + rs[0] + "_" + rs[1] + "_" + rs[2]);
                    Label label = TLP.Controls.Find("lb_" + vitri[0] + "_" + vitri[1] + "_" + vitri[2], false).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = row[headData].ToString();
                        if (row[10].ToString() != "")
                        {
                            //MessageBox.Show(row[10].ToString());
                            String[] argb = row[10].ToString().Split(',');

                            int[] rgb = new int[3];

                            Int32.TryParse(argb[0], out rgb[0]);
                            Int32.TryParse(argb[1], out rgb[1]);
                            Int32.TryParse(argb[2], out rgb[2]);


                            label.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                        }
                    }
                }
            }

        }

        //date 30/05/2021
        public void reset_VT()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    TableLayoutPanel table = (TableLayoutPanel)control;
                    foreach (Control ct in table.Controls)
                    {
                        if (ct is Label)
                        {
                            Label label = (Label)ct;
                            label.Text = "";
                            label.BackColor = Color.FromArgb(206, 246, 203);
                        }
                    }
                }
            }
        }

        public void loadLabel()
        {
            lb_MaHH.Text = "Mã hàng hóa: " + frmChonHangHoa.MaHH;
            lb_TenHH.Text = "Tên hàng hóa: " + frmChonHangHoa.TenHH;
            lb_loaiHH.Text = "Loại hàng hóa: " + frmChonHangHoa.MaLoai;
            lb_DVT.Text = "Đơn vị tính: " + frmChonHangHoa.MaDVT;
            lb_ThoiGian.Text = "Thời gian lưu trữ: " + frmChonHangHoa.BatDauLuuTru.ToString("dd/MM/yyyy") + " - " + frmChonHangHoa.KetThucLuuTru.ToString("dd/MM/yyyy");
            lb_TrangThai.Text = "Trạng thái hàng hóa: " + frmChonHangHoa.TrangThai;
            lb_Khachhang.Text = "Khách hàng: " + frmChonHangHoa.MaKH;
        }

        //date 28/05/2021
        public void loadcb()
        {
            String sql = "Select * from HH";
            DataTable table = cRUD.getData(sql);

            foreach (DataColumn column in table.Columns)
            {
                cbHead.Items.Add(column.ColumnName);
            }
            //cbHead.ValueMember = table.Rows[0];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData_VT(dataTable, "MaHH");
        }

        //date 29/05/2021
        private void cbHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = cbHead.SelectedItem.ToString();
            String sql = "Select DISTINCT "+value+" from HH";
            DataTable table = cRUD.getData(sql);

            MessageBox.Show(value);
            cbData.DataSource = table;
            cbData.ValueMember = value;
            cbData.DisplayMember = value;
            cbData.ResetText();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MaVT == "null") // Thêm vị trí
            {
                int T = cbT.SelectedIndex + 1;
                int N = cbN.SelectedIndex + 1;
                ToaDo = cbG.Text + "-" + T + "-" + N;
                string TrangThai = "Đã có hàng";
                string sql1 = "sp_themVT '" + frmChonHangHoa.MaHH + "','" + ToaDo + "','" + TrangThai + "'";
                string sql2 = "sp_themCL '" + color_str + "','" + frmChonHangHoa.MaHH + "'";
                string sql3 = "UPDATE HANG_HOA SET TrangThai = N'Đã lưu kho' WHERE MaHH = '" + frmChonHangHoa.MaHH + "'";
                if (cRUD.Them_sua_xoa(sql1))
                {
                    if (cRUD.Them_sua_xoa(sql2))
                    {
                        cRUD.Them_sua_xoa(sql3); //sql1 + sql2 thực hiện thành công -> Đã lưu kho
                    }
                    
                }
                String sql = "SELECT * FROM VT_HH_CL";
                dataTable = cRUD.getData(sql);
                loadData_VT(dataTable, "MaHH");
            }
            else // Sửa vị trí
            {
                int T = cbT.SelectedIndex + 1;
                int N = cbN.SelectedIndex + 1;
                ToaDo = cbG.Text + "-" + T + "-" + N;
                string TrangThai = "Đã có hàng";
                string sql1 = "sp_suaVT '" + MaVT + "','" + MaHH + "','" + ToaDo + "','" + TrangThai + "'";
                string sql2 = "UPDATE COLOR_HANGHOA SET Color = '" + color_str + "' WHERE ID = '" + IDColor + "'";
                string sql3 = "INSERT INTO LICHSU_VITRI(MaHH,MaNV,ToaDoBanDau,ToaDoSauCung,NgayGio) VALUES('" + MaHH + "','" + MaNV + "','" + ToaDoBanDau +"','" + ToaDo + "','"+NgayGioHienTai+"')";
                cRUD.Them_sua_xoa(sql1);
                cRUD.Them_sua_xoa(sql2);
                if(ToaDo != ToaDoBanDau)
                {
                    cRUD.Them_sua_xoa(sql3); // Lưu lịch sử vị trí 
                }
                
                String sql = "SELECT * FROM VT_HH_CL";
                dataTable = cRUD.getData(sql);
                loadData_VT(dataTable, "MaHH");
                MaVT = "null";
            }
        }

        //date 30/05/2021
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DataTable table = dataTable;

            if (cbData.Text != "")
            {
                String sql = cbHead.SelectedItem.ToString() + " = " + "'" + cbData.Text + "'";
                //MessageBox.Show(sql);
                try
                {
                    table = table.Select(sql).CopyToDataTable();
                }catch(Exception ex)
                {
                    MessageBox.Show("Không tìm thấy hàng hóa đó!");
                }
                

            }
            loadData_VT(table, cbHead.SelectedItem.ToString());
        }

        private void btnChonHangHoa_Click(object sender, EventArgs e)
        {
            frmChonHangHoa frm = new frmChonHangHoa();
            frm.ShowDialog();
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
                //MessageBox.Show(color_str);
            }
        }
    }
}
