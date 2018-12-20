using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ExportManyFilesToOneBigPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
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
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ExportManyFilesToOneBigPDF.MasterDetail.mdc"))
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
