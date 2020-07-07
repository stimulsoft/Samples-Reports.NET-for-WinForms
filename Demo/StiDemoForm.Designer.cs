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
            this.buttonHiddenPreview = new System.Windows.Forms.Button();
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
            this.border.Location = new System.Drawing.Point(608, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(8, 1000);
            this.border.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point(0, 915);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(608, 30);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Image = global::Demo.Properties.Resources.Hyperlink;
            this.linkLabel1.Location = new System.Drawing.Point(0, 947);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(608, 53);
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
            this.panel1.Controls.Add(this.buttonHiddenPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 1000);
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
            this.tvReports.Location = new System.Drawing.Point(0, 168);
            this.tvReports.Name = "tvReports";
            this.tvReports.SelectedImageIndex = 0;
            this.tvReports.Size = new System.Drawing.Size(596, 747);
            this.tvReports.TabIndex = 0;
            this.tvReports.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReports_AfterSelect);
            this.tvReports.DoubleClick += new System.EventHandler(this.btPreview_Click);
            this.tvReports.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvReports_KeyDown);
            // 
            // separator2
            // 
            this.separator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separator2.Location = new System.Drawing.Point(0, 945);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(608, 2);
            this.separator2.TabIndex = 30;
            this.separator2.Paint += new System.Windows.Forms.PaintEventHandler(this.separator1_Paint);
            // 
            // separator1
            // 
            this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator1.Location = new System.Drawing.Point(0, 157);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(608, 2);
            this.separator1.TabIndex = 29;
            this.separator1.Paint += new System.Windows.Forms.PaintEventHandler(this.separator1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Demo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // buttonHiddenPreview
            // 
            this.buttonHiddenPreview.Location = new System.Drawing.Point(134, 469);
            this.buttonHiddenPreview.Name = "buttonHiddenPreview";
            this.buttonHiddenPreview.Size = new System.Drawing.Size(2, 2);
            this.buttonHiddenPreview.TabIndex = 31;
            this.buttonHiddenPreview.Text = "button1";
            this.buttonHiddenPreview.UseVisualStyleBackColor = true;
            this.buttonHiddenPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // viewerControl
            // 
            this.viewerControl.AllowDrop = true;
            this.viewerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerControl.Location = new System.Drawing.Point(616, 2);
            this.viewerControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewerControl.Name = "viewerControl";
            this.viewerControl.Report = null;
            this.viewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewerControl.ShowZoom = true;
            this.viewerControl.Size = new System.Drawing.Size(1278, 997);
            this.viewerControl.TabIndex = 31;
            // 
            // stiUserData1
            // 
            this.stiUserData1.Count = 10;
            this.stiUserData1.GetData += new Stimulsoft.Report.Dictionary.StiUserGetDataEventHandler(this.stiUserData1_GetData);
            // 
            // StiDemoForm
            // 
            this.AcceptButton = this.buttonHiddenPreview;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1894, 1000);
            this.Controls.Add(this.viewerControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1920, 1071);
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
        private System.Windows.Forms.Button buttonHiddenPreview;
        private Stimulsoft.Report.Viewer.StiViewerControl viewerControl;
    }
}