using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Base.Theme;

namespace Changing_the_Viewer_and_Designer_Theme
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
        private Label labelAppearance;
        private ComboBox comboBoxAppearance;
        private Label labelAccentColor;
        private ComboBox comboBoxAccentColor;
        private Button buttonShowDesigner;
        private Button buttonShowViewer;
        private Button buttonShowDesignerForm;

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

            switch (StiUXTheme.Appearance)
            {
                case StiThemeAppearance.Auto:
                    comboBoxAppearance.SelectedIndex = 0;
                    break;

                case StiThemeAppearance.Light:
                    comboBoxAppearance.SelectedIndex = 1;
                    break;

                case StiThemeAppearance.Dark:
                    comboBoxAppearance.SelectedIndex = 2;
                    break;
            }

            switch (StiUXTheme.AccentColor)
            {
                case StiThemeAccentColor.Auto:
                    comboBoxAccentColor.SelectedIndex = 0;
                    break;

                case StiThemeAccentColor.Blue:
                    comboBoxAccentColor.SelectedIndex = 1;
                    break;

                case StiThemeAccentColor.Violet:
                    comboBoxAccentColor.SelectedIndex = 2;
                    break;

                case StiThemeAccentColor.Carmine:
                    comboBoxAccentColor.SelectedIndex = 3;
                    break;

                case StiThemeAccentColor.Teal:
                    comboBoxAccentColor.SelectedIndex = 4;
                    break;

                case StiThemeAccentColor.Green:
                    comboBoxAccentColor.SelectedIndex = 5;
                    break;

                case StiThemeAccentColor.Orange:
                    comboBoxAccentColor.SelectedIndex = 6;
                    break;
            }

            isInit = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #region Fields
        private bool isInit = false;
        #endregion

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
            this.button2 = new System.Windows.Forms.Button();
            this.labelAppearance = new System.Windows.Forms.Label();
            this.comboBoxAppearance = new System.Windows.Forms.ComboBox();
            this.labelAccentColor = new System.Windows.Forms.Label();
            this.comboBoxAccentColor = new System.Windows.Forms.ComboBox();
            this.buttonShowDesigner = new System.Windows.Forms.Button();
            this.buttonShowViewer = new System.Windows.Forms.Button();
            this.buttonShowDesignerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(316, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAppearance
            // 
            this.labelAppearance.AutoSize = true;
            this.labelAppearance.Location = new System.Drawing.Point(13, 13);
            this.labelAppearance.Name = "labelAppearance";
            this.labelAppearance.Size = new System.Drawing.Size(65, 13);
            this.labelAppearance.TabIndex = 4;
            this.labelAppearance.Text = "Appearance";
            // 
            // comboBoxAppearance
            // 
            this.comboBoxAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppearance.FormattingEnabled = true;
            this.comboBoxAppearance.Items.AddRange(new object[] {
            "Auto",
            "Light",
            "Dark"});
            this.comboBoxAppearance.Location = new System.Drawing.Point(120, 10);
            this.comboBoxAppearance.Name = "comboBoxAppearance";
            this.comboBoxAppearance.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAppearance.TabIndex = 5;
            this.comboBoxAppearance.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAppearance_SelectedIndexChanged);
            // 
            // labelAccentColor
            // 
            this.labelAccentColor.AutoSize = true;
            this.labelAccentColor.Location = new System.Drawing.Point(12, 40);
            this.labelAccentColor.Name = "labelAccentColor";
            this.labelAccentColor.Size = new System.Drawing.Size(68, 13);
            this.labelAccentColor.TabIndex = 6;
            this.labelAccentColor.Text = "Accent Color";
            // 
            // comboBoxAccentColor
            // 
            this.comboBoxAccentColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccentColor.FormattingEnabled = true;
            this.comboBoxAccentColor.Items.AddRange(new object[] {
            "Auto",
            "Blue",
            "Violet",
            "Carmine",
            "Teal",
            "Green",
            "Orange"});
            this.comboBoxAccentColor.Location = new System.Drawing.Point(120, 37);
            this.comboBoxAccentColor.Name = "comboBoxAccentColor";
            this.comboBoxAccentColor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAccentColor.TabIndex = 7;
            this.comboBoxAccentColor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAccentColor_SelectedIndexChanged);
            // 
            // buttonShowDesigner
            // 
            this.buttonShowDesigner.Location = new System.Drawing.Point(120, 76);
            this.buttonShowDesigner.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowDesigner.Name = "buttonShowDesigner";
            this.buttonShowDesigner.Size = new System.Drawing.Size(200, 27);
            this.buttonShowDesigner.TabIndex = 8;
            this.buttonShowDesigner.Text = "Show Designer";
            this.buttonShowDesigner.Click += new System.EventHandler(this.ButtonShowDesigner_Click);
            // 
            // buttonShowViewer
            // 
            this.buttonShowViewer.Location = new System.Drawing.Point(120, 138);
            this.buttonShowViewer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowViewer.Name = "buttonShowViewer";
            this.buttonShowViewer.Size = new System.Drawing.Size(200, 27);
            this.buttonShowViewer.TabIndex = 9;
            this.buttonShowViewer.Text = "Show Viewer";
            this.buttonShowViewer.Click += new System.EventHandler(this.ButtonShowViewer_Click);
            // 
            // buttonShowDesignerForm
            // 
            this.buttonShowDesignerForm.Location = new System.Drawing.Point(120, 107);
            this.buttonShowDesignerForm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowDesignerForm.Name = "buttonShowDesignerForm";
            this.buttonShowDesignerForm.Size = new System.Drawing.Size(200, 27);
            this.buttonShowDesignerForm.TabIndex = 10;
            this.buttonShowDesignerForm.Text = "Show Designer Form";
            this.buttonShowDesignerForm.Click += new System.EventHandler(this.buttonShowDesignerForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.buttonShowDesignerForm);
            this.Controls.Add(this.buttonShowViewer);
            this.Controls.Add(this.buttonShowDesigner);
            this.Controls.Add(this.comboBoxAccentColor);
            this.Controls.Add(this.labelAccentColor);
            this.Controls.Add(this.comboBoxAppearance);
            this.Controls.Add(this.labelAppearance);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changing the Viewer and Designer Theme";
            this.ResumeLayout(false);
            this.PerformLayout();

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

            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Close();
		}

        private void ComboBoxAppearance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInit) return;

            var appearance = StiThemeAppearance.Light;
            switch (comboBoxAppearance.SelectedIndex)
            {
                case 0:
                    appearance = StiThemeAppearance.Auto;
                    break;

                case 1:
                    appearance = StiThemeAppearance.Light;
                    break;

                case 2:
                    appearance = StiThemeAppearance.Dark;
                    break;
            }

            StiUXTheme.ApplyNewTheme(appearance, StiUXTheme.AccentColor);
        }

        private void ComboBoxAccentColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInit) return;

            var accentColor = StiThemeAccentColor.Blue;
            switch (comboBoxAccentColor.SelectedIndex)
            {
                case 0:
                    accentColor = StiThemeAccentColor.Auto;
                    break;

                case 1:
                    accentColor = StiThemeAccentColor.Blue;
                    break;

                case 2:
                    accentColor = StiThemeAccentColor.Violet;
                    break;

                case 3:
                    accentColor = StiThemeAccentColor.Carmine;
                    break;

                case 4:
                    accentColor = StiThemeAccentColor.Teal;
                    break;

                case 5:
                    accentColor = StiThemeAccentColor.Green;
                    break;

                case 6:
                    accentColor = StiThemeAccentColor.Orange;
                    break;
            }

            StiUXTheme.ApplyNewTheme(StiUXTheme.Appearance, accentColor);
        }

        private void ButtonShowDesigner_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Design();
        }

        private void ButtonShowViewer_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.Show();
        }

        private void buttonShowDesignerForm_Click(object sender, EventArgs e)
        {
            var designerForm = new Form2();
            designerForm.ShowDialog();
        }
    }
}
