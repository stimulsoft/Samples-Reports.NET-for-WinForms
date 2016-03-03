using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Chart;
using Stimulsoft.Base.Drawing;

namespace RealtimePreview
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Stimulsoft.Report.StiReport stiReport1;
		private Stimulsoft.Report.Render.StiPreviewControl stiPreviewControl1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			stiReport1.Render();
			StiComponentsCollection comps = stiReport1.RenderedPages[0].GetComponents();
			text = comps["Text1"] as StiText;
			chart = comps["Chart1"] as StiChart;
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
			this.components = new System.ComponentModel.Container();
			this.stiReport1 = new Stimulsoft.Report.StiReport();
			this.stiPreviewControl1 = new Stimulsoft.Report.Render.StiPreviewControl();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// stiReport1
			// 
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
			this.stiReport1.ReportName = "Report";
			this.stiReport1.ReportSource = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\r\n<StiSerializer version=\"" +
				"1.0\" application=\"StiReport\">\r\n  <Dictionary Ref=\"1\" type=\"Dictionary\" isKey=\"tr" +
				"ue\">\r\n    <Databases isList=\"true\" count=\"0\" />\r\n    <DataSources isList=\"true\" " +
				"count=\"0\" />\r\n    <Relations isList=\"true\" count=\"0\" />\r\n    <Report isRef=\"0\" /" +
				">\r\n    <Variables isList=\"true\" count=\"0\" />\r\n  </Dictionary>\r\n  <Pages isList=\"" +
				"true\" count=\"1\">\r\n    <Page1 Ref=\"2\" type=\"Page\" isKey=\"true\">\r\n      <Border>No" +
				"ne;Black;2;Solid;False;4;Black</Border>\r\n      <Brush>White</Brush>\r\n      <Comp" +
				"onents isList=\"true\" count=\"2\">\r\n        <Chart1 Ref=\"3\" type=\"Stimulsoft.Report" +
				".Chart.StiChart\" isKey=\"true\">\r\n          <Area Ref=\"4\" type=\"Stimulsoft.Report." +
				"Chart.StiDoughnutArea\" isKey=\"true\">\r\n            <BorderColor>95, 72, 29</Borde" +
				"rColor>\r\n            <Brush>GradientBrush,[255:255:255],[255:255:219],90</Brush>" +
				"\r\n            <Chart isRef=\"3\" />\r\n          </Area>\r\n          <Brush>[255:255:" +
				"255]</Brush>\r\n          <ClientRectangle>3.6,0.4,11.2,11.6</ClientRectangle>\r\n  " +
				"        <DataRelationName />\r\n          <DataSourceName />\r\n          <Legend Re" +
				"f=\"5\" type=\"Stimulsoft.Report.Chart.StiLegend\" isKey=\"true\">\r\n            <Borde" +
				"rColor>95, 72, 29</BorderColor>\r\n            <Brush>GradientBrush,[255:255:255]," +
				"[255:242:199],90</Brush>\r\n            <Chart isRef=\"3\" />\r\n            <Font>Ari" +
				"al,8</Font>\r\n            <LabelsColor>95, 72, 29</LabelsColor>\r\n            <Mar" +
				"kerSize>10, 10</MarkerSize>\r\n            <TitleColor>95, 72, 29</TitleColor>\r\n  " +
				"          <TitleFont>Arial,14,Bold</TitleFont>\r\n            <VertAlignment>Botto" +
				"mOutside</VertAlignment>\r\n          </Legend>\r\n          <Name>Chart1</Name>\r\n  " +
				"        <Page isRef=\"2\" />\r\n          <Parent isRef=\"2\" />\r\n          <Series is" +
				"List=\"true\" count=\"2\">\r\n            <Item3 Ref=\"6\" type=\"Stimulsoft.Report.Chart" +
				".StiDoughnutSeries\" isKey=\"true\">\r\n              <ArgumentDataColumn />\r\n       " +
				"       <BorderColor>144, 67, 3</BorderColor>\r\n              <Brush>GlareBrush,[1" +
				"44:67:3],[194:117:53],0,0.5,1</Brush>\r\n              <Chart isRef=\"3\" />\r\n      " +
				"        <ListOfValues>1;2;3;4</ListOfValues>\r\n              <Title>Series 1</Tit" +
				"le>\r\n              <ValueDataColumn />\r\n            </Item3>\r\n            <Item4" +
				" Ref=\"7\" type=\"Stimulsoft.Report.Chart.StiDoughnutSeries\" isKey=\"true\">\r\n       " +
				"       <ArgumentDataColumn />\r\n              <BorderColor>181, 90, 15</BorderCol" +
				"or>\r\n              <Brush>GlareBrush,[181:90:15],[231:140:65],0,0.5,1</Brush>\r\n " +
				"             <Chart isRef=\"3\" />\r\n              <ListOfValues>2;3;4;2</ListOfVal" +
				"ues>\r\n              <Title>Series 2</Title>\r\n              <ValueDataColumn />\r\n" +
				"            </Item4>\r\n          </Series>\r\n          <SeriesLabels Ref=\"8\" type=" +
				"\"Stimulsoft.Report.Chart.StiCenterPieLabels\" isKey=\"true\">\r\n            <AutoRot" +
				"ate>True</AutoRotate>\r\n            <BorderColor>95, 72, 29</BorderColor>\r\n      " +
				"      <Brush>Wheat</Brush>\r\n            <Chart isRef=\"3\" />\r\n            <Font>A" +
				"rial,7</Font>\r\n            <LabelColor>95, 72, 29</LabelColor>\r\n            <Val" +
				"ueType>Value</ValueType>\r\n          </SeriesLabels>\r\n          <Sort isList=\"tru" +
				"e\" count=\"0\" />\r\n          <Style Ref=\"9\" type=\"Stimulsoft.Report.Chart.StiStyle" +
				"01\" isKey=\"true\" />\r\n        </Chart1>\r\n        <Text1 Ref=\"10\" type=\"Text\" isKe" +
				"y=\"true\">\r\n          <Border>All;Black;1;Solid;False;4;Black</Border>\r\n         " +
				" <Brush>Transparent</Brush>\r\n          <ClientRectangle>3.6,12.8,11.2,9.8</Clien" +
				"tRectangle>\r\n          <Font>Arial,48,Bold</Font>\r\n          <HighlightCondition" +
				" Ref=\"11\" type=\"HighlightCondition\" isKey=\"true\">\r\n            <Brush>Transparen" +
				"t</Brush>\r\n            <Font>Arial,8</Font>\r\n            <TextBrush>Red</TextBru" +
				"sh>\r\n          </HighlightCondition>\r\n          <HorAlignment>Center</HorAlignme" +
				"nt>\r\n          <Margins>0,0,0,0</Margins>\r\n          <Name>Text1</Name>\r\n       " +
				"   <Page isRef=\"2\" />\r\n          <Parent isRef=\"2\" />\r\n          <Text>TEST</Tex" +
				"t>\r\n          <TextBrush>Black</TextBrush>\r\n          <TextFormat Ref=\"12\" type=" +
				"\"GeneralFormat\" isKey=\"true\" />\r\n          <VertAlignment>Center</VertAlignment>" +
				"\r\n          <WYSIWYG>True</WYSIWYG>\r\n        </Text1>\r\n      </Components>\r\n    " +
				"  <Margins>1,1,1,1</Margins>\r\n      <Name>Page1</Name>\r\n      <Page isRef=\"2\" />" +
				"\r\n      <PageHeight>29.7</PageHeight>\r\n      <PageWidth>21</PageWidth>\r\n      <R" +
				"eport isRef=\"0\" />\r\n      <Watermark Ref=\"13\" type=\"Stimulsoft.Report.Components" +
				".StiWatermark\" isKey=\"true\">\r\n        <Font>Arial,100</Font>\r\n        <TextBrush" +
				">[50:0:0:0]</TextBrush>\r\n      </Watermark>\r\n    </Page1>\r\n  </Pages>\r\n  <Refere" +
				"ncedAssemblies isList=\"true\" count=\"8\">\r\n    <value>System.Dll</value>\r\n    <val" +
				"ue>System.Drawing.Dll</value>\r\n    <value>System.Windows.Forms.Dll</value>\r\n    " +
				"<value>System.Data.Dll</value>\r\n    <value>System.Xml.Dll</value>\r\n    <value>St" +
				"imulsoft.Controls.Dll</value>\r\n    <value>Stimulsoft.Base.Dll</value>\r\n    <valu" +
				"e>Stimulsoft.Report.Dll</value>\r\n  </ReferencedAssemblies>\r\n  <ReportAlias>Repor" +
				"t</ReportAlias>\r\n  <ReportChanged>5/17/2006 7:18:30 PM</ReportChanged>\r\n  <Repor" +
				"tCreated>5/17/2006 5:02:17 PM</ReportCreated>\r\n  <ReportName>Report</ReportName>" +
				"\r\n  <ReportUnit>Centimeters</ReportUnit>\r\n  <ReportVersion>1.60</ReportVersion>\r" +
				"\n  <Script>using System;\r\nusing System.Drawing;\r\nusing System.Windows.Forms;\r\nus" +
				"ing System.Data;\r\nusing Stimulsoft.Controls;\r\nusing Stimulsoft.Base.Drawing;\r\nus" +
				"ing Stimulsoft.Report;\r\nusing Stimulsoft.Report.ReportControls;\r\nusing Stimulsof" +
				"t.Report.Components;\r\n\r\nnamespace Reports\r\n{\r\n    \r\n    public class Report : St" +
				"imulsoft.Report.StiReport\r\n    {\r\n        \r\n        public Report()\r\n        {\r\n" +
				"            this.InitializeComponent();\r\n        }\r\n        #region StiReport De" +
				"signer generated code - do not modify#endregion StiReport Designer generated cod" +
				"e - do not modify\r\n    }\r\n}</Script>\r\n  <ScriptLanguage>CSharp</ScriptLanguage>\r" +
				"\n  <Styles isList=\"true\" count=\"0\" />\r\n</StiSerializer>";
			this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
			this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
			// 
			// stiPreviewControl1
			// 
			this.stiPreviewControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.stiPreviewControl1.Location = new System.Drawing.Point(8, 8);
			this.stiPreviewControl1.Name = "stiPreviewControl1";
			this.stiPreviewControl1.Report = this.stiReport1;
			this.stiPreviewControl1.Size = new System.Drawing.Size(576, 456);
			this.stiPreviewControl1.TabIndex = 0;
			this.stiPreviewControl1.Close += new System.EventHandler(this.stiPreviewControl1_Close);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 469);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.stiPreviewControl1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Realtime Preview";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private StiText text = null;
		private StiChart chart = null;

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (text == null)return;

			//Rotate text
			float angle = text.TextOptions.Angle;
			angle -= 1f;
			if (angle < 0)angle = 359;
			text.TextOptions.Angle = angle;

			//Rotate series 1
			angle = ((StiDoughnutSeries)chart.Series[0]).StartAngle;
			angle -= 1f;
			if (angle < 0)angle = 359;
			((StiDoughnutSeries)chart.Series[0]).StartAngle = angle;

			//Rotate series 2
			angle = ((StiDoughnutSeries)chart.Series[1]).StartAngle;
			angle += 1f;
			if (angle > 359)angle = 0;
			((StiDoughnutSeries)chart.Series[1]).StartAngle = angle;

			RectangleD rect = stiPreviewControl1.GetComponentRect(text);
			stiPreviewControl1.InvalidatePageRect(rect.ToRectangle());

			rect = stiPreviewControl1.GetComponentRect(chart);
			stiPreviewControl1.InvalidatePageRect(rect.ToRectangle());
			//stiPreviewControl1.View.Invalidate();			
		}

		private void stiPreviewControl1_Close(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			timer1.Enabled = true;
		}
	}
}
