namespace Connecting_to_Data_from_Code
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
            this.buttonXml = new System.Windows.Forms.Button();
            this.buttonJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonXml
            // 
            this.buttonXml.Location = new System.Drawing.Point(320, 190);
            this.buttonXml.Name = "buttonXml";
            this.buttonXml.Size = new System.Drawing.Size(340, 60);
            this.buttonXml.TabIndex = 0;
            this.buttonXml.Text = "Register XML Data";
            this.buttonXml.UseVisualStyleBackColor = true;
            this.buttonXml.Click += new System.EventHandler(this.buttonXml_Click);
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(320, 260);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(340, 60);
            this.buttonJson.TabIndex = 1;
            this.buttonJson.Text = "Register JSON Data";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.buttonXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecting to Data from Code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXml;
        private System.Windows.Forms.Button buttonJson;
    }
}

