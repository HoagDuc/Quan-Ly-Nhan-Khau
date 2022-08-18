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
    public partial class FormPhuong : Form
    {
        FormHome cur_frmhome;
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void hienPhuong(string dieukienloc = "")
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC sp_select_tblPhuong";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DataView dvPhuong = new DataView(table);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvPhuong.RowFilter = dieukienloc;
            dgvPhuong.DataSource = dvPhuong;
            txtMaPhuong.Enabled = true;
            btnSuaP.Enabled = btnXoaP.Enabled = (dgvPhuong.Rows.Count > 0);
        }

        private void chuyenTrangThaiSua(DataRowView drvPhuong)
        {
            txtMaPhuong.Text = drvPhuong["sMaPhuong"].ToString();
            txtTenPhuong.Text = drvPhuong["sTenPhuong"].ToString();
            txtSDT.Text = drvPhuong["sSDTKhanCap"].ToString();


            btnThemP.Text = "Cập Nhật";
            btnThemP.Enabled = true;

            btnSuaP.Enabled =
                btnXoaP.Enabled =
                btnTimKiemP.Enabled =
                txtMaPhuong.Enabled = false;
        }
        public FormPhuong(FormHome frmhome)
        {
            cur_frmhome = frmhome;
            InitializeComponent();
        }

        private void FormPhuong_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienPhuong();
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaPhuong.Text
                = txtTenPhuong.Text
                = txtSDT.Text
                = string.Empty;
            txtMaPhuong.Focus();

            btnThemP.Text = "Thêm";
            conn.Open();
            hienPhuong();
            conn.Close();
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                if (btnThemP.Text == "Thêm")
                    cmd.CommandText = "EXEC sp_insert_tblPhuong N'" + txtMaPhuong.Text + "', N'" + txtTenPhuong.Text + "', N'" + txtSDT.Text + "'";
                if (btnThemP.Text == "Cập Nhật")
                    cmd.CommandText = "EXEC sp_update_tblPhuong N'" + txtMaPhuong.Text + "', N'" + txtTenPhuong.Text + "', N'" + txtSDT.Text + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                hienPhuong();
                conn.Close();
                btnClear_Click(sender, e);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
                conn.Close();
            }
        }

        private void txtMaPhuong_TextChanged(object sender, EventArgs e)
        {
            btnThemP.Enabled = (txtMaPhuong.Text.Trim().Length > 0);
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            DataView dvPhuong = (DataView)dgvPhuong.DataSource;
            DataRowView drvPhuong= dvPhuong[dgvPhuong.CurrentRow.Index];
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC sp_delete_tblPhuong  N'" + drvPhuong["sMaPhuong"].ToString() + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                hienPhuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            DataView dvPhuong = (DataView)dgvPhuong.DataSource;
            DataRowView drvPhuong = dvPhuong[dgvPhuong.CurrentRow.Index];
            chuyenTrangThaiSua(drvPhuong);
        }
        private void btnTimKiemP_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cur_frmhome.Show();
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

        private void tsmiQLTDP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormToDanPho frmtdp = new FormToDanPho(cur_frmhome);
            frmtdp.Show();
        }

        private void quảnLíNhânKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FormPhuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            cur_frmhome.Show();
        }
    }
}
