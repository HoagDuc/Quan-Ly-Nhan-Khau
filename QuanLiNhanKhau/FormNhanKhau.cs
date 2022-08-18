using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiNhanKhau
{
    public partial class FormNhanKhau : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        FormHome cur_frmhome;

        private void hienNK(string dieukienloc = "")
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC sp_select_tblNhanKhau";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DataView dvNhanKhau = new DataView(table);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvNhanKhau.RowFilter = dieukienloc;

            dgvNhanKhau.DataSource = dvNhanKhau;
            txtMaNK.Enabled = txtMaToDanPhoNK.Enabled = true;
            btnSuaNK.Enabled = btnXoaNK.Enabled = btnBaoCaoNK.Enabled = (dgvNhanKhau.Rows.Count > 0);
        }

        private void chuyenTrangThaiSua(DataRowView drvNhanKhau)
        {
            txtMaToDanPhoNK.Text = drvNhanKhau["sMaTDP"].ToString();
            txtMaNK.Text = drvNhanKhau["sMaNhanKhau"].ToString();
            txtTenNK.Text = drvNhanKhau["sTenChuHo"].ToString();
            dtpNgaySinhNK.Text = string.Format(Convert.ToString(drvNhanKhau["dNgaySinh"]));
            txtCoQuanNK.Text = drvNhanKhau["sCoQuan"].ToString();
            txtSDTNK.Text = drvNhanKhau["sDienThoai"].ToString();
            txtCCCDNK.Text = drvNhanKhau["sSoCCCD"].ToString();

            btnThemNK.Text = "Cập Nhật";
            btnThemNK.Enabled = true;

            btnSuaNK.Enabled = 
                btnXoaNK.Enabled = 
                btnBaoCaoNK.Enabled = 
                txtMaNK.Enabled = 
                txtMaToDanPhoNK.Enabled = false;
            // Lỗi sửa mã, enable 2 cái mã khi sửa là được
        }
        public FormNhanKhau(FormHome frmhome)
        {
            cur_frmhome = frmhome;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienNK();
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                if (btnThemNK.Text == "Thêm")
                {
                        //trùng
                    string sql = "";
                    sql = "Select Count(*) From tbl_NhanKhau Where sMaNhanKhau ='" + txtMaNK.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    int val = (int)cmd.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("Mã Nhân Khẩu bị trùng!", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        cmd.CommandText = "EXEC sp_insert_tblNhanKhau N'" + txtMaToDanPhoNK.Text + "', N'" + txtMaNK.Text + "', N'" + txtTenNK.Text + "', '" + dtpNgaySinhNK.Text + "', N'" + txtCoQuanNK.Text + "', '" + txtSDTNK.Text + "', '" + txtCCCDNK.Text + "'";
                    }
                }
                if (btnThemNK.Text == "Cập Nhật")
                    cmd.CommandText = "EXEC sp_update_tblNhanKhau N'" + txtMaToDanPhoNK.Text + "', N'" + txtMaNK.Text + "', N'" + txtTenNK.Text + "', '" + dtpNgaySinhNK.Text + "', N'" + txtCoQuanNK.Text + "', '" + txtSDTNK.Text + "', '" + txtCCCDNK.Text + "'";
                cmd.ExecuteNonQuery();
                hienNK();
                conn.Close();
                btnClear_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);                
                conn.Close();
            }
        }

        private void txtMaToDanPhoNK_TextChanged(object sender, EventArgs e)
        {
            btnThemNK.Enabled = (txtMaToDanPhoNK.Text.Trim().Length > 0)
                && (txtMaNK.Text.Trim().Length > 0);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataView dvNhanKhau = (DataView)dgvNhanKhau.DataSource;
            DataRowView drvNhanKhau = dvNhanKhau[dgvNhanKhau.CurrentRow.Index];
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không ? ", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC sp_delete_tblNhanKhau  N'" + drvNhanKhau["sMaNhanKhau"].ToString() + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    hienNK();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNK.Text
                = txtMaToDanPhoNK.Text
                = txtTenNK.Text
                = dtpNgaySinhNK.Text
                = txtCoQuanNK.Text
                = txtSDTNK.Text
                = txtCCCDNK.Text
                = string.Empty;
            txtMaToDanPhoNK.Focus();

            btnThemNK.Text = "Thêm";
            conn.Open();
            hienNK();
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataView dvNhanKhau = (DataView)dgvNhanKhau.DataSource;
            DataRowView drvNhanKhau = dvNhanKhau[dgvNhanKhau.CurrentRow.Index];
            chuyenTrangThaiSua(drvNhanKhau);

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không ? ", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin frmlogin = new FormLogin();
                frmlogin.Show();
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void quảnLíPhườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhuong frmphuong = new FormPhuong(cur_frmhome);
            frmphuong.Show();
        }

        private void quảnLíTổDânPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormToDanPho frmtdp = new FormToDanPho(cur_frmhome);
            frmtdp.Show();
        }

        private void quảnLíNgườiPhụThuộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNPT frmnpt = new FormNPT(cur_frmhome);
            frmnpt.Show();
        }

        private void FormNhanKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnBaoCaoNK_Click(object sender, EventArgs e)
        {
            FormBaoCaoNK frmBaoCaoNK = new FormBaoCaoNK(this);
            frmBaoCaoNK.Show();
            this.Hide();
        }
    }
}
