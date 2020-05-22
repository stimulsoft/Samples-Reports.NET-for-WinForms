using Stimulsoft.Report;
using System;
using System.Data;
using System.Windows.Forms;

namespace Asynchronous_Render_and_Export
{
    public partial class FormMain : Form
    {
        public StiReport Report { get; set; }

        public FormMain()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();

            labelLoad.Text = "Loading... ";
            Report = GetReport("Master-Detail.mrt");
            labelLoad.Text += "OK";
        }

        private StiReport GetReport(string name)
        {
            var dataSet = new DataSet();
            dataSet.ReadXmlSchema("..\\..\\Data\\Demo.xsd");
            dataSet.ReadXml("..\\..\\Data\\Demo.xml");

            var report = new StiReport();
            report.Load("..\\..\\Reports\\" + name);
            report.RegData(dataSet);

            return report;
        }

        private async void buttonRender_Click(object sender, EventArgs e)
        {
            labelRender.Text = "Rendering... ";

            await Report.CompileAsync(); // if compilation is needed
            await Report.RenderAsync();

            labelRender.Text += "OK";
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = Report.ReportName + ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelExport.Text = "Exporting... ";

                await Report.ExportDocumentAsync(StiExportFormat.Pdf, saveFileDialog.FileName);

                labelExport.Text += "OK";
            }
        }
    }
}
