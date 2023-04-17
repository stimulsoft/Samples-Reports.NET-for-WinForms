using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Creating_Chart_at_Runtime
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Form
	{
		private string path = string.Empty;

		private Button button1;

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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Chart";
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 215);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating Report at Runtime";
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

        StiReport report;

        private void button2_Click(object sender, EventArgs e)
        {
            report = new StiReport();

            Stimulsoft.Report.Components.StiPage page;
            Stimulsoft.Report.Chart.StiChart chart;
            Stimulsoft.Report.Chart.StiGanttArea chartArea;
            Stimulsoft.Report.Chart.StiGanttSeries ganttSeries;
            Stimulsoft.Report.Chart.StiCenterAxisLabels centerAxisLabels;
            DataDataSource Data;

            Data = new DataDataSource();
            page = new Stimulsoft.Report.Components.StiPage
            {
                PageWidth = 8.27,
                PageHeight = 11.69,
                Alias = "Gantt",
                Guid = "3a7d7edd89b2440f84fee03628209a97",
                Name = "Gantt",
                PaperSize = System.Drawing.Printing.PaperKind.A4,
                Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false),
                Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent),
                Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0),
                Report = report
            };
            report.Pages.Clear();
            report.Pages.AddRange(new StiPage[] { page });


            chart = new Stimulsoft.Report.Chart.StiChart
            {
                ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.3, 6.3),
                CustomStyleName = "Chart",
                EditorType = Stimulsoft.Report.Chart.StiChartEditorType.Simple,
                Name = "Chart1",
                Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Transparent, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 0, 0, 0)), false),
                Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255)),
                Interaction = null,
                Page = page,
                Parent = page,
                Style = new Stimulsoft.Report.Chart.StiCustomStyle()
            };

            chartArea = new Stimulsoft.Report.Chart.StiGanttArea
            {
                BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29),
                BorderThickness = 1F,
                ColorEach = true,
                Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 219), 90),
                GridLinesHorRight = new Stimulsoft.Report.Chart.StiGridLinesHor(System.Drawing.Color.Silver, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, System.Drawing.Color.Gainsboro, Stimulsoft.Base.Drawing.StiPenStyle.Dot, false, 0, true),
                YAxis = new Stimulsoft.Report.Chart.StiYLeftAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Base.Drawing.StiHorAlignment.Right, 0F, true, false), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.BottomToTop, true, Stimulsoft.Report.Chart.StiTitlePosition.Outside), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, true, true, Stimulsoft.Report.Chart.StiShowYAxis.Both, true, false),
                YRightAxis = new Stimulsoft.Report.Chart.StiYRightAxis(new Stimulsoft.Report.Chart.StiAxisLabels("", "", "", 0F, new System.Drawing.Font("Tahoma", 8F), true, Stimulsoft.Report.Chart.StiLabelsPlacement.OneLine, System.Drawing.Color.FromArgb(255, 95, 72, 29), 0F, Stimulsoft.Base.Drawing.StiHorAlignment.Left, 0F, true, false), new Stimulsoft.Report.Chart.StiAxisRange(true, 0, 0), new Stimulsoft.Report.Chart.StiAxisTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", System.Drawing.Color.FromArgb(255, 95, 72, 29), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiDirection.TopToBottom, true, Stimulsoft.Report.Chart.StiTitlePosition.Outside), new Stimulsoft.Report.Chart.StiAxisTicks(true, 5F, false, 2F, 4, 0, 5F), new Stimulsoft.Report.Chart.StiAxisInteraction(false, true), Stimulsoft.Report.Chart.StiArrowStyle.None, Stimulsoft.Base.Drawing.StiPenStyle.Solid, System.Drawing.Color.FromArgb(255, 95, 72, 29), 1F, false, true, true, false),
                Chart = chart
            };

            ganttSeries = new Stimulsoft.Report.Chart.StiGanttSeries
            {
                ArgumentDataColumn = "Data.Year",
                BorderColor = System.Drawing.Color.FromArgb(255, 94, 17, 0),
                ShowShadow = false,
                ValueDataColumn = "Data.Units_in_Stock",
                ValueDataColumnEnd = "Data.Units_Ordered",
                Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 194, 117, 53)),
                BrushNegative = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Firebrick),
                Chart = chart
            };
            ganttSeries.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item5__GetTitle);

            centerAxisLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels
            {
                BorderColor = System.Drawing.Color.FromArgb(255, 95, 72, 29),
                LabelColor = System.Drawing.Color.FromArgb(255, 95, 72, 29),
                MarkerSize = new System.Drawing.Size(8, 6),
                ValueTypeSeparator = "-",
                Width = 0,
                Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat),
                Font = new System.Drawing.Font("Arial", 7F),
                Chart = chart
            };

            chart.Area = chartArea;
            chart.SeriesLabels = centerAxisLabels;
            ganttSeries.SeriesLabels = centerAxisLabels;

            chart.Series.Clear();
            chart.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] { ganttSeries});

            page.Components.Clear();
            page.Components.AddRange(new StiComponent[] { chart});

            Data.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Units", "Units", "Units", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Units in Stock", "Units in Stock", "Units in Stock", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Units Ordered", "Units Ordered", "Units Ordered", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Year", "Year", "Year", typeof(string), null)});
            report.DataSources.Add(Data);
            report.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiExcelDatabase("Data", "..\\Data\\Data.xlsx", "935c893d445c42d7b4113a6b5cc797e2", true));
            report.Dictionary.Synchronize();

            report.CalculationMode = StiCalculationMode.Interpretation;
            report.Show();
        }

        public class DataDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            public DataDataSource() :
                    base("Data.Data", "Data", "Data", "6974e28fa8754b298fa767db9df3a4d5")
            {
            }

            public virtual double Units
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["Units"], typeof(double), true)));
                }
            }

            public virtual double Units_in_Stock
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["Units in Stock"], typeof(double), true)));
                }
            }

            public virtual double Units_Ordered
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["Units Ordered"], typeof(double), true)));
                }
            }

            public virtual string Year
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Year"], typeof(string), true)));
                }
            }
        }

        public void Item5__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            e.Value = "Series 1";
        }
    }
}
