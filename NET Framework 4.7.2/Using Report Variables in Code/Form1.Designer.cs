using Stimulsoft.Controls;
using System.Windows.Forms;

namespace Using_Report_Variables_in_Code
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftPanel = new Stimulsoft.Controls.StiPanel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDesign = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.labelSex = new Stimulsoft.Controls.StiLabel();
            this.textBoxAddress = new Stimulsoft.Controls.StiTextBox();
            this.labelAddress = new Stimulsoft.Controls.StiLabel();
            this.dateTimePickerBirthday = new Stimulsoft.Controls.StiDateTimePicker();
            this.labelBirthday = new Stimulsoft.Controls.StiLabel();
            this.textBoxEmail = new Stimulsoft.Controls.StiTextBox();
            this.labelEmail = new Stimulsoft.Controls.StiLabel();
            this.textBoxSurname = new Stimulsoft.Controls.StiTextBox();
            this.labelSurname = new Stimulsoft.Controls.StiLabel();
            this.textBoxName = new Stimulsoft.Controls.StiTextBox();
            this.labelName = new Stimulsoft.Controls.StiLabel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.rightPanel = new Stimulsoft.Controls.StiPanel();
            this.viewerControl = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerBirthday)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.AutoSize = true;
            this.leftPanel.Controls.Add(this.buttonShow);
            this.leftPanel.Controls.Add(this.buttonDesign);
            this.leftPanel.Controls.Add(this.rbMale);
            this.leftPanel.Controls.Add(this.rbFemale);
            this.leftPanel.Controls.Add(this.labelSex);
            this.leftPanel.Controls.Add(this.textBoxAddress);
            this.leftPanel.Controls.Add(this.labelAddress);
            this.leftPanel.Controls.Add(this.dateTimePickerBirthday);
            this.leftPanel.Controls.Add(this.labelBirthday);
            this.leftPanel.Controls.Add(this.textBoxEmail);
            this.leftPanel.Controls.Add(this.labelEmail);
            this.leftPanel.Controls.Add(this.textBoxSurname);
            this.leftPanel.Controls.Add(this.labelSurname);
            this.leftPanel.Controls.Add(this.textBoxName);
            this.leftPanel.Controls.Add(this.labelName);
            this.leftPanel.Controls.Add(this.buttonSubmit);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(328, 606);
            this.leftPanel.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShow.Location = new System.Drawing.Point(11, 530);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonShow.Size = new System.Drawing.Size(313, 28);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Show Report in Dialog Window";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDesign
            // 
            this.buttonDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDesign.Location = new System.Drawing.Point(11, 567);
            this.buttonDesign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDesign.Name = "buttonDesign";
            this.buttonDesign.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonDesign.Size = new System.Drawing.Size(313, 28);
            this.buttonDesign.TabIndex = 8;
            this.buttonDesign.Text = "Design Report in Dialog Window";
            this.buttonDesign.UseVisualStyleBackColor = true;
            this.buttonDesign.Click += new System.EventHandler(this.buttonDesign_Click);
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(93, 142);
            this.rbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 23);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(149, 142);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(104, 23);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.Text = "Female";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(8, 147);
            this.labelSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(25, 13);
            this.labelSex.TabIndex = 7;
            this.labelSex.Text = "Sex";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(93, 110);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(233, 24);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.Text = "Address";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(8, 115);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(93, 175);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(233, 24);
            this.dateTimePickerBirthday.TabIndex = 7;
            this.dateTimePickerBirthday.Value = new System.DateTime(2025, 7, 28, 16, 37, 24, 531);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(8, 179);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(45, 13);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Birthday";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(93, 78);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(233, 24);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "johndoe@mail.com";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(8, 83);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(93, 46);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(233, 24);
            this.textBoxSurname.TabIndex = 2;
            this.textBoxSurname.Text = "Doe";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(8, 51);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 14);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 24);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "John";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 19);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(228, 213);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonSubmit.Size = new System.Drawing.Size(98, 28);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.viewerControl);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(328, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(8, 10, 10, 10);
            this.rightPanel.Size = new System.Drawing.Size(688, 606);
            this.rightPanel.TabIndex = 0;
            // 
            // viewerControl
            // 
            this.viewerControl.AllowDrop = true;
            this.viewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerControl.Location = new System.Drawing.Point(8, 10);
            this.viewerControl.Margin = new System.Windows.Forms.Padding(2);
            this.viewerControl.Name = "viewerControl";
            this.viewerControl.Report = null;
            this.viewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewerControl.ShowZoom = true;
            this.viewerControl.Size = new System.Drawing.Size(670, 586);
            this.viewerControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 606);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Report Variables in Code";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerBirthday)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stimulsoft.Report.Viewer.StiViewerControl viewerControl;
        private System.Windows.Forms.Button buttonSubmit;
        private Stimulsoft.Controls.StiLabel labelName;
        private Stimulsoft.Controls.StiTextBox textBoxName;
        private Stimulsoft.Controls.StiLabel labelSurname;
        private Stimulsoft.Controls.StiTextBox textBoxSurname;
        private Stimulsoft.Controls.StiLabel labelEmail;
        private Stimulsoft.Controls.StiTextBox textBoxEmail;
        private Stimulsoft.Controls.StiLabel labelBirthday;
        private StiDateTimePicker dateTimePickerBirthday;
        private Stimulsoft.Controls.StiPanel leftPanel;
        private Stimulsoft.Controls.StiPanel rightPanel;
        private StiTextBox textBoxAddress;
        private StiLabel labelAddress;
        private StiLabel labelSex;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button buttonDesign;
        private Button buttonShow;
    }
}

