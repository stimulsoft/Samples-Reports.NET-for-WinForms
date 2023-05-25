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

namespace Using_Report_Variables_in_Code
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

        private void button1_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Load(@"Reports\Variables.mrt");

            // Required to prepare the in compilation mode
            report.Compile();

            // Set Variables
            report["Name"] = textBoxName.Text;
            report["Surname"] = textBoxSurname.Text;
            report["Email"] = textBoxEmail.Text;
            report["Address"] = textBoxAddress.Text;
            report["Sex"] = radioButtonMale.Checked;

            report.Show();
        }
    }
}
