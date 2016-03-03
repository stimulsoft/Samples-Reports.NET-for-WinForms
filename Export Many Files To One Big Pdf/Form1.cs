using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Export_Many_Files_To_One_Big_Pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExportClick(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.ReportCacheMode = StiReportCacheMode.On;
            report.RenderedPages.CanUseCacheMode = true;
            report.RenderedPages.CacheMode = true;
            report.RenderedPages.Clear();

            var tempReport = new StiReport();
            for (int index = 0; index < 1000; index++)
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Export_Many_Files_To_One_Big_Pdf.MasterDetail.mdc"))
                {
                    tempReport.LoadDocument(stream);
                }
                tempReport.ReportUnit = report.ReportUnit;

                foreach (StiPage page in tempReport.RenderedPages)
                {
                    page.Report = tempReport;
                    page.Guid = System.Guid.NewGuid().ToString().Replace("-", "");
                    report.RenderedPages.Add(page);
                }
            }

            report.ExportDocument(StiExportFormat.Pdf, "d:\\1.pdf");
        }
    }
}
