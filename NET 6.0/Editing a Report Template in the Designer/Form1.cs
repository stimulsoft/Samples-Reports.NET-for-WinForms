using Stimulsoft.Report;
using Stimulsoft.Report.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editing_a_Report_Template_in_the_Designer
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

            StiDesigner.SavingReport += new StiSavingObjectEventHandler(GlobalEvents_SaveReport);
        }

        private void GlobalEvents_SaveReport(object sender, StiSavingObjectEventArgs e)
        {
            // Skip the SaveAs event
            if (e.EventSource == StiSaveEventSource.SaveAs)
            {
                e.Processed = false;
                return;
            }

            var report = ((IStiDesignerBase)sender).Report;

            // How to Save
            //report.Save("Report.mrt");
            //report.SaveToJson("Report.mrt");
            //var xml = report.SaveToString();
            //var json = report.SaveToJsonString();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Design();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.Design();
        }
    }
}
