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
    public partial class FormBaoCaoNK : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        FormNhanKhau cur_frmNK;

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
            
        }
        public FormBaoCaoNK(FormNhanKhau frmNK)
        {
            cur_frmNK = frmNK;
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = string.Format("sMaNhanKhau <> ''");
            if (!string.IsNullOrEmpty(txtMaTDPNK.Text.Trim()))
                filter += string.Format(" AND sMaTDP LIKE '*{0}*'", txtMaTDPNK.Text);
            if (!string.IsNullOrEmpty(txtMaNK.Text.Trim()))
                filter += string.Format(" AND sMaNhanKhau LIKE '*{0}*'", txtMaNK.Text);
            if (!string.IsNullOrEmpty(txtTenNK.Text.Trim()))
                filter += string.Format(" AND sTenChuHo LIKE '*{0}*'", txtTenNK.Text);
            if (!string.IsNullOrEmpty(txtSDTNK.Text.Trim()))
                filter += string.Format(" AND sDienThoai LIKE '*{0}*'", txtSDTNK.Text);
            if (!string.IsNullOrEmpty(txtCCCDNK.Text.Trim()))
                filter += string.Format(" AND sSoCCCD LIKE '*{0}*'", txtCCCDNK.Text);
            
            hienNK(filter);
        }

        private void FormBaoCaoNK_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienNK();
            conn.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            cur_frmNK.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string filter = string.Format("{0} <> ''", "{tbl_NhanKhau.sMaNhanKhau}");

            if (!string.IsNullOrEmpty(txtMaTDPNK.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NhanKhau.sMaTDP}", txtMaTDPNK.Text);
            if (!string.IsNullOrEmpty(txtMaNK.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NhanKhau.sMaNhanKhau}", txtMaNK.Text);
            if (!string.IsNullOrEmpty(txtTenNK.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NhanKhau.sTenChuHo}", txtTenNK.Text);
            if (!string.IsNullOrEmpty(txtSDTNK.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NhanKhau.sDienThoai}", txtSDTNK.Text);
            if (!string.IsNullOrEmpty(txtCCCDNK.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NhanKhau.sSoCCCD}", txtCCCDNK.Text);



            reportNhanKhau reportViewForm = Program.FindOpenedForm("reportNhanKhau") as reportNhanKhau;
            if (reportViewForm == null)
                reportViewForm = new reportNhanKhau();

            reportViewForm.Show();
            reportViewForm.ShowReport("NhanKhau.rpt", filter, "Báo Cáo Nhân Khẩu");
            reportViewForm.Activate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNK.Text
                = txtMaTDPNK.Text
                = txtTenNK.Text
                = txtSDTNK.Text
                = txtCCCDNK.Text
                = string.Empty;
            txtMaTDPNK.Focus();
            conn.Open();
            hienNK();
            conn.Close();
        }

        private void FormBaoCaoNK_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            cur_frmNK.Show();
        }
    }
}
