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

        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(int n)
        {
            InitializeComponent();
            switch(n)
            {
                case 1: break;
                case 2:
                    menuthem.Visible = false;
                    menuxoa.Visible = false;
                    menuthemuser.Visible = false;
                    menuxoauser.Visible = false;
                    break;
                case 3:
                    menuthem.Visible = false;
                    menuxoa.Visible = false;
                    menusua.Visible = false;
                    menuthemuser.Visible = false;
                    menuxoauser.Visible = false;
                    break;
            }
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
            Application.Exit();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXoa.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
