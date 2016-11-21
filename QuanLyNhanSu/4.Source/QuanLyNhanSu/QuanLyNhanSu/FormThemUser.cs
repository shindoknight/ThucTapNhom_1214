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
    public partial class FormThemUser : Form
    {
        KetNoiCSDL _con = new KetNoiCSDL();
        public FormThemUser()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text==""||txtPass.Text==""||cboGroup.Text=="")
            {
                MessageBox.Show("Tên đăng nhập, mật khẩu, group không được để trống!");
            }
            else
            {
                int n;
            switch(cboGroup.Text)
            {
                case "Admin":
                    n=1;
                    break;
                case "Quản trị":
                    n=2; break;
                default:
                    n=3;break;
            }
                _con.Exec("insert into tblNguoiDung values('"+txtUserName.Text+"','"+txtPass.Text+"',"+n.ToString()+",N'"+txtName.Text+"','"+dtpNgaySinh.Text+"',N'"+txtDiaChi.Text+"',N'"+txtChucVu.Text+"')");
                this.Close();
            }
        }
    }
}
