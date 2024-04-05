using System;
using System.Windows.Forms;

namespace Customizing_the_Viewer
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private Stimulsoft.Report.Viewer.StiViewerControl PreviewControl;
		private Stimulsoft.Report.StiReport Report;
		private System.Windows.Forms.CheckBox cbThumbs;
		private System.Windows.Forms.CheckBox cbBookmarks;
		private System.Windows.Forms.GroupBox gbSettings;
		private System.Windows.Forms.CheckBox cbToolbar;
		private System.Windows.Forms.CheckBox cbVerScrollBar;
		private System.Windows.Forms.CheckBox cbHorScrollBar;
		private System.Windows.Forms.CheckBox cbStatusBar;
		private System.Windows.Forms.CheckBox cbCloseButton;
		private System.Windows.Forms.CheckBox cbContextMenu;
		private System.Windows.Forms.CheckBox cbPrint;
		private System.Windows.Forms.CheckBox cbOpen;
        private System.Windows.Forms.CheckBox cbSave;
		private System.Windows.Forms.CheckBox cbPageNew;
		private System.Windows.Forms.CheckBox cbPageDelete;
		private System.Windows.Forms.CheckBox cbPageDesign;
		private System.Windows.Forms.CheckBox cbBookmarksButton;
		private System.Windows.Forms.CheckBox cbThumbsButton;
		private System.Windows.Forms.CheckBox cbToolEditor;
		private System.Windows.Forms.CheckBox cbToolFind;
		private System.Windows.Forms.CheckBox cbZoom;
		private System.Windows.Forms.CheckBox cbPageControl;
		private System.Windows.Forms.GroupBox gbZoom;
		private System.Windows.Forms.ImageList ilZoom;
        private Button tbOnePage;
        private Button tbTwoPages;
		private Button tbNormal;
		private Button tbPageWidth;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ImageList ilPageControl;
		private Button tbFirstPage;
		private Button tbLastPage;
		private Button tbNextPage;
		private Button tbPreviousPage;
		private System.Windows.Forms.Button btRefresh;
		private System.Windows.Forms.CheckBox cbSendByEMail;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PreviewControl = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.Report = new Stimulsoft.Report.StiReport();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLastPage = new System.Windows.Forms.Button();
            this.ilPageControl = new System.Windows.Forms.ImageList(this.components);
            this.tbNextPage = new System.Windows.Forms.Button();
            this.tbPreviousPage = new System.Windows.Forms.Button();
            this.tbFirstPage = new System.Windows.Forms.Button();
            this.gbZoom = new System.Windows.Forms.GroupBox();
            this.tbPageWidth = new System.Windows.Forms.Button();
            this.ilZoom = new System.Windows.Forms.ImageList(this.components);
            this.tbNormal = new System.Windows.Forms.Button();
            this.tbTwoPages = new System.Windows.Forms.Button();
            this.tbOnePage = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbThumbs = new System.Windows.Forms.CheckBox();
            this.cbBookmarks = new System.Windows.Forms.CheckBox();
            this.cbToolbar = new System.Windows.Forms.CheckBox();
            this.cbVerScrollBar = new System.Windows.Forms.CheckBox();
            this.cbHorScrollBar = new System.Windows.Forms.CheckBox();
            this.cbStatusBar = new System.Windows.Forms.CheckBox();
            this.cbCloseButton = new System.Windows.Forms.CheckBox();
            this.cbContextMenu = new System.Windows.Forms.CheckBox();
            this.cbPrint = new System.Windows.Forms.CheckBox();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.cbPageNew = new System.Windows.Forms.CheckBox();
            this.cbPageDelete = new System.Windows.Forms.CheckBox();
            this.cbPageDesign = new System.Windows.Forms.CheckBox();
            this.cbBookmarksButton = new System.Windows.Forms.CheckBox();
            this.cbThumbsButton = new System.Windows.Forms.CheckBox();
            this.cbToolEditor = new System.Windows.Forms.CheckBox();
            this.cbToolFind = new System.Windows.Forms.CheckBox();
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.cbPageControl = new System.Windows.Forms.CheckBox();
            this.cbSendByEMail = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbZoom.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewControl
            // 
            this.PreviewControl.AllowDrop = true;
            this.PreviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewControl.Location = new System.Drawing.Point(228, 0);
            this.PreviewControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PreviewControl.Name = "PreviewControl";
            this.PreviewControl.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.PreviewControl.Report = this.Report;
            this.PreviewControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreviewControl.ShowZoom = true;
            this.PreviewControl.Size = new System.Drawing.Size(1252, 849);
            this.PreviewControl.TabIndex = 0;
            this.PreviewControl.Close += new System.EventHandler(this.PreviewControl_Close);
            // 
            // Report
            // 
            this.Report.CookieContainer = null;
            this.Report.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Report.HttpHeadersContainer = null;
            this.Report.Key = "fad8611e45e64305930541721c02a040";
            this.Report.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Report.ReportAlias = "Report";
            this.Report.ReportGuid = "0becb2e85c404caba26de24eb21c4933";
            this.Report.ReportName = "Report";
            this.Report.ReportSource = null;
            this.Report.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Report.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Report.UseProgressInThread = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbZoom);
            this.panel1.Controls.Add(this.gbSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 849);
            this.panel1.TabIndex = 2;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(24, 945);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(180, 34);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLastPage);
            this.groupBox1.Controls.Add(this.tbNextPage);
            this.groupBox1.Controls.Add(this.tbPreviousPage);
            this.groupBox1.Controls.Add(this.tbFirstPage);
            this.groupBox1.Location = new System.Drawing.Point(12, 737);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Page Control";
            // 
            // tbLastPage
            // 
            this.tbLastPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLastPage.ImageIndex = 3;
            this.tbLastPage.ImageList = this.ilPageControl;
            this.tbLastPage.Location = new System.Drawing.Point(12, 129);
            this.tbLastPage.Name = "tbLastPage";
            this.tbLastPage.Size = new System.Drawing.Size(180, 32);
            this.tbLastPage.TabIndex = 3;
            this.tbLastPage.Text = "Last Page";
            this.tbLastPage.UseVisualStyleBackColor = false;
            this.tbLastPage.Click += new System.EventHandler(this.tbLastPage_Click);
            // 
            // ilPageControl
            // 
            this.ilPageControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPageControl.ImageStream")));
            this.ilPageControl.TransparentColor = System.Drawing.Color.Magenta;
            this.ilPageControl.Images.SetKeyName(0, "");
            this.ilPageControl.Images.SetKeyName(1, "");
            this.ilPageControl.Images.SetKeyName(2, "");
            this.ilPageControl.Images.SetKeyName(3, "");
            // 
            // tbNextPage
            // 
            this.tbNextPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbNextPage.ImageIndex = 2;
            this.tbNextPage.ImageList = this.ilPageControl;
            this.tbNextPage.Location = new System.Drawing.Point(12, 94);
            this.tbNextPage.Name = "tbNextPage";
            this.tbNextPage.Size = new System.Drawing.Size(180, 32);
            this.tbNextPage.TabIndex = 2;
            this.tbNextPage.Text = "Next Page";
            this.tbNextPage.UseVisualStyleBackColor = false;
            this.tbNextPage.Click += new System.EventHandler(this.tbNextPage_Click);
            // 
            // tbPreviousPage
            // 
            this.tbPreviousPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPreviousPage.ImageIndex = 1;
            this.tbPreviousPage.ImageList = this.ilPageControl;
            this.tbPreviousPage.Location = new System.Drawing.Point(12, 58);
            this.tbPreviousPage.Name = "tbPreviousPage";
            this.tbPreviousPage.Size = new System.Drawing.Size(180, 32);
            this.tbPreviousPage.TabIndex = 1;
            this.tbPreviousPage.Text = "Previous Page";
            this.tbPreviousPage.UseVisualStyleBackColor = false;
            this.tbPreviousPage.Click += new System.EventHandler(this.tbPreviousPage_Click);
            // 
            // tbFirstPage
            // 
            this.tbFirstPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFirstPage.ImageIndex = 0;
            this.tbFirstPage.ImageList = this.ilPageControl;
            this.tbFirstPage.Location = new System.Drawing.Point(12, 25);
            this.tbFirstPage.Name = "tbFirstPage";
            this.tbFirstPage.Size = new System.Drawing.Size(180, 32);
            this.tbFirstPage.TabIndex = 0;
            this.tbFirstPage.Text = "First Page";
            this.tbFirstPage.UseVisualStyleBackColor = false;
            this.tbFirstPage.Click += new System.EventHandler(this.tbFirstPage_Click);
            // 
            // gbZoom
            // 
            this.gbZoom.Controls.Add(this.tbPageWidth);
            this.gbZoom.Controls.Add(this.tbNormal);
            this.gbZoom.Controls.Add(this.tbTwoPages);
            this.gbZoom.Controls.Add(this.tbOnePage);
            this.gbZoom.Location = new System.Drawing.Point(12, 551);
            this.gbZoom.Name = "gbZoom";
            this.gbZoom.Size = new System.Drawing.Size(204, 177);
            this.gbZoom.TabIndex = 1;
            this.gbZoom.TabStop = false;
            this.gbZoom.Text = "Zoom";
            // 
            // tbPageWidth
            // 
            this.tbPageWidth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPageWidth.ImageIndex = 4;
            this.tbPageWidth.ImageList = this.ilZoom;
            this.tbPageWidth.Location = new System.Drawing.Point(12, 129);
            this.tbPageWidth.Name = "tbPageWidth";
            this.tbPageWidth.Size = new System.Drawing.Size(180, 32);
            this.tbPageWidth.TabIndex = 4;
            this.tbPageWidth.Text = "Page Width";
            this.tbPageWidth.UseVisualStyleBackColor = false;
            this.tbPageWidth.Click += new System.EventHandler(this.tbPageWidth_Click);
            // 
            // ilZoom
            // 
            this.ilZoom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilZoom.ImageStream")));
            this.ilZoom.TransparentColor = System.Drawing.Color.Magenta;
            this.ilZoom.Images.SetKeyName(0, "");
            this.ilZoom.Images.SetKeyName(1, "");
            this.ilZoom.Images.SetKeyName(2, "");
            this.ilZoom.Images.SetKeyName(3, "");
            this.ilZoom.Images.SetKeyName(4, "");
            // 
            // tbNormal
            // 
            this.tbNormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbNormal.ImageIndex = 3;
            this.tbNormal.ImageList = this.ilZoom;
            this.tbNormal.Location = new System.Drawing.Point(12, 94);
            this.tbNormal.Name = "tbNormal";
            this.tbNormal.Size = new System.Drawing.Size(180, 32);
            this.tbNormal.TabIndex = 3;
            this.tbNormal.Text = "Normal";
            this.tbNormal.UseVisualStyleBackColor = false;
            this.tbNormal.Click += new System.EventHandler(this.tbNormal_Click);
            // 
            // tbTwoPages
            // 
            this.tbTwoPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTwoPages.ImageIndex = 1;
            this.tbTwoPages.ImageList = this.ilZoom;
            this.tbTwoPages.Location = new System.Drawing.Point(12, 58);
            this.tbTwoPages.Name = "tbTwoPages";
            this.tbTwoPages.Size = new System.Drawing.Size(180, 32);
            this.tbTwoPages.TabIndex = 1;
            this.tbTwoPages.Text = "Two Pages";
            this.tbTwoPages.UseVisualStyleBackColor = false;
            this.tbTwoPages.Click += new System.EventHandler(this.tbTwoPages_Click);
            // 
            // tbOnePage
            // 
            this.tbOnePage.ForeColor = System.Drawing.Color.Black;
            this.tbOnePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOnePage.ImageIndex = 0;
            this.tbOnePage.ImageList = this.ilZoom;
            this.tbOnePage.Location = new System.Drawing.Point(12, 25);
            this.tbOnePage.Name = "tbOnePage";
            this.tbOnePage.Size = new System.Drawing.Size(180, 32);
            this.tbOnePage.TabIndex = 0;
            this.tbOnePage.Text = "One Page";
            this.tbOnePage.Click += new System.EventHandler(this.tbOnePage_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbThumbs);
            this.gbSettings.Controls.Add(this.cbBookmarks);
            this.gbSettings.Controls.Add(this.cbToolbar);
            this.gbSettings.Controls.Add(this.cbVerScrollBar);
            this.gbSettings.Controls.Add(this.cbHorScrollBar);
            this.gbSettings.Controls.Add(this.cbStatusBar);
            this.gbSettings.Controls.Add(this.cbCloseButton);
            this.gbSettings.Controls.Add(this.cbContextMenu);
            this.gbSettings.Controls.Add(this.cbPrint);
            this.gbSettings.Controls.Add(this.cbOpen);
            this.gbSettings.Controls.Add(this.cbSave);
            this.gbSettings.Controls.Add(this.cbPageNew);
            this.gbSettings.Controls.Add(this.cbPageDelete);
            this.gbSettings.Controls.Add(this.cbPageDesign);
            this.gbSettings.Controls.Add(this.cbBookmarksButton);
            this.gbSettings.Controls.Add(this.cbThumbsButton);
            this.gbSettings.Controls.Add(this.cbToolEditor);
            this.gbSettings.Controls.Add(this.cbToolFind);
            this.gbSettings.Controls.Add(this.cbZoom);
            this.gbSettings.Controls.Add(this.cbPageControl);
            this.gbSettings.Controls.Add(this.cbSendByEMail);
            this.gbSettings.Location = new System.Drawing.Point(12, 0);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(204, 543);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // cbThumbs
            // 
            this.cbThumbs.Checked = true;
            this.cbThumbs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThumbs.Location = new System.Drawing.Point(12, 48);
            this.cbThumbs.Name = "cbThumbs";
            this.cbThumbs.Size = new System.Drawing.Size(156, 25);
            this.cbThumbs.TabIndex = 1;
            this.cbThumbs.Text = "Thumbs";
            this.cbThumbs.CheckedChanged += new System.EventHandler(this.cbThumbs_CheckedChanged);
            // 
            // cbBookmarks
            // 
            this.cbBookmarks.Checked = true;
            this.cbBookmarks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBookmarks.Location = new System.Drawing.Point(12, 25);
            this.cbBookmarks.Name = "cbBookmarks";
            this.cbBookmarks.Size = new System.Drawing.Size(156, 23);
            this.cbBookmarks.TabIndex = 0;
            this.cbBookmarks.Text = "Bookmarks";
            this.cbBookmarks.CheckedChanged += new System.EventHandler(this.cbBookmarks_CheckedChanged);
            // 
            // cbToolbar
            // 
            this.cbToolbar.Checked = true;
            this.cbToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToolbar.Location = new System.Drawing.Point(12, 71);
            this.cbToolbar.Name = "cbToolbar";
            this.cbToolbar.Size = new System.Drawing.Size(156, 23);
            this.cbToolbar.TabIndex = 2;
            this.cbToolbar.Text = "Toolbar";
            this.cbToolbar.CheckedChanged += new System.EventHandler(this.cbToolbar_CheckedChanged);
            // 
            // cbVerScrollBar
            // 
            this.cbVerScrollBar.Checked = true;
            this.cbVerScrollBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVerScrollBar.Location = new System.Drawing.Point(12, 94);
            this.cbVerScrollBar.Name = "cbVerScrollBar";
            this.cbVerScrollBar.Size = new System.Drawing.Size(156, 25);
            this.cbVerScrollBar.TabIndex = 3;
            this.cbVerScrollBar.Text = "Ver ScrollBar";
            this.cbVerScrollBar.CheckedChanged += new System.EventHandler(this.cbVerScrollBar_CheckedChanged);
            // 
            // cbHorScrollBar
            // 
            this.cbHorScrollBar.Checked = true;
            this.cbHorScrollBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHorScrollBar.Location = new System.Drawing.Point(12, 118);
            this.cbHorScrollBar.Name = "cbHorScrollBar";
            this.cbHorScrollBar.Size = new System.Drawing.Size(156, 23);
            this.cbHorScrollBar.TabIndex = 4;
            this.cbHorScrollBar.Text = "Hor ScrollBar";
            this.cbHorScrollBar.CheckedChanged += new System.EventHandler(this.cbHorScrollBar_CheckedChanged);
            // 
            // cbStatusBar
            // 
            this.cbStatusBar.Checked = true;
            this.cbStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatusBar.Location = new System.Drawing.Point(12, 142);
            this.cbStatusBar.Name = "cbStatusBar";
            this.cbStatusBar.Size = new System.Drawing.Size(156, 25);
            this.cbStatusBar.TabIndex = 5;
            this.cbStatusBar.Text = "Status Bar";
            this.cbStatusBar.CheckedChanged += new System.EventHandler(this.cbStatusBar_CheckedChanged);
            // 
            // cbCloseButton
            // 
            this.cbCloseButton.Checked = true;
            this.cbCloseButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCloseButton.Location = new System.Drawing.Point(12, 511);
            this.cbCloseButton.Name = "cbCloseButton";
            this.cbCloseButton.Size = new System.Drawing.Size(156, 23);
            this.cbCloseButton.TabIndex = 22;
            this.cbCloseButton.Text = "Close Button";
            this.cbCloseButton.CheckedChanged += new System.EventHandler(this.cbCloseButton_CheckedChanged);
            // 
            // cbContextMenu
            // 
            this.cbContextMenu.Checked = true;
            this.cbContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextMenu.Location = new System.Drawing.Point(12, 166);
            this.cbContextMenu.Name = "cbContextMenu";
            this.cbContextMenu.Size = new System.Drawing.Size(156, 23);
            this.cbContextMenu.TabIndex = 6;
            this.cbContextMenu.Text = "Context Menu";
            this.cbContextMenu.CheckedChanged += new System.EventHandler(this.cbContextMenu_CheckedChanged);
            // 
            // cbPrint
            // 
            this.cbPrint.Checked = true;
            this.cbPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrint.Location = new System.Drawing.Point(12, 202);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.Size = new System.Drawing.Size(156, 25);
            this.cbPrint.TabIndex = 7;
            this.cbPrint.Text = "Print";
            this.cbPrint.CheckedChanged += new System.EventHandler(this.cbPrint_CheckedChanged);
            // 
            // cbOpen
            // 
            this.cbOpen.Checked = true;
            this.cbOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpen.Location = new System.Drawing.Point(12, 225);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(156, 23);
            this.cbOpen.TabIndex = 8;
            this.cbOpen.Text = "Open";
            this.cbOpen.CheckedChanged += new System.EventHandler(this.cbOpen_CheckedChanged);
            // 
            // cbSave
            // 
            this.cbSave.Checked = true;
            this.cbSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSave.Location = new System.Drawing.Point(12, 248);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(156, 25);
            this.cbSave.TabIndex = 9;
            this.cbSave.Text = "Save";
            this.cbSave.CheckedChanged += new System.EventHandler(this.cbSave_CheckedChanged);
            // 
            // cbPageNew
            // 
            this.cbPageNew.Checked = true;
            this.cbPageNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPageNew.Location = new System.Drawing.Point(12, 297);
            this.cbPageNew.Name = "cbPageNew";
            this.cbPageNew.Size = new System.Drawing.Size(156, 25);
            this.cbPageNew.TabIndex = 11;
            this.cbPageNew.Text = "Page New";
            this.cbPageNew.CheckedChanged += new System.EventHandler(this.cbPageNew_CheckedChanged);
            // 
            // cbPageDelete
            // 
            this.cbPageDelete.Checked = true;
            this.cbPageDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPageDelete.Location = new System.Drawing.Point(12, 322);
            this.cbPageDelete.Name = "cbPageDelete";
            this.cbPageDelete.Size = new System.Drawing.Size(156, 23);
            this.cbPageDelete.TabIndex = 12;
            this.cbPageDelete.Text = "Page Delete";
            this.cbPageDelete.CheckedChanged += new System.EventHandler(this.cbPageDelete_CheckedChanged);
            // 
            // cbPageDesign
            // 
            this.cbPageDesign.Checked = true;
            this.cbPageDesign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPageDesign.Location = new System.Drawing.Point(12, 345);
            this.cbPageDesign.Name = "cbPageDesign";
            this.cbPageDesign.Size = new System.Drawing.Size(156, 25);
            this.cbPageDesign.TabIndex = 13;
            this.cbPageDesign.Text = "Page Design";
            this.cbPageDesign.CheckedChanged += new System.EventHandler(this.cbPageDesign_CheckedChanged);
            // 
            // cbBookmarksButton
            // 
            this.cbBookmarksButton.Checked = true;
            this.cbBookmarksButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBookmarksButton.Location = new System.Drawing.Point(12, 368);
            this.cbBookmarksButton.Name = "cbBookmarksButton";
            this.cbBookmarksButton.Size = new System.Drawing.Size(180, 23);
            this.cbBookmarksButton.TabIndex = 14;
            this.cbBookmarksButton.Text = "Bookmarks Button";
            this.cbBookmarksButton.CheckedChanged += new System.EventHandler(this.cbBookmarksButton_CheckedChanged);
            // 
            // cbThumbsButton
            // 
            this.cbThumbsButton.Checked = true;
            this.cbThumbsButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThumbsButton.Location = new System.Drawing.Point(12, 391);
            this.cbThumbsButton.Name = "cbThumbsButton";
            this.cbThumbsButton.Size = new System.Drawing.Size(156, 25);
            this.cbThumbsButton.TabIndex = 15;
            this.cbThumbsButton.Text = "Thumbs Button";
            this.cbThumbsButton.CheckedChanged += new System.EventHandler(this.cbThumbsButton_CheckedChanged);
            // 
            // cbToolEditor
            // 
            this.cbToolEditor.Checked = true;
            this.cbToolEditor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToolEditor.Location = new System.Drawing.Point(12, 417);
            this.cbToolEditor.Name = "cbToolEditor";
            this.cbToolEditor.Size = new System.Drawing.Size(156, 23);
            this.cbToolEditor.TabIndex = 18;
            this.cbToolEditor.Text = "Tool Editor";
            this.cbToolEditor.CheckedChanged += new System.EventHandler(this.cbToolEditor_CheckedChanged);
            // 
            // cbToolFind
            // 
            this.cbToolFind.Checked = true;
            this.cbToolFind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToolFind.Location = new System.Drawing.Point(12, 440);
            this.cbToolFind.Name = "cbToolFind";
            this.cbToolFind.Size = new System.Drawing.Size(156, 25);
            this.cbToolFind.TabIndex = 19;
            this.cbToolFind.Text = "Tool Find";
            this.cbToolFind.CheckedChanged += new System.EventHandler(this.cbToolFind_CheckedChanged);
            // 
            // cbZoom
            // 
            this.cbZoom.Checked = true;
            this.cbZoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZoom.Location = new System.Drawing.Point(12, 465);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(156, 23);
            this.cbZoom.TabIndex = 20;
            this.cbZoom.Text = "Zoom";
            this.cbZoom.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
            // 
            // cbPageControl
            // 
            this.cbPageControl.Checked = true;
            this.cbPageControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPageControl.Location = new System.Drawing.Point(12, 488);
            this.cbPageControl.Name = "cbPageControl";
            this.cbPageControl.Size = new System.Drawing.Size(156, 25);
            this.cbPageControl.TabIndex = 21;
            this.cbPageControl.Text = "Page Control";
            this.cbPageControl.CheckedChanged += new System.EventHandler(this.cbPageControl_CheckedChanged);
            // 
            // cbSendByEMail
            // 
            this.cbSendByEMail.Checked = true;
            this.cbSendByEMail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSendByEMail.Location = new System.Drawing.Point(12, 274);
            this.cbSendByEMail.Name = "cbSendByEMail";
            this.cbSendByEMail.Size = new System.Drawing.Size(156, 23);
            this.cbSendByEMail.TabIndex = 10;
            this.cbSendByEMail.Text = "Send By E-Mail";
            this.cbSendByEMail.CheckedChanged += new System.EventHandler(this.cbSendByEMail_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 849);
            this.Controls.Add(this.PreviewControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customizing the Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbZoom.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
        {
            // Enable HiDPI mode
            Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void cbBookmarks_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowBookmarksPanel = cbBookmarks.Checked;
		}

		private void cbThumbs_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowThumbsPanel = cbThumbs.Checked;
		}

		private void cbToolbar_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowToolbar = cbToolbar.Checked;
		}

		private void cbVerScrollBar_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowVertScrollBar = cbVerScrollBar.Checked;
		}

		private void cbHorScrollBar_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowHorScrollBar = cbHorScrollBar.Checked;
		}

		private void cbStatusBar_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowStatusBar = cbStatusBar.Checked;
		}

		private void cbContextMenu_CheckedChanged(object sender, System.EventArgs e)
		{
            PreviewControl.ShowContextMenu = cbContextMenu.Checked;
		}

		private void cbPrint_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowPrint = cbPrint.Checked;		
		}

		private void cbOpen_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowOpen = cbOpen.Checked;
		}

		private void cbSave_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowSave = cbSave.Checked;
		}


		private void cbPageNew_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowPageNew = cbPageNew.Checked;
		}

		private void cbPageDelete_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowPageDelete = cbPageDelete.Checked;
		}

		private void cbPageDesign_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowPageDesign = cbPageDesign.Checked;
		}

		private void cbBookmarksButton_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowBookmarksPanel = cbBookmarksButton.Checked;
		}

		private void cbThumbsButton_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowThumbsPanel = cbThumbsButton.Checked;
		}

		private void cbToolEditor_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowEditor = cbToolEditor.Checked;
		}

		private void cbToolFind_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowFind = cbToolFind.Checked;
		}

		private void cbZoom_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowZoom = cbZoom.Checked;
		}

		private void cbCloseButton_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowCloseButton = cbCloseButton.Checked;
		}

		private void PreviewControl_Close(object sender, System.EventArgs e)
		{
			Close();
		}

		private void cbPageControl_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowPageControl = cbPageControl.Checked;
		}

		private void tbOnePage_Click(object sender, System.EventArgs e)
		{
			PreviewControl.SetZoomOnePage();
		}

		private void tbTwoPages_Click(object sender, System.EventArgs e)
		{
			PreviewControl.SetZoomTwoPages();
		}

		private void tbNormal_Click(object sender, System.EventArgs e)
		{
			PreviewControl.SetZoom(100d);
		}

		private void tbPageWidth_Click(object sender, System.EventArgs e)
		{
			PreviewControl.SetZoomPageWidth();
		}

		private void tbFirstPage_Click(object sender, System.EventArgs e)
		{
			PreviewControl.FirstPage();
		}

		private void tbPreviousPage_Click(object sender, System.EventArgs e)
		{
			PreviewControl.PrevPage();
		}

		private void tbNextPage_Click(object sender, System.EventArgs e)
		{
			PreviewControl.NextPage();
		}

		private void tbLastPage_Click(object sender, System.EventArgs e)
		{
			PreviewControl.LastPage();
		}

		private void btRefresh_Click(object sender, System.EventArgs e)
		{
			Report.Render(false);
			PreviewControl.SaveConfig();
			PreviewControl.Refresh();
			PreviewControl.LoadConfig();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Customizing_the_Viewer.CustomPreview.mrt"))
            {
                Report.Load(stream);
            }
			Report.Compile();
			btRefresh_Click(sender, e);
			
		}

		private void cbSendByEMail_CheckedChanged(object sender, System.EventArgs e)
		{
			PreviewControl.ShowSendEMail = cbSendByEMail.Checked;
		}
	}
}
