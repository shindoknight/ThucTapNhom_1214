using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormMain : Form
    {
        KetNoiCSDL _con = new KetNoiCSDL();
        FormThem frmThem = new FormThem();
        FormXoa frmXoa = new FormXoa();
        string s;

        public FormMain()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThem.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = _con.GetTable("select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXoa.ShowDialog();
        }

        private void TK_Manv_TextChanged(object sender, EventArgs e)
        {
            s = "select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB and MaNV like '%" + TK_Manv.Text + "%'";
            dgvNhanVien.DataSource = _con.GetTable(s);
        }

        private void TK_Hoten_TextChanged(object sender, EventArgs e)
        {
            s = "select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB and TenNV like '%" + TK_Hoten.Text + "%'";
            dgvNhanVien.DataSource = _con.GetTable(s);
        }

        private void TK_NgSinh_TextChanged(object sender, EventArgs e)
        {
            s = "select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB and NgaySinh like '%" + TK_NgSinh.Text + "%'";
            dgvNhanVien.DataSource = _con.GetTable(s);
        }

        private void TK_Diachi_TextChanged(object sender, EventArgs e)
        {
            s = "select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB and DChi like '%" + TK_Diachi.Text + "%'";
            dgvNhanVien.DataSource = _con.GetTable(s);
        }

        private void TK_Luong_TextChanged(object sender, EventArgs e)
        {
            s = "select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB and luong like '%" + TK_Luong.Text + "%'";
            dgvNhanVien.DataSource = _con.GetTable(s);
        }

        private void TK_PhongBan_TextChanged(object sender, EventArgs e)
        {
            s = "select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB and Tenpb like '%" + TK_PhongBan.Text + "%'";
            dgvNhanVien.DataSource = _con.GetTable(s);
        }
        
    }
}
