using Stimulsoft.Base.Drawing;
using Stimulsoft.Controls;
using Stimulsoft.Report;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Using_Report_Variables_in_Code
{
    public partial class Form1 : StiForm
    {
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
            // Enable HiDPI mode
            Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        public Form1()
        {
            Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();
            InitializeComponent();
        }

        #region Methods
        private StiReport GetReportWithVariables()
        {
            var report = new StiReport();
            report.Load(@"..\Variables.mrt");
            report.Compile();

            report["Name"] = textBoxName.Text;
            report["Surname"] = textBoxSurname.Text;
            report["Email"] = textBoxEmail.Text;
            report["Address"] = textBoxAddress.Text;
            report["Sex"] = rbMale.Checked;
            report["BirthDay"] = dateTimePickerBirthday.Value;

            return report;
        }

        private void StyleButton(Button button)
        {
            button.BackColor = StiUX.GetAccent();
            button.ForeColor = System.Drawing.Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = StiUX.GetAccent();
            button.FlatAppearance.BorderSize = 1;

            // Corner radius
            var radius = 10;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path); // Apply rounded corners
        }
        #endregion

        #region Handlers
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            StyleButton(buttonSubmit);
            StyleButton(buttonShow);
            StyleButton(buttonDesign);
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var report = GetReportWithVariables();
            report.Render();

            viewerControl.Report = report;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var report = GetReportWithVariables();
            report.Show();
        }

        private void buttonDesign_Click(object sender, EventArgs e)
        {
            var report = GetReportWithVariables();
            report.Design();
        }
        #endregion
    }
}
