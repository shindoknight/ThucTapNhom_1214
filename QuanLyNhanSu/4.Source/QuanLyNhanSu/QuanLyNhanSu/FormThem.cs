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
    public partial class FormThem : Form
    {
        KetNoiCSDL _con = new KetNoiCSDL();

        public FormThem()
        {
            InitializeComponent();
        }

        public string Them_MaNV()
        {
            DataTable dtb = new DataTable();
            dtb = _con.GetTable("select * from NhanVien");
            string ma = "";
            int so = 0, i = 1000;
            for (int j = 1; j <= dtb.Rows.Count - 1; j++)
            {
                ma = Convert.ToString(dtb.Rows[j - 1][0].ToString());
                ma = ma.Remove(0, 2);
                so = Convert.ToInt32(ma);
                if (so != j) { so = j - 1; i = 0; break; }
            }
            if (i != 0)
            {
                ma = Convert.ToString(dtb.Rows[dtb.Rows.Count - 1][0].ToString());
                ma = ma.Remove(0, 2);
                so = Convert.ToInt32(ma);
            }

            ma = "NV";
            so += 1;
            if (so < 10)
                ma = ma + "0";
            ma = ma + so.ToString();
            return ma;
        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            dtb = _con.GetMaPB("select * from PhongBan");
            
            txtMaNV.Text = Them_MaNV();
            txtMaNV.Enabled = false;

            cmbPhongBan.DataSource = dtb;
            cmbPhongBan.DisplayMember = "TenPB";
            cmbPhongBan.ValueMember = "MaPB";

            txtHoTen.Text = ""; txtDiaChi.Text = ""; txtLuong.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtMaNV != null && txtHoTen != null)
            {
                _con.Them_NV(txtMaNV.Text, txtHoTen.Text, txtDiaChi.Text, dateTimePicker1.Text, txtLuong.Text, cmbPhongBan.Text);

                this.Close();
            }
        }
    }
}
