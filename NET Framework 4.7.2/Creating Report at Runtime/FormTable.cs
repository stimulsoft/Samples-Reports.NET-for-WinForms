using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Components.Table;
using Stimulsoft.Base.Drawing;

namespace Creating_Report_at_Runtime
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormTable : Form
	{
		private Button button1;
		private DataGrid dataGrid1;
		private DataView dataView1;
        private Panel panel1;
        private GroupBox groupBox2;
        private RadioButton rbAWTLastColumns;
        private RadioButton rbAWTFullTable;
        private RadioButton rbAWTNone;
        private GroupBox groupBox1;
        private RadioButton rbAWPage;
        private RadioButton rbAWTable;
        private RadioButton rbAWNone;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public FormTable()
		{
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataView1 = new System.Data.DataView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAWTLastColumns = new System.Windows.Forms.RadioButton();
            this.rbAWTFullTable = new System.Windows.Forms.RadioButton();
            this.rbAWTNone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAWPage = new System.Windows.Forms.RadioButton();
            this.rbAWTable = new System.Windows.Forms.RadioButton();
            this.rbAWNone = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dataView1;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 8);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(448, 215);
            this.dataGrid1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(8, 228);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 96);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAWTLastColumns);
            this.groupBox2.Controls.Add(this.rbAWTFullTable);
            this.groupBox2.Controls.Add(this.rbAWTNone);
            this.groupBox2.Location = new System.Drawing.Point(222, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(221, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AutoWidthType";
            // 
            // rbAWTLastColumns
            // 
            this.rbAWTLastColumns.AutoSize = true;
            this.rbAWTLastColumns.Location = new System.Drawing.Point(6, 62);
            this.rbAWTLastColumns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAWTLastColumns.Name = "rbAWTLastColumns";
            this.rbAWTLastColumns.Size = new System.Drawing.Size(85, 17);
            this.rbAWTLastColumns.TabIndex = 5;
            this.rbAWTLastColumns.Text = "LastColumns";
            this.rbAWTLastColumns.UseVisualStyleBackColor = true;
            // 
            // rbAWTFullTable
            // 
            this.rbAWTFullTable.AutoSize = true;
            this.rbAWTFullTable.Location = new System.Drawing.Point(6, 41);
            this.rbAWTFullTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAWTFullTable.Name = "rbAWTFullTable";
            this.rbAWTFullTable.Size = new System.Drawing.Size(68, 17);
            this.rbAWTFullTable.TabIndex = 4;
            this.rbAWTFullTable.Text = "FullTable";
            this.rbAWTFullTable.UseVisualStyleBackColor = true;
            // 
            // rbAWTNone
            // 
            this.rbAWTNone.AutoSize = true;
            this.rbAWTNone.Checked = true;
            this.rbAWTNone.Location = new System.Drawing.Point(6, 18);
            this.rbAWTNone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAWTNone.Name = "rbAWTNone";
            this.rbAWTNone.Size = new System.Drawing.Size(51, 17);
            this.rbAWTNone.TabIndex = 3;
            this.rbAWTNone.TabStop = true;
            this.rbAWTNone.Text = "None";
            this.rbAWTNone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAWPage);
            this.groupBox1.Controls.Add(this.rbAWTable);
            this.groupBox1.Controls.Add(this.rbAWNone);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(212, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AutoWidth";
            // 
            // rbAWPage
            // 
            this.rbAWPage.AutoSize = true;
            this.rbAWPage.Location = new System.Drawing.Point(6, 62);
            this.rbAWPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAWPage.Name = "rbAWPage";
            this.rbAWPage.Size = new System.Drawing.Size(50, 17);
            this.rbAWPage.TabIndex = 2;
            this.rbAWPage.Text = "Page";
            this.rbAWPage.UseVisualStyleBackColor = true;
            // 
            // rbAWTable
            // 
            this.rbAWTable.AutoSize = true;
            this.rbAWTable.Checked = true;
            this.rbAWTable.Location = new System.Drawing.Point(6, 41);
            this.rbAWTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAWTable.Name = "rbAWTable";
            this.rbAWTable.Size = new System.Drawing.Size(52, 17);
            this.rbAWTable.TabIndex = 1;
            this.rbAWTable.TabStop = true;
            this.rbAWTable.Text = "Table";
            this.rbAWTable.UseVisualStyleBackColor = true;
            // 
            // rbAWNone
            // 
            this.rbAWNone.AutoSize = true;
            this.rbAWNone.Location = new System.Drawing.Point(6, 18);
            this.rbAWNone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAWNone.Name = "rbAWNone";
            this.rbAWNone.Size = new System.Drawing.Size(51, 17);
            this.rbAWNone.TabIndex = 0;
            this.rbAWNone.Text = "None";
            this.rbAWNone.UseVisualStyleBackColor = true;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runtime Table Creation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void PrintDataGrid(DataGrid sender)
		{
			DataView dataView = (DataView)sender.DataSource;
			StiReport report = new StiReport();
			report.ScriptLanguage = StiReportLanguageType.CSharp;

			//Add data to datastore
			report.RegData("view", dataView);
			
			//Fill dictionary
			report.Dictionary.Synchronize();
			StiPage page = report.Pages.Items[0];

            //Create Table
            StiTable table = new StiTable();
            table.Name = "Table1";
            if (rbAWNone.Checked)
                table.AutoWidth = StiTableAutoWidth.None;
            else if (rbAWPage.Checked)
                    table.AutoWidth = StiTableAutoWidth.Page;
                else table.AutoWidth = StiTableAutoWidth.Table;

            if (rbAWTNone.Checked)
                table.AutoWidthType = StiTableAutoWidthType.None;
            else if (rbAWTFullTable.Checked)
                table.AutoWidthType = StiTableAutoWidthType.FullTable;
            else table.AutoWidthType = StiTableAutoWidthType.LastColumns;

            table.ColumnCount = 3;
            table.RowCount = 3;
            table.HeaderRowsCount = 1;
            table.FooterRowsCount = 1;
            table.Width = page.Width;
            table.Height = page.GridSize * 12;
            table.DataSourceName = "view" + dataView.Table.TableName;
            page.Components.Add(table);
            table.CreateCell();
            table.TableStyleFX = new StiTable27StyleFX();
            table.TableStyle = Stimulsoft.Report.Components.Table.StiTableStyle.Style59;

            int indexHeaderCell = 0;
            int indexDataCell = 3;

            foreach (DataColumn column in dataView.Table.Columns)
            {
                //Set text on header
                StiTableCell headerCell = table.Components[indexHeaderCell] as StiTableCell;
                headerCell.Text.Value = column.Caption;
                headerCell.HorAlignment = StiTextHorAlignment.Center;
                headerCell.VertAlignment = StiVertAlignment.Center;

                StiTableCell dataCell = table.Components[indexDataCell] as StiTableCell;
                dataCell.Text.Value = "{view" + dataView.Table.TableName + "." + Stimulsoft.Report.CodeDom.StiCodeDomSerializator.ReplaceSymbols(column.ColumnName) + "}";
                dataCell.Border = new StiBorder(StiBorderSides.All, Color.FromArgb(32, 178, 170), 1, StiPenStyle.Dash);

                indexHeaderCell++;
                indexDataCell++;
            }

            StiTableCell dataCheckBoxCell = table.Components[indexDataCell - 1] as StiTableCell;
            dataCheckBoxCell.CellType = StiTablceCellType.CheckBox;

            //Set text on footer
            StiTableCell footerCell = table.Components[table.Components.Count - 1] as StiTableCell;
            footerCell.Text.Value = "Count - {Count()}";
            footerCell.Font = new Font("Arial", 15, FontStyle.Bold);
            footerCell.VertAlignment = StiVertAlignment.Center;
            footerCell.HorAlignment = StiTextHorAlignment.Center;

			//Render without progress bar
			report.Render(false);
			report.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PrintDataGrid(dataGrid1);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DataTable table = new DataTable("Demo");
			
			table.Columns.Add();
			table.Columns.Add();
            table.Columns.Add();

			DataRow row1 = table.NewRow();
			DataRow row2 = table.NewRow();
			DataRow row3 = table.NewRow();
            DataRow row4 = table.NewRow();

			row1.ItemArray = new string[3] { "1", "One", "true" };
            row2.ItemArray = new string[3] { "2", "Two", "false" };
            row3.ItemArray = new string[3] { "3", "Three", "false" };
            row4.ItemArray = new string[3] { "4", "Four", "true" };

			table.Rows.Add(row1);
			table.Rows.Add(row2);
			table.Rows.Add(row3);
            table.Rows.Add(row4);
			dataView1.Table = table;
		}
	}
}
