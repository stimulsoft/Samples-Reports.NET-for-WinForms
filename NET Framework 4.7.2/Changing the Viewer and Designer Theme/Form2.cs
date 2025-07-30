using Stimulsoft.Base.Drawing;
using Stimulsoft.Base.Theme;
using Stimulsoft.Controls;
using Stimulsoft.Report;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Changing_the_Viewer_and_Designer_Theme
{
    public partial class Form2 : StiForm
    {
        public Form2()
        {
            // Enable DPI awareness for Stimulsoft
            Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

            InitializeComponent();

            // Create an empty report and assign it to the designer
            var report = new StiReport();
            designerControl.Report = report;

            ApplyStyle(); // Apply controls style on startup
        }

        #region Methods
        // Handler for the theme change button click
        private void ButtonChangeTheme_Click(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyStyle()
        {
            // Change button caption
            var themeName = StiUXTheme.ActualAppTheme == StiAppThemeAppearance.Light ? "Dark" : "Light";
            buttonChangeTheme.Text = $"Switch to {themeName} Theme";

            // Set blue color and white text for the standard button
            buttonChangeTheme.BackColor = StiUX.GetAccent();
            buttonChangeTheme.ForeColor = System.Drawing.Color.White;
            buttonChangeTheme.FlatStyle = FlatStyle.Flat;
            buttonChangeTheme.FlatAppearance.BorderColor = StiUX.GetAccent();
            buttonChangeTheme.FlatAppearance.BorderSize = 1;
        }

        // Apply theme and set button colors
        private void ApplyTheme()
        {
            if (StiUXTheme.ActualAppTheme == StiAppThemeAppearance.Dark)
            {
                StiUXTheme.ApplyNewTheme(StiThemeAppearance.Light, StiUXTheme.AccentColor, false);
            }
            else
            {
                StiUXTheme.ApplyNewTheme(StiThemeAppearance.Dark, StiUXTheme.AccentColor, false);
            }

            ApplyStyle();
        }
        #endregion

        // Add rounded corners to the button on form load
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Corner radius
            int radius = 10;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(buttonChangeTheme.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(buttonChangeTheme.Width - radius, buttonChangeTheme.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, buttonChangeTheme.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            buttonChangeTheme.Region = new Region(path); // Apply rounded corners
        }
    }
}
