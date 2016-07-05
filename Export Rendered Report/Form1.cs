using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace ExportRenderedReport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Button button7;
        private System.ComponentModel.Container components = null;
		
		DataSet dataSet = new DataSet();

		public Form1()
		{
			dataSet.ReadXmlSchema("..\\..\\Data\\Demo.xsd");
            dataSet.ReadXml("..\\..\\Data\\Demo.xml");
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(112, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Export";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(288, 206);
            this.Controls.Add(this.button7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private StiReport GetReport(string name)
		{
			var report = new StiReport();
            report.Load("..\\..\\Reports\\" + name);
            report.RegData(dataSet);
            report.Render(false);
			return report;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			StiReport report1 = GetReport("SimpleList.mrt");
            StiReport report2 = GetReport("SimpleGroup.mrt");
			StiReport report3 = GetReport("Master-Detail.mrt");

            StiReport report = new StiReport();
            report.Render(false);
            report.RenderedPages.Clear();
            
            foreach (StiPage page in report1.RenderedPages)
            {
                report.RenderedPages.Add(page);
            }

            foreach (StiPage page in report2.RenderedPages)
            {
                report.RenderedPages.Add(page);
            }

            foreach (StiPage page in report3.RenderedPages)
            {
                report.RenderedPages.Add(page);
            }
			report.ExportDocument(StiExportFormat.Pdf, "d:\\file.pdf");
		}
	}
}
