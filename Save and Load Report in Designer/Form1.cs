using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Design;

namespace SaveAndLoadReportInDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Design();
        }

        static Form1()
        {
            StiDesigner.SavingReport += new StiSavingObjectEventHandler(OnSaving);
            StiDesigner.LoadingReport += new StiLoadingObjectEventHandler(OnLoading);

            //If you need you can hide menu item "Save As.."
            StiMainMenuService service = StiMainMenuService.GetService();
            service.ShowFileReportSaveAs = false;
        }

        private static void OnSaving(object sender, StiSavingObjectEventArgs e)
        {
            StiDesigner designer = sender as StiDesigner;
            //string str = designer.Report.SaveToString();            
            MessageBox.Show("Report saved");
        }

        private static void OnLoading(object sender, StiLoadingObjectEventArgs e)
        {
            StiDesigner designer = sender as StiDesigner;
            //designer.Report.LoadFromString(str);
            MessageBox.Show("Report loaded");
        }
    }
}