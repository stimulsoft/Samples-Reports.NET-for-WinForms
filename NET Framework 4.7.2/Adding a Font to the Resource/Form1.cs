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

namespace Adding_a_Font_to_the_Resource
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

            //Loading and adding a font to resources
            var fileContent = System.IO.File.ReadAllBytes("Fonts/Roboto-Black.ttf");
            var resource = new StiResource("Roboto-Black", "Roboto-Black", false, StiResourceType.FontTtf, fileContent, false);
            report.Dictionary.Resources.Add(resource);

            //Adding a font from resources to the font collection
            StiFontCollection.AddResourceFont(resource.Name, resource.Content, "ttf", resource.Alias);

            //Creating a text component
            var dataText = new StiText();
            dataText.ClientRectangle = new RectangleD(1, 1, 3, 2);
            dataText.Text = "Sample Text";
            dataText.Font = StiFontCollection.CreateFont("Roboto-Black", 12, FontStyle.Regular);
            dataText.Border.Side = StiBorderSides.All;

            report.Pages[0].Components.Add(dataText);
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            report.Show();
        }

        private void btDesign_Click(object sender, EventArgs e)
        {
            report.Design();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
