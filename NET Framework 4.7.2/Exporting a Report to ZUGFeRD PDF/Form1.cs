using Stimulsoft.Base.Theme;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Export;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Exporting_a_Report_to_ZUGFeRD_PDF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
            var report = StiReport.CreateNewReport();
            report.Load("Reports\\Invoice.mrt");
            report.Render();

            string pdfPath = "Reports\\Invoice-ZUGFeRD.pdf";
            string xmlPath = "Reports\\ZUGFeRD-sample.xml";

            byte[] xmlBuf = File.ReadAllBytes(xmlPath);

            using (var fileStream = new FileStream(pdfPath, FileMode.Create))
            {
                var settings = new StiPdfExportSettings()
                {
                    ZUGFeRDComplianceMode = StiPdfZUGFeRDComplianceMode.V2_1,
                    ZUGFeRDInvoiceData = xmlBuf,
                    ZUGFeRDConformanceLevel = "EN 16931"
                };

                report.ExportDocument(StiExportFormat.Pdf, fileStream, settings);
            }
        }
	}
}