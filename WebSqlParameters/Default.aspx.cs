using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Stimulsoft.Report;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ListBox1.SelectedItem == null) return;

        StiReport report = StiReportWeb1.GetReport();        
        report.Dictionary.DataStore.Clear();

        System.Data.OleDb.OleDbConnection connection =
            new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=\"Nwind.mdb\"");

        report.RegData("NorthWind", connection);
        report.Compile();
        report.CompiledReport.DataSources["Customers"].Parameters["@countryID"].ParameterValue = ListBox1.SelectedItem.Value;

        report.Render();
        StiWebViewer1.Report = report;

    }

}
