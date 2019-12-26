using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Chart;
using Stimulsoft.Base.Drawing;

namespace RealtimePreview
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Stimulsoft.Report.StiReport stiReport1;
		private Stimulsoft.Report.Render.StiPreviewControl stiPreviewControl1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			// How to Activate
			//Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
			//Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
			//Stimulsoft.Base.StiLicense.LoadFromStream(stream);

			stiPreviewControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
			stiReport1.Render();
			StiComponentsCollection comps = stiReport1.RenderedPages[0].GetComponents();
			text = comps["Text1"] as StiText;
			chart = comps["Chart1"] as StiChart;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiPreviewControl1 = new Stimulsoft.Report.Render.StiPreviewControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
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
            this.stiReport1.ReportGuid = "52dc044e321d4dc9860db01c975e370a";
            this.stiReport1.ReportImage = null;
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // stiPreviewControl1
            // 
            this.stiPreviewControl1.AllowDrop = true;
            this.stiPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stiPreviewControl1.Location = new System.Drawing.Point(8, 8);
            this.stiPreviewControl1.Name = "stiPreviewControl1";
            this.stiPreviewControl1.Report = this.stiReport1;
            this.stiPreviewControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiPreviewControl1.ShowZoom = true;
            this.stiPreviewControl1.Size = new System.Drawing.Size(576, 456);
            this.stiPreviewControl1.TabIndex = 0;
            this.stiPreviewControl1.Close += new System.EventHandler(this.stiPreviewControl1_Close);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 469);
            this.Controls.Add(this.stiPreviewControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realtime Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
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

		private StiText text = null;
		private StiChart chart = null;

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (text == null)return;

			//Rotate text
			float angle = text.TextOptions.Angle;
			angle -= 1f;
			if (angle < 0)angle = 359;
			text.TextOptions.Angle = angle;

			//Rotate series 1
			angle = ((StiDoughnutSeries)chart.Series[0]).StartAngle;
			angle -= 1f;
			if (angle < 0)angle = 359;
			((StiDoughnutSeries)chart.Series[0]).StartAngle = angle;

			//Rotate series 2
			angle = ((StiDoughnutSeries)chart.Series[1]).StartAngle;
			angle += 1f;
			if (angle > 359)angle = 0;
			((StiDoughnutSeries)chart.Series[1]).StartAngle = angle;

			RectangleD rect = stiPreviewControl1.GetComponentRect(text);
			stiPreviewControl1.InvalidatePageRect(rect.ToRectangle());

			rect = stiPreviewControl1.GetComponentRect(chart);
			stiPreviewControl1.InvalidatePageRect(rect.ToRectangle());
			//stiPreviewControl1.View.Invalidate();			
		}

		private void stiPreviewControl1_Close(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			timer1.Enabled = true;
		}
	}
}
