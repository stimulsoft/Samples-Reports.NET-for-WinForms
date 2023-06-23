using Stimulsoft.Base;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecting_to_Data_from_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();
        }

        private void ShowReport(DataSet dataSet)
        {
            var report = new StiReport();
            report.Load(@"Reports\TwoSimpleLists.mrt");
            report.Dictionary.Databases.Clear();
            report.RegData("Demo", dataSet);
            report.Show();
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            var dataSet = new DataSet();
            dataSet.ReadXmlSchema(@"Data\Demo.xsd");
            dataSet.ReadXml(@"Data\Demo.xml");

            ShowReport(dataSet);
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            var dataSet = StiJsonToDataSetConverterV2.GetDataSetFromFile(@"Data\Demo.json");

            ShowReport(dataSet);
        }
    }
}
