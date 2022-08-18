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
    public partial class FormLogin : Form
    {
        public static string UsertName = "";
        int dem = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                conn.Open();
                string userName = txtUserName.Text.Trim();
                string passWord = txtPassWord.Text.Trim();
                
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SP_AuthoLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passWord;
                cmd.Connection = conn;

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);

                SqlDataReader reader = cmd.ExecuteReader();
                
                
                    if (code == 0)
                    {
                        FormHomeUser frmhome = new FormHomeUser(this);
                        frmhome.Show();
                        this.Hide();
                        FormAccount.UsertName = txtUserName.Text;
                    }
                    else if (code == 1)
                    {
                        FormHome frmhome = new FormHome(this);
                        frmhome.Show();
                        this.Hide();
                        FormAccount.UsertName = txtUserName.Text; // chú ý dòng này
                    }
                    else if (code == 2)
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Red;
                        lblShowInfor.Text = "Tài khoản không chính xác!";
                        txtPassWord.Text = "";
                        txtUserName.Text = "";
                        txtUserName.Focus();
                        dem++;
                    if (dem > 3)
                    {
                        MessageBox.Show("Bạn đã đăng nhập quá 3 lần", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
                    else
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Red;
                        lblShowInfor.Text = "Tài khoản không tồn tại!";
                        txtPassWord.Text = "";
                        txtUserName.Text = "";
                        txtUserName.Focus();
                        dem++;
                    if (dem > 3)
                    {
                        MessageBox.Show("Bạn đã đăng nhập quá 3 lần", "Cảnh báo", MessageBoxButtons.OK);
                    }
                    //MessageBox.Show("a"+dem+"a", "Cảnh báo", MessageBoxButtons.OK);
                }
                
                //if (dem < 3)
                
                    


                


                /*string sql = "select *from tbl_User where taikhoan = N'" + userName + "' and matkhau = N'" + passWord + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    FormHome frmhome = new FormHome(this);
                    frmhome.Show();
                    this.Hide();
                    FormAccount.UsertName = txtUserName.Text; // chú ý dòng này
                }
                else
                {
                    lblShowInfor.ForeColor = System.Drawing.Color.Red;
                    lblShowInfor.Text = "Tài khoản không chính xác!";
                }*/


                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối", "lỗi");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không ? ", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bạn sẽ được thoát khỏi chương trình !", "Thông Báo Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked)
                txtPassWord.UseSystemPasswordChar = false;
            else txtPassWord.UseSystemPasswordChar = true;
        }
    }
}
