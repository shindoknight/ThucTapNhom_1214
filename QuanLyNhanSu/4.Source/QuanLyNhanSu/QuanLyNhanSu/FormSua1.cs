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
        string manv;
        int pk;
        public FormSua1()
        {
            InitializeComponent();
        }
        public FormSua1(string m,int n)
        {
            InitializeComponent();
            manv = m;
            pk = n;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" ||
               // cmbGioiTinh.Text == "" ||
                cboGioiTinh.Text==""||
                  cboPB.Text=="" )
                MessageBox.Show(" Tên,giới tính và phòng ban không được bỏ trống!");
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn sửa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // gọi đến hàm sửa 
                        _con.suaNhanvien(txtMaNV.Text, txtTenNV.Text, dTP_NgaySinh.Text, txtDChi.Text, cboGioiTinh.Text, txtLuong.Text, cboPB.Text, cboNgGS.Text);
                  
                }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSua1_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            dtb = _con.GetMaPB("select * from PhongBan");
            cboPB.DataSource = dtb;
            cboPB.DisplayMember = "TenPB";
            cboPB.ValueMember = "MaPB";
            DataTable dtb2 = new DataTable();
            dtb2 = _con.GetMaPB("select maNV from nhanvien");
            cboNgGS.DataSource = dtb2;
            cboNgGS.DisplayMember = "maNV";
            cboNgGS.ValueMember = "maNV";
            DataTable dt = new DataTable();
            dt = _con.GetTable("select * from NhanVien a,phongban b where a.mapb=b.mapb and manv='" + manv + "'");
            txtMaNV.Text = manv;
            txtTenNV.Text = dt.Rows[0]["TenNV"].ToString();
            txtDChi.Text = dt.Rows[0]["DChi"].ToString();
            txtLuong.Text = dt.Rows[0]["Luong"].ToString();
            cboPB.Text = dt.Rows[0]["TenPB"].ToString();
            cboGioiTinh.Text = dt.Rows[0]["GTinh"].ToString();
            dTP_NgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
            cboNgGS.Text = dt.Rows[0]["NgGS"].ToString();
            if (pk > 2) btn_Sua.Visible = true;
            
        }
    }
}
