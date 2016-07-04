using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace GlobalEventsSaveAndLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StiOptions.Engine.GlobalEvents.SavingReportInDesigner += new Stimulsoft.Report.Design.StiSavingObjectEventHandler(GlobalEvents_SavingReportInDesigner);
            StiOptions.Engine.GlobalEvents.LoadingReportInDesigner += new Stimulsoft.Report.Design.StiLoadingObjectEventHandler(GlobalEvents_LoadingReportInDesigner);
        }

        private void GlobalEvents_LoadingReportInDesigner(object sender, Stimulsoft.Report.Design.StiLoadingObjectEventArgs e)
        {
            e.Processed = true;

            StiReport report = new StiReport();
            report.Load("..\\..\\Reports\\SimpleList.mrt");
            designerControl1.Report = report;
        }

        private void GlobalEvents_SavingReportInDesigner(object sender, Stimulsoft.Report.Design.StiSavingObjectEventArgs e)
        {
            if (designerControl1.Report == null) return;
            e.Processed = true;

            designerControl1.Report.Save("Report.mrt");
        }
    }
}