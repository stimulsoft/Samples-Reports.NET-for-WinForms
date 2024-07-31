namespace Demo
{
    partial class StiDemoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StiDemoForm));
            this.dataSet1 = new System.Data.DataSet();
            this.ilReports = new System.Windows.Forms.ImageList(this.components);
            this.border = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvReports = new Stimulsoft.Controls.StiTreeView();
            this.separator2 = new System.Windows.Forms.Panel();
            this.separator1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewerControl = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.stiUserData1 = new Stimulsoft.Report.Dictionary.StiUserData();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("ru-RU");
            // 
            // ilReports
            // 
            this.ilReports.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilReports.ImageStream")));
            this.ilReports.TransparentColor = System.Drawing.Color.Magenta;
            this.ilReports.Images.SetKeyName(0, "browserCategory.png");
            this.ilReports.Images.SetKeyName(1, "browserReport.png");
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.border.Dock = System.Windows.Forms.DockStyle.Right;
            this.border.ForeColor = System.Drawing.Color.White;
            this.border.Location = new System.Drawing.Point(304, 0);
            this.border.Margin = new System.Windows.Forms.Padding(2);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(4, 525);
            this.border.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point(0, 480);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(304, 16);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Image = global::Demo.Properties.Resources.Hyperlink;
            this.linkLabel1.Location = new System.Drawing.Point(0, 497);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(304, 28);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tvReports);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.separator2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.separator1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.border);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 525);
            this.panel1.TabIndex = 29;
            // 
            // tvReports
            // 
            this.tvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvReports.BackColor = System.Drawing.Color.White;
            this.tvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvReports.HideSelection = false;
            this.tvReports.ImageIndex = 0;
            this.tvReports.ImageList = this.ilReports;
            this.tvReports.Location = new System.Drawing.Point(0, 87);
            this.tvReports.Margin = new System.Windows.Forms.Padding(2);
            this.tvReports.Name = "tvReports";
            this.tvReports.SelectedImageIndex = 0;
            this.tvReports.Size = new System.Drawing.Size(298, 393);
            this.tvReports.TabIndex = 0;
            this.tvReports.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReports_AfterSelect);
            this.tvReports.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvReports_KeyDown);
            // 
            // separator2
            // 
            this.separator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separator2.Location = new System.Drawing.Point(0, 496);
            this.separator2.Margin = new System.Windows.Forms.Padding(2);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(304, 1);
            this.separator2.TabIndex = 30;
            this.separator2.Paint += new System.Windows.Forms.PaintEventHandler(this.separator1_Paint);
            // 
            // separator1
            // 
            this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator1.Location = new System.Drawing.Point(0, 82);
            this.separator1.Margin = new System.Windows.Forms.Padding(2);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(304, 1);
            this.separator1.TabIndex = 29;
            this.separator1.Paint += new System.Windows.Forms.PaintEventHandler(this.separator1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Demo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // viewerControl
            // 
            this.viewerControl.AllowDrop = true;
            this.viewerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerControl.Location = new System.Drawing.Point(308, 1);
            this.viewerControl.Name = "viewerControl";
            this.viewerControl.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.viewerControl.Report = null;
            this.viewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewerControl.ShowZoom = true;
            this.viewerControl.Size = new System.Drawing.Size(639, 518);
            this.viewerControl.TabIndex = 31;
            // 
            // stiUserData1
            // 
            this.stiUserData1.Count = 10;
            this.stiUserData1.GetData += new Stimulsoft.Report.Dictionary.StiUserGetDataEventHandler(this.stiUserData1_GetData);
            // 
            // StiDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 525);
            this.Controls.Add(this.viewerControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(967, 564);
            this.Name = "StiDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private Stimulsoft.Controls.StiTreeView tvReports;
        private Stimulsoft.Report.Dictionary.StiUserData stiUserData1;
        private System.Windows.Forms.ImageList ilReports;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel separator1;
        private System.Windows.Forms.Panel separator2;
        private Stimulsoft.Report.Viewer.StiViewerControl viewerControl;
    }
}