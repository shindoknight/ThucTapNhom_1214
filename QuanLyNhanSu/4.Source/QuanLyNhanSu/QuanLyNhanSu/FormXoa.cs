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

namespace QuanLyNhanSu
{
    public partial class FormXoa : Form
    {
        KetNoiCSDL _con = new KetNoiCSDL();
        public FormXoa()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            DialogResult dlrXoa;
            dlrXoa = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa học sinh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrXoa == DialogResult.OK)
            {
                
                string str = cmbMaNV.Text.Trim();
                 _con.Xoa_NV(str);
            }
            
        }

        private void FormXoa_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            dtb = _con.GetMaPB("select MaNV from NhanVien");

            cmbMaNV.DataSource = dtb;
            cmbMaNV.ValueMember = "MaNV";
            cmbMaNV.DisplayMember = "MaNV";
        }

        private void FormXoa_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
