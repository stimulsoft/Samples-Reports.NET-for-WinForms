using System;
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;

namespace Globalizing_Reports
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string path = string.Empty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbCountry;
		DataSet dataSet1 = new DataSet();

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

            dataSet1.ReadXmlSchema("..\\Data\\Demo.xsd");
			dataSet1.ReadXml("..\\Data\\Demo.xml");
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(219, 82);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(136, 82);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Preview";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(53, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Design";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Country:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Items.AddRange(new object[] {
            "France",
            "Germany",
            "Italy",
            "Russia",
            "Spain",
            "United Kingdom",
            "United States"});
            this.cbCountry.Location = new System.Drawing.Point(101, 16);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(195, 21);
            this.cbCountry.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 116);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Globalizing Reports";
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
			report.Load("..\\GlobalizedSimpleList.mrt");
			report.Design();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (cbCountry.Text.Length == 0)
			{
				cbCountry.Focus();
				MessageBox.Show("Please, select country.");
			}
			else
			{
				#region Switch Culture
				string cultureName = "";
				switch (cbCountry.Text)
				{
					case "France":
						cultureName = "fr-FR";
						break;

					case "Germany":
						cultureName = "de-DE";
						break;

					case "Italy":
						cultureName = "it-IT";
						break;

					case "Russia":
						cultureName = "ru-RU";
						break;

					case "Spain":
						cultureName = "es-ES";
						break;

					case "United Kingdom":
						cultureName = "en-GB";
						break;

					case "United States":
						cultureName = "en-US";
						break;
				}
				#endregion
                
				StiReport report = new StiReport();
			
				//Set globalization
				report.GlobalizationManager = new GlobalizationManager("Globalizing_Reports.MyResources",
					new CultureInfo(cultureName));

				report.RegData(dataSet1);
				report.Load("..\\GlobalizedSimpleList.mrt");		
				report.Show();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
