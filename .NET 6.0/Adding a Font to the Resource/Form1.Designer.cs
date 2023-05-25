namespace Adding_a_Font_to_the_Resource
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonDesign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(172, 89);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(183, 28);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show Report";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonDesign
            // 
            this.buttonDesign.Location = new System.Drawing.Point(172, 122);
            this.buttonDesign.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDesign.Name = "buttonDesign";
            this.buttonDesign.Size = new System.Drawing.Size(183, 28);
            this.buttonDesign.TabIndex = 1;
            this.buttonDesign.Text = "Design Report";
            this.buttonDesign.UseVisualStyleBackColor = true;
            this.buttonDesign.Click += new System.EventHandler(this.buttonDesign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 248);
            this.Controls.Add(this.buttonDesign);
            this.Controls.Add(this.buttonShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding a Font to the Resource";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonDesign;
    }
}

