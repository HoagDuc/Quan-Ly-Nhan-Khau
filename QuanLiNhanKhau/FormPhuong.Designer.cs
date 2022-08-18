
namespace QuanLiNhanKhau
{
    partial class FormPhuong
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuatPhuong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLTDP = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhânKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLNPT = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenPhuong = new System.Windows.Forms.TextBox();
            this.txtMaPhuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaP = new System.Windows.Forms.Button();
            this.btnClearP = new System.Windows.Forms.Button();
            this.btnTimKiemP = new System.Windows.Forms.Button();
            this.btnSuaP = new System.Windows.Forms.Button();
            this.btnThemP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhuong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.LightSalmon;
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(586, 74);
            this.pnTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÍ PHƯỜNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThongTinTK,
            this.tsmiDangXuatPhuong,
            this.tsmiQLTaiKhoan});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // tsmiThongTinTK
            // 
            this.tsmiThongTinTK.Name = "tsmiThongTinTK";
            this.tsmiThongTinTK.Size = new System.Drawing.Size(181, 22);
            this.tsmiThongTinTK.Text = "Thông Tin Tài Khoản";
            // 
            // tsmiDangXuatPhuong
            // 
            this.tsmiDangXuatPhuong.Name = "tsmiDangXuatPhuong";
            this.tsmiDangXuatPhuong.Size = new System.Drawing.Size(181, 22);
            this.tsmiDangXuatPhuong.Text = "Đăng Xuất";
            this.tsmiDangXuatPhuong.Click += new System.EventHandler(this.tsmiDangXuatPhuong_Click);
            // 
            // tsmiQLTaiKhoan
            // 
            this.tsmiQLTaiKhoan.Name = "tsmiQLTaiKhoan";
            this.tsmiQLTaiKhoan.Size = new System.Drawing.Size(181, 22);
            this.tsmiQLTaiKhoan.Text = "Quản Lí Tài Khoản";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQLTDP,
            this.quảnLíNhânKhẩuToolStripMenuItem,
            this.tsmiQLNPT});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLíToolStripMenuItem.Text = "Quản Lí";
            // 
            // tsmiQLTDP
            // 
            this.tsmiQLTDP.Name = "tsmiQLTDP";
            this.tsmiQLTDP.Size = new System.Drawing.Size(211, 22);
            this.tsmiQLTDP.Text = "Quản Lí Tổ Dân Phố";
            this.tsmiQLTDP.Click += new System.EventHandler(this.tsmiQLTDP_Click);
            // 
            // quảnLíNhânKhẩuToolStripMenuItem
            // 
            this.quảnLíNhânKhẩuToolStripMenuItem.Name = "quảnLíNhânKhẩuToolStripMenuItem";
            this.quảnLíNhânKhẩuToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.quảnLíNhânKhẩuToolStripMenuItem.Text = "Quản Lí Nhân Khẩu";
            this.quảnLíNhânKhẩuToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNhânKhẩuToolStripMenuItem_Click);
            // 
            // tsmiQLNPT
            // 
            this.tsmiQLNPT.Name = "tsmiQLNPT";
            this.tsmiQLNPT.Size = new System.Drawing.Size(211, 22);
            this.tsmiQLNPT.Text = "Quản Lí Người Phụ Thuộc";
            this.tsmiQLNPT.Click += new System.EventHandler(this.tsmiQLNPT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenPhuong);
            this.groupBox1.Controls.Add(this.txtMaPhuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(586, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Khẩu";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(184, 95);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(285, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtTenPhuong
            // 
            this.txtTenPhuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenPhuong.Location = new System.Drawing.Point(184, 59);
            this.txtTenPhuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenPhuong.Name = "txtTenPhuong";
            this.txtTenPhuong.Size = new System.Drawing.Size(285, 20);
            this.txtTenPhuong.TabIndex = 4;
            // 
            // txtMaPhuong
            // 
            this.txtMaPhuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPhuong.Location = new System.Drawing.Point(184, 25);
            this.txtMaPhuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhuong.Name = "txtMaPhuong";
            this.txtMaPhuong.Size = new System.Drawing.Size(285, 20);
            this.txtMaPhuong.TabIndex = 3;
            this.txtMaPhuong.TextChanged += new System.EventHandler(this.txtMaPhuong_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SĐT Khẩn Cấp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Phường";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phường";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaP);
            this.panel1.Controls.Add(this.btnClearP);
            this.panel1.Controls.Add(this.btnTimKiemP);
            this.panel1.Controls.Add(this.btnSuaP);
            this.panel1.Controls.Add(this.btnThemP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 86);
            this.panel1.TabIndex = 17;
            // 
            // btnXoaP
            // 
            this.btnXoaP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaP.Location = new System.Drawing.Point(401, 5);
            this.btnXoaP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaP.Name = "btnXoaP";
            this.btnXoaP.Size = new System.Drawing.Size(68, 27);
            this.btnXoaP.TabIndex = 20;
            this.btnXoaP.Text = "Xóa";
            this.btnXoaP.UseVisualStyleBackColor = false;
            this.btnXoaP.Click += new System.EventHandler(this.btnXoaP_Click);
            // 
            // btnClearP
            // 
            this.btnClearP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClearP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearP.Location = new System.Drawing.Point(330, 50);
            this.btnClearP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearP.Name = "btnClearP";
            this.btnClearP.Size = new System.Drawing.Size(68, 27);
            this.btnClearP.TabIndex = 19;
            this.btnClearP.Text = "Clear";
            this.btnClearP.UseVisualStyleBackColor = false;
            this.btnClearP.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTimKiemP
            // 
            this.btnTimKiemP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiemP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemP.Location = new System.Drawing.Point(184, 50);
            this.btnTimKiemP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemP.Name = "btnTimKiemP";
            this.btnTimKiemP.Size = new System.Drawing.Size(68, 27);
            this.btnTimKiemP.TabIndex = 15;
            this.btnTimKiemP.Text = "Tìm Kiếm";
            this.btnTimKiemP.UseVisualStyleBackColor = false;
            this.btnTimKiemP.Click += new System.EventHandler(this.btnTimKiemP_Click);
            // 
            // btnSuaP
            // 
            this.btnSuaP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSuaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaP.Location = new System.Drawing.Point(260, 5);
            this.btnSuaP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaP.Name = "btnSuaP";
            this.btnSuaP.Size = new System.Drawing.Size(68, 27);
            this.btnSuaP.TabIndex = 18;
            this.btnSuaP.Text = "Sửa";
            this.btnSuaP.UseVisualStyleBackColor = false;
            this.btnSuaP.Click += new System.EventHandler(this.btnSuaP_Click);
            // 
            // btnThemP
            // 
            this.btnThemP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThemP.Enabled = false;
            this.btnThemP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemP.Location = new System.Drawing.Point(112, 5);
            this.btnThemP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemP.Name = "btnThemP";
            this.btnThemP.Size = new System.Drawing.Size(68, 27);
            this.btnThemP.TabIndex = 17;
            this.btnThemP.Text = "Thêm";
            this.btnThemP.UseVisualStyleBackColor = false;
            this.btnThemP.Click += new System.EventHandler(this.btnThemP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhuong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(586, 160);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Khẩu";
            // 
            // dgvPhuong
            // 
            this.dgvPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuong.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPhuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPhuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhuong.Location = new System.Drawing.Point(2, 17);
            this.dgvPhuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhuong.Name = "dgvPhuong";
            this.dgvPhuong.RowHeadersWidth = 51;
            this.dgvPhuong.RowTemplate.Height = 24;
            this.dgvPhuong.Size = new System.Drawing.Size(582, 141);
            this.dgvPhuong.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaPhuong";
            this.Column1.HeaderText = "Mã Phường";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenPhuong";
            this.Column2.HeaderText = "Tên Phường";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sSDTKhanCap";
            this.Column3.HeaderText = "SĐT Khẩn Cấp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // FormPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(586, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPhuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Phường";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPhuong_FormClosed);
            this.Load += new System.EventHandler(this.FormPhuong_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuatPhuong;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLTDP;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLNPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenPhuong;
        private System.Windows.Forms.TextBox txtMaPhuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaP;
        private System.Windows.Forms.Button btnClearP;
        private System.Windows.Forms.Button btnTimKiemP;
        private System.Windows.Forms.Button btnSuaP;
        private System.Windows.Forms.Button btnThemP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhânKhẩuToolStripMenuItem;
    }
}