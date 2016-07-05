using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace InvoiceCreator
{
    public partial class MainForm : Form
    {
        #region Fields

        private DataSet dataSetInvoice = new DataSet("Invoice");
        private string InvoicesPath = ".." + Path.DirectorySeparatorChar + "Invoices" + Path.DirectorySeparatorChar;
        private string SchmemaPath = ".." + Path.DirectorySeparatorChar + "EmptyTemplate.xsd";

        #endregion

        #region Methods

        public MainForm()
        {
            InitializeComponent();
        }

        private void FillTreeView()
        {
            treeViewInvoices.Nodes.Clear();
            string[] strFiles = Directory.GetFiles(InvoicesPath);
            foreach (string myFile in strFiles)
            {
                if (Path.GetExtension(myFile).ToUpperInvariant() == ".XML")
                {
                    treeViewInvoices.Nodes.Add(Path.GetFileNameWithoutExtension(myFile));
                };
            }
            if (treeViewInvoices.Nodes.Count > 0)
            {
                treeViewInvoices.SelectedNode = treeViewInvoices.Nodes[0];
            }
        }

        private void CheckButtons()
        {
            if (treeViewInvoices.Nodes.Count > 0)
            {
                toolStripButtonDelete.Enabled = true;
                toolStripButtonEdit.Enabled = true;
                toolStripButtonPrint.Enabled = true;
            }
            else
            {
                toolStripButtonDelete.Enabled = false;
                toolStripButtonEdit.Enabled = false;
                toolStripButtonPrint.Enabled = false;
            }
        }

        #endregion

        #region Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillTreeView();
            CheckButtons();
        }
        
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            string defaultXML = InvoiceCreator.Resource.EmptyTemplate;
            string invoiceFileName = InvoicesPath + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") +".xml";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(invoiceFileName))
            {
                file.WriteLine(defaultXML);
                file.Close();
                dataSetInvoice.Clear();
                dataSetInvoice.ReadXmlSchema(SchmemaPath);
                using (EditForm editForm = new EditForm(invoiceFileName, dataSetInvoice))
                {
                    editForm.Text = "New Invoice";
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        File.Move(invoiceFileName, InvoicesPath + "Invoice #" + editForm.invoiceNumber.ToString() + " from " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xml");
                    }
                    else
                    {
                        File.Delete(invoiceFileName);
                    }
                }
            }
            FillTreeView();
            CheckButtons();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete invoice?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string filePath = treeViewInvoices.SelectedNode.Text;
                if (filePath.Length > 0)
                {
                    File.Delete(InvoicesPath + filePath + ".xml");
                }
                FillTreeView();
                CheckButtons();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (treeViewInvoices.SelectedNode.Index != -1)
            {
                dataSetInvoice.Clear();
                dataSetInvoice.ReadXmlSchema(SchmemaPath);
                using (EditForm editForm = new EditForm(InvoicesPath + treeViewInvoices.SelectedNode.Text + ".xml", dataSetInvoice))
                {
                    editForm.Text = "Edit Invoice";
                    editForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select invoice first to proceed!");
            }
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            if (treeViewInvoices.SelectedNode.Index != -1)
            {
                dataSetInvoice.Clear();
                dataSetInvoice.ReadXmlSchema(SchmemaPath);
                dataSetInvoice.ReadXml(InvoicesPath + treeViewInvoices.SelectedNode.Text + ".xml");
                using (PrintForm printForm = new PrintForm(dataSetInvoice))
                {
                    printForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select invoice first to proceed!");
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void treeViewInvoices_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewInvoices.SelectedNode = treeViewInvoices.GetNodeAt(e.X, e.Y);
                if (treeViewInvoices.SelectedNode != null)
                {
                    contextMenuStripInvoices.Show(treeViewInvoices, e.Location);
                }
                else if (treeViewInvoices.Nodes.Count > 0)
                {
                    treeViewInvoices.SelectedNode = treeViewInvoices.Nodes[0];
                }
            }
        }

        #endregion;
    }
}