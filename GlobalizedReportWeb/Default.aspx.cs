using System;
using System.Globalization;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Stimulsoft.Report;
using GlobalizedReport;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page != null)
        {
            // Apply Localization to WebViewer
            StiWebViewer1.GlobalizationFile = "\\Localizations\\es.xml";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
		//Resources.Resource.ResourceManager.
		//object obj = MyResources;
		//Resources.Resource.Answer
        string appPath = Server.MapPath(string.Empty);
        string cultureName = DropDownList1.SelectedValue;

        // Get Report Data
        DataSet data = new DataSet();
        data.ReadXml(appPath + "\\Data\\Demo.xml");

        // Get Report
        StiReport report = new StiReport();
        report.GlobalizationManager = new GlobalizationManager(new CultureInfo(cultureName));
        report.RegData(data);
        report.Load(appPath + "\\Data\\SimpleList.mrt");

        // Show Report
        StiWebViewer1.Report = report;
    }
}
