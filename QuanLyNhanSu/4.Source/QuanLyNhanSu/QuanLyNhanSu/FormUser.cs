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
    public partial class FormUser : Form
    {
        KetNoiCSDL _con = new KetNoiCSDL();
        public FormUser()
        {
            InitializeComponent();
        }
        public FormUser(int i,string id)
        {
            InitializeComponent();
            if(i==1)
            {
                dgvUser.Enabled = true;
                dgvUser.DataSource = _con.GetTable("select * from tblNguoidung");
            }
            else
            {
                
                Height = 220;
                DataTable dt= _con.GetTable("select * from tblNguoidung where id='" + id + "'");
                txtUserName.Text = id;
                txtPass.Text = dt.Rows[0]["pass"].ToString();
                txtName.Text = dt.Rows[0]["HoTen"].ToString();
                txtChucVu.Text = dt.Rows[0]["ChucVu"].ToString();
                dtpNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                switch(int.Parse(dt.Rows[0]["capdo"].ToString()))
                {
                    case 1:
                        cboGroup.Text = "Admin";
                        break;
                    case 2:
                        cboGroup.Text = "Quản trị";
                        break;
                    case 3:
                        cboGroup.Text = "Người dùng";
                        break;

                }
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btnLuu.Enabled = true;
                btnCapNhat.Visible = false;
                cboGroup.Enabled = false;
            }
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUser.CurrentRow.Selected = true;
            }
            catch
            { }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtUserName.Text = dgvUser.CurrentRow.Cells["clmUsername"].Value.ToString();
                txtPass.Text = dgvUser.CurrentRow.Cells["clmPassword"].Value.ToString();
                txtName.Text = dgvUser.CurrentRow.Cells["clmHoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvUser.CurrentRow.Cells["clmNgaySinh"].Value.ToString();
                txtChucVu.Text = dgvUser.CurrentRow.Cells["clmChucVu"].Value.ToString();
                switch (int.Parse(dgvUser.CurrentRow.Cells["clmGroup"].Value.ToString()))
                {
                    case 1:
                        cboGroup.Text = "Admin";
                        break;
                    case 2:
                        cboGroup.Text = "Quản trị";
                        break;
                    case 3:
                        cboGroup.Text = "Người dùng";
                        break;

                }
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
            
           
           DialogResult dlrTraloi;
            dlrTraloi = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrTraloi == DialogResult.OK)
            {
                _con.Exec("update tblNguoiDung set pass='" + txtPass.Text + "',capdo=" + n.ToString() + ",HoTen=N'" + txtName.Text + "',NgaySinh='" + dtpNgaySinh.Text + "',ChucVu=N'" + txtChucVu.Text + "' where id='"+txtUserName.Text+"'");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlrTraloi;
            dlrTraloi = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản "+txtUserName.Text+"?", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrTraloi == DialogResult.OK)
            {
                _con.Exec("delete tblNguoiDung where id='" + txtUserName.Text + "'");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = _con.GetTable("select * from tblNguoidung");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemUser frmthemuser = new FormThemUser();
            frmthemuser.ShowDialog();
        }
    }
}
