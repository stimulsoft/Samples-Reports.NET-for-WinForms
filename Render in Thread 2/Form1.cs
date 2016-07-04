using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;
using System.Reflection;

namespace RenderInThread2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            for (int index = 0; index < 5; index++)
            {
                var worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
                worker.RunWorkerAsync();
            }
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
            var report = new StiReport();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RenderInThread2.Master-Detail-Subdetail.mrt"))
            {
                report.Load(stream);
            }

			DataSet data = new DataSet();
			data.ReadXmlSchema("..\\..\\..\\Data\\demo.xsd");
            data.ReadXml("..\\..\\..\\Data\\demo.xml");

			report.RegData(data);
			report.IsRendered = false;
			report.Compile();
			report.Render(false);
		}
	}
}