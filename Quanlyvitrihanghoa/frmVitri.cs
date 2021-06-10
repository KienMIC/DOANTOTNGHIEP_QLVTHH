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
        //public String[] Gvalue = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
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
        public int R = 206, G = 246, B = 203; //227, 239, 255
        public string color_str = "";
        public string NgayGioHienTai = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        public string MaNV = Quanlyhethong.XtraFormDangNhap.MaNV;
        public string vtBD = "";
        public string vtKT = "";
        public string HanhDong = "";


        clsCRUD cRUD = new clsCRUD();
        public DataTable dataTable = new DataTable();
        List<String> list_pos = new List<string>();

        String hd = "";
        String[] headname = {
            "Mã hàng hóa: " ,
            "Tên hàng hóa: " ,
            "Loại hàng hóa: " ,
            "Đơn vị tính: " ,
            "Thời gian bắt đầu: " ,
            "Thời gian kết thúc:" ,
            "Trạng thái hàng hóa: " ,
            "Khách hàng: "
        };



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

                    table.Controls.Add(label, i, j);

                }
            }

        }

        //date 6/6/2021
        protected void CusClick(object sender, EventArgs e)
        {
            //Hiển thị vị trí hiện tại
            String[] arr = ((Label)sender).Name.Split('_');

            cbG.Text = arr[1];
            cbT.Text = "0" + arr[2];
            cbN.Text = "00" + arr[3];

            /*
            for (int i = 0; i < Gvalue.Length; i++)
            {
                if (arr[1] == Gvalue[i]) cbG.SelectedIndex = i;
            }

            int rs1, rs2;
            Int32.TryParse(arr[2], out rs1);
            Int32.TryParse(arr[3], out rs2);

            cbT.SelectedIndex = rs1 - 1;
            cbN.SelectedIndex = rs2 - 1;
            */

            //

            String pos = arr[1] + "-" + arr[2] + "-" + arr[3];

            //Thao tác ui và chuẩn bị dữ liệu cho thêm sửa xóa
            if (checkLock.Checked == true)
            {
                if (hd == "Them")
                {
                    HanhDong = "Thêm";
                    list_pos.Add(pos);
                    ((Label)sender).BackColor = lb_Color.BackColor;
                }
                if (hd == "Sua")
                {
                    HanhDong = "Đảo chuyển";
                    if (vtBD == "")
                    {
                        vtBD = pos;
                        //MessageBox.Show(pos);
                        ((Label)sender).BackColor = Color.FromArgb(206, 246, 203);
                    }
                    else
                    {
                        vtKT = pos;
                        ((Label)sender).BackColor = lb_Color.BackColor;
                    }
                }
                if (hd == "Xoa")
                {
                    HanhDong = "Xóa";
                    list_pos.Add(pos);
                    ((Label)sender).BackColor = Color.FromArgb(206, 246, 203);
                }
                return;
            };
            //

            if (dataTable == null) return;

            //load_LabelINFO(null);

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[9].ToString() == pos)
                {
                    //xử lí dữ liệu và load lên label info
                    String[] data = new string[8];
                    for (int i = 0; i < 8; i++)
                    {
                        if (i != 4 && i != 5)
                        {
                            if (i < 2) data[i] = row[i].ToString();
                            else data[i] = row[i + 1].ToString();
                        }
                        else
                        {
                            DateTime dt = (DateTime)row[i + 1];
                            data[i] = dt.ToString("dd/MM/yyyy");
                        }
                    }
                    load_LabelINFO(data);
                    //

                    //Đưa màu ra label
                    if (row[10].ToString() != "")
                    {
                        String[] argb = row[10].ToString().Split(',');
                        int[] rgb = new int[3];

                        Int32.TryParse(argb[0], out rgb[0]);
                        Int32.TryParse(argb[1], out rgb[1]);
                        Int32.TryParse(argb[2], out rgb[2]);

                        lb_Color.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                    }
                    //
                    break;

                }
                else
                {
                    load_LabelINFO(null);
                    lb_Color.BackColor = Color.FromArgb(227, 239, 255);
                }

            }
        }

        //date 06/06/2021
        protected void frmVitri_Load(object sender, EventArgs e)
        {

            loadForm();
            loadcb();
        }

        public void loadForm()
        {
            String sql = "SELECT * FROM VT_HH_CL";
            dataTable = cRUD.getData(sql);
            loadData_VT(dataTable, "MaHH");


            load_LabelINFO(null);
            reset_cb();
            reset_varible();

            checkLock.Checked = false;
            btnChonHangHoa.Enabled = true;
            setButton("00001");
        }

        public void reset_varible()
        {
            hd = vtBD = vtKT = "";
            list_pos.Clear();
        }

        public void reset_cb()
        {
            cbG.ResetText();
            cbN.ResetText();
            cbT.ResetText();
            cbHead.ResetText();
            cbData.DataSource = null;
        }

        public void setButton(String code)
        {
            int i = 0;
            foreach (var control in groupBox2.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (code[i] == '1') control.Enabled = true;
                else control.Enabled = false;
                i++;
            }
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
            String[] info =
            {
                frmChonHangHoa.MaHH,
                frmChonHangHoa.TenHH,
                frmChonHangHoa.MaLoai,
                frmChonHangHoa.MaDVT,
                frmChonHangHoa.BatDauLuuTru.ToString("dd/MM/yyyy"),
                frmChonHangHoa.KetThucLuuTru.ToString("dd/MM/yyyy"),
                frmChonHangHoa.TrangThai,
                frmChonHangHoa.MaKH
            };
            load_LabelINFO(info);
            /*
            lb_MaHH.Text = "Mã hàng hóa: " + frmChonHangHoa.MaHH;
            lb_TenHH.Text = "Tên hàng hóa: " + frmChonHangHoa.TenHH;
            lb_loaiHH.Text = "Loại hàng hóa: " + frmChonHangHoa.MaLoai;
            lb_DVT.Text = "Đơn vị tính: " + frmChonHangHoa.MaDVT;
            lb_tgBD.Text = "Thời gian lưu trữ: " + frmChonHangHoa.BatDauLuuTru.ToString("dd/MM/yyyy") + " - " + frmChonHangHoa.KetThucLuuTru.ToString("dd/MM/yyyy");
            lb_TrangThai.Text = "Trạng thái hàng hóa: " + frmChonHangHoa.TrangThai;
            lb_Khachhang.Text = "Khách hàng: " + frmChonHangHoa.MaKH;
            */
        }

        //date 03/06/2021
        public void loadcb()
        {
            String sql = "Select * from HH";
            DataTable table = cRUD.getData(sql);

            String[] display = { "Mã hàng hóa", "Tên hàng hóa", "Tồn kho", "Tên loại", "Đơn vị tính", "Bắt đầu lưu trữ", "Kết thúc lưu trữ", "Tên khách hàng", "Màu sắc" };
            int i = 0;


            foreach (DataColumn column in table.Columns)
            {
                if (column.ColumnName.ToString() != "TrangThai")
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = display[i];
                    item.Value = column.ColumnName.ToString();

                    cbHead.Items.Add(item);
                    i++;
                }
            }
        }

        private void checkLock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLock.Checked == true)
            {
                setButton("11101");
                btnChonHangHoa.Enabled = false;
            }
            else
            {
                btnChonHangHoa.Enabled = true;
                setButton("00001");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hd = "Them";
            setButton("10011");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hd = "Xoa";
            setButton("00111");
        }

        private void btnThucThi_Click(object sender, EventArgs e)
        {
            if (hd == "Them") ThemVT();
            if (hd == "Sua") SuaVT();
            if (hd == "Xoa") XoaVT();
            loadForm();
        }

        public void ThemVT()
        {
            String[] value = lb_MaHH.Text.Split(' ');
            String MaHH = value[3];
            string sql2 = "UPDATE HANG_HOA SET TrangThai = N'Đã lưu kho' WHERE MaHH = '" + frmChonHangHoa.MaHH + "'";

            for (int i = 0; i < list_pos.Count(); i++)
            {
                string TrangThai = "Đã có hàng";
                string sql1 = "sp_themVT '" + MaHH + "','" + list_pos[i] + "','" + TrangThai + "'";
                if (cRUD.Them_sua_xoa(sql1))
                {
                    cRUD.Them_sua_xoa(sql2); //sql1thực hiện thành công -> Đã lưu kho
                }
                string sql3 = "INSERT INTO LICHSU_VITRI(MaHH,MaNV,ToaDoBanDau,NgayGio,HanhDong) VALUES('" + MaHH + "','" + MaNV + "','" + list_pos[i] + "','" + NgayGioHienTai + "',N'" + HanhDong + "')";
                cRUD.Them_sua_xoa(sql3);
            }

        }
        public void SuaVT()
        {
            String[] value = lb_MaHH.Text.Split(' ');
            String MaHH = value[3];
            string TrangThai = "Đã có hàng";

            string sql1 = "sp_suaVT '" + MaHH + "','" + vtBD + "','" + vtKT + "','" + TrangThai + "'";
            string sql2 = "INSERT INTO LICHSU_VITRI(MaHH,MaNV,ToaDoBanDau,ToaDoSauCung,NgayGio,HanhDong) VALUES('" + MaHH + "','" + MaNV + "','" + vtBD + "','" + vtKT + "','" + NgayGioHienTai + "',N'" + HanhDong + "')";
            cRUD.Them_sua_xoa(sql1);
            cRUD.Them_sua_xoa(sql2);
        }
        public void XoaVT()
        {
            for (int i = 0; i < list_pos.Count(); i++)
            {
                String[] value = lb_MaHH.Text.Split(' ');
                String MaHH = value[3];
                cRUD.Them_sua_xoa("sp_xoaVT'" + list_pos[i] + "'");
                string sql2 = "INSERT INTO LICHSU_VITRI(MaHH,MaNV,ToaDoBanDau,NgayGio,HanhDong) VALUES('" + MaHH + "','" + MaNV + "','" + list_pos[i] + "','" + NgayGioHienTai + "',N'" + HanhDong + "')";
                cRUD.Them_sua_xoa(sql2);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            hd = "Sua";
            setButton("01011");
        }

        //date 03/06/2021
        private void cbHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = (cbHead.SelectedItem as ComboboxItem).Value.ToString();
            String sql = "Select DISTINCT " + value + " from VT_HH_CL";
            DataTable table = cRUD.getData(sql);

            //MessageBox.Show(value);

            cbData.DataSource = table;
            cbData.ValueMember = value;
            cbData.DisplayMember = value;
            cbData.ResetText();

        }

        //date 03/06/2021
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DataTable table = dataTable;
            try
            {
                String value = (cbHead.SelectedItem as ComboboxItem).Value.ToString();
                if (cbData.Text != "")
                {
                    String sql = value + " = " + "'" + cbData.Text + "'";
                    table = table.Select(sql).CopyToDataTable();
                    //table = table.Select(sql).
                }
                loadData_VT(table, value);
            }
            catch
            {
                //
            }

        }

        //date 6/6/2021
        public void load_LabelINFO(String[] info)
        {
            Label[] lb = { lb_MaHH, lb_TenHH, lb_loaiHH, lb_DVT, lb_tgBD, lb_tgKT, lb_TrangThai, lb_Khachhang };
            if (info == null)
            {
                for (int i = 0; i < lb.Length; i++)
                {
                    lb[i].Text = headname[i];
                }
            }
            else
            {
                for (int i = 0; i < lb.Length; i++)
                {
                    lb[i].Text = headname[i] + info[i];
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnChonHangHoa_Click(object sender, EventArgs e)
        {
            frmChonHangHoa frm = new frmChonHangHoa();
            frm.ShowDialog();
            string Color_str = frmChonHangHoa.Color_str;
            string Color_str_2 = frmThemMauSac_ChonHangHoa.color_str;
            if (Color_str != "")
            {
                String[] argb = Color_str.Split(',');
                int[] rgb = new int[3];
                Int32.TryParse(argb[0], out rgb[0]);
                Int32.TryParse(argb[1], out rgb[1]);
                Int32.TryParse(argb[2], out rgb[2]);

                R = rgb[0];
                G = rgb[1];
                B = rgb[2];

                lb_Color.BackColor = Color.FromArgb(R, G, B);
            }
            else
            {

                String[] argb = Color_str_2.Split(',');
                int[] rgb = new int[3];
                Int32.TryParse(argb[0], out rgb[0]);
                Int32.TryParse(argb[1], out rgb[1]);
                Int32.TryParse(argb[2], out rgb[2]);

                R = rgb[0];
                G = rgb[1];
                B = rgb[2];

                lb_Color.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void btnChonMauSac_Click(object sender, EventArgs e)
        {

            frmQuanLyMauSac frm = new frmQuanLyMauSac();
            frm.ShowDialog();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
