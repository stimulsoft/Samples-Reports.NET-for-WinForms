using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;

namespace Using_a_Custom_Data_Adapter
{
    public partial class Form1 : Form
    {
        private StiReport report = new StiReport();

        public Form1()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();

            //Clearing standard data adapters, if necessary
            StiOptions.Services.Databases.Clear();

            //Adding a Custom PostgreSQL data adapter
            StiOptions.Services.Databases.Add(new CustomPostgreSQLDatabase());
            StiOptions.Services.DataAdapters.Add(new CustomPostgreSQLAdapterService());
        }

        private void btDesign_Click(object sender, EventArgs e)
        {
            //Adding a connection to the report from code
            var database = new CustomPostgreSQLDatabase("CustomData1", "Server=127.0.0.1; Port=5432; Database=myDataBase; User Id=myUsername; Password=myPassword;");
            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(database);
            report.ReferencedAssemblies = report.ReferencedAssemblies.Append("Using_a_Custom_Data_Adapter").ToArray();

            report.Design();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
