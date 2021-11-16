using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using System.Reflection;

namespace Working_with_Sub_Reports
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button7;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.CheckBox checkBoxPrintOnPreviousPage;
		private System.Windows.Forms.CheckBox checkBoxResetPageNumber;
		
		public Form1()
		{
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBoxPrintOnPreviousPage = new System.Windows.Forms.CheckBox();
            this.checkBoxResetPageNumber = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Design";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 41);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 41);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Design";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(168, 72);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "Design";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(72, 72);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 25);
            this.button6.TabIndex = 4;
            this.button6.Text = "Show";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Report 3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 169);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "Show Report with Sub-Reports";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBoxPrintOnPreviousPage
            // 
            this.checkBoxPrintOnPreviousPage.Location = new System.Drawing.Point(15, 117);
            this.checkBoxPrintOnPreviousPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPrintOnPreviousPage.Name = "checkBoxPrintOnPreviousPage";
            this.checkBoxPrintOnPreviousPage.Size = new System.Drawing.Size(200, 23);
            this.checkBoxPrintOnPreviousPage.TabIndex = 6;
            this.checkBoxPrintOnPreviousPage.Text = "Print on Previous Page";
            // 
            // checkBoxResetPageNumber
            // 
            this.checkBoxResetPageNumber.Location = new System.Drawing.Point(15, 140);
            this.checkBoxResetPageNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxResetPageNumber.Name = "checkBoxResetPageNumber";
            this.checkBoxResetPageNumber.Size = new System.Drawing.Size(200, 23);
            this.checkBoxResetPageNumber.TabIndex = 7;
            this.checkBoxResetPageNumber.Text = "Reset Page Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 217);
            this.Controls.Add(this.checkBoxPrintOnPreviousPage);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxResetPageNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub-Reports";
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

		private StiReport GetReport(string name)
		{
			var report = new StiReport();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Working_with_Sub_Reports." + name))
            {
                report.Load(stream);
            }
			return report;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			StiReport report = GetReport("SimpleList.mrt");
			report.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			var report = GetReport("SimpleList.mrt");
			report.Design();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			var report = GetReport("SimpleGroup.mrt");
			report.Show();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			var report = GetReport("SimpleGroup.mrt");
			report.Design();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			var report = GetReport("MasterDetail.mrt");
			report.Show();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			var report = GetReport("MasterDetail.mrt");
			report.Design();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			var report1 = GetReport("SimpleList.mrt");
			var report2 = GetReport("SimpleGroup.mrt");
			var report3 = GetReport("MasterDetail.mrt");

			var report = new StiReport();
			report.SubReports.Add(report1);
			report.SubReports.Add(report2, checkBoxResetPageNumber.Checked, checkBoxPrintOnPreviousPage.Checked);
			report.SubReports.Add(report3, checkBoxResetPageNumber.Checked, checkBoxPrintOnPreviousPage.Checked);
			
			report.Render(false);
			report.Show();
		}
	}
}
