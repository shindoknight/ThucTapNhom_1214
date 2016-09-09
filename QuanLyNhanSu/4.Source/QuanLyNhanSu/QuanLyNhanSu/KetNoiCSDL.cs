using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyNhanSu
{
    class KetNoiCSDL
    {
        public static SqlConnection con = null;
        public static void OpenConnect()
        {
            try
            {
                string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
                con = new SqlConnection(strConnect);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Kết nối dữ liệu không thành công!");
            }
        }
        public static void CloseConnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable GetTable(string sql) // hàm lấy ra một bảng trong sql  
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            da.Fill(data);
            CloseConnect();
            return data;
        }
    }
}
