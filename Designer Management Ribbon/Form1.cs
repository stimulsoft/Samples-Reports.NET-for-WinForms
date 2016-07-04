using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Design;
using Stimulsoft.Report.Design.ContextTools;
using Stimulsoft.Report.Design.Toolbars;

namespace DesignerManagement
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button btRunDesigner;
        private System.Windows.Forms.CheckBox cbMenuReportNew;
		private System.Windows.Forms.CheckBox cbMenuPageNew;
		private System.Windows.Forms.CheckBox cbMenuFormNew;
		private System.Windows.Forms.CheckBox cbMenuReportOpen;
		private System.Windows.Forms.CheckBox cbMenuPageOpen;
		private System.Windows.Forms.CheckBox cbMenuReportSave;
		private System.Windows.Forms.CheckBox cbMenuReportSaveAs;
		private System.Windows.Forms.CheckBox cbMenuPageSaveAs;
		private System.Windows.Forms.CheckBox cbMenuPageDelete;
        private System.Windows.Forms.CheckBox cbMenuReportPreview;
        private System.Windows.Forms.CheckBox cbMenuReportSetup;
        private System.Windows.Forms.CheckBox cbMenuClose;
		private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMainMenu;
		private System.Windows.Forms.TabPage tbContextMenu;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.CheckBox cbContextDesignComponent;
		private System.Windows.Forms.CheckBox cbContextCut;
		private System.Windows.Forms.CheckBox cbContextCopy;
		private System.Windows.Forms.CheckBox cbContextPaste;
		private System.Windows.Forms.CheckBox cbContextDelete;
        private System.Windows.Forms.CheckBox cbContextSelectAll;
		private System.Windows.Forms.CheckBox cbContextOrder;
		private System.Windows.Forms.CheckBox cbContextAlign;
        private CheckBox cbMenuReportWizardNew;
        private CheckBox cbMenuNew;
        private CheckBox cbMenuSaveAs;
        private CheckBox cbMenuCheckForIssues;
        private CheckBox cbMenuExit;
        private CheckBox cbMenuOptions;
        private CheckBox cbApplicationMenu;
        private TabPage tbBars;
        private GroupBox groupBox4;
        private CheckBox tbBarView;
        private GroupBox groupBox3;
        private CheckBox tbBarPage;
        private CheckBox tbBarPageSetup;
        private CheckBox tbBarPageWatermarkImage;
        private CheckBox tbBarPageWatermarkText;
        private GroupBox groupBox2;
        private CheckBox tbBarLayout;
        private CheckBox tbBarLayoutArrange;
        private CheckBox tbBarLayoutDockStyle;
        private GroupBox groupBox1;
        private CheckBox tbBarHome;
        private CheckBox tbBarHomeAlignment;
        private CheckBox tbBarHomeBorders;
        private CheckBox tbBarHomeClipboard;
        private CheckBox tbBarHomeFont;
        private CheckBox tbBarHomeTextFormat;
        private CheckBox tbBarHomeStyle;
		private System.ComponentModel.IContainer components = null;

		public Form1()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btRunDesigner = new System.Windows.Forms.Button();
            this.cbMenuReportNew = new System.Windows.Forms.CheckBox();
            this.cbMenuPageNew = new System.Windows.Forms.CheckBox();
            this.cbMenuFormNew = new System.Windows.Forms.CheckBox();
            this.cbMenuReportOpen = new System.Windows.Forms.CheckBox();
            this.cbMenuPageOpen = new System.Windows.Forms.CheckBox();
            this.cbMenuReportSave = new System.Windows.Forms.CheckBox();
            this.cbMenuReportSaveAs = new System.Windows.Forms.CheckBox();
            this.cbMenuPageSaveAs = new System.Windows.Forms.CheckBox();
            this.cbMenuPageDelete = new System.Windows.Forms.CheckBox();
            this.cbMenuReportPreview = new System.Windows.Forms.CheckBox();
            this.cbMenuReportSetup = new System.Windows.Forms.CheckBox();
            this.cbMenuClose = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMainMenu = new System.Windows.Forms.TabPage();
            this.cbMenuExit = new System.Windows.Forms.CheckBox();
            this.cbMenuOptions = new System.Windows.Forms.CheckBox();
            this.cbMenuCheckForIssues = new System.Windows.Forms.CheckBox();
            this.cbMenuSaveAs = new System.Windows.Forms.CheckBox();
            this.cbMenuReportWizardNew = new System.Windows.Forms.CheckBox();
            this.cbMenuNew = new System.Windows.Forms.CheckBox();
            this.tbContextMenu = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbContextOrder = new System.Windows.Forms.CheckBox();
            this.cbContextAlign = new System.Windows.Forms.CheckBox();
            this.cbContextDesignComponent = new System.Windows.Forms.CheckBox();
            this.cbContextDelete = new System.Windows.Forms.CheckBox();
            this.cbContextCut = new System.Windows.Forms.CheckBox();
            this.cbContextCopy = new System.Windows.Forms.CheckBox();
            this.cbContextPaste = new System.Windows.Forms.CheckBox();
            this.cbContextSelectAll = new System.Windows.Forms.CheckBox();
            this.cbApplicationMenu = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBarHomeStyle = new System.Windows.Forms.CheckBox();
            this.tbBarHomeTextFormat = new System.Windows.Forms.CheckBox();
            this.tbBarHomeFont = new System.Windows.Forms.CheckBox();
            this.tbBarHomeClipboard = new System.Windows.Forms.CheckBox();
            this.tbBarHomeBorders = new System.Windows.Forms.CheckBox();
            this.tbBarHomeAlignment = new System.Windows.Forms.CheckBox();
            this.tbBarHome = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbBarLayoutDockStyle = new System.Windows.Forms.CheckBox();
            this.tbBarLayoutArrange = new System.Windows.Forms.CheckBox();
            this.tbBarLayout = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBarPageWatermarkText = new System.Windows.Forms.CheckBox();
            this.tbBarPageWatermarkImage = new System.Windows.Forms.CheckBox();
            this.tbBarPageSetup = new System.Windows.Forms.CheckBox();
            this.tbBarPage = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbBarView = new System.Windows.Forms.CheckBox();
            this.tbBars = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbMainMenu.SuspendLayout();
            this.tbContextMenu.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tbBars.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRunDesigner
            // 
            this.btRunDesigner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRunDesigner.Location = new System.Drawing.Point(550, 465);
            this.btRunDesigner.Name = "btRunDesigner";
            this.btRunDesigner.Size = new System.Drawing.Size(96, 23);
            this.btRunDesigner.TabIndex = 1;
            this.btRunDesigner.Text = "Run Designer";
            this.btRunDesigner.Click += new System.EventHandler(this.btRunDesigner_Click);
            // 
            // cbMenuReportNew
            // 
            this.cbMenuReportNew.Checked = true;
            this.cbMenuReportNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportNew.Location = new System.Drawing.Point(23, 58);
            this.cbMenuReportNew.Name = "cbMenuReportNew";
            this.cbMenuReportNew.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportNew.TabIndex = 2;
            this.cbMenuReportNew.Text = "Report New";
            // 
            // cbMenuPageNew
            // 
            this.cbMenuPageNew.Checked = true;
            this.cbMenuPageNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuPageNew.Location = new System.Drawing.Point(23, 102);
            this.cbMenuPageNew.Name = "cbMenuPageNew";
            this.cbMenuPageNew.Size = new System.Drawing.Size(136, 16);
            this.cbMenuPageNew.TabIndex = 4;
            this.cbMenuPageNew.Text = "Page New";
            // 
            // cbMenuFormNew
            // 
            this.cbMenuFormNew.Checked = true;
            this.cbMenuFormNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuFormNew.Location = new System.Drawing.Point(23, 124);
            this.cbMenuFormNew.Name = "cbMenuFormNew";
            this.cbMenuFormNew.Size = new System.Drawing.Size(136, 16);
            this.cbMenuFormNew.TabIndex = 5;
            this.cbMenuFormNew.Text = "Form New";
            // 
            // cbMenuReportOpen
            // 
            this.cbMenuReportOpen.Checked = true;
            this.cbMenuReportOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportOpen.Location = new System.Drawing.Point(8, 146);
            this.cbMenuReportOpen.Name = "cbMenuReportOpen";
            this.cbMenuReportOpen.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportOpen.TabIndex = 6;
            this.cbMenuReportOpen.Text = "Report Open";
            // 
            // cbMenuPageOpen
            // 
            this.cbMenuPageOpen.Checked = true;
            this.cbMenuPageOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuPageOpen.Location = new System.Drawing.Point(8, 168);
            this.cbMenuPageOpen.Name = "cbMenuPageOpen";
            this.cbMenuPageOpen.Size = new System.Drawing.Size(136, 16);
            this.cbMenuPageOpen.TabIndex = 7;
            this.cbMenuPageOpen.Text = "Page Open";
            // 
            // cbMenuReportSave
            // 
            this.cbMenuReportSave.Checked = true;
            this.cbMenuReportSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportSave.Location = new System.Drawing.Point(8, 190);
            this.cbMenuReportSave.Name = "cbMenuReportSave";
            this.cbMenuReportSave.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportSave.TabIndex = 8;
            this.cbMenuReportSave.Text = "Report Save";
            // 
            // cbMenuReportSaveAs
            // 
            this.cbMenuReportSaveAs.Checked = true;
            this.cbMenuReportSaveAs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportSaveAs.Location = new System.Drawing.Point(23, 234);
            this.cbMenuReportSaveAs.Name = "cbMenuReportSaveAs";
            this.cbMenuReportSaveAs.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportSaveAs.TabIndex = 10;
            this.cbMenuReportSaveAs.Text = "Report Save As";
            // 
            // cbMenuPageSaveAs
            // 
            this.cbMenuPageSaveAs.Checked = true;
            this.cbMenuPageSaveAs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuPageSaveAs.Location = new System.Drawing.Point(23, 256);
            this.cbMenuPageSaveAs.Name = "cbMenuPageSaveAs";
            this.cbMenuPageSaveAs.Size = new System.Drawing.Size(136, 16);
            this.cbMenuPageSaveAs.TabIndex = 11;
            this.cbMenuPageSaveAs.Text = "Page Save As";
            // 
            // cbMenuPageDelete
            // 
            this.cbMenuPageDelete.Checked = true;
            this.cbMenuPageDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuPageDelete.Location = new System.Drawing.Point(8, 278);
            this.cbMenuPageDelete.Name = "cbMenuPageDelete";
            this.cbMenuPageDelete.Size = new System.Drawing.Size(136, 16);
            this.cbMenuPageDelete.TabIndex = 12;
            this.cbMenuPageDelete.Text = "Page Delete";
            // 
            // cbMenuReportPreview
            // 
            this.cbMenuReportPreview.Checked = true;
            this.cbMenuReportPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportPreview.Location = new System.Drawing.Point(8, 300);
            this.cbMenuReportPreview.Name = "cbMenuReportPreview";
            this.cbMenuReportPreview.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportPreview.TabIndex = 13;
            this.cbMenuReportPreview.Text = "Report Preview";
            // 
            // cbMenuReportSetup
            // 
            this.cbMenuReportSetup.Checked = true;
            this.cbMenuReportSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportSetup.Location = new System.Drawing.Point(8, 344);
            this.cbMenuReportSetup.Name = "cbMenuReportSetup";
            this.cbMenuReportSetup.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportSetup.TabIndex = 15;
            this.cbMenuReportSetup.Text = "Report Setup";
            // 
            // cbMenuClose
            // 
            this.cbMenuClose.Checked = true;
            this.cbMenuClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuClose.Location = new System.Drawing.Point(8, 366);
            this.cbMenuClose.Name = "cbMenuClose";
            this.cbMenuClose.Size = new System.Drawing.Size(136, 16);
            this.cbMenuClose.TabIndex = 16;
            this.cbMenuClose.Text = "Close";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMainMenu);
            this.tabControl1.Controls.Add(this.tbContextMenu);
            this.tabControl1.Controls.Add(this.tbBars);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tbMainMenu
            // 
            this.tbMainMenu.Controls.Add(this.cbMenuExit);
            this.tbMainMenu.Controls.Add(this.cbMenuOptions);
            this.tbMainMenu.Controls.Add(this.cbMenuClose);
            this.tbMainMenu.Controls.Add(this.cbMenuCheckForIssues);
            this.tbMainMenu.Controls.Add(this.cbMenuReportSetup);
            this.tbMainMenu.Controls.Add(this.cbMenuReportPreview);
            this.tbMainMenu.Controls.Add(this.cbMenuPageDelete);
            this.tbMainMenu.Controls.Add(this.cbMenuPageSaveAs);
            this.tbMainMenu.Controls.Add(this.cbMenuReportSaveAs);
            this.tbMainMenu.Controls.Add(this.cbMenuSaveAs);
            this.tbMainMenu.Controls.Add(this.cbMenuReportSave);
            this.tbMainMenu.Controls.Add(this.cbMenuPageOpen);
            this.tbMainMenu.Controls.Add(this.cbMenuReportOpen);
            this.tbMainMenu.Controls.Add(this.cbMenuFormNew);
            this.tbMainMenu.Controls.Add(this.cbMenuPageNew);
            this.tbMainMenu.Controls.Add(this.cbMenuReportWizardNew);
            this.tbMainMenu.Controls.Add(this.cbApplicationMenu);
            this.tbMainMenu.Controls.Add(this.cbMenuNew);
            this.tbMainMenu.Controls.Add(this.cbMenuReportNew);
            this.tbMainMenu.Location = new System.Drawing.Point(4, 22);
            this.tbMainMenu.Name = "tbMainMenu";
            this.tbMainMenu.Size = new System.Drawing.Size(650, 433);
            this.tbMainMenu.TabIndex = 0;
            this.tbMainMenu.Text = "Application Menu";
            // 
            // cbMenuExit
            // 
            this.cbMenuExit.Checked = true;
            this.cbMenuExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuExit.Location = new System.Drawing.Point(23, 410);
            this.cbMenuExit.Name = "cbMenuExit";
            this.cbMenuExit.Size = new System.Drawing.Size(136, 16);
            this.cbMenuExit.TabIndex = 18;
            this.cbMenuExit.Text = "Exit";
            // 
            // cbMenuOptions
            // 
            this.cbMenuOptions.Checked = true;
            this.cbMenuOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuOptions.Location = new System.Drawing.Point(23, 388);
            this.cbMenuOptions.Name = "cbMenuOptions";
            this.cbMenuOptions.Size = new System.Drawing.Size(78, 16);
            this.cbMenuOptions.TabIndex = 17;
            this.cbMenuOptions.Text = "Options";
            // 
            // cbMenuCheckForIssues
            // 
            this.cbMenuCheckForIssues.Checked = true;
            this.cbMenuCheckForIssues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuCheckForIssues.Location = new System.Drawing.Point(8, 322);
            this.cbMenuCheckForIssues.Name = "cbMenuCheckForIssues";
            this.cbMenuCheckForIssues.Size = new System.Drawing.Size(136, 16);
            this.cbMenuCheckForIssues.TabIndex = 14;
            this.cbMenuCheckForIssues.Text = "Check for Issues";
            // 
            // cbMenuSaveAs
            // 
            this.cbMenuSaveAs.Checked = true;
            this.cbMenuSaveAs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuSaveAs.Location = new System.Drawing.Point(8, 212);
            this.cbMenuSaveAs.Name = "cbMenuSaveAs";
            this.cbMenuSaveAs.Size = new System.Drawing.Size(136, 16);
            this.cbMenuSaveAs.TabIndex = 9;
            this.cbMenuSaveAs.Text = "Save As";
            // 
            // cbMenuReportWizardNew
            // 
            this.cbMenuReportWizardNew.Checked = true;
            this.cbMenuReportWizardNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuReportWizardNew.Location = new System.Drawing.Point(23, 80);
            this.cbMenuReportWizardNew.Name = "cbMenuReportWizardNew";
            this.cbMenuReportWizardNew.Size = new System.Drawing.Size(136, 16);
            this.cbMenuReportWizardNew.TabIndex = 3;
            this.cbMenuReportWizardNew.Text = "Report Wizard New";
            // 
            // cbMenuNew
            // 
            this.cbMenuNew.Checked = true;
            this.cbMenuNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMenuNew.Location = new System.Drawing.Point(8, 36);
            this.cbMenuNew.Name = "cbMenuNew";
            this.cbMenuNew.Size = new System.Drawing.Size(136, 16);
            this.cbMenuNew.TabIndex = 1;
            this.cbMenuNew.Text = "New";
            // 
            // tbContextMenu
            // 
            this.tbContextMenu.Controls.Add(this.groupBox11);
            this.tbContextMenu.Location = new System.Drawing.Point(4, 22);
            this.tbContextMenu.Name = "tbContextMenu";
            this.tbContextMenu.Size = new System.Drawing.Size(650, 470);
            this.tbContextMenu.TabIndex = 4;
            this.tbContextMenu.Text = "Context Menu";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbContextOrder);
            this.groupBox11.Controls.Add(this.cbContextAlign);
            this.groupBox11.Controls.Add(this.cbContextDesignComponent);
            this.groupBox11.Controls.Add(this.cbContextDelete);
            this.groupBox11.Controls.Add(this.cbContextCut);
            this.groupBox11.Controls.Add(this.cbContextCopy);
            this.groupBox11.Controls.Add(this.cbContextPaste);
            this.groupBox11.Controls.Add(this.cbContextSelectAll);
            this.groupBox11.Location = new System.Drawing.Point(8, 8);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(304, 181);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Menu File";
            // 
            // cbContextOrder
            // 
            this.cbContextOrder.BackColor = System.Drawing.SystemColors.Control;
            this.cbContextOrder.Checked = true;
            this.cbContextOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextOrder.Location = new System.Drawing.Point(8, 40);
            this.cbContextOrder.Name = "cbContextOrder";
            this.cbContextOrder.Size = new System.Drawing.Size(136, 16);
            this.cbContextOrder.TabIndex = 1;
            this.cbContextOrder.Text = "Order";
            this.cbContextOrder.UseVisualStyleBackColor = false;
            // 
            // cbContextAlign
            // 
            this.cbContextAlign.Checked = true;
            this.cbContextAlign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextAlign.Location = new System.Drawing.Point(8, 56);
            this.cbContextAlign.Name = "cbContextAlign";
            this.cbContextAlign.Size = new System.Drawing.Size(136, 16);
            this.cbContextAlign.TabIndex = 2;
            this.cbContextAlign.Text = "Align";
            // 
            // cbContextDesignComponent
            // 
            this.cbContextDesignComponent.Checked = true;
            this.cbContextDesignComponent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextDesignComponent.Location = new System.Drawing.Point(8, 16);
            this.cbContextDesignComponent.Name = "cbContextDesignComponent";
            this.cbContextDesignComponent.Size = new System.Drawing.Size(136, 16);
            this.cbContextDesignComponent.TabIndex = 0;
            this.cbContextDesignComponent.Text = "Design";
            // 
            // cbContextDelete
            // 
            this.cbContextDelete.Checked = true;
            this.cbContextDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextDelete.Location = new System.Drawing.Point(8, 136);
            this.cbContextDelete.Name = "cbContextDelete";
            this.cbContextDelete.Size = new System.Drawing.Size(136, 16);
            this.cbContextDelete.TabIndex = 6;
            this.cbContextDelete.Text = "Delete";
            // 
            // cbContextCut
            // 
            this.cbContextCut.Checked = true;
            this.cbContextCut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextCut.Location = new System.Drawing.Point(8, 88);
            this.cbContextCut.Name = "cbContextCut";
            this.cbContextCut.Size = new System.Drawing.Size(136, 16);
            this.cbContextCut.TabIndex = 3;
            this.cbContextCut.Text = "Cut";
            // 
            // cbContextCopy
            // 
            this.cbContextCopy.Checked = true;
            this.cbContextCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextCopy.Location = new System.Drawing.Point(8, 104);
            this.cbContextCopy.Name = "cbContextCopy";
            this.cbContextCopy.Size = new System.Drawing.Size(136, 16);
            this.cbContextCopy.TabIndex = 4;
            this.cbContextCopy.Text = "Copy";
            // 
            // cbContextPaste
            // 
            this.cbContextPaste.Checked = true;
            this.cbContextPaste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextPaste.Location = new System.Drawing.Point(8, 120);
            this.cbContextPaste.Name = "cbContextPaste";
            this.cbContextPaste.Size = new System.Drawing.Size(136, 16);
            this.cbContextPaste.TabIndex = 5;
            this.cbContextPaste.Text = "Paste";
            // 
            // cbContextSelectAll
            // 
            this.cbContextSelectAll.Checked = true;
            this.cbContextSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextSelectAll.Location = new System.Drawing.Point(8, 152);
            this.cbContextSelectAll.Name = "cbContextSelectAll";
            this.cbContextSelectAll.Size = new System.Drawing.Size(136, 16);
            this.cbContextSelectAll.TabIndex = 7;
            this.cbContextSelectAll.Text = "Select All";
            // 
            // cbApplicationMenu
            // 
            this.cbApplicationMenu.Checked = true;
            this.cbApplicationMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbApplicationMenu.Location = new System.Drawing.Point(8, 14);
            this.cbApplicationMenu.Name = "cbApplicationMenu";
            this.cbApplicationMenu.Size = new System.Drawing.Size(136, 16);
            this.cbApplicationMenu.TabIndex = 0;
            this.cbApplicationMenu.Text = "Application Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBarHome);
            this.groupBox1.Controls.Add(this.tbBarHomeAlignment);
            this.groupBox1.Controls.Add(this.tbBarHomeBorders);
            this.groupBox1.Controls.Add(this.tbBarHomeClipboard);
            this.groupBox1.Controls.Add(this.tbBarHomeFont);
            this.groupBox1.Controls.Add(this.tbBarHomeTextFormat);
            this.groupBox1.Controls.Add(this.tbBarHomeStyle);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home";
            // 
            // tbBarHomeStyle
            // 
            this.tbBarHomeStyle.Checked = true;
            this.tbBarHomeStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHomeStyle.Location = new System.Drawing.Point(8, 96);
            this.tbBarHomeStyle.Name = "tbBarHomeStyle";
            this.tbBarHomeStyle.Size = new System.Drawing.Size(136, 16);
            this.tbBarHomeStyle.TabIndex = 5;
            this.tbBarHomeStyle.Text = "Style";
            // 
            // tbBarHomeTextFormat
            // 
            this.tbBarHomeTextFormat.Checked = true;
            this.tbBarHomeTextFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHomeTextFormat.Location = new System.Drawing.Point(8, 112);
            this.tbBarHomeTextFormat.Name = "tbBarHomeTextFormat";
            this.tbBarHomeTextFormat.Size = new System.Drawing.Size(136, 16);
            this.tbBarHomeTextFormat.TabIndex = 6;
            this.tbBarHomeTextFormat.Text = "Text Format";
            // 
            // tbBarHomeFont
            // 
            this.tbBarHomeFont.Checked = true;
            this.tbBarHomeFont.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHomeFont.Location = new System.Drawing.Point(8, 80);
            this.tbBarHomeFont.Name = "tbBarHomeFont";
            this.tbBarHomeFont.Size = new System.Drawing.Size(136, 16);
            this.tbBarHomeFont.TabIndex = 4;
            this.tbBarHomeFont.Text = "Font";
            // 
            // tbBarHomeClipboard
            // 
            this.tbBarHomeClipboard.Checked = true;
            this.tbBarHomeClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHomeClipboard.Location = new System.Drawing.Point(8, 64);
            this.tbBarHomeClipboard.Name = "tbBarHomeClipboard";
            this.tbBarHomeClipboard.Size = new System.Drawing.Size(136, 16);
            this.tbBarHomeClipboard.TabIndex = 3;
            this.tbBarHomeClipboard.Text = "Clipboard";
            // 
            // tbBarHomeBorders
            // 
            this.tbBarHomeBorders.Checked = true;
            this.tbBarHomeBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHomeBorders.Location = new System.Drawing.Point(8, 48);
            this.tbBarHomeBorders.Name = "tbBarHomeBorders";
            this.tbBarHomeBorders.Size = new System.Drawing.Size(136, 16);
            this.tbBarHomeBorders.TabIndex = 2;
            this.tbBarHomeBorders.Text = "Borders";
            // 
            // tbBarHomeAlignment
            // 
            this.tbBarHomeAlignment.Checked = true;
            this.tbBarHomeAlignment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHomeAlignment.Location = new System.Drawing.Point(8, 32);
            this.tbBarHomeAlignment.Name = "tbBarHomeAlignment";
            this.tbBarHomeAlignment.Size = new System.Drawing.Size(136, 16);
            this.tbBarHomeAlignment.TabIndex = 1;
            this.tbBarHomeAlignment.Text = "Alignment";
            // 
            // tbBarHome
            // 
            this.tbBarHome.Checked = true;
            this.tbBarHome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarHome.Location = new System.Drawing.Point(8, 16);
            this.tbBarHome.Name = "tbBarHome";
            this.tbBarHome.Size = new System.Drawing.Size(136, 16);
            this.tbBarHome.TabIndex = 0;
            this.tbBarHome.Text = "Bar Visible";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbBarLayout);
            this.groupBox2.Controls.Add(this.tbBarLayoutArrange);
            this.groupBox2.Controls.Add(this.tbBarLayoutDockStyle);
            this.groupBox2.Location = new System.Drawing.Point(166, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 147);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Layout";
            // 
            // tbBarLayoutDockStyle
            // 
            this.tbBarLayoutDockStyle.Checked = true;
            this.tbBarLayoutDockStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarLayoutDockStyle.Location = new System.Drawing.Point(8, 48);
            this.tbBarLayoutDockStyle.Name = "tbBarLayoutDockStyle";
            this.tbBarLayoutDockStyle.Size = new System.Drawing.Size(136, 16);
            this.tbBarLayoutDockStyle.TabIndex = 2;
            this.tbBarLayoutDockStyle.Text = "Dock Style";
            // 
            // tbBarLayoutArrange
            // 
            this.tbBarLayoutArrange.Checked = true;
            this.tbBarLayoutArrange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarLayoutArrange.Location = new System.Drawing.Point(8, 32);
            this.tbBarLayoutArrange.Name = "tbBarLayoutArrange";
            this.tbBarLayoutArrange.Size = new System.Drawing.Size(136, 16);
            this.tbBarLayoutArrange.TabIndex = 1;
            this.tbBarLayoutArrange.Text = "Arrange";
            // 
            // tbBarLayout
            // 
            this.tbBarLayout.Checked = true;
            this.tbBarLayout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarLayout.Location = new System.Drawing.Point(8, 16);
            this.tbBarLayout.Name = "tbBarLayout";
            this.tbBarLayout.Size = new System.Drawing.Size(136, 16);
            this.tbBarLayout.TabIndex = 0;
            this.tbBarLayout.Text = "Bar Visible";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBarPage);
            this.groupBox3.Controls.Add(this.tbBarPageSetup);
            this.groupBox3.Controls.Add(this.tbBarPageWatermarkImage);
            this.groupBox3.Controls.Add(this.tbBarPageWatermarkText);
            this.groupBox3.Location = new System.Drawing.Point(324, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 147);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Page";
            // 
            // tbBarPageWatermarkText
            // 
            this.tbBarPageWatermarkText.Checked = true;
            this.tbBarPageWatermarkText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarPageWatermarkText.Location = new System.Drawing.Point(8, 64);
            this.tbBarPageWatermarkText.Name = "tbBarPageWatermarkText";
            this.tbBarPageWatermarkText.Size = new System.Drawing.Size(136, 16);
            this.tbBarPageWatermarkText.TabIndex = 3;
            this.tbBarPageWatermarkText.Text = "Watermark Text";
            // 
            // tbBarPageWatermarkImage
            // 
            this.tbBarPageWatermarkImage.Checked = true;
            this.tbBarPageWatermarkImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarPageWatermarkImage.Location = new System.Drawing.Point(8, 48);
            this.tbBarPageWatermarkImage.Name = "tbBarPageWatermarkImage";
            this.tbBarPageWatermarkImage.Size = new System.Drawing.Size(136, 16);
            this.tbBarPageWatermarkImage.TabIndex = 2;
            this.tbBarPageWatermarkImage.Text = "Watermark Image";
            // 
            // tbBarPageSetup
            // 
            this.tbBarPageSetup.Checked = true;
            this.tbBarPageSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarPageSetup.Location = new System.Drawing.Point(8, 32);
            this.tbBarPageSetup.Name = "tbBarPageSetup";
            this.tbBarPageSetup.Size = new System.Drawing.Size(136, 16);
            this.tbBarPageSetup.TabIndex = 1;
            this.tbBarPageSetup.Text = "Page Setup";
            // 
            // tbBarPage
            // 
            this.tbBarPage.Checked = true;
            this.tbBarPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarPage.Location = new System.Drawing.Point(8, 16);
            this.tbBarPage.Name = "tbBarPage";
            this.tbBarPage.Size = new System.Drawing.Size(136, 16);
            this.tbBarPage.TabIndex = 0;
            this.tbBarPage.Text = "Bar Visible";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbBarView);
            this.groupBox4.Location = new System.Drawing.Point(482, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 147);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View";
            // 
            // tbBarView
            // 
            this.tbBarView.Checked = true;
            this.tbBarView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBarView.Location = new System.Drawing.Point(8, 16);
            this.tbBarView.Name = "tbBarView";
            this.tbBarView.Size = new System.Drawing.Size(136, 16);
            this.tbBarView.TabIndex = 0;
            this.tbBarView.Text = "Bar Visible";
            // 
            // tbBars
            // 
            this.tbBars.Controls.Add(this.groupBox4);
            this.tbBars.Controls.Add(this.groupBox3);
            this.tbBars.Controls.Add(this.groupBox2);
            this.tbBars.Controls.Add(this.groupBox1);
            this.tbBars.Location = new System.Drawing.Point(4, 22);
            this.tbBars.Name = "tbBars";
            this.tbBars.Size = new System.Drawing.Size(650, 433);
            this.tbBars.TabIndex = 3;
            this.tbBars.Text = "Bars";
            // 
            // Form1
            // 
            this.AcceptButton = this.btRunDesigner;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btRunDesigner;
            this.ClientSize = new System.Drawing.Size(658, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btRunDesigner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Designer Management Ribbon";
            this.tabControl1.ResumeLayout(false);
            this.tbMainMenu.ResumeLayout(false);
            this.tbContextMenu.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tbBars.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		private void btRunDesigner_Click(object sender, System.EventArgs e)
		{
			var report = new StiReport();
            StiOptions.Windows.GlobalGuiStyle = StiGlobalGuiStyle.Office2013;

			#region Update Config
            var ribbonService = StiConfig.Services.GetService(typeof(StiRibbonGuiService)) as StiRibbonGuiService;
   
            #region Application Main Menu
            ribbonService.ShowMainMenuNew = cbMenuNew.Checked;
            ribbonService.ShowMainMenuReportNew = cbMenuReportNew.Checked;

            ribbonService.ShowMainMenuReportOpen = cbMenuReportOpen.Checked;
            
            ribbonService.ShowMainMenuReportSave = cbMenuReportSave.Checked;
            ribbonService.ShowMainMenuSaveAs = cbMenuSaveAs.Checked;
            ribbonService.ShowMainMenuReportSaveAs = cbMenuReportSaveAs.Checked;

            ribbonService.ShowMainMenuCheckForIssues = cbMenuCheckForIssues.Checked;

            ribbonService.ShowMainMenuReportSetup = cbMenuReportSetup.Checked;
            ribbonService.ShowMainMenuClose = cbMenuClose.Checked;

            ribbonService.ShowMainMenuOptions = cbMenuOptions.Checked;
            ribbonService.ShowMainMenuExit = cbMenuExit.Checked;
            #endregion

            #region Home Tab
            ribbonService.ShowTabHome = tbBarHome.Checked;
            ribbonService.ShowTabHomeBarAlignment = tbBarHomeAlignment.Checked;
            ribbonService.ShowTabHomeBarBorders = tbBarHomeBorders.Checked;
            ribbonService.ShowTabHomeBarClipboard = tbBarHomeClipboard.Checked;
            ribbonService.ShowTabHomeBarFont = tbBarHomeFont.Checked;
            ribbonService.ShowTabHomeBarStyle = tbBarHomeStyle.Checked;
            ribbonService.ShowTabHomeBarTextFormat = tbBarHomeTextFormat.Checked;

            ribbonService.ShowTabLayout = tbBarLayout.Checked;
            ribbonService.ShowTabLayoutBarArrange = tbBarLayoutArrange.Checked;

            ribbonService.ShowTabPage = tbBarPage.Checked;
            ribbonService.ShowTabPageBarPageSetup = tbBarPageSetup.Checked;
            #endregion

            var mainMenu = StiConfig.Services.GetService(typeof(StiMainMenuService)) as StiMainMenuService;            

			#region Context Menu
            var designComponentCT = StiDesignComponentCTService.GetService();
			if (designComponentCT != null)designComponentCT.ServiceEnabled = cbContextDesignComponent.Checked;

            var orderCT = StiOrderCTService.GetService();
			if (orderCT != null)orderCT.ServiceEnabled = cbContextOrder.Checked;

            var alignCT = StiAlignCTService.GetService();
			if (alignCT != null)alignCT.ServiceEnabled = cbContextAlign.Checked;

            var objectCutCT = StiObjectCutCTService.GetService();
			if (objectCutCT != null)objectCutCT.ServiceEnabled = cbContextCut.Checked;

			var objectCopyCT = StiObjectCopyCTService.GetService();
			if (objectCopyCT != null)objectCopyCT.ServiceEnabled = cbContextCopy.Checked;

			var objectPasteCT = StiObjectPasteCTService.GetService();
			if (objectPasteCT != null)objectPasteCT.ServiceEnabled = cbContextPaste.Checked;

			var objectDeleteCT = StiObjectDeleteCTService.GetService();
			if (objectDeleteCT != null)objectDeleteCT.ServiceEnabled = cbContextDelete.Checked;

			var objectSelectAllCT = StiObjectSelectAllCTService.GetService();
			if (objectSelectAllCT != null)objectSelectAllCT.ServiceEnabled = cbContextSelectAll.Checked;
			#endregion
			#endregion
			
			report.Design();
		}
	}
}