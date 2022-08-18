
namespace QuanLiNhanKhau
{
    partial class FormAccountManager
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
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSaff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Location = new System.Drawing.Point(290, 24);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.Size = new System.Drawing.Size(324, 280);
            this.dataGridViewAccount.TabIndex = 25;
            this.dataGridViewAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(35, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRemove.Location = new System.Drawing.Point(197, 148);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEdit.Location = new System.Drawing.Point(116, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAdd.Location = new System.Drawing.Point(35, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(116, 72);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(156, 20);
            this.txtPassWord.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mật khẩu:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(116, 30);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 20);
            this.txtUserName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Loại tài khoản:";
            // 
            // cbbSaff
            // 
            this.cbbSaff.FormattingEnabled = true;
            this.cbbSaff.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbbSaff.Location = new System.Drawing.Point(116, 113);
            this.cbbSaff.Name = "cbbSaff";
            this.cbbSaff.Size = new System.Drawing.Size(156, 21);
            this.cbbSaff.TabIndex = 27;
            // 
            // FormAccountManager
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(626, 325);
            this.Controls.Add(this.cbbSaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccountManager";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormAccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSaff;
    }
}