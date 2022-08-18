
namespace QuanLiNhanKhau
{
    partial class FormNhanKhau
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
            this.pnNavbar = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíPhườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTổDânPhốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNgườiPhụThuộcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaToDanPhoNK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCCCDNK = new System.Windows.Forms.TextBox();
            this.txtSDTNK = new System.Windows.Forms.TextBox();
            this.txtCoQuanNK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinhNK = new System.Windows.Forms.DateTimePicker();
            this.txtTenNK = new System.Windows.Forms.TextBox();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaoCaoNK = new System.Windows.Forms.Button();
            this.btnXoaNK = new System.Windows.Forms.Button();
            this.btnClearNK = new System.Windows.Forms.Button();
            this.btnSuaNK = new System.Windows.Forms.Button();
            this.btnThemNK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            this.pnNavbar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
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
            this.pnTitle.Size = new System.Drawing.Size(734, 74);
            this.pnTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÍ NHÂN KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnNavbar
            // 
            this.pnNavbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNavbar.Controls.Add(this.menuStrip1);
            this.pnNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNavbar.Location = new System.Drawing.Point(0, 74);
            this.pnNavbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNavbar.Name = "pnNavbar";
            this.pnNavbar.Size = new System.Drawing.Size(734, 26);
            this.pnNavbar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(209, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.quảnLíTàiKhoảnToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản Lí Tài Khoản";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíPhườngToolStripMenuItem,
            this.quảnLíTổDânPhốToolStripMenuItem,
            this.quảnLíNgườiPhụThuộcToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLíToolStripMenuItem.Text = "Quản Lí";
            // 
            // quảnLíPhườngToolStripMenuItem
            // 
            this.quảnLíPhườngToolStripMenuItem.Name = "quảnLíPhườngToolStripMenuItem";
            this.quảnLíPhườngToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.quảnLíPhườngToolStripMenuItem.Text = "Quản Lí Phường";
            this.quảnLíPhườngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíPhườngToolStripMenuItem_Click);
            // 
            // quảnLíTổDânPhốToolStripMenuItem
            // 
            this.quảnLíTổDânPhốToolStripMenuItem.Name = "quảnLíTổDânPhốToolStripMenuItem";
            this.quảnLíTổDânPhốToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.quảnLíTổDânPhốToolStripMenuItem.Text = "Quản Lí Tổ Dân Phố";
            this.quảnLíTổDânPhốToolStripMenuItem.Click += new System.EventHandler(this.quảnLíTổDânPhốToolStripMenuItem_Click);
            // 
            // quảnLíNgườiPhụThuộcToolStripMenuItem
            // 
            this.quảnLíNgườiPhụThuộcToolStripMenuItem.Name = "quảnLíNgườiPhụThuộcToolStripMenuItem";
            this.quảnLíNgườiPhụThuộcToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.quảnLíNgườiPhụThuộcToolStripMenuItem.Text = "Quản Lí Người Phụ Thuộc";
            this.quảnLíNgườiPhụThuộcToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNgườiPhụThuộcToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.txtMaToDanPhoNK);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCCCDNK);
            this.groupBox1.Controls.Add(this.txtSDTNK);
            this.groupBox1.Controls.Add(this.txtCoQuanNK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgaySinhNK);
            this.groupBox1.Controls.Add(this.txtTenNK);
            this.groupBox1.Controls.Add(this.txtMaNK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(734, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Khẩu";
            // 
            // txtMaToDanPhoNK
            // 
            this.txtMaToDanPhoNK.Location = new System.Drawing.Point(335, 149);
            this.txtMaToDanPhoNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaToDanPhoNK.Name = "txtMaToDanPhoNK";
            this.txtMaToDanPhoNK.Size = new System.Drawing.Size(144, 20);
            this.txtMaToDanPhoNK.TabIndex = 13;
            this.txtMaToDanPhoNK.TextChanged += new System.EventHandler(this.txtMaToDanPhoNK_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã Tổ Dân Phố";
            // 
            // txtCCCDNK
            // 
            this.txtCCCDNK.Location = new System.Drawing.Point(468, 103);
            this.txtCCCDNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCCCDNK.Name = "txtCCCDNK";
            this.txtCCCDNK.Size = new System.Drawing.Size(144, 20);
            this.txtCCCDNK.TabIndex = 11;
            // 
            // txtSDTNK
            // 
            this.txtSDTNK.Location = new System.Drawing.Point(468, 67);
            this.txtSDTNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDTNK.Name = "txtSDTNK";
            this.txtSDTNK.Size = new System.Drawing.Size(144, 20);
            this.txtSDTNK.TabIndex = 10;
            // 
            // txtCoQuanNK
            // 
            this.txtCoQuanNK.Location = new System.Drawing.Point(468, 31);
            this.txtCoQuanNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCoQuanNK.Name = "txtCoQuanNK";
            this.txtCoQuanNK.Size = new System.Drawing.Size(144, 20);
            this.txtCoQuanNK.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên Cơ Quan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CCCD";
            // 
            // dtpNgaySinhNK
            // 
            this.dtpNgaySinhNK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhNK.Location = new System.Drawing.Point(204, 103);
            this.dtpNgaySinhNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgaySinhNK.Name = "dtpNgaySinhNK";
            this.dtpNgaySinhNK.Size = new System.Drawing.Size(90, 20);
            this.dtpNgaySinhNK.TabIndex = 5;
            this.dtpNgaySinhNK.Value = new System.DateTime(2022, 3, 1, 13, 33, 24, 0);
            // 
            // txtTenNK
            // 
            this.txtTenNK.Location = new System.Drawing.Point(204, 67);
            this.txtTenNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNK.Name = "txtTenNK";
            this.txtTenNK.Size = new System.Drawing.Size(144, 20);
            this.txtTenNK.TabIndex = 4;
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(204, 31);
            this.txtMaNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(144, 20);
            this.txtMaNK.TabIndex = 3;
            this.txtMaNK.TextChanged += new System.EventHandler(this.txtMaToDanPhoNK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Chủ Hộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaoCaoNK);
            this.panel1.Controls.Add(this.btnXoaNK);
            this.panel1.Controls.Add(this.btnClearNK);
            this.panel1.Controls.Add(this.btnSuaNK);
            this.panel1.Controls.Add(this.btnThemNK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 40);
            this.panel1.TabIndex = 16;
            // 
            // btnBaoCaoNK
            // 
            this.btnBaoCaoNK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaoCaoNK.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBaoCaoNK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoNK.Location = new System.Drawing.Point(547, 5);
            this.btnBaoCaoNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaoCaoNK.Name = "btnBaoCaoNK";
            this.btnBaoCaoNK.Size = new System.Drawing.Size(68, 27);
            this.btnBaoCaoNK.TabIndex = 21;
            this.btnBaoCaoNK.Text = "Báo Cáo";
            this.btnBaoCaoNK.UseVisualStyleBackColor = false;
            this.btnBaoCaoNK.Click += new System.EventHandler(this.btnBaoCaoNK_Click);
            // 
            // btnXoaNK
            // 
            this.btnXoaNK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaNK.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoaNK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNK.Location = new System.Drawing.Point(339, 5);
            this.btnXoaNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaNK.Name = "btnXoaNK";
            this.btnXoaNK.Size = new System.Drawing.Size(68, 27);
            this.btnXoaNK.TabIndex = 20;
            this.btnXoaNK.Text = "Xóa";
            this.btnXoaNK.UseVisualStyleBackColor = false;
            this.btnXoaNK.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClearNK
            // 
            this.btnClearNK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearNK.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClearNK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNK.Location = new System.Drawing.Point(444, 5);
            this.btnClearNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearNK.Name = "btnClearNK";
            this.btnClearNK.Size = new System.Drawing.Size(68, 27);
            this.btnClearNK.TabIndex = 19;
            this.btnClearNK.Text = "Clear";
            this.btnClearNK.UseVisualStyleBackColor = false;
            this.btnClearNK.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSuaNK
            // 
            this.btnSuaNK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaNK.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSuaNK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNK.Location = new System.Drawing.Point(233, 5);
            this.btnSuaNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaNK.Name = "btnSuaNK";
            this.btnSuaNK.Size = new System.Drawing.Size(68, 27);
            this.btnSuaNK.TabIndex = 18;
            this.btnSuaNK.Text = "Sửa";
            this.btnSuaNK.UseVisualStyleBackColor = false;
            this.btnSuaNK.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemNK
            // 
            this.btnThemNK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemNK.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThemNK.Enabled = false;
            this.btnThemNK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNK.Location = new System.Drawing.Point(124, 5);
            this.btnThemNK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemNK.Name = "btnThemNK";
            this.btnThemNK.Size = new System.Drawing.Size(68, 27);
            this.btnThemNK.TabIndex = 17;
            this.btnThemNK.Text = "Thêm";
            this.btnThemNK.UseVisualStyleBackColor = false;
            this.btnThemNK.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanKhau);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(734, 284);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Khẩu";
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanKhau.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvNhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanKhau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvNhanKhau.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvNhanKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanKhau.Location = new System.Drawing.Point(2, 17);
            this.dgvNhanKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.RowHeadersWidth = 51;
            this.dgvNhanKhau.RowTemplate.Height = 24;
            this.dgvNhanKhau.Size = new System.Drawing.Size(730, 265);
            this.dgvNhanKhau.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaTDP";
            this.Column1.HeaderText = "Mã Tổ Dân Phố";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sMaNhanKhau";
            this.Column2.HeaderText = "Mã Nhân Khẩu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sTenChuHo";
            this.Column3.HeaderText = "Tên Chủ Hộ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dNgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sCoQuan";
            this.Column5.HeaderText = "Cơ Quan";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sDienThoai";
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sSoCCCD";
            this.Column7.HeaderText = "Số CCCD";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // FormNhanKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(734, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnNavbar);
            this.Controls.Add(this.pnTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhanKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Nhân Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanKhau_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnNavbar.ResumeLayout(false);
            this.pnNavbar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnNavbar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNK;
        private System.Windows.Forms.TextBox txtTenNK;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.TextBox txtCCCDNK;
        private System.Windows.Forms.TextBox txtSDTNK;
        private System.Windows.Forms.TextBox txtCoQuanNK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearNK;
        private System.Windows.Forms.Button btnSuaNK;
        private System.Windows.Forms.Button btnThemNK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.TextBox txtMaToDanPhoNK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoaNK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíPhườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTổDânPhốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNgườiPhụThuộcToolStripMenuItem;
        private System.Windows.Forms.Button btnBaoCaoNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
    }
}

