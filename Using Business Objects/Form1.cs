using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;

namespace BusinessObjects
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btPreviewITypedList;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btPreviewIEnumerable;
		private System.Windows.Forms.Button btDesignIEnumerable;
		private System.Windows.Forms.Button btDesignITypedList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btPreviewITypedList = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btPreviewIEnumerable = new System.Windows.Forms.Button();
            this.btDesignIEnumerable = new System.Windows.Forms.Button();
            this.btDesignITypedList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPreviewITypedList
            // 
            this.btPreviewITypedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPreviewITypedList.Location = new System.Drawing.Point(152, 19);
            this.btPreviewITypedList.Name = "btPreviewITypedList";
            this.btPreviewITypedList.Size = new System.Drawing.Size(75, 26);
            this.btPreviewITypedList.TabIndex = 1;
            this.btPreviewITypedList.Text = "Preview";
            this.btPreviewITypedList.Click += new System.EventHandler(this.btPreviewITypedList_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(148, 150);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 26);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPreviewIEnumerable
            // 
            this.btPreviewIEnumerable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPreviewIEnumerable.Location = new System.Drawing.Point(152, 19);
            this.btPreviewIEnumerable.Name = "btPreviewIEnumerable";
            this.btPreviewIEnumerable.Size = new System.Drawing.Size(75, 26);
            this.btPreviewIEnumerable.TabIndex = 1;
            this.btPreviewIEnumerable.Text = "Preview";
            this.btPreviewIEnumerable.Click += new System.EventHandler(this.btPreviewIEnumerable_Click);
            // 
            // btDesignIEnumerable
            // 
            this.btDesignIEnumerable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesignIEnumerable.Location = new System.Drawing.Point(71, 19);
            this.btDesignIEnumerable.Name = "btDesignIEnumerable";
            this.btDesignIEnumerable.Size = new System.Drawing.Size(75, 26);
            this.btDesignIEnumerable.TabIndex = 0;
            this.btDesignIEnumerable.Text = "Design";
            this.btDesignIEnumerable.Click += new System.EventHandler(this.btDesignIEnumerable_Click);
            // 
            // btDesignITypedList
            // 
            this.btDesignITypedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesignITypedList.Location = new System.Drawing.Point(71, 19);
            this.btDesignITypedList.Name = "btDesignITypedList";
            this.btDesignITypedList.Size = new System.Drawing.Size(75, 26);
            this.btDesignITypedList.TabIndex = 0;
            this.btDesignITypedList.Text = "Design";
            this.btDesignITypedList.Click += new System.EventHandler(this.btDesignITypedList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDesignIEnumerable);
            this.groupBox1.Controls.Add(this.btPreviewIEnumerable);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IEnumerable";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDesignITypedList);
            this.groupBox2.Controls.Add(this.btPreviewITypedList);
            this.groupBox2.Location = new System.Drawing.Point(8, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ITypedList";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(257, 186);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Business Objects";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btDesignIEnumerable_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
			report.Load("..\\BusinessObjects_IEnumerable.mrt");
			report.Design();
		}

		private void btDesignITypedList_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
			report.Load("..\\BusinessObjects_ITypedList.mrt");
			report.Design();
		}

		private void btPreviewIEnumerable_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
			report.Load("..\\BusinessObjects_IEnumerable.mrt");
			report.Show();
		}

		private void btPreviewITypedList_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();
			report.RegData("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
			report.Load("..\\BusinessObjects_ITypedList.mrt");
			report.Show();
		}
	}
}
