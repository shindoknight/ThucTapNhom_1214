using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace QuanLyNhanSu
{
    public partial class FormSua1 : Form
    {
        KetNoiCSDL _con = new KetNoiCSDL();
        SqlDataAdapter daNhanvien = null;
        DataTable dtNhanvien = null;
        public FormSua1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            if (chk_MaNV.Checked == true)
            // goi store procedure tim theo ma( nhap vao text)
            {
                if (_con.GetTable("select * from NhanVien where MaNV= '" + txt_Timkiem.Text + "' ") != null)
                {
                    // MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                    conn.Open();
                    // đây là đổ dữ liệu vào bảng 
                    daNhanvien = new SqlDataAdapter("select * from NhanVien where MaNV='" + txt_Timkiem.Text + "'", conn);
                    dtNhanvien = new DataTable();
                    dtNhanvien.Clear();
                    daNhanvien.Fill(dtNhanvien);
                    dgv_NhanVien.DataSource = dtNhanvien;
                    dtNhanvien.Dispose();
                    conn.Close();
                    dtNhanvien = null;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (chk_TenNV.Checked == true)
            // goi store procedure tim theo ma( nhap vao text)
            {
                if (_con.GetTable("select * from NhanVien where TenNV= N'" + txt_Timkiem.Text + "'") != null)
                {
                    //MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                    conn.Open();
                    // đây là đổ dữ liệu vào bảng 
                    daNhanvien = new SqlDataAdapter("select * from NhanVien where TenNV=N'" + txt_Timkiem.Text + "'", conn);
                    dtNhanvien = new DataTable();
                    dtNhanvien.Clear();
                    daNhanvien.Fill(dtNhanvien);
                    dgv_NhanVien.DataSource = dtNhanvien;
                    dtNhanvien.Dispose();
                    dtNhanvien = null;
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvTimkiem.DataSource = null;
                }
            }
        }
        public void suaNhanvien(string MaNV, string TenNV, string NgaySinh, string DChi, string GTinh,  string Luong, string MaPB, string SoNVDuoiQuyen, string NgGS)
        {
            string a = "dbo.SuaNhanVien";
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand(a, conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaNV", MaNV);
            sqlcmd.Parameters.AddWithValue("@TenNV", TenNV);
            sqlcmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            sqlcmd.Parameters.AddWithValue("@DChi", DChi);
            sqlcmd.Parameters.AddWithValue("@GTinh", GTinh);
            sqlcmd.Parameters.AddWithValue("@Luong", int.Parse(Luong));
            sqlcmd.Parameters.AddWithValue("@MaPB", MaPB);
            sqlcmd.Parameters.AddWithValue("@SoNVDuoiQuyen", int.Parse(SoNVDuoiQuyen));
            sqlcmd.Parameters.AddWithValue("@NgGS", NgGS);
            sqlcmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" ||
               // cmbGioiTinh.Text == "" ||
                  txtMaNV.Text == "" ||
                  txtDChi.Text == "" ||
                  txtLuong.Text == "" ||
                  txtSoNVDuoiQuyen.Text == "" ||
                 // txtNgGS.Text == "" ||
                  dTP_NgaySinh.Text == "" ||
                  txtMaPB.Text == "")
                MessageBox.Show(" bạn hãy điền đủ thông tin");
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn sửa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // gọi đến hàm sửa 
                    try
                    {
                        suaNhanvien(txtMaNV.Text, txtTenNV.Text, dTP_NgaySinh.Text, txtDChi.Text, cmbGioiTinh.Text, txtLuong.Text, txtMaPB.Text, txtSoNVDuoiQuyen.Text, txtNgGS.Text);
                        MessageBox.Show("Bạn đã sửa thành công");
                        if (chk_MaNV.Checked == true)
                        // goi store procedure tim theo ma( nhap vao text)
                        {
                                // MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                                conn.Open();
                                // đây là đổ dữ liệu vào bảng 
                                daNhanvien = new SqlDataAdapter("select * from NhanVien where MaNV='" + txt_Timkiem.Text + "'", conn);
                                dtNhanvien = new DataTable();
                                dtNhanvien.Clear();
                                daNhanvien.Fill(dtNhanvien);
                                dgv_NhanVien.DataSource = dtNhanvien;
                                dtNhanvien.Dispose();
                                conn.Close();
                                dtNhanvien = null;
                        }
                        if (chk_TenNV.Checked == true)
                        // goi store procedure tim theo ma( nhap vao text)
                        {
                                //MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
                                conn.Open();
                                // đây là đổ dữ liệu vào bảng 
                                daNhanvien = new SqlDataAdapter("select * from NhanVien where TenNV=N'" + txt_Timkiem.Text + "'", conn);
                                dtNhanvien = new DataTable();
                                dtNhanvien.Clear();
                                daNhanvien.Fill(dtNhanvien);
                                dgv_NhanVien.DataSource = dtNhanvien;
                                dtNhanvien.Dispose();
                                dtNhanvien = null;
                                conn.Close();
                        }
                   }
                   catch (SqlException ex)
                   {
                      MessageBox.Show("Bạn sửa bị lỗi rồi!\n"+ex.ToString());
                   }
                }
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int CurrentIndex = dgv_NhanVien.CurrentCell.RowIndex;
                dgv_NhanVien.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                txtMaNV.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[1].Value.ToString();
                //int dd = int.Parse(dgv_NhanVien.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(0, 2));
               // int MM = int.Parse(dgv_NhanVien.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(3, 2));
                //int yyyy = int.Parse(dgv_NhanVien.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(6, 4));
                dTP_NgaySinh.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[2].Value.ToString();
                txtDChi.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[3].Value.ToString();
                cmbGioiTinh.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[4].Value.ToString();
                //txtGTinh.Text = Convert.ToString(dgv_NhanVien.Rows[CurrentIndex].Cells[4].Value.ToString());
                txtLuong.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[5].Value.ToString();                
                txtMaPB.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[6].Value.ToString();
                txtNgGS.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[7].Value.ToString();
                txtSoNVDuoiQuyen.Text = dgv_NhanVien.Rows[CurrentIndex].Cells[8].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi rồi!\n"+ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
