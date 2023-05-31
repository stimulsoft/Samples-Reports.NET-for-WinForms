using Stimulsoft.Report;
using Stimulsoft.Report.Viewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showing_a_Report_in_the_Viewer
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

        private void buttonControl_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.Render();
            stiViewerControl1.Report = report;
        }

        private void buttonDialog_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.Show();
            //report.ShowWithRibbonGUI();
        }
    }
}
