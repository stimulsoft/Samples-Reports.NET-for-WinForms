using Stimulsoft.Base.Localization;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localizing_the_User_Interface
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

            foreach (var fileName in Directory.GetFiles(@"Localization"))
            {
                comboBoxLocalizations.Items.Add(fileName);

                if (fileName.EndsWith("en.xml"))
                    comboBoxLocalizations.SelectedItem = fileName;
            }
        }

        private void LoadLocalization()
        {
            StiOptions.Localization.Load(comboBoxLocalizations.Text);
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            LoadLocalization();

            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.Show();
        }

        private void ButtonDesign_Click(object sender, EventArgs e)
        {
            LoadLocalization();

            var report = new StiReport();
            report.Load(@"Reports\SimpleList.mrt");
            report.Design();
        }
    }
}
