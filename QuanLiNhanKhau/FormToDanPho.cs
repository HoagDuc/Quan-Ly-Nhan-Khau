using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    public partial class FormToDanPho : Form
    {
        FormHome cur_frmhome;
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void hienTDP(string dieukienloc = "")
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC sp_select_tblToDanPho";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvTDP.DataSource = table;
            DataView dvPhuong = new DataView(table);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvPhuong.RowFilter = dieukienloc;
            dgvTDP.DataSource = dvPhuong;
            txtMaPhuong.Enabled = txtMaTDP.Enabled = true;
            btnSuaTDP.Enabled = btnXoaTDP.Enabled = (dgvTDP.Rows.Count > 0);
        }

        private void chuyenTrangThaiSua(DataRowView drvTDP)
        {
            txtMaPhuong.Text = drvTDP["sMaPhuong"].ToString();
            txtMaTDP.Text = drvTDP["sMaTDP"].ToString();
            txtTenTDP.Text = drvTDP["sTenTDP"].ToString();
            txtTenCSKV.Text = drvTDP["sTenCSKV"].ToString();
            txtTenToTruong.Text = drvTDP["sTenToTruong"].ToString();
            txtSDTLH.Text = drvTDP["sSoDTLH"].ToString();

            btnThemTDP.Text = "Cập Nhật";
            btnThemTDP.Enabled = true;

            btnSuaTDP.Enabled =
                btnXoaTDP.Enabled =
                btnTimKiemTDP.Enabled =
                txtMaPhuong.Enabled =
                txtMaTDP.Enabled = false;
        }
        public FormToDanPho(FormHome frmhome)
        {
            cur_frmhome = frmhome;
            InitializeComponent();
        }

        private void FormToDanPho_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienTDP();
            conn.Close();
        }

        private void txtMaPhuong_TextChanged(object sender, EventArgs e)
        {
            btnThemTDP.Enabled = (txtMaPhuong.Text.Trim().Length > 0) && 
                (txtMaTDP.Text.Trim().Length > 0);
        }


        private void btnThemTDP_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                if (btnThemTDP.Text == "Thêm")
                    cmd.CommandText = "EXEC sp_insert_tblToDanPho N'" + txtMaPhuong.Text + "', N'" + txtMaTDP.Text + "', N'" + txtTenTDP.Text + "', '" + txtTenCSKV.Text + "', N'" + txtTenToTruong.Text + "', '" + txtSDTLH.Text + "'";
                if (btnThemTDP.Text == "Cập Nhật")
                    cmd.CommandText = "EXEC sp_update_tblToDanPho N'" + txtMaPhuong.Text + "', N'" + txtMaTDP.Text + "', N'" + txtTenTDP.Text + "', '" + txtTenCSKV.Text + "', N'" + txtTenToTruong.Text + "', '" + txtSDTLH.Text + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                hienTDP();
                conn.Close();
                btnClearTDP_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
                conn.Close();
            }
        }

        private void btnClearTDP_Click(object sender, EventArgs e)
        {
            txtMaPhuong.Text
                = txtMaTDP.Text
                = txtTenTDP.Text
                = txtTenCSKV.Text
                = txtTenToTruong.Text
                = txtSDTLH.Text
                = string.Empty;
            txtMaPhuong.Focus();

            btnThemTDP.Text = "Thêm";
            conn.Open();
            hienTDP();
            conn.Close();
        }

        private void btnXoaTDP_Click(object sender, EventArgs e)
        {
            DataView dvTDP = (DataView)dgvTDP.DataSource;
            DataRowView drvTDP = dvTDP[dgvTDP.CurrentRow.Index];
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC sp_delete_tblToDanPho  N'" + drvTDP["sMaTDP"].ToString() + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                hienTDP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void btnSuaTDP_Click(object sender, EventArgs e)
        {
            DataView dvTDP = (DataView)dgvTDP.DataSource;
            DataRowView drvTDP = dvTDP[dgvTDP.CurrentRow.Index];
            chuyenTrangThaiSua(drvTDP);
        }

        private void btnTimKiemTDP_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDangXuatPhuong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không ? ", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin frmlogin = new FormLogin();
                frmlogin.Show();
            }
        }

        private void tsmiQLPhuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhuong frmphuong = new FormPhuong(cur_frmhome);
            frmphuong.Show();
        }

        private void tsmiQLNhanKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNhanKhau frmnk = new FormNhanKhau(cur_frmhome);
            frmnk.Show();
        }

        private void tsmiQLNPT_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNPT frmnpt = new FormNPT(cur_frmhome);
            frmnpt.Show();
        }

        private void FormToDanPho_FormClosing(object sender, FormClosingEventArgs e)
        {
            cur_frmhome.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cur_frmhome.Show();
        }
    }
}
