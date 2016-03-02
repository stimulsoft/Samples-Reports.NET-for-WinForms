namespace Demo
{
    partial class StiWelcomeScreenControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxDisplayWelcomeScreenAgain = new Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX();
            this.buttonSampleProject = new Demo.Controls.StiDemoButton();
            this.buttonForum = new Demo.Controls.StiDemoButton();
            this.buttonSupport = new Demo.Controls.StiDemoButton();
            this.buttonDocumentation = new Demo.Controls.StiDemoButton();
            this.buttonDemo = new Demo.Controls.StiDemoButton();
            this.buttonVideo = new Demo.Controls.StiDemoButton();
            this.SuspendLayout();
            // 
            // checkBoxDisplayWelcomeScreenAgain
            // 
            this.checkBoxDisplayWelcomeScreenAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.checkBoxDisplayWelcomeScreenAgain.BackgroundStyle.Class = "";
            this.checkBoxDisplayWelcomeScreenAgain.BackgroundStyle.CornerType = Stimulsoft.Controls.Win.DotNetBar.eCornerType.Square;
            this.checkBoxDisplayWelcomeScreenAgain.CheckBoxPosition = Stimulsoft.Controls.Win.DotNetBar.eCheckBoxPosition.Right;
            this.checkBoxDisplayWelcomeScreenAgain.Checked = true;
            this.checkBoxDisplayWelcomeScreenAgain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayWelcomeScreenAgain.CheckValue = "Y";
            this.checkBoxDisplayWelcomeScreenAgain.FocusCuesEnabled = false;
            this.checkBoxDisplayWelcomeScreenAgain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDisplayWelcomeScreenAgain.Location = new System.Drawing.Point(545, 524);
            this.checkBoxDisplayWelcomeScreenAgain.Name = "checkBoxDisplayWelcomeScreenAgain";
            this.checkBoxDisplayWelcomeScreenAgain.Size = new System.Drawing.Size(352, 23);
            this.checkBoxDisplayWelcomeScreenAgain.Style = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2010;
            this.checkBoxDisplayWelcomeScreenAgain.TabIndex = 12;
            this.checkBoxDisplayWelcomeScreenAgain.Text = "Display Welcome Screen Again";
            this.checkBoxDisplayWelcomeScreenAgain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(75)))));
            // 
            // buttonSampleProject
            // 
            this.buttonSampleProject.ButtonStyle = 1;
            this.buttonSampleProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSampleProject.Header = "";
            this.buttonSampleProject.Image = global::Demo.Properties.Resources.buttonSampleProject;
            this.buttonSampleProject.Location = new System.Drawing.Point(454, 444);
            this.buttonSampleProject.Name = "buttonSampleProject";
            this.buttonSampleProject.Size = new System.Drawing.Size(445, 68);
            this.buttonSampleProject.TabIndex = 18;
            // 
            // buttonForum
            // 
            this.buttonForum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonForum.Header = "";
            this.buttonForum.Image = global::Demo.Properties.Resources.buttonForum;
            this.buttonForum.Location = new System.Drawing.Point(3, 444);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(445, 68);
            this.buttonForum.TabIndex = 17;
            this.buttonForum.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonSupport
            // 
            this.buttonSupport.ButtonStyle = 1;
            this.buttonSupport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSupport.Header = "";
            this.buttonSupport.Image = global::Demo.Properties.Resources.buttonSupport;
            this.buttonSupport.Location = new System.Drawing.Point(454, 247);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(445, 68);
            this.buttonSupport.TabIndex = 14;
            this.buttonSupport.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonDocumentation
            // 
            this.buttonDocumentation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDocumentation.Header = "";
            this.buttonDocumentation.Image = global::Demo.Properties.Resources.buttonDocumentation;
            this.buttonDocumentation.Location = new System.Drawing.Point(454, 342);
            this.buttonDocumentation.Name = "buttonDocumentation";
            this.buttonDocumentation.Size = new System.Drawing.Size(445, 68);
            this.buttonDocumentation.TabIndex = 16;
            this.buttonDocumentation.Click += new System.EventHandler(this.buttons_Click);
            // 
            // buttonDemo
            // 
            this.buttonDemo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDemo.Header = "";
            this.buttonDemo.Image = global::Demo.Properties.Resources.buttonDemo;
            this.buttonDemo.Location = new System.Drawing.Point(3, 247);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(445, 68);
            this.buttonDemo.TabIndex = 13;
            // 
            // buttonVideo
            // 
            this.buttonVideo.ButtonStyle = 1;
            this.buttonVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonVideo.Header = "";
            this.buttonVideo.Image = global::Demo.Properties.Resources.buttonVideo;
            this.buttonVideo.Location = new System.Drawing.Point(3, 342);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(445, 68);
            this.buttonVideo.TabIndex = 15;
            this.buttonVideo.Click += new System.EventHandler(this.buttons_Click);
            // 
            // StiWelcomeScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxDisplayWelcomeScreenAgain);
            this.Controls.Add(this.buttonSampleProject);
            this.Controls.Add(this.buttonForum);
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.buttonDocumentation);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.buttonVideo);
            this.Name = "StiWelcomeScreenControl";
            this.Size = new System.Drawing.Size(900, 550);
            this.ResumeLayout(false);

        }

        #endregion

        internal Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX checkBoxDisplayWelcomeScreenAgain;
        internal Demo.Controls.StiDemoButton buttonDemo;
        internal Demo.Controls.StiDemoButton buttonSupport;
        internal Demo.Controls.StiDemoButton buttonVideo;
        internal Demo.Controls.StiDemoButton buttonDocumentation;
        internal Demo.Controls.StiDemoButton buttonForum;
        internal Demo.Controls.StiDemoButton buttonSampleProject;
    }
}