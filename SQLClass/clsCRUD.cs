using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DoAn1.SQLClass
{
    class clsCRUD
    {
        public DataTable getData(string sql)
        {
            clsKetNoi cn = new clsKetNoi();
            cn.KetNoi();
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter dta = new SqlDataAdapter(sql, cn.con);
                dta.Fill(ds, sql);
                DataTable tbl = ds.Tables[0];
                if(tbl.Rows.Count != 0)
                    return tbl;
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Them_sua_xoa(string sql)
        {
            clsKetNoi cn = new clsKetNoi();
            try
            {
                cn.KetNoi();
                SqlCommand cmd = new SqlCommand(sql, cn.con);
                cmd.ExecuteNonQuery();
                cn.DongKetNoi();
                return true;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                return false;
                
            }
        }
    }
}
