using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;

namespace ViewerAndRightToLeft
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Stimulsoft.Report.Viewer.StiViewerControl panel1;
		private Stimulsoft.Report.StiReport stiReport1;
		private System.Data.DataSet dataSet1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			StiOptions.Viewer.RightToLeft = StiRightToLeftType.Yes;
				
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
            this.panel1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Report = this.stiReport1;
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.ShowZoom = true;
            this.panel1.Size = new System.Drawing.Size(688, 493);
            this.panel1.TabIndex = 0;
            this.panel1.Close += new System.EventHandler(this.panel1_Close);
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
            this.stiReport1.ReportGuid = "41599dc0625e4d03b314014f8926ee17";
            this.stiReport1.ReportImage = null;
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("ru-RU");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(688, 493);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Viewer in Right-To-Left";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			if (File.Exists("..\\..\\Data\\Demo.xsd"))dataSet1.ReadXmlSchema("..\\..\\Data\\Demo.xsd");
			else MessageBox.Show("File \"Demo.xsd\" not found");

			if (File.Exists("..\\..\\Data\\Demo.xsd"))dataSet1.ReadXml("..\\..\\Data\\Demo.xml");
			else MessageBox.Show("File \"Demo.xml\" not found");

			dataSet1.DataSetName = "Demo";
			stiReport1.RegData(dataSet1);
			
			if (File.Exists("..\\..\\Reports\\BookmarksHyperlinks.mrt"))stiReport1.Load("..\\..\\Reports\\BookmarksHyperlinks.mrt");
			else MessageBox.Show("File \"BookmarksHyperlinks.mrt\" not found");
			stiReport1.Load("..\\..\\Reports\\BookmarksHyperlinks.mrt");

			stiReport1.Render(true);
            stiReport1.Info.Zoom = panel1.Zoom;
            if (stiReport1.CompiledReport != null) stiReport1.CompiledReport.Info.Zoom = panel1.Zoom;
            panel1.Refresh();
        }

		private void panel1_Close(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
