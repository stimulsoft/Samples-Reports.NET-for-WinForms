using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;
using System.Reflection;

namespace SampleProgress
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

        StiReport report = new StiReport();

		private void button1_Click(object sender, EventArgs e)
		{
			backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
			backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
			backgroundWorker1.RunWorkerAsync();

			label1.Text = "Rendering...";
			label1.Visible = true;
			progressBar1.Visible = true;

			while (backgroundWorker1.IsBusy)
				Application.DoEvents();			
		}

		void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			label1.Visible = false;
			progressBar1.Visible = false;

			report.Show();
		}

		void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			DataSet data = new DataSet();
			data.ReadXml("..\\..\\Data\\Demo.xml");

			report.RegData(data);
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SampleProgress.Master-Detail-Subdetail.mrt"))
            {
                report.Load(stream);
            }

			report.Compile();
			report.CompiledReport.Rendering += new EventHandler(CompiledReport_Rendering);

			report.Render(false);
		}

		void CompiledReport_Rendering(object sender, EventArgs e)
		{
			if (label1.InvokeRequired)
				label1.Invoke((EventHandler)delegate
						{
							label1.Text = report.StatusString;
						});
			else
				label1.Text = report.StatusString;
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}