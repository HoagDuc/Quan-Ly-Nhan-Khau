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
    public partial class FormNPT : Form
    {
        FormHome cur_frmhome;
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void hienNPT(string dieukienloc = "")
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC SP_NguoiPhuThuoc";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvNPT.DataSource = table;
            DataView dvPhuong = new DataView(table);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvPhuong.RowFilter = dieukienloc;
            dgvNPT.DataSource = dvPhuong;
            txtMaNK.Enabled = txtMaNPT.Enabled = true;
            btnSuaNPT.Enabled = btnXoaNPT.Enabled = (dgvNPT.Rows.Count > 0);
        }

        private void ChuyenTrangThaiSua(DataRowView drvNPT)
        {
            txtMaNK.Text = drvNPT["sMaNhanKhau"].ToString();
            txtMaNPT.Text = drvNPT["sMaNPT"].ToString();
            txtTenNPT.Text = drvNPT["sHoTen"].ToString();
            txtNgheNghiep.Text = drvNPT["sNgheNghiep"].ToString();
            txtQHVCH.Text = drvNPT["sQHvsCH"].ToString();
            rbNu.Checked = drvNPT["sGioiTinh"].ToString().Trim() == "Nữ";
            
            btnThemNPT.Text = "Cập Nhật";
            btnThemNPT.Enabled = true;

            btnSuaNPT.Enabled =
                btnXoaNPT.Enabled =
                btnBaoCaoNPT.Enabled =
                txtMaNK.Enabled =
                txtMaNPT.Enabled = false;
        }

        public FormNPT(FormHome frmhome)
        {
            cur_frmhome = frmhome;
            InitializeComponent();
        }

        private void FormNPT_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienNPT();
            conn.Close();
        }

        private void btnThemNPT_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                string gioitinh = "Nam";
                if (rbNu.Checked == true)
                {
                    gioitinh = "Nữ";
                }

                if (btnThemNPT.Text == "Thêm")
                    cmd.CommandText = "EXEC SP_ThemNguoiPhuThuoc N'" + txtMaNK.Text + "', N'" + txtMaNPT.Text + "', N'" + txtTenNPT.Text + "', '" + txtNgheNghiep.Text + "', N'" + gioitinh + "', '" + txtQHVCH.Text + "'";
                if (btnThemNPT.Text == "Cập Nhật")
                    cmd.CommandText = "EXEC sp_update_tblNguoiPhuThuoc N'" + txtMaNK.Text + "', N'" + txtMaNPT.Text + "', N'" + txtTenNPT.Text + "', '" + txtNgheNghiep.Text + "', N'" + gioitinh + "', '" + txtQHVCH.Text + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                hienNPT();
                conn.Close();
                btnClearNPT_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
                conn.Close();
            }
        }

        private void btnClearNPT_Click(object sender, EventArgs e)
        {
            txtMaNK.Text
                = txtMaNPT.Text
                = txtTenNPT.Text
                = txtNgheNghiep.Text
                = txtQHVCH.Text
                = string.Empty;
            txtMaNK.Focus();
            rbNam.Checked = true;

            btnThemNPT.Text = "Thêm";
            conn.Open();
            hienNPT();
            conn.Close();
        }

        private void btnSuaNPT_Click(object sender, EventArgs e)
        {
            DataView dvNPT = (DataView)dgvNPT.DataSource;
            DataRowView drvNPT = dvNPT[dgvNPT.CurrentRow.Index];
            ChuyenTrangThaiSua(drvNPT);
        }

        private void btnXoaNPT_Click(object sender, EventArgs e)
        {
            DataView dvNPT = (DataView)dgvNPT.DataSource;
            DataRowView drvNPT = dvNPT[dgvNPT.CurrentRow.Index];
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC sp_delete_tblNguoiPhuThuoc  N'" + drvNPT["sMaNPT"].ToString() + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                hienNPT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            conn.Close();
        }

        private void btnBaoCaoNPT_Click(object sender, EventArgs e)
        {
            FormBaoCaoNPT f = new FormBaoCaoNPT(this);
            f.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cur_frmhome.Show();
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
            FormNhanKhau frmnk = new FormNhanKhau(cur_frmhome);
            frmnk.Show();
        }

        private void FormNPT_FormClosed(object sender, FormClosedEventArgs e)
        {
            cur_frmhome.Show();
        }

        private void txtMaNK_TextChanged(object sender, EventArgs e)
        {
            btnThemNPT.Enabled = (txtMaNK.Text.Trim().Length > 0) &&
                (txtMaNPT.Text.Trim().Length > 0);
        }
    }
}
