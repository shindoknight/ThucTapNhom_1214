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
    public partial class FormLogin : Form
    {
        KetNoiCSDL _conn = new KetNoiCSDL();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string str = @"select * from tblNguoiDung where  ID='" + txtID.Text + "' and pass='" + txtPass.Text+"'";
            if(_conn.Login(str)==true)
            {
                this.Hide();
                string a,b;
                a=_conn.GetTable(str).Rows[0]["capdo"].ToString();
                b = _conn.GetTable(str).Rows[0]["ID"].ToString();
                FormMain frmMain = new FormMain(int.Parse(a),b);    
                frmMain.FormClosed += new FormClosedEventHandler(frmMain_closed);
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
           // this.Close();
        }
        private void frmMain_closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtID.Text = "";
            txtPass.Text = "";
            txtID.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
