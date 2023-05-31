namespace Localizing_the_User_Interface
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
            this.buttonDesign = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLocalizations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDesign
            // 
            this.buttonDesign.Location = new System.Drawing.Point(330, 320);
            this.buttonDesign.Name = "buttonDesign";
            this.buttonDesign.Size = new System.Drawing.Size(320, 60);
            this.buttonDesign.TabIndex = 2;
            this.buttonDesign.Text = "Design Report";
            this.buttonDesign.UseVisualStyleBackColor = true;
            this.buttonDesign.Click += new System.EventHandler(this.ButtonDesign_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(330, 250);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(320, 60);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show Report";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface Localization:";
            // 
            // comboBoxLocalizations
            // 
            this.comboBoxLocalizations.FormattingEnabled = true;
            this.comboBoxLocalizations.Location = new System.Drawing.Point(330, 169);
            this.comboBoxLocalizations.Name = "comboBoxLocalizations";
            this.comboBoxLocalizations.Size = new System.Drawing.Size(320, 40);
            this.comboBoxLocalizations.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.comboBoxLocalizations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonDesign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizing the User Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDesign;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLocalizations;
    }
}

