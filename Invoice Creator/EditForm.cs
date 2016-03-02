using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace InvoiceCreator
{
    public partial class EditForm : Form
    {
        #region Fields

        private string pathXML;
        private DataSet dataSetInvoice;
        public int invoiceNumber
        {
            get
            {
                int invNum = -1;
                int.TryParse(textBoxNumber.Text, out invNum);
                return invNum;
            }
        }

        #endregion

        #region Methods

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string pathXML, DataSet dataSetInvoice)
        {
            this.pathXML = pathXML;
            this.dataSetInvoice = dataSetInvoice;
            InitializeComponent();
        }

        #endregion

        #region Handlers

        private void EditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            dataSetInvoice.ReadXml(pathXML);
            dataGridViewProducts.DataSource = dataSetInvoice;
            dataGridViewProducts.DataMember = "Products";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXML);

            DateTime tmpDate = new DateTime();
            dateTimePickerInvoiceDate.Value = DateTime.TryParse(xmlDoc.SelectSingleNode("//Demo/Invoice/InvoiceDate").InnerText, out tmpDate) ? tmpDate : DateTime.Now;
            textBoxNumber.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/InvoiceNumber").InnerText;
            textBoxCustomer.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/CustomerID").InnerText;
            textBoxBillToName.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_Name").InnerText;
            textBoxBillToAddress.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_Address").InnerText;
            textBoxBillToAddress2.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_Address2").InnerText;
            textBoxBillToCity.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_City").InnerText;
            textBoxBillToState.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_State").InnerText;
            textBoxBillToZipCode.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_ZipCode").InnerText;
            textBoxShipToName.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_Name").InnerText;
            textBox1ShipToAddress.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_Address").InnerText;
            textBoxShipToAddress2.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_Address2").InnerText;
            textBoxShipToCity.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_City").InnerText;
            textBoxShipToState.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_State").InnerText;
            textBoxShipToZipCode.Text = xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_ZipCode").InnerText;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataSetInvoice.WriteXml(pathXML);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXML);
            xmlDoc.SelectSingleNode("//Demo/Invoice/InvoiceDate").InnerText = dateTimePickerInvoiceDate.Value.ToString();
            xmlDoc.SelectSingleNode("//Demo/Invoice/InvoiceNumber").InnerText = textBoxNumber.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/CustomerID").InnerText = textBoxCustomer.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_Name").InnerText = textBoxBillToName.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_Address").InnerText = textBoxBillToAddress.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_Address2").InnerText = textBoxBillToAddress2.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_City").InnerText = textBoxBillToCity.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_State").InnerText = textBoxBillToState.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/BillTo_ZipCode").InnerText = textBoxBillToZipCode.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_Name").InnerText = textBoxShipToName.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_Address").InnerText = textBox1ShipToAddress.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_Address2").InnerText = textBoxShipToAddress2.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_City").InnerText = textBoxShipToCity.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_State").InnerText = textBoxShipToState.Text;
            xmlDoc.SelectSingleNode("//Demo/Invoice/ShipTo_ZipCode").InnerText = textBoxShipToZipCode.Text;
            xmlDoc.Save(pathXML);
            this.Close();
        }

        #endregion

    }
}