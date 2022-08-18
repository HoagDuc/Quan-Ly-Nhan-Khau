using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    public partial class FormReportNPT : Form
    {
        public FormReportNPT()
        {
            InitializeComponent();
        }
        /*public void ShowReport(string reportName, string reportFilter = "", string recordTitle = "")
        {
            ReportDocument rpt = new ReportDocument();
            string path = string.Format(@"D:\learning\C#\QuanLiNhanKhau\QuanLiNhanKhau\{0}", reportName);
            rpt.Load(path);

            TableLogOnInfo logonInfo = new TableLogOnInfo();
            logonInfo.ConnectionInfo.ServerName = @"DESKTOP-9M996E6\SQLEXPRESS";
            logonInfo.ConnectionInfo.DatabaseName = "BTL_HSK_QUANLINHANKHAU";

            foreach (Table t in rpt.Database.Tables)
                t.ApplyLogOnInfo(logonInfo);
            if (!string.IsNullOrEmpty(reportFilter))
                rpt.RecordSelectionFormula = reportFilter;
            if (!string.IsNullOrEmpty(recordTitle))
                rpt.SummaryInfo.ReportTitle = recordTitle;

            crystalReportViewer1.ReportSource = rpt;
        }*/
        private void FormReportNPT_Load(object sender, EventArgs e)
        {
            ReportNPT rpt = new ReportNPT();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from tbl_NguoiPhuThuoc", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReportNPT rpt = new ReportNPT();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9M996E6\SQLEXPRESS;Initial Catalog=BTL_HSK_QUANLINHANKHAU;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from tbl_NguoiPhuThuoc where sMaNPT='"+txtMaNPT.Text+"'", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
