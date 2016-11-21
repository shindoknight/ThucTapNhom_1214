namespace QuanLyNhanSu
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.cboGroup);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtChucVu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 176);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(329, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Người sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(98, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(411, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(141, 20);
            this.txtPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đầy đủ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(694, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhóm";
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "Admin",
            "Quản trị",
            "Người dùng"});
            this.cboGroup.Location = new System.Drawing.Point(694, 95);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(141, 21);
            this.cboGroup.TabIndex = 3;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmUsername,
            this.clmPassword,
            this.clmHoTen,
            this.clmNgaysinh,
            this.clmChucVu,
            this.clmDiaChi,
            this.clmGroup});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Enabled = false;
            this.dgvUser.Location = new System.Drawing.Point(0, 176);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(935, 144);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chức Vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(411, 95);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(141, 20);
            this.txtChucVu.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(98, 96);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(141, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.Width = 50;
            // 
            // clmUsername
            // 
            this.clmUsername.DataPropertyName = "ID";
            this.clmUsername.HeaderText = "Tên Đăng Nhập";
            this.clmUsername.Name = "clmUsername";
            this.clmUsername.Width = 120;
            // 
            // clmPassword
            // 
            this.clmPassword.DataPropertyName = "pass";
            this.clmPassword.HeaderText = "Mật Khẩu";
            this.clmPassword.Name = "clmPassword";
            // 
            // clmHoTen
            // 
            this.clmHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHoTen.DataPropertyName = "HoTen";
            this.clmHoTen.HeaderText = "Họ Tên";
            this.clmHoTen.Name = "clmHoTen";
            // 
            // clmNgaysinh
            // 
            this.clmNgaysinh.DataPropertyName = "NgaySinh";
            this.clmNgaysinh.HeaderText = "Ngày Sinh";
            this.clmNgaysinh.Name = "clmNgaysinh";
            this.clmNgaysinh.Width = 150;
            // 
            // clmChucVu
            // 
            this.clmChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmChucVu.DataPropertyName = "ChucVu";
            this.clmChucVu.HeaderText = "Chức Vụ";
            this.clmChucVu.Name = "clmChucVu";
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.DataPropertyName = "DiaChi";
            this.clmDiaChi.HeaderText = "Địa Chỉ";
            this.clmDiaChi.Name = "clmDiaChi";
            // 
            // clmGroup
            // 
            this.clmGroup.DataPropertyName = "capdo";
            this.clmGroup.HeaderText = "Nhóm";
            this.clmGroup.Name = "clmGroup";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::QuanLyNhanSu.Properties.Resources.Button_Refresh_icon__1_;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(602, 122);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 48);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::QuanLyNhanSu.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(479, 122);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 48);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::QuanLyNhanSu.Properties.Resources.edit_icon__1_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(347, 122);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 48);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyNhanSu.Properties.Resources.Actions_list_add_icon__1_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(229, 122);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 48);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 320);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGroup;
        private System.Windows.Forms.Button btnCapNhat;
    }
}