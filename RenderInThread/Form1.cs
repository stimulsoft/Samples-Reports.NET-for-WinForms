using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();

		private void button1_Click(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsApplication1.Master-Detail-Subdetail.mrt"))
            {
                report.Load(stream);
            }

			DataSet data = new DataSet();
			data.ReadXmlSchema("..\\..\\..\\Data\\demo.xsd");
            data.ReadXml("..\\..\\..\\Data\\demo.xml");

			report.RegData(data);
			report.IsRendered = false;
			report.Compile();
			report.CompiledReport.Rendering += new EventHandler(CompiledReport_Rendering);
			report.Render(false);
		}

		void CompiledReport_Rendering(object sender, EventArgs e)
		{
			button1.Invoke((EventHandler)delegate { button1.Text = report.StatusString; });
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			report.Show();
		}
	}
}