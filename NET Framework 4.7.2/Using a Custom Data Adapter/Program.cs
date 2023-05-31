using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Using_a_Custom_Data_Adapter
{
    static class Program
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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
