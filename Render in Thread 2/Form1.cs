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
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

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
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("RenderInThread2.MasterDetailSubdetail.mrt"))
            {
                report.Load(stream);
            }

			report.IsRendered = false;
            report.EndRender += new EventHandler(CompiledReport_Rendering);
            report.Render(false);
		}

        void CompiledReport_Rendering(object sender, EventArgs e)
        {
            button1.Invoke((EventHandler)delegate { button1.Text = button1.Text + " ."; });
        }
    }
}