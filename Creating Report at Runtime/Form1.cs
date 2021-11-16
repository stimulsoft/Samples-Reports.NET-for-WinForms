using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace Creating_Report_at_Runtime
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Form
	{
		private string path = string.Empty;

		private DataSet dataSet1;
		private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

		public Form1()
		{
			// How to Activate
			//Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
			//Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
			//Stimulsoft.Base.StiLicense.LoadFromStream(stream);

			InitializeComponent();

            dataSet1.ReadXmlSchema("..\\Data\\Demo.xsd");
            dataSet1.ReadXml("..\\Data\\Demo.xml");
			dataSet1.DataSetName = "Demo";
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
            this.dataSet1 = new System.Data.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("ru-RU");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Simple Report";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Cross-Tab";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create Report with Business Objects";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(68, 150);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Create Table Report";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 215);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating Report at Runtime";
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
			// Enable HiDPI mode
			Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

        // Simple Report
		private void button1_Click(object sender, EventArgs e)
		{
			var report = new StiReport();

			//Add data to datastore
			report.RegData(dataSet1);

			//Fill dictionary
			report.Dictionary.Synchronize();

			var page = report.Pages[0];

			//Create HeaderBand
			var headerBand = new StiHeaderBand();
			headerBand.Height = 0.5;
			headerBand.Name = "HeaderBand";
			page.Components.Add(headerBand);

			//Create text on header
			var headerText = new StiText(new RectangleD(0, 0, 5, 0.5));
			headerText.Text = "CompanyName";
			headerText.HorAlignment = StiTextHorAlignment.Center;
			headerText.Name = "HeaderText";
			headerText.Brush = new StiSolidBrush(Color.LightGreen);
			headerBand.Components.Add(headerText);
			
			//Create Databand
			var dataBand = new StiDataBand();
			dataBand.DataSourceName = "Customers";
			dataBand.Height = 0.5;
			dataBand.Name = "DataBand";
			page.Components.Add(dataBand);

			//Create text
			var dataText = new StiText(new RectangleD(0, 0, 5, 0.5));
			dataText.Text = "{Line}.{Customers.CompanyName}";
			dataText.Name = "DataText";
			dataBand.Components.Add(dataText);

			//Create FooterBand
			var footerBand = new StiFooterBand();
			footerBand.Height = 0.5;
			footerBand.Name = "FooterBand";
			page.Components.Add(footerBand);

			//Create text on footer
			var footerText = new StiText(new RectangleD(0, 0, 5, 0.5));
			footerText.Text = "Count - {Count()}";
			footerText.HorAlignment = StiTextHorAlignment.Right;
			footerText.Name = "FooterText";
			footerText.Brush = new StiSolidBrush(Color.LightGreen);
			footerBand.Components.Add(footerText);

			report.Show();
		}

        // Cross-Tab
        private void button2_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.RegData(dataSet1);
            report.Dictionary.Synchronize();

            Stimulsoft.Report.CrossTab.StiCrossTab crossTab1 = new Stimulsoft.Report.CrossTab.StiCrossTab();
            crossTab1.ClientRectangle = new RectangleD(1.8, 4.6, 14.6, 13);
            crossTab1.DataSourceName = "Categories";
            crossTab1.Name = "CrossTab1";

            Stimulsoft.Report.CrossTab.StiCrossRowTotal crossTab1_RowTotal1 = new Stimulsoft.Report.CrossTab.StiCrossRowTotal();
            crossTab1_RowTotal1.Guid = "416a93a6cbff4f24929c07006f5f4c21";
            crossTab1_RowTotal1.Name = "CrossTab1_RowTotal1";
            crossTab1_RowTotal1.Text.Value = "Total";

            Stimulsoft.Report.CrossTab.StiCrossTitle crossTab1_Row1_Title = new Stimulsoft.Report.CrossTab.StiCrossTitle();
            crossTab1_Row1_Title.Name = "CrossTab1_Row1_Title";
            crossTab1_Row1_Title.TypeOfComponent = "Row:CrossTab1_Row1";
            crossTab1_Row1_Title.Text.Value = "CategoryID";

            Stimulsoft.Report.CrossTab.StiCrossColumnTotal crossTab1_ColTotal1 = new Stimulsoft.Report.CrossTab.StiCrossColumnTotal();
            crossTab1_ColTotal1.Guid = "9e5a67edfe87448e96ebcf75e4ef19c4";
            crossTab1_ColTotal1.Name = "CrossTab1_ColTotal1";
            crossTab1_ColTotal1.Text.Value = "Total";

            Stimulsoft.Report.CrossTab.StiCrossTitle crossTab1_LeftTitle = new Stimulsoft.Report.CrossTab.StiCrossTitle();
            crossTab1_LeftTitle.Guid = "a4a019be008042c9a4c4b604e041ceba";
            crossTab1_LeftTitle.Name = "CrossTab1_LeftTitle";
            crossTab1_LeftTitle.TypeOfComponent = "LeftTitle";
            crossTab1_LeftTitle.Text.Value = "Categories";

            Stimulsoft.Report.CrossTab.StiCrossRow crossTab1_Row1 = new Stimulsoft.Report.CrossTab.StiCrossRow();
            crossTab1_Row1.Alias = "CategoryID";
            crossTab1_Row1.Guid = "7f0d8b9785504d009e6afe47f70a74d3";
            crossTab1_Row1.Name = "CrossTab1_Row1";
            crossTab1_Row1.TotalGuid = "416a93a6cbff4f24929c07006f5f4c21";
            crossTab1_Row1.DisplayValue.Value = "{Categories.CategoryID}";
            crossTab1_Row1.Value.Value = "{Categories.CategoryID}";

            Stimulsoft.Report.CrossTab.StiCrossColumn crossTab1_Column1 = new Stimulsoft.Report.CrossTab.StiCrossColumn();
            crossTab1_Column1.Alias = "CategoryName";
            crossTab1_Column1.Guid = "fc86b73eb9694091b62b55fce6041715";
            crossTab1_Column1.Name = "CrossTab1_Column1";
            crossTab1_Column1.TotalGuid = "9e5a67edfe87448e96ebcf75e4ef19c4";
            crossTab1_Column1.DisplayValue.Value = "{Categories.CategoryName}";
            crossTab1_Column1.Value.Value = "{Categories.CategoryName}";

            Stimulsoft.Report.CrossTab.StiCrossSummary crossTab1_Sum1 = new Stimulsoft.Report.CrossTab.StiCrossSummary();
            crossTab1_Sum1.Alias = "Description";
            crossTab1_Sum1.Guid = "ec4c270655bf49a58766bf36a2b21c5c";
            crossTab1_Sum1.Name = "CrossTab1_Sum1";
            crossTab1_Sum1.Summary = Stimulsoft.Report.CrossTab.Core.StiSummaryType.None;
            crossTab1_Sum1.Value.Value = "{Categories.Description}";

            Stimulsoft.Report.CrossTab.StiCrossTitle crossTab1_RightTitle = new Stimulsoft.Report.CrossTab.StiCrossTitle();
            crossTab1_RightTitle.Guid = "43929f3151c248b6b4e07b0a8ea44f93";
            crossTab1_RightTitle.Name = "CrossTab1_RightTitle";
            crossTab1_RightTitle.TypeOfComponent = "RightTitle";
            crossTab1_RightTitle.Text.Value = "CategoryName";

            report.Pages[0].Components.Add(crossTab1);
            crossTab1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        crossTab1_RowTotal1,
                        crossTab1_Row1_Title,
                        crossTab1_ColTotal1,
                        crossTab1_LeftTitle,
                        crossTab1_Row1,
                        crossTab1_Column1,
                        crossTab1_Sum1,
                        crossTab1_RightTitle});

            report.Show();
        }

        // Business Objects
        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FormBusiness();
            form.ShowDialog();
        }

        // Table
        private void button4_Click(object sender, EventArgs e)
        {
            var form = new FormTable();
            form.ShowDialog();
        }
    }
}
