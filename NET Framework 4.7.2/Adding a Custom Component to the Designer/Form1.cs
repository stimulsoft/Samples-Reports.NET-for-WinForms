using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;

namespace Adding_a_Custom_Component_to_the_Designer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run Designer";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 140);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding a Custom Component to the Designer";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			// Enable HiDPI mode
			Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

			AddCustomComponent();

            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private static void AddCustomComponent()
		{
			StiConfig.Load();

			StiOptions.Engine.ReferencedAssemblies
				 = new string[]{
							"System.Dll",
							"System.Drawing.Dll",
							"System.Windows.Forms.Dll",
							"System.Data.Dll",
							"System.Xml.Dll",
							"Stimulsoft.Controls.Dll",
							"Stimulsoft.Base.Dll",
							"Stimulsoft.Report.Dll",

							#region Add reference to your assembly
							"Adding_a_Custom_Component_to_the_Designer.exe"
							#endregion
						};

			StiConfig.Services.Add(new MyCustomComponent());
			StiConfig.Services.Add(new MyCustomComponentWithDataSource());
            StiConfig.Services.Add(new MyCustomComponentWithExpression());
			StiConfig.Services.Add(new MyCustomComponent2());
			StiConfig.Services.Add(new MyCustomComponent2WithDataSource());
			StiConfig.Save();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{			
            StiReport report = new StiReport();
			report.Design();
		}
	}
}
