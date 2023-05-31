namespace Showing_a_Report_in_the_Viewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonControl = new System.Windows.Forms.Button();
            this.buttonDialog = new System.Windows.Forms.Button();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.SuspendLayout();
            // 
            // buttonControl
            // 
            this.buttonControl.Location = new System.Drawing.Point(14, 13);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(380, 60);
            this.buttonControl.TabIndex = 0;
            this.buttonControl.Text = "Show the Report in Control";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // buttonDialog
            // 
            this.buttonDialog.Location = new System.Drawing.Point(409, 13);
            this.buttonDialog.Name = "buttonDialog";
            this.buttonDialog.Size = new System.Drawing.Size(485, 60);
            this.buttonDialog.TabIndex = 1;
            this.buttonDialog.Text = "Show the Report in a Dialog Window";
            this.buttonDialog.UseVisualStyleBackColor = true;
            this.buttonDialog.Click += new System.EventHandler(this.buttonDialog_Click);
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stiViewerControl1.Location = new System.Drawing.Point(15, 89);
            this.stiViewerControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(1544, 824);
            this.stiViewerControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.buttonDialog);
            this.Controls.Add(this.buttonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Showing a Report in the Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.Viewer.StiRibbonViewerControl stiRibbonViewerControl1;
        private System.Windows.Forms.Button buttonControl;
        private System.Windows.Forms.Button buttonDialog;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}

