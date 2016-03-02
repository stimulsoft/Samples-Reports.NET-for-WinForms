using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Controls;
using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;

namespace PrintTable
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
		private System.Data.DataTable dataTable;
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTable = new System.Data.DataTable();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(280, 232);
            this.dataGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
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
			dataTable.Columns.Add();
			dataTable.Columns.Add();

			DataRow row1 = dataTable.NewRow();
			DataRow row2 = dataTable.NewRow();
			DataRow row3 = dataTable.NewRow();

			row1.ItemArray = new string[2]{"1", "One"};
			row2.ItemArray = new string[2]{"2", "Two"};
			row3.ItemArray = new string[2]{"3", "Three"};

			dataTable.Rows.Add(row1);
			dataTable.Rows.Add(row2);
			dataTable.Rows.Add(row3);

			dataGrid1.DataSource = dataTable;
		}


		private void button1_Click(object sender, System.EventArgs e)
		{
			PrintTable(dataTable);
		}
		
		private void PrintTable(DataTable data)
		{
			StiReport report = new StiReport();

			//Add data to datastore
			report.RegData("data", data);

			//Fill dictionary
			report.Dictionary.Synchronize();
			report.Dictionary.DataSources[0].Name = "data";
			report.Dictionary.DataSources[0].Alias = "data";

			StiPage page = report.Pages[0];

			//Create HeaderBand
			StiHeaderBand headerBand = new StiHeaderBand();
			headerBand.Height = 0.5;
			headerBand.Name = "HeaderBand";
			page.Components.Add(headerBand);

			//Create Databand
			StiDataBand dataBand = new StiDataBand();
			dataBand.DataSourceName = "data";
			dataBand.Height = 0.5;
			dataBand.Name = "DataBand";
			page.Components.Add(dataBand);

			//Create texts
			double pos = 0;

			double columnWidth = StiAlignValue.AlignToMinGrid(page.Width / data.Columns.Count, 0.1, true);

			int nameIndex = 1;

			foreach (DataColumn dataColumn in data.Columns)
			{

				//Create text on header
				StiText headerText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5));
				headerText.Text.Value = dataColumn.Caption;
				headerText.HorAlignment = StiTextHorAlignment.Center;
				headerText.Name = "HeaderText" + nameIndex.ToString();
				headerText.Brush = new StiSolidBrush(Color.LightGreen);
				headerText.Border.Side = StiBorderSides.All;
				headerBand.Components.Add(headerText);

				//Create text on Data Band
				StiText dataText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5));
				dataText.Text.Value = "{data." + Stimulsoft.Report.CodeDom.StiCodeDomSerializator.ReplaceSymbols(dataColumn.ColumnName) + "}";
				dataText.Name = "DataText" + nameIndex.ToString();
				dataText.Border.Side = StiBorderSides.All;

				//Add highlight
				StiCondition condition = new StiCondition();
				condition.BackColor = Color.CornflowerBlue;
				condition.TextColor = Color.Black;
				condition.Expression = "(Line & 1) == 1";
				condition.Item = StiFilterItem.Expression;
				dataText.Conditions.Add(condition);

				dataBand.Components.Add(dataText);

				pos = pos + columnWidth;

				nameIndex++;
			}

			//Create FooterBand
			StiFooterBand footerBand = new StiFooterBand();
			footerBand.Height = 0.5;
			footerBand.Name = "FooterBand";
			page.Components.Add(footerBand);

			//Create text on footer
			StiText footerText = new StiText(new RectangleD(0, 0, page.Width, 0.5));
			footerText.Text.Value = "Count - {Count()}";
			footerText.HorAlignment = StiTextHorAlignment.Right;
			footerText.Name = "FooterText";
			footerText.Brush = new StiSolidBrush(Color.LightGreen);
			footerBand.Components.Add(footerText);

			//Render without progress bar
			report.Render(false);
			report.Show();
		}

	}
}
