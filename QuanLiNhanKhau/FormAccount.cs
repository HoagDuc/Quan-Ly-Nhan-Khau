using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    public partial class FormAccount : Form
    {
        public static string UsertName = "";
        public FormAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool KiemTra()
        {
            if (txtPassWord.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !";
                txtPassWord.Focus();
                return false;
            }
            else if (txtNewPassWord.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !";
                txtNewPassWord.Focus();
                return false;
            }
            else if (txtRePassWord.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !";
                txtRePassWord.Focus();
                return false;
            }
            else if (txtNewPassWord.Text != txtRePassWord.Text)
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận khác nhau !";
                txtNewPassWord.Focus();
                txtNewPassWord.SelectAll();
                return false;
            }
            return true;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_Update_Pass";
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUserName.Text;
                    cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txtPassWord.Text;
                    cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtNewPassWord.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Blue;
                        lblShowInfor.Text = dr.GetString(1);
                        txtRePassWord.Text = "";
                        txtPassWord.Text = "";
                        txtNewPassWord.Text = "";
                        txtPassWord.Focus();
                    }
                    else
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Red;
                        lblShowInfor.Text = dr.GetString(1);
                        txtPassWord.Focus();
                        txtPassWord.SelectAll();
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            txtUserName.Text = UsertName;
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
                txtNewPassWord.UseSystemPasswordChar = false;
                txtRePassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
                txtNewPassWord.UseSystemPasswordChar = true;
                txtRePassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
