using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exporting_a_Report_from_Code
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\TwoSimpleLists.mrt");
            report.Print();

            MessageBox.Show("The print action is complete.", "Print Report");
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\TwoSimpleLists.mrt");
            report.Render();

            var stream = new MemoryStream();
            switch (comboBoxFormat.Text)
            {
                case "PDF":
                    report.ExportDocument(StiExportFormat.Pdf, stream);
                    saveFileDialog.DefaultExt = ".pdf";
                    break;

                case "Word":
                    report.ExportDocument(StiExportFormat.Word2007, stream);
                    saveFileDialog.DefaultExt = ".docx";
                    break;

                case "Excel":
                    report.ExportDocument(StiExportFormat.Excel2007, stream);
                    saveFileDialog.DefaultExt = ".xlsx";
                    break;

                case "Text":
                    report.ExportDocument(StiExportFormat.Text, stream);
                    saveFileDialog.DefaultExt = ".txt";
                    break;

                case "Image":
                    report.ExportDocument(StiExportFormat.ImagePng, stream);
                    saveFileDialog.DefaultExt = ".png";
                    break;
            }

            saveFileDialog.FileName = report.ReportName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save to Local Storage
                using (var fileStream = File.Create(saveFileDialog.FileName))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(fileStream);
                }
            }

            MessageBox.Show("The export action is complete.", "Export Report");
        }
    }
}
