using Stimulsoft.Controls;

namespace Changing_the_Viewer_and_Designer_Theme
{
    partial class Form2
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
            this.buttonPanel = new Stimulsoft.Controls.StiPanel();
            this.buttonChangeTheme = new System.Windows.Forms.Button();
            this.desigerPanel = new Stimulsoft.Controls.StiPanel();
            this.designerControl = new Stimulsoft.Report.Design.StiRibbonDesignerControl();
            this.buttonPanel.SuspendLayout();
            this.desigerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.AutoSize = true;
            this.buttonPanel.Controls.Add(this.buttonChangeTheme);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(229, 616);
            this.buttonPanel.TabIndex = 1;
            // 
            // buttonChangeTheme
            // 
            this.buttonChangeTheme.Location = new System.Drawing.Point(10, 10);
            this.buttonChangeTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChangeTheme.Name = "buttonChangeTheme";
            this.buttonChangeTheme.Size = new System.Drawing.Size(217, 46);
            this.buttonChangeTheme.TabIndex = 0;
            this.buttonChangeTheme.Text = "Change Theme";
            this.buttonChangeTheme.UseVisualStyleBackColor = false;
            this.buttonChangeTheme.Click += new System.EventHandler(this.ButtonChangeTheme_Click);
            // 
            // desigerPanel
            // 
            this.desigerPanel.Controls.Add(this.designerControl);
            this.desigerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desigerPanel.Location = new System.Drawing.Point(229, 0);
            this.desigerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desigerPanel.Name = "desigerPanel";
            this.desigerPanel.Padding = new System.Windows.Forms.Padding(8, 10, 10, 10);
            this.desigerPanel.Size = new System.Drawing.Size(798, 616);
            this.desigerPanel.TabIndex = 0;
            // 
            // designerControl
            // 
            this.designerControl.AllowDrop = true;
            this.designerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.designerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designerControl.Location = new System.Drawing.Point(8, 10);
            this.designerControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.designerControl.Name = "designerControl";
            this.designerControl.Size = new System.Drawing.Size(780, 596);
            this.designerControl.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 616);
            this.Controls.Add(this.desigerPanel);
            this.Controls.Add(this.buttonPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form2";
            this.Text = "Designer";
            this.buttonPanel.ResumeLayout(false);
            this.desigerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stimulsoft.Controls.StiPanel buttonPanel;
        private Stimulsoft.Controls.StiPanel desigerPanel;
        private System.Windows.Forms.Button buttonChangeTheme;
        private Stimulsoft.Report.Design.StiRibbonDesignerControl designerControl;
    }
}

