using System;
using System.Reflection;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using Reports;

namespace WebDemo
{
	/// <summary>
	/// Summary description for WebDemo.
	/// </summary>
	public partial class WebDemo : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;

		static WebDemo()
		{
            StiOptions.Configuration.InitWeb();
			StiOptions.Engine.HideExceptions = false;
            StiOptions.Engine.HideMessages = false;
		}
        
        private string path = string.Empty;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Stimulsoft\\Stimulsoft Reports");
            bool is64Bit = IntPtr.Size == 8;
            if (is64Bit) key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Stimulsoft\\Stimulsoft Reports");
            path = (string)key.GetValue("Bin") + "\\Data\\";

			DataSet dataSet1 = new DataSet();
			dataSet1.ReadXmlSchema(path + "Demo.xsd");
			dataSet1.ReadXml(path + "Demo.xml");
			
			StiReport report = null;

            switch (ReportsList.SelectedItem.Value)
            {
                case "SimpleList":
                    report = new SimpleList();
                    break;

                case "TwoSimpleLists":
                    report = new TwoSimpleLists();
                    break;

                case "SideBySideListWithContainers":
                    report = new SideBySideListWithContainers();
                    break;

                case "HighlightCondition":
                    report = new HighlightCondition();
                    break;

                case "SimpleGroup":
                    report = new SimpleGroup();
                    break;

                case "SideBySideGroupWithContainers":
                    report = new SideBySideGroupWithContainers();
                    break;

                case "MultiColumnList":
                    report = new MultiColumnListContainers();
                    break;

                case "MultiColumnBandsAcrossThenDown":
                    report = new MultiColumnBandsAcrossThenDown();
                    break;

                case "Labels":
                    report = new Labels();
                    break;

                case "MasterDetail":
                    report = new MasterDetail();
                    break;
            }

			report.RegData(dataSet1);
				
			StiWebViewer1.Report = report;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
		//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion

		protected void ReportsList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            StiWebViewer1.ResetCurrentPage();
		}
	}
}
