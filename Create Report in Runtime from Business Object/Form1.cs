using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;

namespace PrintGrid
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(448, 319);
            this.dataGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(462, 374);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Print Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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
		
		public class BusinessEntity
		{
			private string name;
			public string Name
			{
				get
				{
					return name;
				}
				set
				{
					name = value;
				}
			}

			private string alias;
			public string Alias
			{
				get
				{
					return alias;
				}
				set
				{
					alias = value;
				}
			}

			public BusinessEntity(string name, string alias)
			{
				this.name = name;
				this.alias = alias;
			}
		}

		private ArrayList list = null;

		private void FillBusinessObject()
		{
			list = new ArrayList();
			list.Add(new BusinessEntity("name1", "alias1"));
			list.Add(new BusinessEntity("name2", "alias2"));
			list.Add(new BusinessEntity("name3", "alias3"));
		}

		private void PrintDataGrid(DataGrid sender)
		{
			StiReport report = new StiReport();
			report.ScriptLanguage = StiReportLanguageType.CSharp;

			//Add data to datastore
			report.RegData("MyList", list);
			
			//Fill dictionary
			report.Dictionary.Synchronize();
			StiPage page = report.Pages.Items[0];

			//Create HeaderBand
			StiHeaderBand headerBand = new StiHeaderBand();
			headerBand.Name = "HeaderBand";
			page.Components.Add(headerBand);

			//Create Dataaband
			StiDataBand dataBand = new StiDataBand();
			dataBand.DataSourceName = "MyList";
			dataBand.Height = 0.5f;
			dataBand.Name = "DataBand";
			page.Components.Add(dataBand);

			StiDataSource dataSource = report.Dictionary.DataSources[0];

			//Create texts
			Double pos = 0;
			Double columnWidth = StiAlignValue.AlignToMinGrid(page.Width / dataSource.Columns.Count, 0.1, true);
			int nameIndex = 1;
			foreach (StiDataColumn column in dataSource.Columns)
			{
				if (column.Name == "_ID" || column.Name == "_Current")continue;

				//Create text on header
				StiText headerText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5f));
				headerText.Text.Value = column.Name;
				headerText.HorAlignment = StiTextHorAlignment.Center;
				headerText.Name = "HeaderText" + nameIndex.ToString();
				headerText.Brush = new StiSolidBrush(Color.LightGreen);
				headerText.Border.Side = StiBorderSides.All;
				headerBand.Components.Add(headerText);

				//Create text on Data Band
				StiText dataText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5f));
				dataText.Text.Value = "{MyList." + column.Name + "}";
				dataText.Name = "DataText" + nameIndex.ToString();
				dataText.Border.Side = StiBorderSides.All;

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

			//For checking created report you can uncomment this line
			//report.Design();
		}

        private void button1_Click(object sender, System.EventArgs e)
		{
			PrintDataGrid(dataGrid1);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			FillBusinessObject();
			dataGrid1.DataSource = list;
		}
	}
}
