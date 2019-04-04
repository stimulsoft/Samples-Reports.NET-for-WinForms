namespace Asynchronous_Render_and_Export
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRender = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelLoad = new System.Windows.Forms.Label();
            this.labelRender = new System.Windows.Forms.Label();
            this.labelExport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRender
            // 
            this.buttonRender.Location = new System.Drawing.Point(12, 12);
            this.buttonRender.Name = "buttonRender";
            this.buttonRender.Size = new System.Drawing.Size(150, 40);
            this.buttonRender.TabIndex = 9;
            this.buttonRender.Text = "Async Render";
            this.buttonRender.Click += new System.EventHandler(this.buttonRender_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(167, 12);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(150, 40);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Text = "Async Export";
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(12, 92);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(63, 13);
            this.labelLoad.TabIndex = 11;
            this.labelLoad.Text = "Not Loaded";
            // 
            // labelRender
            // 
            this.labelRender.AutoSize = true;
            this.labelRender.Location = new System.Drawing.Point(12, 116);
            this.labelRender.Name = "labelRender";
            this.labelRender.Size = new System.Drawing.Size(74, 13);
            this.labelRender.TabIndex = 12;
            this.labelRender.Text = "Not Rendered";
            // 
            // labelExport
            // 
            this.labelExport.AutoSize = true;
            this.labelExport.Location = new System.Drawing.Point(12, 140);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(69, 13);
            this.labelExport.TabIndex = 13;
            this.labelExport.Text = "Not Exported";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 196);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.labelRender);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async Render and Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRender;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Label labelRender;
        private System.Windows.Forms.Label labelExport;
    }
}

