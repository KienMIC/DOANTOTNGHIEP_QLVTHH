using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn1.SQLClass
{
    class clsKetNoi
    {
        public SqlConnection con = new SqlConnection();
        string ChuoiKetNoi = "Data Source = localhost\\sqlexpress" + ";Database=QLVTHH" + ";Integrated Security = True" + ";Connect Timeout=30" + ";User Instance=False";
        public bool KetNoi()
        {
            try
            {
                con = new SqlConnection(ChuoiKetNoi);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void DongKetNoi()
        {
            con.Close();
        }
    }
}
