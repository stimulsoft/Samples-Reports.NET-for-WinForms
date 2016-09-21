namespace Linq
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
            this.btPreview = new System.Windows.Forms.Button();
            this.btDesign = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPreview
            // 
            this.btPreview.Location = new System.Drawing.Point(35, 35);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(75, 26);
            this.btPreview.TabIndex = 0;
            this.btPreview.Text = "Preview";
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btDesign
            // 
            this.btDesign.Location = new System.Drawing.Point(119, 35);
            this.btDesign.Name = "btDesign";
            this.btDesign.Size = new System.Drawing.Size(75, 26);
            this.btDesign.TabIndex = 0;
            this.btDesign.Text = "Design";
            this.btDesign.UseVisualStyleBackColor = true;
            this.btDesign.Click += new System.EventHandler(this.btDesign_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(203, 35);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 26);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 97);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDesign);
            this.Controls.Add(this.btPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Linq in Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btDesign;
        private System.Windows.Forms.Button btClose;
    }
}

