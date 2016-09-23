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
                //string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
                string strConnect = "Data Source=.;Initial Catalog=QUANLYNHANSU;Integrated Security=True";
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
        public DataTable GetMaPB(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            da.Fill(data);
            CloseConnect();
            return data;
        }

        public DataTable Them_NV(string manhanvien,string hoten,string diachi,string ngay,string luong,string phongban)  
        {
            OpenConnect();
            DataTable dtb = new DataTable();
            string them = "Them_NhanVien";
            SqlCommand com = new SqlCommand(them, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@manv", manhanvien);
            com.Parameters.AddWithValue("@hoten", hoten);
            com.Parameters.AddWithValue("@diachi", diachi);
            com.Parameters.AddWithValue("@ngaysinh", ngay);
            com.Parameters.AddWithValue("@luong", luong);
            com.Parameters.AddWithValue("@phongban", phongban);
            com.ExecuteNonQuery();
            da.Fill(dtb);
            CloseConnect();
            return dtb;
        }

        public DataTable Xoa_NV(string manhanvien)
        {
            OpenConnect();
            DataTable dtb = new DataTable();
            string them = "Xoa_NhanVien";
            SqlCommand com = new SqlCommand(them, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@manv", manhanvien);
            com.ExecuteNonQuery();
            da.Fill(dtb);
            CloseConnect();
            return dtb;
        }

    }
}
