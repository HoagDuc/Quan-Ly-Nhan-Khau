
namespace QuanLiNhanKhau
{
    partial class FormHome
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
            this.btnQLNhanKhau = new System.Windows.Forms.Button();
            this.btnQLTDP = new System.Windows.Forms.Button();
            this.btnQLPhuong = new System.Windows.Forms.Button();
            this.btnQLNPT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAccouontManager = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnTitle.Size = new System.Drawing.Size(671, 74);
            this.pnTitle.TabIndex = 2;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANG CHỦ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnQLNhanKhau
            // 
            this.btnQLNhanKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQLNhanKhau.BackColor = System.Drawing.Color.LightSalmon;
            this.btnQLNhanKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanKhau.Location = new System.Drawing.Point(0, 174);
            this.btnQLNhanKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLNhanKhau.Name = "btnQLNhanKhau";
            this.btnQLNhanKhau.Size = new System.Drawing.Size(151, 77);
            this.btnQLNhanKhau.TabIndex = 6;
            this.btnQLNhanKhau.Text = "QUẢN LÍ NHÂN KHẨU";
            this.btnQLNhanKhau.UseVisualStyleBackColor = false;
            this.btnQLNhanKhau.Click += new System.EventHandler(this.btnQLNhanKhau_Click);
            // 
            // btnQLTDP
            // 
            this.btnQLTDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLTDP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnQLTDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTDP.Location = new System.Drawing.Point(325, 2);
            this.btnQLTDP.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLTDP.Name = "btnQLTDP";
            this.btnQLTDP.Size = new System.Drawing.Size(148, 77);
            this.btnQLTDP.TabIndex = 7;
            this.btnQLTDP.Text = "QUẢN LÍ TỔ DÂN PHỐ";
            this.btnQLTDP.UseVisualStyleBackColor = false;
            this.btnQLTDP.Click += new System.EventHandler(this.btnQLTDP_Click);
            // 
            // btnQLPhuong
            // 
            this.btnQLPhuong.BackColor = System.Drawing.Color.LightSalmon;
            this.btnQLPhuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhuong.Location = new System.Drawing.Point(0, 2);
            this.btnQLPhuong.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLPhuong.Name = "btnQLPhuong";
            this.btnQLPhuong.Size = new System.Drawing.Size(151, 77);
            this.btnQLPhuong.TabIndex = 8;
            this.btnQLPhuong.Text = "QUẢN LÍ PHƯỜNG";
            this.btnQLPhuong.UseVisualStyleBackColor = false;
            this.btnQLPhuong.Click += new System.EventHandler(this.btnQLPhuong_Click);
            // 
            // btnQLNPT
            // 
            this.btnQLNPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLNPT.BackColor = System.Drawing.Color.LightSalmon;
            this.btnQLNPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNPT.Location = new System.Drawing.Point(322, 174);
            this.btnQLNPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLNPT.Name = "btnQLNPT";
            this.btnQLNPT.Size = new System.Drawing.Size(151, 77);
            this.btnQLNPT.TabIndex = 9;
            this.btnQLNPT.Text = "QUẢN LÍ NGƯỜI PHỤ THUỘC";
            this.btnQLNPT.UseVisualStyleBackColor = false;
            this.btnQLNPT.Click += new System.EventHandler(this.btnQLNPT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQLPhuong);
            this.panel1.Controls.Add(this.btnQLNPT);
            this.panel1.Controls.Add(this.btnQLTDP);
            this.panel1.Controls.Add(this.btnQLNhanKhau);
            this.panel1.Location = new System.Drawing.Point(97, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 251);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.LightCoral;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(288, 396);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 43);
            this.btnDangXuat.TabIndex = 11;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.BackColor = System.Drawing.Color.LightCoral;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(97, 396);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(94, 43);
            this.btnAccount.TabIndex = 12;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAccouontManager
            // 
            this.btnAccouontManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccouontManager.BackColor = System.Drawing.Color.LightCoral;
            this.btnAccouontManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccouontManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccouontManager.Location = new System.Drawing.Point(419, 396);
            this.btnAccouontManager.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccouontManager.Name = "btnAccouontManager";
            this.btnAccouontManager.Size = new System.Drawing.Size(151, 43);
            this.btnAccouontManager.TabIndex = 13;
            this.btnAccouontManager.Text = "Quản Lý Tài Khoản";
            this.btnAccouontManager.UseVisualStyleBackColor = false;
            this.btnAccouontManager.Click += new System.EventHandler(this.btnAccouontManager_Click);
            // 
            // FormHome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(671, 492);
            this.Controls.Add(this.btnAccouontManager);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLNhanKhau;
        private System.Windows.Forms.Button btnQLTDP;
        private System.Windows.Forms.Button btnQLPhuong;
        private System.Windows.Forms.Button btnQLNPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAccouontManager;
    }
}