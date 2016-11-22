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
        string strID;
        string s;
        int capdo;
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(int n, string id)
        {
            InitializeComponent();
            strID = id;
            capdo = n;
            switch (n)
            {
                case 1: break;
                case 2:
                    menuthem.Visible = false;
                    menuxoa.Visible = false;
                   // menuthemuser.Visible = false;
                    //menuxoauser.Visible = false;
                    break;
                case 3:
                    menuthem.Visible = false;
                    menuxoa.Visible = false;
                    menusua.Visible = false;
                   // menuthemuser.Visible = false;
                   // menuxoauser.Visible = false;
                    break;
            }
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Hide();
            frmThem.ShowDialog();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            menuxoa.Enabled = false;
            dgvNhanVien.DataSource = _con.GetTable("select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB");
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlrXoa;
            dlrXoa = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên " + dgvNhanVien.CurrentRow.Cells["clmHoTen"].Value.ToString()+"?", "Xóa Nhân  viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrXoa == DialogResult.OK)
            {
                string str = dgvNhanVien.CurrentRow.Cells["clmMaNV"].Value.ToString();
                _con.Xoa_NV(str);
                dgvNhanVien.DataSource = _con.GetTable("select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
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
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSua1 frmForm_Sua = new FormSua1();
            //  this.Close();
            frmForm_Sua.Show();
        }

        private void cậpNhậtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = _con.GetTable("select MaNV,TenNV,NgaySinh,DChi,Luong,TenPB from NhanVien,PhongBan where NhanVien.MaPB=PhongBan.MaPB");
        }

        private void menuuser_Click(object sender, EventArgs e)
        {
            FormUser frmuser = new FormUser(capdo, strID);
            frmuser.FormClosed += new FormClosedEventHandler(frmuser_closed);
            frmuser.Show();
            this.Hide();
        }
        private void frmuser_closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.CurrentCell.Selected = true;
            }
            catch { }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            menuxoa.Enabled = true;
        }
    }
}
