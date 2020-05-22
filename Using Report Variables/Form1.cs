using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace UsingReportVariables
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbAddress;
		private Stimulsoft.Report.StiReport stiReport1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtBirthDay;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button3;
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(168, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(364, 31);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Name";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(168, 79);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(364, 31);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.Text = "Surname";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(168, 124);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(364, 31);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Text = "name@domain.com";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(168, 168);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(364, 31);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.Text = "Address";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(99, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Design";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(263, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Preview";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "bec93c51f7e74bbea96c460910b2c9c6";
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
            this.stiReport1.ReportGuid = "daed7215d2c44878b86b5a0c6b25631c";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sex";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Location = new System.Drawing.Point(168, 257);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(364, 31);
            this.dtBirthDay.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Birth Day";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(168, 212);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(96, 45);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(280, 212);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(208, 45);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.Text = "Female";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtBirthDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(427, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(591, 427);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Report Variables";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
			stiReport1.Load("..\\Variables.mrt");
			stiReport1.Design();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			stiReport1.Load("..\\Variables.mrt");
			stiReport1.Compile();
			//Set Variables
			stiReport1["Name"] =		tbName.Text;
			stiReport1["Surname"] =		tbSurname.Text;
			stiReport1["Email"] =		tbEmail.Text;
			stiReport1["Address"] =		tbAddress.Text;
			stiReport1["Sex"] =			rbMale.Checked;
			stiReport1["BirthDay"] =	dtBirthDay.Value;
			
			stiReport1.Show();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
