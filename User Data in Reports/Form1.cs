using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.Reflection;
using Stimulsoft.Report;

namespace UserDataInReports
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		DataSet dataSet1 = new DataSet();
		private MethodInfo[] assemblys = null;

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Stimulsoft.Report.Dictionary.StiUserData stiUserData1;
		private Stimulsoft.Report.StiReport stiReport1;
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

            stiReport1.RegData("HatchStyleEnum", Enum.GetNames(typeof(HatchStyle)));
						
			Type type = typeof(Graphics);
			assemblys = type.GetMethods();
			stiUserData1.Count = assemblys.Length;
			stiReport1.RegData("UserData", stiUserData1);
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stiUserData1 = new Stimulsoft.Report.Dictionary.StiUserData();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(432, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 48);
            this.button3.TabIndex = 11;
            this.button3.Text = "Close";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(248, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Preview";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(64, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Design";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stiUserData1
            // 
            this.stiUserData1.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
            new Stimulsoft.Report.Dictionary.StiDataColumn("Name", "Name", "Name", typeof(object), null),
            new Stimulsoft.Report.Dictionary.StiDataColumn("ReturnType", "ReturnType", "ReturnType", typeof(object), null),
            new Stimulsoft.Report.Dictionary.StiDataColumn("IsStatic", "IsStatic", "IsStatic", typeof(object), null),
            new Stimulsoft.Report.Dictionary.StiDataColumn("Parameters", "Parameters", "Parameters", typeof(object), null)});
            this.stiUserData1.Count = 10;
            this.stiUserData1.GetData += new Stimulsoft.Report.Dictionary.StiUserGetDataEventHandler(this.stiUserData1_GetData);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "ba77c71630e4472785eb939520a6db29";
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
            this.stiReport1.ReportGuid = "9004eb010eec44b0925867c926808ffa";
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
            this.ClientSize = new System.Drawing.Size(664, 199);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Data in Reports";
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

		private void button1_Click(object sender, EventArgs e)
		{
			stiReport1.Load("..\\UserData.mrt");
			stiReport1.Design();
		}

		private void stiUserData1_GetData(object sender, Stimulsoft.Report.Dictionary.StiUserGetDataEventArgs e)
		{
			if (e.ColumnName == "Name") e.Data = assemblys[e.Position].Name;
			if (e.ColumnName == "ReturnType") e.Data = assemblys[e.Position].ReturnType.Name;
			if (e.ColumnName == "IsStatic") e.Data = assemblys[e.Position].IsStatic;
			if (e.ColumnName == "Parameters")
			{
				ParameterInfo[] pars = assemblys[e.Position].GetParameters();

				string s = string.Empty;
				foreach (ParameterInfo par in pars)s += par.ParameterType.Name + " " + par.Name + "\n";

				e.Data = s;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{			
			stiReport1.Load("..\\UserData.mrt");
			stiReport1.Show();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
