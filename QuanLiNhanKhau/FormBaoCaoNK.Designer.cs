
namespace QuanLiNhanKhau
{
    partial class FormBaoCaoNK
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCCCDNK = new System.Windows.Forms.TextBox();
            this.txtSDTNK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTDPNK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNK = new System.Windows.Forms.TextBox();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhanKhau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.LightSalmon;
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(962, 74);
            this.pnTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO NHÂN KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanKhau);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(701, 391);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCCCDNK);
            this.panel1.Controls.Add(this.txtSDTNK);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaTDPNK);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTenNK);
            this.panel1.Controls.Add(this.txtMaNK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(701, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 391);
            this.panel1.TabIndex = 19;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuayLai.BackColor = System.Drawing.Color.Coral;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(154, 311);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(90, 33);
            this.btnQuayLai.TabIndex = 24;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(27, 251);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 33);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaoCao.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Location = new System.Drawing.Point(154, 251);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(90, 33);
            this.btnBaoCao.TabIndex = 22;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(27, 311);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 33);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCCCDNK
            // 
            this.txtCCCDNK.Location = new System.Drawing.Point(100, 175);
            this.txtCCCDNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCCDNK.Name = "txtCCCDNK";
            this.txtCCCDNK.Size = new System.Drawing.Size(144, 20);
            this.txtCCCDNK.TabIndex = 34;
            // 
            // txtSDTNK
            // 
            this.txtSDTNK.Location = new System.Drawing.Point(100, 140);
            this.txtSDTNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTNK.Name = "txtSDTNK";
            this.txtSDTNK.Size = new System.Drawing.Size(144, 20);
            this.txtSDTNK.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "CCCD";
            // 
            // txtMaTDPNK
            // 
            this.txtMaTDPNK.Location = new System.Drawing.Point(100, 25);
            this.txtMaTDPNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTDPNK.Name = "txtMaTDPNK";
            this.txtMaTDPNK.Size = new System.Drawing.Size(144, 20);
            this.txtMaTDPNK.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mã Tổ Dân Phố";
            // 
            // txtTenNK
            // 
            this.txtTenNK.Location = new System.Drawing.Point(100, 101);
            this.txtTenNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNK.Name = "txtTenNK";
            this.txtTenNK.Size = new System.Drawing.Size(144, 20);
            this.txtTenNK.TabIndex = 28;
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(100, 65);
            this.txtMaNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(144, 20);
            this.txtMaNK.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Chủ Hộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Nhân Khẩu";
            // 
            // dgvNhanKhau
            // 
            this.dgvNhanKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanKhau.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvNhanKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanKhau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvNhanKhau.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvNhanKhau.Location = new System.Drawing.Point(0, 20);
            this.dgvNhanKhau.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanKhau.Name = "dgvNhanKhau";
            this.dgvNhanKhau.RowHeadersWidth = 51;
            this.dgvNhanKhau.RowTemplate.Height = 24;
            this.dgvNhanKhau.Size = new System.Drawing.Size(694, 371);
            this.dgvNhanKhau.TabIndex = 1;
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
            // Column4
            // 
            this.Column4.DataPropertyName = "dNgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sTenChuHo";
            this.Column3.HeaderText = "Tên Chủ Hộ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
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
            // FormBaoCaoNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(962, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBaoCaoNK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCaoNK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBaoCaoNK_FormClosed);
            this.Load += new System.EventHandler(this.FormBaoCaoNK_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCCCDNK;
        private System.Windows.Forms.TextBox txtSDTNK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTDPNK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenNK;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhanKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}