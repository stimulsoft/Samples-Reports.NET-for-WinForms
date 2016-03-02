namespace InvoiceCreator
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxShipTo = new System.Windows.Forms.GroupBox();
            this.textBoxShipToZipCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxShipToState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxShipToCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxShipToAddress2 = new System.Windows.Forms.TextBox();
            this.textBox1ShipToAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxShipToName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxBillTo = new System.Windows.Forms.GroupBox();
            this.textBoxBillToZipCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBillToState = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBillToCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBillToAddress2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBillToAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBillToName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxShipTo.SuspendLayout();
            this.groupBoxBillTo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dateTimePickerInvoiceDate);
            this.panel1.Controls.Add(this.groupBoxShipTo);
            this.panel1.Controls.Add(this.groupBoxBillTo);
            this.panel1.Controls.Add(this.textBoxCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 732);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewProducts);
            this.panel3.Location = new System.Drawing.Point(10, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 457);
            this.panel3.TabIndex = 7;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(456, 451);
            this.dataGridViewProducts.TabIndex = 16;
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(160, 12);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerInvoiceDate.TabIndex = 0;
            // 
            // groupBoxShipTo
            // 
            this.groupBoxShipTo.Controls.Add(this.textBoxShipToZipCode);
            this.groupBoxShipTo.Controls.Add(this.label15);
            this.groupBoxShipTo.Controls.Add(this.label8);
            this.groupBoxShipTo.Controls.Add(this.textBoxShipToState);
            this.groupBoxShipTo.Controls.Add(this.label9);
            this.groupBoxShipTo.Controls.Add(this.textBoxShipToCity);
            this.groupBoxShipTo.Controls.Add(this.label10);
            this.groupBoxShipTo.Controls.Add(this.textBoxShipToAddress2);
            this.groupBoxShipTo.Controls.Add(this.textBox1ShipToAddress);
            this.groupBoxShipTo.Controls.Add(this.label11);
            this.groupBoxShipTo.Controls.Add(this.textBoxShipToName);
            this.groupBoxShipTo.Controls.Add(this.label12);
            this.groupBoxShipTo.Location = new System.Drawing.Point(242, 91);
            this.groupBoxShipTo.Name = "groupBoxShipTo";
            this.groupBoxShipTo.Size = new System.Drawing.Size(226, 178);
            this.groupBoxShipTo.TabIndex = 4;
            this.groupBoxShipTo.TabStop = false;
            this.groupBoxShipTo.Text = "Ship To";
            // 
            // textBoxShipToZipCode
            // 
            this.textBoxShipToZipCode.Location = new System.Drawing.Point(78, 148);
            this.textBoxShipToZipCode.Name = "textBoxShipToZipCode";
            this.textBoxShipToZipCode.Size = new System.Drawing.Size(143, 20);
            this.textBoxShipToZipCode.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "ZipCode:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "State:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxShipToState
            // 
            this.textBoxShipToState.Location = new System.Drawing.Point(78, 122);
            this.textBoxShipToState.Name = "textBoxShipToState";
            this.textBoxShipToState.Size = new System.Drawing.Size(143, 20);
            this.textBoxShipToState.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "City:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxShipToCity
            // 
            this.textBoxShipToCity.Location = new System.Drawing.Point(78, 96);
            this.textBoxShipToCity.Name = "textBoxShipToCity";
            this.textBoxShipToCity.Size = new System.Drawing.Size(143, 20);
            this.textBoxShipToCity.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Address 2:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxShipToAddress2
            // 
            this.textBoxShipToAddress2.Location = new System.Drawing.Point(78, 70);
            this.textBoxShipToAddress2.Name = "textBoxShipToAddress2";
            this.textBoxShipToAddress2.Size = new System.Drawing.Size(143, 20);
            this.textBoxShipToAddress2.TabIndex = 11;
            // 
            // textBox1ShipToAddress
            // 
            this.textBox1ShipToAddress.Location = new System.Drawing.Point(78, 44);
            this.textBox1ShipToAddress.Name = "textBox1ShipToAddress";
            this.textBox1ShipToAddress.Size = new System.Drawing.Size(143, 20);
            this.textBox1ShipToAddress.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Address:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxShipToName
            // 
            this.textBoxShipToName.Location = new System.Drawing.Point(78, 18);
            this.textBoxShipToName.Name = "textBoxShipToName";
            this.textBoxShipToName.Size = new System.Drawing.Size(143, 20);
            this.textBoxShipToName.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Name:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxBillTo
            // 
            this.groupBoxBillTo.Controls.Add(this.textBoxBillToZipCode);
            this.groupBoxBillTo.Controls.Add(this.label13);
            this.groupBoxBillTo.Controls.Add(this.textBoxBillToState);
            this.groupBoxBillTo.Controls.Add(this.label14);
            this.groupBoxBillTo.Controls.Add(this.textBoxBillToCity);
            this.groupBoxBillTo.Controls.Add(this.label7);
            this.groupBoxBillTo.Controls.Add(this.textBoxBillToAddress2);
            this.groupBoxBillTo.Controls.Add(this.label6);
            this.groupBoxBillTo.Controls.Add(this.textBoxBillToAddress);
            this.groupBoxBillTo.Controls.Add(this.label5);
            this.groupBoxBillTo.Controls.Add(this.textBoxBillToName);
            this.groupBoxBillTo.Controls.Add(this.label4);
            this.groupBoxBillTo.Location = new System.Drawing.Point(10, 91);
            this.groupBoxBillTo.Name = "groupBoxBillTo";
            this.groupBoxBillTo.Size = new System.Drawing.Size(226, 178);
            this.groupBoxBillTo.TabIndex = 3;
            this.groupBoxBillTo.TabStop = false;
            this.groupBoxBillTo.Text = "Bill To";
            // 
            // textBoxBillToZipCode
            // 
            this.textBoxBillToZipCode.Location = new System.Drawing.Point(73, 146);
            this.textBoxBillToZipCode.Name = "textBoxBillToZipCode";
            this.textBoxBillToZipCode.Size = new System.Drawing.Size(143, 20);
            this.textBoxBillToZipCode.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "ZipCode:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBillToState
            // 
            this.textBoxBillToState.Location = new System.Drawing.Point(73, 120);
            this.textBoxBillToState.Name = "textBoxBillToState";
            this.textBoxBillToState.Size = new System.Drawing.Size(143, 20);
            this.textBoxBillToState.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "State:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBillToCity
            // 
            this.textBoxBillToCity.Location = new System.Drawing.Point(73, 94);
            this.textBoxBillToCity.Name = "textBoxBillToCity";
            this.textBoxBillToCity.Size = new System.Drawing.Size(143, 20);
            this.textBoxBillToCity.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "City:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBillToAddress2
            // 
            this.textBoxBillToAddress2.Location = new System.Drawing.Point(73, 68);
            this.textBoxBillToAddress2.Name = "textBoxBillToAddress2";
            this.textBoxBillToAddress2.Size = new System.Drawing.Size(143, 20);
            this.textBoxBillToAddress2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address 2:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBillToAddress
            // 
            this.textBoxBillToAddress.Location = new System.Drawing.Point(73, 42);
            this.textBoxBillToAddress.Name = "textBoxBillToAddress";
            this.textBoxBillToAddress.Size = new System.Drawing.Size(143, 20);
            this.textBoxBillToAddress.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBillToName
            // 
            this.textBoxBillToName.Location = new System.Drawing.Point(73, 16);
            this.textBoxBillToName.Name = "textBoxBillToName";
            this.textBoxBillToName.Size = new System.Drawing.Size(143, 20);
            this.textBoxBillToName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(160, 64);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(162, 20);
            this.textBoxCustomer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(81, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(160, 38);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(162, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(81, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(265, 732);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 26);
            this.panel2.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(103, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 20);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 20);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 450);
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Invoice";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxShipTo.ResumeLayout(false);
            this.groupBoxShipTo.PerformLayout();
            this.groupBoxBillTo.ResumeLayout(false);
            this.groupBoxBillTo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxBillTo;
        private System.Windows.Forms.TextBox textBoxBillToZipCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxBillToState;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBillToCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBillToAddress2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBillToAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBillToName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxShipTo;
        private System.Windows.Forms.TextBox textBoxShipToZipCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxShipToState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxShipToCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxShipToAddress2;
        private System.Windows.Forms.TextBox textBox1ShipToAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxShipToName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}