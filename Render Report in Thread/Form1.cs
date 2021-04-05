using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace RenderInThread
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

        Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();

		private void button1_Click(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RenderInThread.MasterDetailSubdetail.mrt"))
            {
                report.Load(stream);
            }

			report.IsRendered = false;
			report.Compile();
			report.CompiledReport.Rendering += new EventHandler(CompiledReport_Rendering);
			report.Render(false);
		}

		private void CompiledReport_Rendering(object sender, EventArgs e)
		{
			button1.Invoke((EventHandler)delegate
			{
				button1.Text = report.StatusString;
			});
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			report.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			for (int index = 0; index < 5; index++)
			{
				var worker = new BackgroundWorker();
				worker.DoWork += new DoWorkEventHandler(backgroundWorker2_DoWork);
				worker.RunWorkerAsync();
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			var report = new StiReport();
			using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RenderInThread.MasterDetailSubdetail.mrt"))
			{
				report.Load(stream);
			}

			report.IsRendered = false;
			report.EndRender += new EventHandler(ReportTemplate_EndRender);
			report.Render(false);
		}

		private void ReportTemplate_EndRender(object sender, EventArgs e)
		{
			button1.Invoke((EventHandler)delegate {
				label1.Text = label1.Text + " OK";
			});
		}
	}
}