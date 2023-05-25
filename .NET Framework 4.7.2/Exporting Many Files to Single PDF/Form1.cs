using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Exporting_Many_Files_to_Single_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();
        }

        private void buttonExportClick(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.ReportCacheMode = StiReportCacheMode.On;
            report.RenderedPages.CanUseCacheMode = true;
            report.RenderedPages.CacheMode = true;
            report.RenderedPages.Clear();
            report.ReportUnit = StiReportUnitType.HundredthsOfInch;

            var tempReport = new StiReport();
            for (int index = 0; index < 30; index++)
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Exporting_Many_Files_to_Single_PDF.MasterDetailSubdetail.mdc"))
                {
                    tempReport.LoadDocument(stream);
                }

                foreach (StiPage page in tempReport.RenderedPages)
                {
                    page.Report = tempReport;
                    page.Guid = Guid.NewGuid().ToString().Replace("-", "");
                    report.RenderedPages.Add(page);
                }
            }

            report.ExportDocument(StiExportFormat.Pdf, "d:\\1.pdf");
        }
    }
}
