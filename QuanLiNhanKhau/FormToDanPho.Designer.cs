
namespace QuanLiNhanKhau
{
    partial class FormToDanPho
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
            this.tsmiQLPhuong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLNhanKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLNPT = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDTLH = new System.Windows.Forms.TextBox();
            this.txtTenCSKV = new System.Windows.Forms.TextBox();
            this.txtMaTDP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenToTruong = new System.Windows.Forms.TextBox();
            this.txtTenTDP = new System.Windows.Forms.TextBox();
            this.txtMaPhuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaTDP = new System.Windows.Forms.Button();
            this.btnClearTDP = new System.Windows.Forms.Button();
            this.btnTimKiemTDP = new System.Windows.Forms.Button();
            this.btnSuaTDP = new System.Windows.Forms.Button();
            this.btnThemTDP = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvTDP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnTitle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDP)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.pnTitle.Size = new System.Drawing.Size(736, 74);
            this.pnTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÍ TỔ DÂN PHỐ";
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
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.tsmiQLPhuong,
            this.tsmiQLNhanKhau,
            this.tsmiQLNPT});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLíToolStripMenuItem.Text = "Quản Lí";
            // 
            // tsmiQLPhuong
            // 
            this.tsmiQLPhuong.Name = "tsmiQLPhuong";
            this.tsmiQLPhuong.Size = new System.Drawing.Size(211, 22);
            this.tsmiQLPhuong.Text = "Quản Lí Phường";
            this.tsmiQLPhuong.Click += new System.EventHandler(this.tsmiQLPhuong_Click);
            // 
            // tsmiQLNhanKhau
            // 
            this.tsmiQLNhanKhau.Name = "tsmiQLNhanKhau";
            this.tsmiQLNhanKhau.Size = new System.Drawing.Size(211, 22);
            this.tsmiQLNhanKhau.Text = "Quản Lí Nhân Khẩu";
            this.tsmiQLNhanKhau.Click += new System.EventHandler(this.tsmiQLNhanKhau_Click);
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
            this.groupBox1.Controls.Add(this.txtSDTLH);
            this.groupBox1.Controls.Add(this.txtTenCSKV);
            this.groupBox1.Controls.Add(this.txtMaTDP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenToTruong);
            this.groupBox1.Controls.Add(this.txtTenTDP);
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
            this.groupBox1.Size = new System.Drawing.Size(736, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Khẩu";
            // 
            // txtSDTLH
            // 
            this.txtSDTLH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDTLH.Location = new System.Drawing.Point(456, 93);
            this.txtSDTLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDTLH.Name = "txtSDTLH";
            this.txtSDTLH.Size = new System.Drawing.Size(126, 20);
            this.txtSDTLH.TabIndex = 11;
            // 
            // txtTenCSKV
            // 
            this.txtTenCSKV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenCSKV.Location = new System.Drawing.Point(456, 58);
            this.txtTenCSKV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenCSKV.Name = "txtTenCSKV";
            this.txtTenCSKV.Size = new System.Drawing.Size(126, 20);
            this.txtTenCSKV.TabIndex = 10;
            // 
            // txtMaTDP
            // 
            this.txtMaTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaTDP.Location = new System.Drawing.Point(456, 24);
            this.txtMaTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTDP.Name = "txtMaTDP";
            this.txtMaTDP.Size = new System.Drawing.Size(126, 20);
            this.txtMaTDP.TabIndex = 9;
            this.txtMaTDP.TextChanged += new System.EventHandler(this.txtMaPhuong_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SĐT Liên Hệ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên Cảnh Sát Khu Vực";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Tổ Dân Phố";
            // 
            // txtTenToTruong
            // 
            this.txtTenToTruong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenToTruong.Location = new System.Drawing.Point(203, 93);
            this.txtTenToTruong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenToTruong.Name = "txtTenToTruong";
            this.txtTenToTruong.Size = new System.Drawing.Size(126, 20);
            this.txtTenToTruong.TabIndex = 5;
            // 
            // txtTenTDP
            // 
            this.txtTenTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTDP.Location = new System.Drawing.Point(203, 58);
            this.txtTenTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTDP.Name = "txtTenTDP";
            this.txtTenTDP.Size = new System.Drawing.Size(126, 20);
            this.txtTenTDP.TabIndex = 4;
            // 
            // txtMaPhuong
            // 
            this.txtMaPhuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPhuong.Location = new System.Drawing.Point(203, 24);
            this.txtMaPhuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhuong.Name = "txtMaPhuong";
            this.txtMaPhuong.Size = new System.Drawing.Size(126, 20);
            this.txtMaPhuong.TabIndex = 3;
            this.txtMaPhuong.TextChanged += new System.EventHandler(this.txtMaPhuong_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Tổ Trưởng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Tổ Dân Phố";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phường";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 86);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaTDP);
            this.panel2.Controls.Add(this.btnClearTDP);
            this.panel2.Controls.Add(this.btnTimKiemTDP);
            this.panel2.Controls.Add(this.btnSuaTDP);
            this.panel2.Controls.Add(this.btnThemTDP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 86);
            this.panel2.TabIndex = 22;
            // 
            // btnXoaTDP
            // 
            this.btnXoaTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaTDP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoaTDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTDP.Location = new System.Drawing.Point(476, 5);
            this.btnXoaTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaTDP.Name = "btnXoaTDP";
            this.btnXoaTDP.Size = new System.Drawing.Size(68, 27);
            this.btnXoaTDP.TabIndex = 20;
            this.btnXoaTDP.Text = "Xóa";
            this.btnXoaTDP.UseVisualStyleBackColor = false;
            this.btnXoaTDP.Click += new System.EventHandler(this.btnXoaTDP_Click);
            // 
            // btnClearTDP
            // 
            this.btnClearTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearTDP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClearTDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTDP.Location = new System.Drawing.Point(405, 50);
            this.btnClearTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearTDP.Name = "btnClearTDP";
            this.btnClearTDP.Size = new System.Drawing.Size(68, 27);
            this.btnClearTDP.TabIndex = 19;
            this.btnClearTDP.Text = "Clear";
            this.btnClearTDP.UseVisualStyleBackColor = false;
            this.btnClearTDP.Click += new System.EventHandler(this.btnClearTDP_Click);
            // 
            // btnTimKiemTDP
            // 
            this.btnTimKiemTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiemTDP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemTDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTDP.Location = new System.Drawing.Point(260, 50);
            this.btnTimKiemTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemTDP.Name = "btnTimKiemTDP";
            this.btnTimKiemTDP.Size = new System.Drawing.Size(68, 27);
            this.btnTimKiemTDP.TabIndex = 15;
            this.btnTimKiemTDP.Text = "Tìm Kiếm";
            this.btnTimKiemTDP.UseVisualStyleBackColor = false;
            this.btnTimKiemTDP.Click += new System.EventHandler(this.btnTimKiemTDP_Click);
            // 
            // btnSuaTDP
            // 
            this.btnSuaTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaTDP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSuaTDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTDP.Location = new System.Drawing.Point(334, 5);
            this.btnSuaTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaTDP.Name = "btnSuaTDP";
            this.btnSuaTDP.Size = new System.Drawing.Size(68, 27);
            this.btnSuaTDP.TabIndex = 18;
            this.btnSuaTDP.Text = "Sửa";
            this.btnSuaTDP.UseVisualStyleBackColor = false;
            this.btnSuaTDP.Click += new System.EventHandler(this.btnSuaTDP_Click);
            // 
            // btnThemTDP
            // 
            this.btnThemTDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemTDP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThemTDP.Enabled = false;
            this.btnThemTDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTDP.Location = new System.Drawing.Point(188, 5);
            this.btnThemTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemTDP.Name = "btnThemTDP";
            this.btnThemTDP.Size = new System.Drawing.Size(68, 27);
            this.btnThemTDP.TabIndex = 17;
            this.btnThemTDP.Text = "Thêm";
            this.btnThemTDP.UseVisualStyleBackColor = false;
            this.btnThemTDP.Click += new System.EventHandler(this.btnThemTDP_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuayLai.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(476, 50);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(68, 27);
            this.btnQuayLai.TabIndex = 21;
            this.btnQuayLai.Text = "e";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(476, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 27);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(334, 50);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 27);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(193, 50);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(68, 27);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(334, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 27);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThem.Enabled = false;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(193, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 27);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvTDP
            // 
            this.dgvTDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTDP.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvTDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dgvTDP.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTDP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTDP.Location = new System.Drawing.Point(2, 17);
            this.dgvTDP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTDP.Name = "dgvTDP";
            this.dgvTDP.RowHeadersWidth = 51;
            this.dgvTDP.RowTemplate.Height = 24;
            this.dgvTDP.Size = new System.Drawing.Size(732, 271);
            this.dgvTDP.TabIndex = 19;
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
            this.Column2.DataPropertyName = "sMaTDP";
            this.Column2.HeaderText = "Mã Tổ Dân Phố";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sTenTDP";
            this.Column4.HeaderText = "Tên TDP";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sTenCSKV";
            this.Column5.HeaderText = "Tên Cảnh Sát KV";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sTenToTruong";
            this.Column6.HeaderText = "Tên Tổ Trưởng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sSoDTLH";
            this.Column3.HeaderText = "SĐT Liên Hệ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTDP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 319);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(736, 290);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Khẩu";
            // 
            // FormToDanPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(736, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormToDanPho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormToDanPho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToDanPho_FormClosing);
            this.Load += new System.EventHandler(this.FormToDanPho_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDP)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiQLPhuong;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLNhanKhau;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLNPT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDTLH;
        private System.Windows.Forms.TextBox txtTenCSKV;
        private System.Windows.Forms.TextBox txtMaTDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenToTruong;
        private System.Windows.Forms.TextBox txtTenTDP;
        private System.Windows.Forms.TextBox txtMaPhuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaTDP;
        private System.Windows.Forms.Button btnClearTDP;
        private System.Windows.Forms.Button btnTimKiemTDP;
        private System.Windows.Forms.Button btnSuaTDP;
        private System.Windows.Forms.Button btnThemTDP;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}