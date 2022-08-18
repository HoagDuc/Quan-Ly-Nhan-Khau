using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    public partial class reportNhanKhau : Form
    {
        public reportNhanKhau()
        {
            InitializeComponent();
        }

        public void ShowReport(string reportName, string reportFilter = "", string recordTitle = "")
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
        }

        private void reportNhanKhau_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\learning\C#\QuanLiNhanKhau\QuanLiNhanKhau\NhanKhau.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
