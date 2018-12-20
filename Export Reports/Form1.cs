using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Export;

namespace Export
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string path = string.Empty;

		DataSet dataSet1 = new DataSet();

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton rbRtf;
		private System.Windows.Forms.RadioButton rbTxt;
		private System.Windows.Forms.RadioButton rbHtml;
		private System.Windows.Forms.ListBox lbReports;
		private System.Windows.Forms.RadioButton rbXls;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RadioButton rbPdf;
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

            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            lbReports.SelectedIndex = 0;
            
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRtf = new System.Windows.Forms.RadioButton();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.rbXls = new System.Windows.Forms.RadioButton();
            this.rbHtml = new System.Windows.Forms.RadioButton();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbReports = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRtf);
            this.groupBox1.Controls.Add(this.rbTxt);
            this.groupBox1.Controls.Add(this.rbXls);
            this.groupBox1.Controls.Add(this.rbHtml);
            this.groupBox1.Controls.Add(this.rbPdf);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Type";
            // 
            // rbRtf
            // 
            this.rbRtf.Location = new System.Drawing.Point(8, 144);
            this.rbRtf.Name = "rbRtf";
            this.rbRtf.Size = new System.Drawing.Size(104, 24);
            this.rbRtf.TabIndex = 4;
            this.rbRtf.Text = "Rtf";
            // 
            // rbTxt
            // 
            this.rbTxt.Location = new System.Drawing.Point(8, 112);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(104, 24);
            this.rbTxt.TabIndex = 3;
            this.rbTxt.Text = "Txt";
            // 
            // rbXls
            // 
            this.rbXls.Location = new System.Drawing.Point(8, 80);
            this.rbXls.Name = "rbXls";
            this.rbXls.Size = new System.Drawing.Size(104, 24);
            this.rbXls.TabIndex = 2;
            this.rbXls.Text = "Xls";
            // 
            // rbHtml
            // 
            this.rbHtml.Location = new System.Drawing.Point(8, 48);
            this.rbHtml.Name = "rbHtml";
            this.rbHtml.Size = new System.Drawing.Size(104, 24);
            this.rbHtml.TabIndex = 1;
            this.rbHtml.Text = "Html";
            // 
            // rbPdf
            // 
            this.rbPdf.Checked = true;
            this.rbPdf.Location = new System.Drawing.Point(8, 16);
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Size = new System.Drawing.Size(104, 24);
            this.rbPdf.TabIndex = 0;
            this.rbPdf.TabStop = true;
            this.rbPdf.Text = "Pdf";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbReports);
            this.groupBox2.Location = new System.Drawing.Point(136, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // lbReports
            // 
            this.lbReports.Items.AddRange(new object[] {
            "SimpleList",
            "SimpleGroup",
            "Master-Detail",
            "Anchors",
            "MultiColumnList"});
            this.lbReports.Location = new System.Drawing.Point(8, 16);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(176, 147);
            this.lbReports.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(250, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Preview";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(336, 238);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Reports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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

		private void button2_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData(dataSet1);

			report.Load("..\\..\\Reports\\" + (string)lbReports.SelectedItem + ".mrt");
			report.Render(false);			

			string file = (string)lbReports.SelectedItem + ".";

			if (rbPdf.Checked)
			{
				file += "pdf";				
				report.ExportDocument(StiExportFormat.Pdf, file);
				System.Diagnostics.Process.Start(file);
			}
			else if (rbHtml.Checked)
			{
				file += "html";
				report.ExportDocument(StiExportFormat.HtmlTable, file);
				System.Diagnostics.Process.Start(file);
			}
			else if (rbXls.Checked)
			{
				file += "xls";
				report.ExportDocument(StiExportFormat.Excel, file);
				System.Diagnostics.Process.Start(file);
			}
			else if (rbTxt.Checked)
			{
				file += "txt";
				report.ExportDocument(StiExportFormat.Text, file);
				System.Diagnostics.Process.Start(file);
			}
			else if (rbRtf.Checked)
			{
				file += "rtf";
				report.ExportDocument(StiExportFormat.RtfTable, file);
				System.Diagnostics.Process.Start(file);
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData(dataSet1);

			report.Load("..\\..\\Reports\\" + (string)lbReports.SelectedItem + ".mrt");
			report.Render();
			report.Show(true);
		}
	}
}
