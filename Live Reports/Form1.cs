using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Components;

namespace LiveReports
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private Stimulsoft.Report.StiReport stiReport1;

		private string path = string.Empty;
		DataSet dataSet1 = new DataSet();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			// How to Activate
			//Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
			//Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
			//Stimulsoft.Base.StiLicense.LoadFromStream(stream);

			InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            dataSet1.ReadXmlSchema("..\\..\\Data\\Demo.xsd");
			dataSet1.ReadXml("..\\..\\Data\\Demo.xml");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(240, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Preview";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(406, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "Close";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(74, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Design";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "3806c5eb13cc43639d745560a7eae47a";
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "e35ed5d9964044c8933aaf59baa965c0";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 217);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Reports";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			// Enable HiDPI mode
			Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData(dataSet1);

			report.Load("..\\LiveReports.mrt");
			report.Design();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void click(object sender, EventArgs e)
		{
			StiComponent comp = sender as StiComponent;
			string customerID = (string)comp.BookmarkValue;
            
			if (customerID != null)
			{
				StiReport report = new StiReport();
				report.RegData(dataSet1);
				report.Load("..\\Details.mrt");
				StiDataBand dataBand = (StiDataBand)report.Pages["Page1"].Components["DataBand1"];
                StiFilter filter = new StiFilter("{Orders.CustomerID==\"" + customerID + "\"}");
				dataBand.Filters.Add(filter);
				report.Show();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData(dataSet1);
			report.Load("..\\LiveReports.mrt");
			report.Compile();
			report.CompiledReport.Click += new EventHandler(click);
			report.Show();
		}
	}
}
