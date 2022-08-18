
namespace QuanLiNhanKhau
{
    partial class FormAccount
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
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRePassWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblShowInfor = new System.Windows.Forms.Label();
            this.ckbShowPass = new System.Windows.Forms.CheckBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.SeaShell;
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWord.Location = new System.Drawing.Point(143, 121);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(169, 20);
            this.txtPassWord.TabIndex = 8;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.LightGray;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(143, 85);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(169, 20);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài Khoản:";
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.BackColor = System.Drawing.Color.SeaShell;
            this.txtNewPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassWord.Location = new System.Drawing.Point(143, 157);
            this.txtNewPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.Size = new System.Drawing.Size(169, 20);
            this.txtNewPassWord.TabIndex = 10;
            this.txtNewPassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txtRePassWord
            // 
            this.txtRePassWord.BackColor = System.Drawing.Color.SeaShell;
            this.txtRePassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePassWord.Location = new System.Drawing.Point(143, 193);
            this.txtRePassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtRePassWord.Name = "txtRePassWord";
            this.txtRePassWord.Size = new System.Drawing.Size(169, 20);
            this.txtRePassWord.TabIndex = 12;
            this.txtRePassWord.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(42, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhập lại mật khẩu:";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChangePass.Location = new System.Drawing.Point(79, 270);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(124, 33);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(232, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 33);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblShowInfor
            // 
            this.lblShowInfor.AutoSize = true;
            this.lblShowInfor.Location = new System.Drawing.Point(143, 219);
            this.lblShowInfor.Name = "lblShowInfor";
            this.lblShowInfor.Size = new System.Drawing.Size(0, 13);
            this.lblShowInfor.TabIndex = 15;
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.Location = new System.Drawing.Point(143, 236);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(109, 17);
            this.ckbShowPass.TabIndex = 17;
            this.ckbShowPass.Text = "Hiển thị mật khẩu";
            this.ckbShowPass.UseVisualStyleBackColor = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.LightSalmon;
            this.pnTitle.Controls.Add(this.label2);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(386, 74);
            this.pnTitle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÀI KHOẢN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAccount
            // 
            this.AcceptButton = this.btnChangePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(386, 314);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.lblShowInfor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtRePassWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccount";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRePassWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblShowInfor;
        private System.Windows.Forms.CheckBox ckbShowPass;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label2;
    }
}