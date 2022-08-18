
namespace QuanLiNhanKhau
{
    partial class FormBaoCaoNPT
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNPT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNPT = new System.Windows.Forms.TextBox();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.dgvNPT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuayLai.BackColor = System.Drawing.Color.Coral;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(154, 312);
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
            this.btnTimKiem.Location = new System.Drawing.Point(27, 252);
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
            this.btnBaoCao.Location = new System.Drawing.Point(154, 252);
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
            this.btnClear.Location = new System.Drawing.Point(27, 312);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 33);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNPT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(701, 393);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Khẩu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO NGƯỜI PHỤ THUỘC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtMaNPT);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtTenNPT);
            this.panel1.Controls.Add(this.txtMaNK);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(701, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 392);
            this.panel1.TabIndex = 22;
            // 
            // txtMaNPT
            // 
            this.txtMaNPT.Location = new System.Drawing.Point(100, 36);
            this.txtMaNPT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNPT.Name = "txtMaNPT";
            this.txtMaNPT.Size = new System.Drawing.Size(144, 20);
            this.txtMaNPT.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mã NPT";
            // 
            // txtTenNPT
            // 
            this.txtTenNPT.Location = new System.Drawing.Point(100, 112);
            this.txtTenNPT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNPT.Name = "txtTenNPT";
            this.txtTenNPT.Size = new System.Drawing.Size(144, 20);
            this.txtTenNPT.TabIndex = 26;
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(100, 76);
            this.txtMaNK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(144, 20);
            this.txtMaNK.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã Nhân Khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tên NPT";
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.LightSalmon;
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(968, 74);
            this.pnTitle.TabIndex = 20;
            // 
            // dgvNPT
            // 
            this.dgvNPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNPT.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvNPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvNPT.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvNPT.Location = new System.Drawing.Point(7, 14);
            this.dgvNPT.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNPT.Name = "dgvNPT";
            this.dgvNPT.RowHeadersWidth = 51;
            this.dgvNPT.RowTemplate.Height = 24;
            this.dgvNPT.Size = new System.Drawing.Size(694, 378);
            this.dgvNPT.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sMaNPT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Người Phụ Thuộc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sMaNhanKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Nhân Khẩu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sHoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Người Phụ Thuộc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sNgheNghiep";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nghề Nghiệp";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sGioiTinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sQHvsCH";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quan Hệ Với Chủ Hộ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FormBaoCaoNPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBaoCaoNPT";
            this.Text = "FormBaoCaoNPT";
            this.Load += new System.EventHandler(this.FormBaoCaoNPT_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.TextBox txtMaNPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNPT;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvNPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}