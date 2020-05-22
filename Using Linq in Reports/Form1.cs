using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Linq
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

            Item[] items = new Item[] { new Book{Id = 1, Price = 13.50, Genre = "Comedy", Author = "Jim Bob"}, 
                                        new Book{Id = 2, Price = 8.50, Genre = "Drama", Author = "John Fox"},  
                                        new Movie{Id = 1, Price = 22.99, Genre = "Comedy", Director = "Phil Funk"},
                                        new Movie{Id = 1, Price = 13.40, Genre = "Action", Director = "Eddie Jones"}};


            var query1 = from i in items
                         where i.Price > 9.99
                         orderby i.Price
                         select i;

            report.Load("..\\Report.mrt");

            report.RegBusinessObject("MyData", "MyData", query1);
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
