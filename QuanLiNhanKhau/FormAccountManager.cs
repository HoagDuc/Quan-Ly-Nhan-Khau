using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    public partial class FormAccountManager : Form
    {
        public FormAccountManager()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAccountManager_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()
        {
            SqlConnection conn = new SqlConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable data = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                conn.Open();
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.CommandText = "SP_tblDangNhap";
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Connection = conn;
                adapter.Fill(data);
                dataGridViewAccount.DataSource = data;
                conn.Close();
                dataGridViewAccount.Columns[0].Width = 80;
                dataGridViewAccount.Columns[0].HeaderText = "Tài khoản";
                dataGridViewAccount.Columns[1].Width = 100;
                dataGridViewAccount.Columns[1].HeaderText = "Mật khẩu";
                dataGridViewAccount.Columns[2].Width = 100;
                dataGridViewAccount.Columns[2].HeaderText = "Loại tài khoản";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChuyenTrangThaiSua(DataRowView drvAccount)
        {
            txtUserName.Text = drvAccount["sMaNhanKhau"].ToString();
            txtPassWord.Text = drvAccount["sMaNPT"].ToString();
            if (drvAccount["sLoaitk"].ToString() == "admin")
            {
                cbbSaff.Text = "admin";
            }
            else
            {
                cbbSaff.Text = "user";
            }

            btnAdd.Text = "Cập Nhật";
            btnAdd.Enabled = true;

            btnEdit.Enabled =
                btnRemove.Enabled =
                txtUserName.Enabled = false;
        }
        public bool KTThongTin()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }
            if (txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassWord.Focus();
                return false;
            }
            if (cbbSaff.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassWord.Focus();
                return false;
            }
            return true;
        }

        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dataGridViewAccount.CurrentRow.Index;
                txtUserName.Text = dataGridViewAccount.Rows[i].Cells[0].Value.ToString();
                txtPassWord.Text = dataGridViewAccount.Rows[i].Cells[1].Value.ToString();

                if (dataGridViewAccount.Rows[i].Cells[2].Value.ToString() == "admin")
                {
                    cbbSaff.Text = "admin";
                }
                else
                {
                    cbbSaff.Text = "user";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_ThemDangNhap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = txtUserName.Text;
                    cmd.Parameters.Add("@passWord", SqlDbType.NVarChar).Value = txtPassWord.Text;
                    cmd.Parameters.Add("@loaitk", SqlDbType.NVarChar).Value = cbbSaff.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    loaddata();
                    MessageBox.Show("Đã thêm mới tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_SuaDangNhap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = txtUserName.Text;
                    cmd.Parameters.Add("@passWord", SqlDbType.NVarChar).Value = txtPassWord.Text;
                    cmd.Parameters.Add("@loaitk", SqlDbType.NVarChar).Value = cbbSaff.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    loaddata();
                    MessageBox.Show("Đã sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa tài khoản", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "SP_XoaDangNhap";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = txtUserName.Text.ToString();

                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        loaddata();

                        MessageBox.Show("Đã xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
