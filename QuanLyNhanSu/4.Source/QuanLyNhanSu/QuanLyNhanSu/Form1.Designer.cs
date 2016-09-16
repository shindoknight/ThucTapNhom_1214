namespace QuanLyNhanSu
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TK_Luong = new System.Windows.Forms.TextBox();
            this.TK_Diachi = new System.Windows.Forms.TextBox();
            this.TK_NgSinh = new System.Windows.Forms.TextBox();
            this.TK_Hoten = new System.Windows.Forms.TextBox();
            this.TK_Manv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clmMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_PhongBan = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânSựToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhânSựToolStripMenuItem
            // 
            this.nhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            this.nhânSựToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nhânSựToolStripMenuItem.Text = "Nhân sự";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaNV,
            this.clmHoTen,
            this.clmNgaySinh,
            this.clmDiaChi,
            this.clmLuong,
            this.clmPB});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 61);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(892, 351);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TK_PhongBan);
            this.groupBox1.Controls.Add(this.TK_Luong);
            this.groupBox1.Controls.Add(this.TK_Diachi);
            this.groupBox1.Controls.Add(this.TK_NgSinh);
            this.groupBox1.Controls.Add(this.TK_Hoten);
            this.groupBox1.Controls.Add(this.TK_Manv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 36);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // TK_Luong
            // 
            this.TK_Luong.Location = new System.Drawing.Point(616, 7);
            this.TK_Luong.Multiline = true;
            this.TK_Luong.Name = "TK_Luong";
            this.TK_Luong.Size = new System.Drawing.Size(100, 25);
            this.TK_Luong.TabIndex = 16;
            this.TK_Luong.TextChanged += new System.EventHandler(this.TK_Luong_TextChanged);
            // 
            // TK_Diachi
            // 
            this.TK_Diachi.Location = new System.Drawing.Point(448, 7);
            this.TK_Diachi.Multiline = true;
            this.TK_Diachi.Name = "TK_Diachi";
            this.TK_Diachi.Size = new System.Drawing.Size(162, 25);
            this.TK_Diachi.TabIndex = 15;
            this.TK_Diachi.TextChanged += new System.EventHandler(this.TK_Diachi_TextChanged);
            // 
            // TK_NgSinh
            // 
            this.TK_NgSinh.Location = new System.Drawing.Point(352, 7);
            this.TK_NgSinh.Multiline = true;
            this.TK_NgSinh.Name = "TK_NgSinh";
            this.TK_NgSinh.Size = new System.Drawing.Size(90, 25);
            this.TK_NgSinh.TabIndex = 14;
            this.TK_NgSinh.TextChanged += new System.EventHandler(this.TK_NgSinh_TextChanged);
            // 
            // TK_Hoten
            // 
            this.TK_Hoten.Location = new System.Drawing.Point(175, 7);
            this.TK_Hoten.Multiline = true;
            this.TK_Hoten.Name = "TK_Hoten";
            this.TK_Hoten.Size = new System.Drawing.Size(171, 25);
            this.TK_Hoten.TabIndex = 13;
            this.TK_Hoten.TextChanged += new System.EventHandler(this.TK_Hoten_TextChanged);
            // 
            // TK_Manv
            // 
            this.TK_Manv.Location = new System.Drawing.Point(59, 7);
            this.TK_Manv.Multiline = true;
            this.TK_Manv.Name = "TK_Manv";
            this.TK_Manv.Size = new System.Drawing.Size(110, 25);
            this.TK_Manv.TabIndex = 12;
            this.TK_Manv.TextChanged += new System.EventHandler(this.TK_Manv_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm";
            // 
            // clmMaNV
            // 
            this.clmMaNV.DataPropertyName = "MaNV";
            this.clmMaNV.HeaderText = "Mã Nhân Viên";
            this.clmMaNV.Name = "clmMaNV";
            this.clmMaNV.Width = 130;
            // 
            // clmHoTen
            // 
            this.clmHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHoTen.DataPropertyName = "TenNV";
            this.clmHoTen.HeaderText = "Họ Tên";
            this.clmHoTen.Name = "clmHoTen";
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.DataPropertyName = "NgaySinh";
            this.clmNgaySinh.HeaderText = "Ngày Sinh";
            this.clmNgaySinh.Name = "clmNgaySinh";
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDiaChi.DataPropertyName = "DChi";
            this.clmDiaChi.HeaderText = "Địa Chỉ";
            this.clmDiaChi.Name = "clmDiaChi";
            // 
            // clmLuong
            // 
            this.clmLuong.DataPropertyName = "Luong";
            this.clmLuong.HeaderText = "Lương";
            this.clmLuong.Name = "clmLuong";
            // 
            // clmPB
            // 
            this.clmPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPB.DataPropertyName = "TenPB";
            this.clmPB.HeaderText = "Phòng Ban";
            this.clmPB.Name = "clmPB";
            // 
            // TK_PhongBan
            // 
            this.TK_PhongBan.Location = new System.Drawing.Point(722, 7);
            this.TK_PhongBan.Multiline = true;
            this.TK_PhongBan.Name = "TK_PhongBan";
            this.TK_PhongBan.Size = new System.Drawing.Size(164, 25);
            this.TK_PhongBan.TabIndex = 18;
            this.TK_PhongBan.TextChanged += new System.EventHandler(this.TK_PhongBan_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Quản Lý nhân sự";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TK_Luong;
        private System.Windows.Forms.TextBox TK_Diachi;
        private System.Windows.Forms.TextBox TK_NgSinh;
        private System.Windows.Forms.TextBox TK_Hoten;
        private System.Windows.Forms.TextBox TK_Manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TK_PhongBan;
    }
}

