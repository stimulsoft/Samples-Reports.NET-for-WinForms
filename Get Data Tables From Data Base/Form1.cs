using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System.Collections;
using System.Data.OleDb;
using System.Data.SqlClient;
using Stimulsoft.Report.Design;

namespace GetDataTablesFromDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private StiReport report;
        public StiReport Report
        {
            get { return report; }
            set { report = value; }
        }

        public ArrayList GetAccessTableNames(string connectionString)
        {
            if (connectionString == null)
            {
                throw new InvalidOperationException("ConnectionString must be set before trying to retrieve the Table Names.");
            }
            OleDbConnection oleconn = new OleDbConnection(connectionString);
            oleconn.Open();
            ArrayList arrayList = new ArrayList();
            DataTable tables = ((OleDbConnection)oleconn).GetOleDbSchemaTable(
            OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach (DataRow r in tables.Rows)
            {
                arrayList.Add(r["TABLE_NAME"] as string);
            }
            oleconn.Close();
            return arrayList;
        }

        public ArrayList GetMSSqlTableNames(string connectionString)
        {
            if (connectionString == null)
            {
                throw new InvalidOperationException("ConnectionString must be set before trying to retrieve the Table Names.");
            }
            ArrayList arrayList = new ArrayList();
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from sysobjects where type='u'", myConnection);
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);
            foreach (DataRow myDataRow in myDataSet.Tables[0].Rows)
            {
                arrayList.Add(myDataRow["name"].ToString());
            }
            return arrayList;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLExpress;AttachDbFilename=D:\Stimulsoft\Data\SqlSeverExpress\NorthWindExpress.mdf;Initial Catalog=NorthWindExpress;Integrated Security=True";
            if (textBox1.Text.Trim().Length > 0)
            {
                connectionString = textBox1.Text;
            }
            else
            {
                textBox1.Text = connectionString;            
            }
            ArrayList myArraylist = GetMSSqlTableNames(connectionString);
            foreach (string item in myArraylist)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            string fileName = "\"C:\\Program Files\\Stimulsoft Reports.Net 2007.3 Trial\\.Net 2.0\\Bin\\Data\\NWIND.MDB\"";
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + 
            "Data Source=" + fileName + ";Persist Security Info=False";
            if (textBox2.Text.Trim().Length > 0)
            {
                connectionString = textBox2.Text;
            }
            else
            {
                textBox2.Text = connectionString;
            }
            ArrayList myArraylist = GetAccessTableNames(connectionString);
            foreach (string item in myArraylist)
            {
                checkedListBox2.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool IsNameUnique = true;
            string connectionString1 = textBox1.Text.Trim();
            string connectionString2 = textBox2.Text.Trim();
            if ((connectionString1.Length > 0) || (connectionString2.Length > 0))
            {
                if (this.Report == null)
                {
                    this.Report = new StiReport();
                }
                this.Report.Dictionary.Clear();
                this.report.DataStore.Clear();
            }
            if (connectionString1.Length > 0)
            {
                StiDatabase mySqlDatabase = null;
                foreach (StiDatabase database in this.report.Dictionary.Databases)
                {
                    if (database.Name == "MyStiSqlDatabase")
                        mySqlDatabase = database;
                }
                if (mySqlDatabase == null)
                {
                    mySqlDatabase = new StiSqlDatabase("MyStiSqlDatabase", connectionString1);
                    this.Report.Dictionary.Databases.Add(mySqlDatabase);
                }
                if (mySqlDatabase.GetType() == typeof(StiSqlDatabase))
                {
                    foreach (string myItem in checkedListBox1.CheckedItems)
                    {
                        IsNameUnique = true;
                        foreach (StiDataSource source in this.Report.DataSources)
                        {
                            if (source.Name == myItem)
                            {
                                IsNameUnique = false;
                            }
                        }
                        if (IsNameUnique)
                        {
                            StiSqlSource sqlSource = new StiSqlSource("MyStiSqlDatabase", myItem, myItem, "SELECT * FROM dbo.\"" + myItem + "\"");
                            this.Report.Dictionary.DataSources.Add(sqlSource);
                            this.Report.Dictionary.Synchronize();
                            sqlSource.SynchronizeColumns();
                        }
                    }
                }
            }
            if (connectionString2.Length > 0)
            {
                StiDatabase myOleDbDatabase = null;
                foreach (StiDatabase database in this.report.Dictionary.Databases)
                {
                    if (database.Name == "MyStiOleDbDatabase")
                    {
                        myOleDbDatabase = database;
                    }
                }
                if (myOleDbDatabase == null)
                {
                    myOleDbDatabase = new StiOleDbDatabase("MyStiOleDbDatabase", connectionString2);
                    this.Report.Dictionary.Databases.Add(myOleDbDatabase);
                }
                if (myOleDbDatabase.GetType() == typeof(StiOleDbDatabase))
                {
                    foreach (string myItem in checkedListBox2.CheckedItems)
                    {
                        IsNameUnique = true;
                        foreach (StiDataSource source in this.Report.DataSources)
                        {
                            if (source.Name == myItem)
                            {
                                IsNameUnique = false;
                            }
                        }
                        if (IsNameUnique)
                        {
                            StiOleDbSource oleDbSource = new StiOleDbSource("MyStiOleDbDatabase", myItem, myItem, "SELECT * FROM [" + myItem + "]");
                            this.Report.Dictionary.DataSources.Add(oleDbSource);
                            this.Report.Dictionary.Synchronize();
                            oleDbSource.SynchronizeColumns();
                        }
                    }
                }
            }
            if (this.Report == null)
            {
                this.Report = new StiReport();
            }
            if (this.Report.Designer == null)
            {
                StiDesigner.CreatedReport += new EventHandler(StiDesigner_CreatedReport);
                StiDesigner.ClosingDesigner += ClosingDesigner;
                MessageBox.Show("Click 'File' then 'New Report' and this dialog appears again.");
                this.Report.Design();
                this.Report = null;
            }
            else
            {
                this.Close();
            }
        }

        public static void StiDesigner_CreatedReport(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Report = (sender as StiDesigner).Report;
            form.Report.Designer = (sender as StiDesigner);
            form.ShowDialog();
            Stimulsoft.Report.Design.Panels.StiDictionaryPanelService.GetService(
                form.Report.Designer.DesignerControl as StiDesignerControl).DictionaryControl.Build(form.Report);
        }

        public static void ClosingDesigner(object sender, CancelEventArgs e)
        {
            StiDesigner.CreatedReport -= StiDesigner_CreatedReport;
        }

    }
}