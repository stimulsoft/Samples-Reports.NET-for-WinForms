using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace SqlParameters
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string path = string.Empty;

		//private string path = "D:\\nwind.mdb";

		private System.Windows.Forms.Button button1;
		private Stimulsoft.Report.StiReport stiReport1;
		private System.Windows.Forms.ListBox lbCountries;
		private Stimulsoft.Report.Viewer.StiViewerControl stiPreviewControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Stimulsoft\\Stimulsoft Reports");
            bool is64Bit = IntPtr.Size == 8;
            if (is64Bit) key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Stimulsoft\\Stimulsoft Reports");
            if (key != null)
            {
                path = (string)key.GetValue("Bin") + "\\";
            }
            else
            {
                path = Application.StartupPath + "\\";
            }

			stiReport1.Dictionary.DataStore.Clear();

			System.Data.OleDb.OleDbConnection connection = 
				new System.Data.OleDb.OleDbConnection(
				"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" + path + "\\Data\\Nwind.mdb");

			stiReport1.RegData("NorthWind", connection);

			stiReport1.Compile();
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
            this.button1 = new System.Windows.Forms.Button();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.lbCountries = new System.Windows.Forms.ListBox();
            this.stiPreviewControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(496, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Design";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportAuthor = null;
            this.stiReport1.ReportDescription = null;
            this.stiReport1.ReportGuid = "4533be36b343412b94379b945c0209fe";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // lbCountries
            // 
            this.lbCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCountries.IntegralHeight = false;
            this.lbCountries.Items.AddRange(new object[] {
            "Brazil",
            "Canada",
            "Denmark",
            "Finland",
            "France",
            "Germany",
            "Ireland",
            "Italy",
            "Mexico",
            "Norway",
            "Poland",
            "Portugal",
            "Spain",
            "Sweden",
            "Switzerland",
            "UK",
            "USA",
            "Venezuela"});
            this.lbCountries.Location = new System.Drawing.Point(8, 8);
            this.lbCountries.Name = "lbCountries";
            this.lbCountries.Size = new System.Drawing.Size(232, 392);
            this.lbCountries.TabIndex = 0;
            this.lbCountries.SelectedIndexChanged += new System.EventHandler(this.lbCountries_SelectedIndexChanged);
            // 
            // stiPreviewControl1
            // 
            this.stiPreviewControl1.AllowDrop = true;
            this.stiPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stiPreviewControl1.Location = new System.Drawing.Point(240, 8);
            this.stiPreviewControl1.Name = "stiPreviewControl1";
            this.stiPreviewControl1.Report = null;
            this.stiPreviewControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiPreviewControl1.ShowBookmarksPanel = false;
            this.stiPreviewControl1.ShowCloseButton = false;
            this.stiPreviewControl1.ShowContextMenu = false;
            this.stiPreviewControl1.ShowEditor = false;
            this.stiPreviewControl1.ShowSave = false;
            this.stiPreviewControl1.ShowFind = false;
            this.stiPreviewControl1.ShowHorScrollBar = false;
            this.stiPreviewControl1.ShowOpen = false;
            this.stiPreviewControl1.ShowPageControl = false;
            this.stiPreviewControl1.ShowPageDelete = false;
            this.stiPreviewControl1.ShowPageDesign = false;
            this.stiPreviewControl1.ShowPageNew = false;
            this.stiPreviewControl1.ShowPageSize = false;
            this.stiPreviewControl1.ShowPageViewMode = false;
            this.stiPreviewControl1.ShowPrint = false;
            this.stiPreviewControl1.ShowSendEMail = false;
            this.stiPreviewControl1.ShowStatusBar = false;
            this.stiPreviewControl1.ShowThumbsPanel = false;
            this.stiPreviewControl1.ShowToolbar = false;
            this.stiPreviewControl1.ShowVertScrollBar = false;
            this.stiPreviewControl1.ShowViewModeContinuous = false;
            this.stiPreviewControl1.ShowViewModeMultiplePages = false;
            this.stiPreviewControl1.ShowViewModeSinglePage = false;
            this.stiPreviewControl1.ShowZoom = false;
            this.stiPreviewControl1.ShowZoomMultiplePages = false;
            this.stiPreviewControl1.ShowZoomOnePage = false;
            this.stiPreviewControl1.ShowZoomPageWidth = false;
            this.stiPreviewControl1.ShowZoomTwoPages = false;
            this.stiPreviewControl1.Size = new System.Drawing.Size(328, 392);
            this.stiPreviewControl1.TabIndex = 3;
            this.stiPreviewControl1.ThumbsPanelEnabled = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 445);
            this.Controls.Add(this.stiPreviewControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports with Sql Parameters";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

		private void button1_Click(object sender, System.EventArgs e)
		{			
			stiReport1.Design();
			stiReport1.Compile();
		}
		

		private void lbCountries_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			//Set parameters
			stiReport1["@countryID"] = lbCountries.SelectedItem;

			stiReport1.Render(false);
			stiPreviewControl1.Report = stiReport1;
			stiPreviewControl1.SetZoomOnePage();
		}
	}
}
