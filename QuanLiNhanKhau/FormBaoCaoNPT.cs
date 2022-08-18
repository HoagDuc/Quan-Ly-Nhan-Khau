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
    public partial class FormBaoCaoNPT : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        FormNPT cur_frmNPT;
        public FormBaoCaoNPT(FormNPT frmNPT)
        {
            cur_frmNPT = frmNPT;
            InitializeComponent();
        }
        void hienNPT(string dieukienloc = "")
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC SP_NguoiPhuThuoc";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvNPT.DataSource = table;
            DataView dvNPT = new DataView(table);

            if (!string.IsNullOrEmpty(dieukienloc))
                dvNPT.RowFilter = dieukienloc;
            dgvNPT.DataSource = dvNPT;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = string.Format("sMaNPT <> ''");
            if (!string.IsNullOrEmpty(txtMaNPT.Text.Trim()))
                filter += string.Format(" AND sMaNPT LIKE '*{0}*'", txtMaNPT.Text);
            if (!string.IsNullOrEmpty(txtMaNK.Text.Trim()))
                filter += string.Format(" AND sMaNhanKhau LIKE '*{0}*'", txtMaNK.Text);
            if (!string.IsNullOrEmpty(txtTenNPT.Text.Trim()))
                filter += string.Format(" AND sHoTen LIKE '*{0}*'", txtTenNPT.Text);

            hienNPT(filter);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
                //bt
            FormReportNPT f = new FormReportNPT();
            f.Show();

                //indgv
            /*DataSetNPT ds = new DataSetNPT();
            DataTable dt = new DataTable();
            dt.Columns.Add("sMaNhanKhau", typeof(string));
            dt.Columns.Add("sMaNPT", typeof(string));
            dt.Columns.Add("sHoTen", typeof(string));
            dt.Columns.Add("sNgheNghiep", typeof(string));
            dt.Columns.Add("sGioiTinh", typeof(string));
            dt.Columns.Add("sQHvsCH", typeof(string));

            foreach(DataGridViewRow dgv in dgvNPT.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value,
                    dgv.Cells[4].Value, dgv.Cells[5].Value)
            }

            ds.Tables.Add(dt);
            FormReportNPT f = new FormReportNPT();
            ReportNPT cr = new ReportNPT();
            cr.SetDataSource(ds);
            f.crystalReportViewer1.ReportSource = cr;
            f.crystalReportViewer1.Refresh();
            f.Show();*/

            //lỗi
            /*string filter = string.Format("{0} <> ''", "{tbl_NguoiPhuThuoc.sMaNPT}");

            if (!string.IsNullOrEmpty(txtMaNPT.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NguoiPhuThuoc.sMaNPT}", txtMaNPT.Text);
            if (!string.IsNullOrEmpty(txtMaNK.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NguoiPhuThuoc.sMaNhanKhau}", txtMaNK.Text);
            if (!string.IsNullOrEmpty(txtTenNPT.Text.Trim()))
                filter += string.Format(" AND {0} LIKE '*{1}*'", "{tbl_NguoiPhuThuoc.sHoTen}", txtTenNPT.Text);


            FormReportNPT reportViewForm = Program.FindOpenedForm("FormReportNPT") as FormReportNPT;
            if (reportViewForm == null)
                reportViewForm = new FormReportNPT();

            reportViewForm.Show();
            reportViewForm.ShowReport("ReportNPT.rpt", filter, "Báo Cáo Người Phụ Thuộc");
            reportViewForm.Activate();*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNPT.Text
                = txtMaNK.Text
                = txtTenNPT.Text
                = string.Empty;
            txtMaNPT.Focus();
            conn.Open();
            hienNPT();
            conn.Close();
        }

        private void FormBaoCaoNPT_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            hienNPT();
            conn.Close();
        }
    }
}
