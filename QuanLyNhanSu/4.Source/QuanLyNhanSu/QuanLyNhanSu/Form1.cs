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

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSua1 frmForm_Sua = new FormSua1();
            //  this.Close();
            frmForm_Sua.Show();
        }
    }
}
