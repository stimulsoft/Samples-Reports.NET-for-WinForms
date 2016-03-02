using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InvoiceCreator
{
    public partial class PrintForm : Form
    {
        #region Fields

        private DataSet dataSetInvoice;
        private string ReportsPath = Application.StartupPath + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "Reports" + Path.DirectorySeparatorChar;

        #endregion

        #region Methods

        public PrintForm()
        {
            InitializeComponent();
        }

        public PrintForm(DataSet dataSetInvoice)
        {
            this.dataSetInvoice = dataSetInvoice;
            InitializeComponent();
        }

        private void FillTreeView()
        {
            treeViewReports.Nodes.Clear();
            string[] strFiles = Directory.GetFiles(ReportsPath);
            foreach (string myFile in strFiles)
            {
                if (Path.GetExtension(myFile).ToUpperInvariant() == ".MRT")
                {
                    treeViewReports.Nodes.Add(Path.GetFileNameWithoutExtension(myFile));
                };
            }
            if (treeViewReports.Nodes.Count > 0)
            {
                treeViewReports.SelectedNode = treeViewReports.Nodes[0];
            }
        }

        private void CheckButtons()
        {
            if (treeViewReports.Nodes.Count > 0)
            {
                toolStripButtonPrint.Enabled = true;
                toolStripButtonDesign.Enabled = true;
            }
            else
            {
                toolStripButtonPrint.Enabled = false;
                toolStripButtonDesign.Enabled = false;
            }
        }

        #endregion

        #region Handlers

        private void PrintForm_Load(object sender, EventArgs e)
        {
            FillTreeView();
            if (treeViewReports.Nodes.Count > 0)
            {
                treeViewReports.SelectedNode = treeViewReports.Nodes[0];
            };
            CheckButtons();
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            if (treeViewReports.SelectedNode.Index != -1)
            {
                using (Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport())
                {
                    report.Load(ReportsPath + treeViewReports.SelectedNode.Text + ".mrt");
                    report.Dictionary.Databases.Clear();
                    report.RegData("Demo", "Demo", dataSetInvoice);
                    report.Compile();
                    report.Show(true);
                }
            }
            else
            {
                MessageBox.Show("Select invoice first to proceed!");
            }
        }

        private void toolStripButtonDesign_Click(object sender, EventArgs e)
        {
            if (treeViewReports.SelectedNode.Index != -1)
            {
                using (Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport())
                {
                    report.Load(ReportsPath + treeViewReports.SelectedNode.Text + ".mrt");
                    report.Dictionary.Databases.Clear();
                    report.RegData("Demo", "Demo", dataSetInvoice);
                    report.Compile();
                    report.Design(true);
                }
            }
            else
            {
                MessageBox.Show("Select invoice first to proceed!");
            }
        }

        private void PrintForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeViewReports_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewReports.SelectedNode = treeViewReports.GetNodeAt(e.X, e.Y);
                if (treeViewReports.SelectedNode != null)
                {
                    contextMenuStripPrint.Show(treeViewReports, e.Location);
                }
            }
        }

        #endregion

    }
}