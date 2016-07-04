using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;
using System.Reflection;

namespace SelectingColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new DataSet();
            data.ReadXmlSchema("..\\..\\..\\Data\\Demo.xsd");
            data.ReadXml("..\\..\\..\\Data\\demo.xml");

            var report = new StiReport();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SelectingColumns.SelectingColumns.mrt"))
            {
                report.Load(stream);
            }
            report.RegData(data);
            report.Design();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            data.ReadXmlSchema("..\\..\\..\\Data\\Demo.xsd");
            data.ReadXml("..\\..\\..\\Data\\demo.xml");

            StiReport report = new StiReport();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SelectingColumns.SelectingColumns.mrt"))
            {
                report.Load(stream);
            }
            report.RegData(data);
            report.Show();
        }
    }
}