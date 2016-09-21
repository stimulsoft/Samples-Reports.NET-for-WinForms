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

namespace PrintGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.DataView dataView1;
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataView1 = new System.Data.DataView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dataView1;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(448, 328);
            this.dataGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(464, 373);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
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

		private void PrintDataGrid(DataGrid sender)
		{
			DataView dataView = (DataView)sender.DataSource;
			StiReport report = new StiReport();
			report.ScriptLanguage = StiReportLanguageType.CSharp;

			//Add data to datastore
			report.RegData("view", dataView);
			
			//Fill dictionary
			report.Dictionary.Synchronize();
			StiPage page = report.Pages.Items[0];

			//Create HeaderBand
			StiHeaderBand headerBand = new StiHeaderBand();
			headerBand.Height = 0.5f;
			headerBand.Name = "HeaderBand";
			page.Components.Add(headerBand);

			//Create Dataaband
			StiDataBand dataBand = new StiDataBand();
			dataBand.DataSourceName = "view" + dataView.Table.TableName;
			dataBand.Height = 0.5f;
			dataBand.Name = "DataBand";
			page.Components.Add(dataBand);

			//Create texts
			Double pos = 0;
			Double columnWidth = StiAlignValue.AlignToMinGrid(page.Width / dataView.Table.Columns.Count, 0.1, true);
			int nameIndex = 1;
			foreach (DataColumn column in dataView.Table.Columns)
			{
				//Create text on header
				StiText headerText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5f));
				headerText.Text.Value = column.Caption;
				headerText.HorAlignment = StiTextHorAlignment.Center;
				headerText.Name = "HeaderText" + nameIndex.ToString();
				headerText.Brush = new StiSolidBrush(Color.LightGreen);
				headerText.Border.Side = StiBorderSides.All;
				headerBand.Components.Add(headerText);

				//Create text on Data Band
				StiText dataText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5f));
				dataText.Text.Value = "{view" + dataView.Table.TableName + "." + Stimulsoft.Report.CodeDom.StiCodeDomSerializator.ReplaceSymbols(column.ColumnName) + "}";
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

				pos += columnWidth;

				nameIndex ++;
			}
			//Create FooterBand
			StiFooterBand footerBand = new StiFooterBand();
			footerBand.Height = 0.5f;
			footerBand.Name = "FooterBand";
			page.Components.Add(footerBand);

			//Create text on footer
			StiText footerText = new StiText(new RectangleD(0, 0, page.Width, 0.5f));
			footerText.Text.Value = "Count - {Count()}";
			footerText.HorAlignment = StiTextHorAlignment.Right;
			footerText.Name = "FooterText";
			footerText.Brush = new StiSolidBrush(Color.LightGreen);
			footerBand.Components.Add(footerText);

			//Render without progress bar
			report.Render(false);
			report.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			PrintDataGrid(dataGrid1);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			DataTable table = new DataTable("Demo");
			
			table.Columns.Add();
			table.Columns.Add();

			DataRow row1 = table.NewRow();
			DataRow row2 = table.NewRow();
			DataRow row3 = table.NewRow();

			row1.ItemArray = new string[2]{"1", "One"};
			row2.ItemArray = new string[2]{"2", "Two"};
			row3.ItemArray = new string[2]{"3", "Three"};

			table.Rows.Add(row1);
			table.Rows.Add(row2);
			table.Rows.Add(row3);
			dataView1.Table = table;
		}
	}
}
