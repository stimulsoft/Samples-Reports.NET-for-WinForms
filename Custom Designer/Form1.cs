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

namespace CustomReportsDesigner
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btRunDesigner;
		private System.Windows.Forms.GroupBox gbMenuFile;
		private System.Windows.Forms.CheckBox cbShowFile;
		private System.Windows.Forms.CheckBox cbShowFileReportNew;
		private System.Windows.Forms.CheckBox cbShowFilePageNew;
		private System.Windows.Forms.CheckBox cbShowFileFormNew;
		private System.Windows.Forms.CheckBox cbShowFileReportOpen;
		private System.Windows.Forms.CheckBox cbShowFilePageOpen;
		private System.Windows.Forms.CheckBox cbShowFileReportSave;
		private System.Windows.Forms.CheckBox cbShowFileReportSaveAs;
		private System.Windows.Forms.CheckBox cbShowFilePageSaveAs;
		private System.Windows.Forms.CheckBox cbShowFilePageDelete;
		private System.Windows.Forms.CheckBox cbShowFileReportPreview;
		private System.Windows.Forms.CheckBox cbShowFilePageSetup;
		private System.Windows.Forms.CheckBox cbShowFileReportSetup;
		private System.Windows.Forms.CheckBox cbShowFileRecentFiles;
		private System.Windows.Forms.CheckBox cbShowFileExit;
		private System.Windows.Forms.GroupBox gbMenuEdit;
		private System.Windows.Forms.CheckBox cbShowEdit;
		private System.Windows.Forms.CheckBox cbShowEditUndo;
		private System.Windows.Forms.CheckBox cbShowEditRedo;
		private System.Windows.Forms.CheckBox cbShowEditCut;
		private System.Windows.Forms.CheckBox cbShowEditCopy;
		private System.Windows.Forms.CheckBox cbShowEditPaste;
		private System.Windows.Forms.CheckBox cbShowEditDelete;
		private System.Windows.Forms.CheckBox cbShowEditSelectAll;
		private System.Windows.Forms.CheckBox cbShowEditClearContents;
		private System.Windows.Forms.GroupBox gbMenuView;
		private System.Windows.Forms.CheckBox cbShowView;
		private System.Windows.Forms.CheckBox cbShowViewNormal;
		private System.Windows.Forms.CheckBox cbShowViewPageBreakPreview;
		private System.Windows.Forms.CheckBox cbShowViewShowGrid;
		private System.Windows.Forms.CheckBox cbShowViewAlignToGrid;
		private System.Windows.Forms.CheckBox cbShowViewShowHeaders;
		private System.Windows.Forms.CheckBox cbShowViewShowRulers;
		private System.Windows.Forms.CheckBox cbShowViewShowOrder;
		private System.Windows.Forms.CheckBox cbShowViewToolbars;
		private System.Windows.Forms.CheckBox cbShowViewPanels;
		private System.Windows.Forms.GroupBox gbMenuTools;
		private System.Windows.Forms.CheckBox cbShowTools;
		private System.Windows.Forms.CheckBox cbShowToolsDataStore;
		private System.Windows.Forms.CheckBox cbShowToolsPagesManager;
		private System.Windows.Forms.CheckBox cbShowToolsOptions;
		private System.Windows.Forms.GroupBox gbMenuHelp;
		private System.Windows.Forms.CheckBox cbShowHelp;
		private System.Windows.Forms.CheckBox cbShowHelpProductHomePage;
		private System.Windows.Forms.CheckBox cbShowHelpFaqPage;
		private System.Windows.Forms.CheckBox cbShowHelpSupport;
		private System.Windows.Forms.CheckBox cbShowHelpAboutProgramm;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbMainMenu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox tbStandard;
		private System.Windows.Forms.CheckBox tbStandardReportNew;
		private System.Windows.Forms.CheckBox tbStandardPageNew;
		private System.Windows.Forms.CheckBox tbStandardFormNew;
		private System.Windows.Forms.CheckBox tbStandardReportOpen;
		private System.Windows.Forms.CheckBox tbStandardReportSave;
		private System.Windows.Forms.CheckBox tbStandardPageDelete;
		private System.Windows.Forms.CheckBox tbStandardReportPreview;
		private System.Windows.Forms.CheckBox tbStandardPageSetup;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox tbStandardUndo;
		private System.Windows.Forms.CheckBox tbStandardRedo;
		private System.Windows.Forms.CheckBox tbStandardCut;
		private System.Windows.Forms.CheckBox tbStandardCopy;
		private System.Windows.Forms.CheckBox tbStandardPaste;
		private System.Windows.Forms.CheckBox tbStandardDelete;
		private System.Windows.Forms.CheckBox tbStandardSelectAll;
		private System.Windows.Forms.CheckBox tbStandardShowGrid;
		private System.Windows.Forms.CheckBox tbStandardAlignToGrid;
		private System.Windows.Forms.CheckBox tbStandardShowHeaders;
		private System.Windows.Forms.CheckBox tbStandardShowRulers;
		private System.Windows.Forms.CheckBox tbStandardShowOrder;
		private System.Windows.Forms.CheckBox tbStandardTableMode;
		private System.Windows.Forms.CheckBox tbTextFormat;
		private System.Windows.Forms.CheckBox tbDockStyleFill;
		private System.Windows.Forms.CheckBox tbDockStyleNone;
		private System.Windows.Forms.CheckBox tbDockStyleLeft;
		private System.Windows.Forms.CheckBox tbDockStyleBottom;
		private System.Windows.Forms.CheckBox tbDockStyleRight;
		private System.Windows.Forms.CheckBox tbDockStyleTop;
		private System.Windows.Forms.CheckBox tbDockStyle;
		private System.Windows.Forms.CheckBox tbStyleDesigner;
		private System.Windows.Forms.CheckBox tbStyle;
		private System.Windows.Forms.CheckBox tbTools;
		private System.Windows.Forms.CheckBox tbToolsDataStore;
		private System.Windows.Forms.CheckBox tbToolsModifiers;
		private System.Windows.Forms.CheckBox tbToolsPagesManager;
		private System.Windows.Forms.CheckBox tbLayoutAlignRight;
		private System.Windows.Forms.CheckBox tbLayoutCenterHorizontally;
		private System.Windows.Forms.CheckBox tbLayoutMakeSameSize;
		private System.Windows.Forms.CheckBox tbLayoutCenterVertically;
		private System.Windows.Forms.CheckBox tbLayoutBringToFront;
		private System.Windows.Forms.CheckBox tbLayoutAlignTop;
		private System.Windows.Forms.CheckBox tbLayoutMakeSameWidth;
		private System.Windows.Forms.CheckBox tbLayoutSendToBack;
		private System.Windows.Forms.CheckBox tbLayoutMakeHorizontalSpacingEqual;
		private System.Windows.Forms.CheckBox tbLayoutAlignBottom;
		private System.Windows.Forms.CheckBox tbLayoutAlignMiddle;
		private System.Windows.Forms.CheckBox tbLayoutMoveBackward;
		private System.Windows.Forms.CheckBox tbLayoutMakeSameHeight;
		private System.Windows.Forms.CheckBox tbLayoutAlignToGrid;
		private System.Windows.Forms.CheckBox tbLayoutMakeVerticalSpacingEqual;
		private System.Windows.Forms.CheckBox tbLayoutAlignLeft;
		private System.Windows.Forms.CheckBox tbLayoutAlignCenter;
		private System.Windows.Forms.CheckBox tbLayoutLink;
		private System.Windows.Forms.CheckBox tbLayoutLock;
		private System.Windows.Forms.CheckBox tbLayout;
		private System.Windows.Forms.CheckBox tbFormatting;
		private System.Windows.Forms.CheckBox tbFormattingAlignCenter;
		private System.Windows.Forms.CheckBox tbFormattingAlignLeft;
		private System.Windows.Forms.CheckBox tbFormattingAlignRight;
		private System.Windows.Forms.CheckBox tbFormattingAlignWidth;
		private System.Windows.Forms.CheckBox tbFormattingAlignMiddle;
		private System.Windows.Forms.CheckBox tbFormattingAlignBottom;
		private System.Windows.Forms.CheckBox tbFormattingAlignTop;
		private System.Windows.Forms.CheckBox tbFormattingFont;
		private System.Windows.Forms.CheckBox tbFormattingBold;
		private System.Windows.Forms.CheckBox tbFormattingFontSize;
		private System.Windows.Forms.CheckBox tbFormattingItalic;
		private System.Windows.Forms.CheckBox tbFormattingUnderline;
		private System.Windows.Forms.CheckBox tbFormattingTextBrush;
		private System.Windows.Forms.CheckBox tbFormattingRotateText;
		private System.Windows.Forms.CheckBox tbStandardClose;
		private System.Windows.Forms.CheckBox tbStandardZoom;
		private System.Windows.Forms.CheckBox tbLayoutMoveForward;
		private System.Windows.Forms.CheckBox tbBordersAll;
		private System.Windows.Forms.CheckBox tbBorders;
		private System.Windows.Forms.CheckBox tbBordersNone;
		private System.Windows.Forms.CheckBox tbBordersLeft;
		private System.Windows.Forms.CheckBox tbBordersBottom;
		private System.Windows.Forms.CheckBox tbBordersRight;
		private System.Windows.Forms.CheckBox tbBordersTop;
		private System.Windows.Forms.CheckBox tbBordersShadow;
		private System.Windows.Forms.CheckBox tbBordersFillBrush;
		private System.Windows.Forms.CheckBox tbBordersColor;
		private System.Windows.Forms.CheckBox tbBordersStyle;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.CheckBox tbToolbox;
		private System.Windows.Forms.CheckBox tbStyleStyles;
		private System.Windows.Forms.GroupBox gbAboutBoxType;
		private System.Windows.Forms.RadioButton rbAboutBoxTypeStandard;
		private System.Windows.Forms.RadioButton rbAboutBoxTypeMyAboutBox;
		private System.Windows.Forms.TextBox tbProductHomePage;
		private System.Windows.Forms.Label lbProductHomePage;
		private System.Windows.Forms.TextBox tbFaqPage;
		private System.Windows.Forms.Label lbFaqPage;
		private System.Windows.Forms.Label lbSupport;
		private System.Windows.Forms.TextBox tbSupport;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TabPage tbToolbars;
		private System.Windows.Forms.TabPage tbContextMenu;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.CheckBox cbContextDesignComponent;
		private System.Windows.Forms.CheckBox cbContextCut;
		private System.Windows.Forms.CheckBox cbContextCopy;
		private System.Windows.Forms.CheckBox cbContextPaste;
		private System.Windows.Forms.CheckBox cbContextDelete;
		private System.Windows.Forms.CheckBox cbContextSelectAll;
		private System.Windows.Forms.CheckBox tbFormattingConditions;
		private System.Windows.Forms.CheckBox cbContextOrder;
		private System.Windows.Forms.CheckBox cbContextAlign;
		private System.ComponentModel.IContainer components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btRunDesigner = new System.Windows.Forms.Button();
            this.gbMenuFile = new System.Windows.Forms.GroupBox();
            this.cbShowFile = new System.Windows.Forms.CheckBox();
            this.cbShowFileReportNew = new System.Windows.Forms.CheckBox();
            this.cbShowFilePageNew = new System.Windows.Forms.CheckBox();
            this.cbShowFileFormNew = new System.Windows.Forms.CheckBox();
            this.cbShowFileReportOpen = new System.Windows.Forms.CheckBox();
            this.cbShowFilePageOpen = new System.Windows.Forms.CheckBox();
            this.cbShowFileReportSave = new System.Windows.Forms.CheckBox();
            this.cbShowFileReportSaveAs = new System.Windows.Forms.CheckBox();
            this.cbShowFilePageSaveAs = new System.Windows.Forms.CheckBox();
            this.cbShowFilePageDelete = new System.Windows.Forms.CheckBox();
            this.cbShowFileReportPreview = new System.Windows.Forms.CheckBox();
            this.cbShowFilePageSetup = new System.Windows.Forms.CheckBox();
            this.cbShowFileReportSetup = new System.Windows.Forms.CheckBox();
            this.cbShowFileRecentFiles = new System.Windows.Forms.CheckBox();
            this.cbShowFileExit = new System.Windows.Forms.CheckBox();
            this.gbMenuEdit = new System.Windows.Forms.GroupBox();
            this.cbShowEdit = new System.Windows.Forms.CheckBox();
            this.cbShowEditUndo = new System.Windows.Forms.CheckBox();
            this.cbShowEditRedo = new System.Windows.Forms.CheckBox();
            this.cbShowEditCut = new System.Windows.Forms.CheckBox();
            this.cbShowEditCopy = new System.Windows.Forms.CheckBox();
            this.cbShowEditPaste = new System.Windows.Forms.CheckBox();
            this.cbShowEditDelete = new System.Windows.Forms.CheckBox();
            this.cbShowEditSelectAll = new System.Windows.Forms.CheckBox();
            this.cbShowEditClearContents = new System.Windows.Forms.CheckBox();
            this.gbMenuView = new System.Windows.Forms.GroupBox();
            this.cbShowView = new System.Windows.Forms.CheckBox();
            this.cbShowViewNormal = new System.Windows.Forms.CheckBox();
            this.cbShowViewPageBreakPreview = new System.Windows.Forms.CheckBox();
            this.cbShowViewShowGrid = new System.Windows.Forms.CheckBox();
            this.cbShowViewAlignToGrid = new System.Windows.Forms.CheckBox();
            this.cbShowViewShowHeaders = new System.Windows.Forms.CheckBox();
            this.cbShowViewShowRulers = new System.Windows.Forms.CheckBox();
            this.cbShowViewShowOrder = new System.Windows.Forms.CheckBox();
            this.cbShowViewToolbars = new System.Windows.Forms.CheckBox();
            this.cbShowViewPanels = new System.Windows.Forms.CheckBox();
            this.gbMenuTools = new System.Windows.Forms.GroupBox();
            this.cbShowTools = new System.Windows.Forms.CheckBox();
            this.cbShowToolsDataStore = new System.Windows.Forms.CheckBox();
            this.cbShowToolsPagesManager = new System.Windows.Forms.CheckBox();
            this.cbShowToolsOptions = new System.Windows.Forms.CheckBox();
            this.gbMenuHelp = new System.Windows.Forms.GroupBox();
            this.cbShowHelp = new System.Windows.Forms.CheckBox();
            this.cbShowHelpProductHomePage = new System.Windows.Forms.CheckBox();
            this.cbShowHelpFaqPage = new System.Windows.Forms.CheckBox();
            this.cbShowHelpSupport = new System.Windows.Forms.CheckBox();
            this.cbShowHelpAboutProgramm = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMainMenu = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbProductHomePage = new System.Windows.Forms.Label();
            this.tbSupport = new System.Windows.Forms.TextBox();
            this.lbSupport = new System.Windows.Forms.Label();
            this.lbFaqPage = new System.Windows.Forms.Label();
            this.tbProductHomePage = new System.Windows.Forms.TextBox();
            this.tbFaqPage = new System.Windows.Forms.TextBox();
            this.gbAboutBoxType = new System.Windows.Forms.GroupBox();
            this.rbAboutBoxTypeStandard = new System.Windows.Forms.RadioButton();
            this.rbAboutBoxTypeMyAboutBox = new System.Windows.Forms.RadioButton();
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
            this.tbToolbars = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStandard = new System.Windows.Forms.CheckBox();
            this.tbStandardReportNew = new System.Windows.Forms.CheckBox();
            this.tbStandardReportOpen = new System.Windows.Forms.CheckBox();
            this.tbStandardReportSave = new System.Windows.Forms.CheckBox();
            this.tbStandardPageDelete = new System.Windows.Forms.CheckBox();
            this.tbStandardReportPreview = new System.Windows.Forms.CheckBox();
            this.tbStandardPageSetup = new System.Windows.Forms.CheckBox();
            this.tbStandardFormNew = new System.Windows.Forms.CheckBox();
            this.tbStandardPageNew = new System.Windows.Forms.CheckBox();
            this.tbStandardUndo = new System.Windows.Forms.CheckBox();
            this.tbStandardRedo = new System.Windows.Forms.CheckBox();
            this.tbStandardCut = new System.Windows.Forms.CheckBox();
            this.tbStandardPaste = new System.Windows.Forms.CheckBox();
            this.tbStandardDelete = new System.Windows.Forms.CheckBox();
            this.tbStandardSelectAll = new System.Windows.Forms.CheckBox();
            this.tbStandardCopy = new System.Windows.Forms.CheckBox();
            this.tbStandardShowGrid = new System.Windows.Forms.CheckBox();
            this.tbStandardAlignToGrid = new System.Windows.Forms.CheckBox();
            this.tbStandardShowHeaders = new System.Windows.Forms.CheckBox();
            this.tbStandardShowRulers = new System.Windows.Forms.CheckBox();
            this.tbStandardShowOrder = new System.Windows.Forms.CheckBox();
            this.tbStandardTableMode = new System.Windows.Forms.CheckBox();
            this.tbStandardClose = new System.Windows.Forms.CheckBox();
            this.tbStandardZoom = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLayoutAlignRight = new System.Windows.Forms.CheckBox();
            this.tbLayoutMoveForward = new System.Windows.Forms.CheckBox();
            this.tbLayoutCenterHorizontally = new System.Windows.Forms.CheckBox();
            this.tbLayoutMakeSameSize = new System.Windows.Forms.CheckBox();
            this.tbLayoutCenterVertically = new System.Windows.Forms.CheckBox();
            this.tbLayoutBringToFront = new System.Windows.Forms.CheckBox();
            this.tbLayoutAlignTop = new System.Windows.Forms.CheckBox();
            this.tbLayoutMakeSameWidth = new System.Windows.Forms.CheckBox();
            this.tbLayoutSendToBack = new System.Windows.Forms.CheckBox();
            this.tbLayoutMakeHorizontalSpacingEqual = new System.Windows.Forms.CheckBox();
            this.tbLayoutAlignBottom = new System.Windows.Forms.CheckBox();
            this.tbLayoutAlignMiddle = new System.Windows.Forms.CheckBox();
            this.tbLayoutMoveBackward = new System.Windows.Forms.CheckBox();
            this.tbLayoutMakeSameHeight = new System.Windows.Forms.CheckBox();
            this.tbLayoutAlignToGrid = new System.Windows.Forms.CheckBox();
            this.tbLayoutMakeVerticalSpacingEqual = new System.Windows.Forms.CheckBox();
            this.tbLayoutAlignLeft = new System.Windows.Forms.CheckBox();
            this.tbLayoutAlignCenter = new System.Windows.Forms.CheckBox();
            this.tbLayoutLink = new System.Windows.Forms.CheckBox();
            this.tbLayoutLock = new System.Windows.Forms.CheckBox();
            this.tbLayout = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbFormatting = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignCenter = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignLeft = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignRight = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignWidth = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignMiddle = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignBottom = new System.Windows.Forms.CheckBox();
            this.tbFormattingAlignTop = new System.Windows.Forms.CheckBox();
            this.tbFormattingFont = new System.Windows.Forms.CheckBox();
            this.tbFormattingBold = new System.Windows.Forms.CheckBox();
            this.tbFormattingFontSize = new System.Windows.Forms.CheckBox();
            this.tbFormattingItalic = new System.Windows.Forms.CheckBox();
            this.tbFormattingUnderline = new System.Windows.Forms.CheckBox();
            this.tbFormattingTextBrush = new System.Windows.Forms.CheckBox();
            this.tbFormattingRotateText = new System.Windows.Forms.CheckBox();
            this.tbFormattingConditions = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbTools = new System.Windows.Forms.CheckBox();
            this.tbToolsModifiers = new System.Windows.Forms.CheckBox();
            this.tbToolsPagesManager = new System.Windows.Forms.CheckBox();
            this.tbToolsDataStore = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbDockStyleFill = new System.Windows.Forms.CheckBox();
            this.tbDockStyleNone = new System.Windows.Forms.CheckBox();
            this.tbDockStyleLeft = new System.Windows.Forms.CheckBox();
            this.tbDockStyleBottom = new System.Windows.Forms.CheckBox();
            this.tbDockStyleRight = new System.Windows.Forms.CheckBox();
            this.tbDockStyleTop = new System.Windows.Forms.CheckBox();
            this.tbDockStyle = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbBordersAll = new System.Windows.Forms.CheckBox();
            this.tbBordersNone = new System.Windows.Forms.CheckBox();
            this.tbBordersLeft = new System.Windows.Forms.CheckBox();
            this.tbBordersBottom = new System.Windows.Forms.CheckBox();
            this.tbBordersRight = new System.Windows.Forms.CheckBox();
            this.tbBordersTop = new System.Windows.Forms.CheckBox();
            this.tbBordersShadow = new System.Windows.Forms.CheckBox();
            this.tbBordersFillBrush = new System.Windows.Forms.CheckBox();
            this.tbBordersColor = new System.Windows.Forms.CheckBox();
            this.tbBordersStyle = new System.Windows.Forms.CheckBox();
            this.tbBorders = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbStyleDesigner = new System.Windows.Forms.CheckBox();
            this.tbStyle = new System.Windows.Forms.CheckBox();
            this.tbStyleStyles = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbTextFormat = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbToolbox = new System.Windows.Forms.CheckBox();
            this.gbMenuFile.SuspendLayout();
            this.gbMenuEdit.SuspendLayout();
            this.gbMenuView.SuspendLayout();
            this.gbMenuTools.SuspendLayout();
            this.gbMenuHelp.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbMainMenu.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.gbAboutBoxType.SuspendLayout();
            this.tbContextMenu.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tbToolbars.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRunDesigner
            // 
            this.btRunDesigner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRunDesigner.Location = new System.Drawing.Point(552, 502);
            this.btRunDesigner.Name = "btRunDesigner";
            this.btRunDesigner.Size = new System.Drawing.Size(100, 30);
            this.btRunDesigner.TabIndex = 1;
            this.btRunDesigner.Text = "Run Designer";
            this.btRunDesigner.Click += new System.EventHandler(this.btRunDesigner_Click);
            // 
            // gbMenuFile
            // 
            this.gbMenuFile.Controls.Add(this.cbShowFile);
            this.gbMenuFile.Controls.Add(this.cbShowFileReportNew);
            this.gbMenuFile.Controls.Add(this.cbShowFilePageNew);
            this.gbMenuFile.Controls.Add(this.cbShowFileFormNew);
            this.gbMenuFile.Controls.Add(this.cbShowFileReportOpen);
            this.gbMenuFile.Controls.Add(this.cbShowFilePageOpen);
            this.gbMenuFile.Controls.Add(this.cbShowFileReportSave);
            this.gbMenuFile.Controls.Add(this.cbShowFileReportSaveAs);
            this.gbMenuFile.Controls.Add(this.cbShowFilePageSaveAs);
            this.gbMenuFile.Controls.Add(this.cbShowFilePageDelete);
            this.gbMenuFile.Controls.Add(this.cbShowFileReportPreview);
            this.gbMenuFile.Controls.Add(this.cbShowFilePageSetup);
            this.gbMenuFile.Controls.Add(this.cbShowFileReportSetup);
            this.gbMenuFile.Controls.Add(this.cbShowFileRecentFiles);
            this.gbMenuFile.Controls.Add(this.cbShowFileExit);
            this.gbMenuFile.Location = new System.Drawing.Point(8, 8);
            this.gbMenuFile.Name = "gbMenuFile";
            this.gbMenuFile.Size = new System.Drawing.Size(152, 264);
            this.gbMenuFile.TabIndex = 0;
            this.gbMenuFile.TabStop = false;
            this.gbMenuFile.Text = "Menu File";
            // 
            // cbShowFile
            // 
            this.cbShowFile.BackColor = System.Drawing.SystemColors.Control;
            this.cbShowFile.Checked = true;
            this.cbShowFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFile.Location = new System.Drawing.Point(8, 16);
            this.cbShowFile.Name = "cbShowFile";
            this.cbShowFile.Size = new System.Drawing.Size(136, 16);
            this.cbShowFile.TabIndex = 0;
            this.cbShowFile.Text = "File";
            this.cbShowFile.UseVisualStyleBackColor = false;
            // 
            // cbShowFileReportNew
            // 
            this.cbShowFileReportNew.Checked = true;
            this.cbShowFileReportNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileReportNew.Location = new System.Drawing.Point(8, 32);
            this.cbShowFileReportNew.Name = "cbShowFileReportNew";
            this.cbShowFileReportNew.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileReportNew.TabIndex = 1;
            this.cbShowFileReportNew.Text = "ReportNew";
            // 
            // cbShowFilePageNew
            // 
            this.cbShowFilePageNew.Checked = true;
            this.cbShowFilePageNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFilePageNew.Location = new System.Drawing.Point(8, 48);
            this.cbShowFilePageNew.Name = "cbShowFilePageNew";
            this.cbShowFilePageNew.Size = new System.Drawing.Size(136, 16);
            this.cbShowFilePageNew.TabIndex = 2;
            this.cbShowFilePageNew.Text = "PageNew";
            // 
            // cbShowFileFormNew
            // 
            this.cbShowFileFormNew.Checked = true;
            this.cbShowFileFormNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileFormNew.Location = new System.Drawing.Point(8, 64);
            this.cbShowFileFormNew.Name = "cbShowFileFormNew";
            this.cbShowFileFormNew.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileFormNew.TabIndex = 3;
            this.cbShowFileFormNew.Text = "FormNew";
            // 
            // cbShowFileReportOpen
            // 
            this.cbShowFileReportOpen.Checked = true;
            this.cbShowFileReportOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileReportOpen.Location = new System.Drawing.Point(8, 80);
            this.cbShowFileReportOpen.Name = "cbShowFileReportOpen";
            this.cbShowFileReportOpen.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileReportOpen.TabIndex = 4;
            this.cbShowFileReportOpen.Text = "ReportOpen";
            // 
            // cbShowFilePageOpen
            // 
            this.cbShowFilePageOpen.Checked = true;
            this.cbShowFilePageOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFilePageOpen.Location = new System.Drawing.Point(8, 96);
            this.cbShowFilePageOpen.Name = "cbShowFilePageOpen";
            this.cbShowFilePageOpen.Size = new System.Drawing.Size(136, 16);
            this.cbShowFilePageOpen.TabIndex = 5;
            this.cbShowFilePageOpen.Text = "PageOpen";
            // 
            // cbShowFileReportSave
            // 
            this.cbShowFileReportSave.Checked = true;
            this.cbShowFileReportSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileReportSave.Location = new System.Drawing.Point(8, 112);
            this.cbShowFileReportSave.Name = "cbShowFileReportSave";
            this.cbShowFileReportSave.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileReportSave.TabIndex = 6;
            this.cbShowFileReportSave.Text = "ReportSave";
            // 
            // cbShowFileReportSaveAs
            // 
            this.cbShowFileReportSaveAs.Checked = true;
            this.cbShowFileReportSaveAs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileReportSaveAs.Location = new System.Drawing.Point(8, 128);
            this.cbShowFileReportSaveAs.Name = "cbShowFileReportSaveAs";
            this.cbShowFileReportSaveAs.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileReportSaveAs.TabIndex = 7;
            this.cbShowFileReportSaveAs.Text = "ReportSaveAs";
            // 
            // cbShowFilePageSaveAs
            // 
            this.cbShowFilePageSaveAs.Checked = true;
            this.cbShowFilePageSaveAs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFilePageSaveAs.Location = new System.Drawing.Point(8, 144);
            this.cbShowFilePageSaveAs.Name = "cbShowFilePageSaveAs";
            this.cbShowFilePageSaveAs.Size = new System.Drawing.Size(136, 16);
            this.cbShowFilePageSaveAs.TabIndex = 8;
            this.cbShowFilePageSaveAs.Text = "PageSaveAs";
            // 
            // cbShowFilePageDelete
            // 
            this.cbShowFilePageDelete.Checked = true;
            this.cbShowFilePageDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFilePageDelete.Location = new System.Drawing.Point(8, 160);
            this.cbShowFilePageDelete.Name = "cbShowFilePageDelete";
            this.cbShowFilePageDelete.Size = new System.Drawing.Size(136, 16);
            this.cbShowFilePageDelete.TabIndex = 9;
            this.cbShowFilePageDelete.Text = "PageDelete";
            // 
            // cbShowFileReportPreview
            // 
            this.cbShowFileReportPreview.Checked = true;
            this.cbShowFileReportPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileReportPreview.Location = new System.Drawing.Point(8, 176);
            this.cbShowFileReportPreview.Name = "cbShowFileReportPreview";
            this.cbShowFileReportPreview.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileReportPreview.TabIndex = 10;
            this.cbShowFileReportPreview.Text = "ReportPreview";
            // 
            // cbShowFilePageSetup
            // 
            this.cbShowFilePageSetup.Checked = true;
            this.cbShowFilePageSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFilePageSetup.Location = new System.Drawing.Point(8, 192);
            this.cbShowFilePageSetup.Name = "cbShowFilePageSetup";
            this.cbShowFilePageSetup.Size = new System.Drawing.Size(136, 16);
            this.cbShowFilePageSetup.TabIndex = 11;
            this.cbShowFilePageSetup.Text = "PageSetup";
            // 
            // cbShowFileReportSetup
            // 
            this.cbShowFileReportSetup.Checked = true;
            this.cbShowFileReportSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileReportSetup.Location = new System.Drawing.Point(8, 208);
            this.cbShowFileReportSetup.Name = "cbShowFileReportSetup";
            this.cbShowFileReportSetup.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileReportSetup.TabIndex = 12;
            this.cbShowFileReportSetup.Text = "ReportSetup";
            // 
            // cbShowFileRecentFiles
            // 
            this.cbShowFileRecentFiles.Checked = true;
            this.cbShowFileRecentFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileRecentFiles.Location = new System.Drawing.Point(8, 224);
            this.cbShowFileRecentFiles.Name = "cbShowFileRecentFiles";
            this.cbShowFileRecentFiles.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileRecentFiles.TabIndex = 13;
            this.cbShowFileRecentFiles.Text = "RecentFiles";
            // 
            // cbShowFileExit
            // 
            this.cbShowFileExit.Checked = true;
            this.cbShowFileExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFileExit.Location = new System.Drawing.Point(8, 240);
            this.cbShowFileExit.Name = "cbShowFileExit";
            this.cbShowFileExit.Size = new System.Drawing.Size(136, 16);
            this.cbShowFileExit.TabIndex = 14;
            this.cbShowFileExit.Text = "FileExit";
            // 
            // gbMenuEdit
            // 
            this.gbMenuEdit.Controls.Add(this.cbShowEdit);
            this.gbMenuEdit.Controls.Add(this.cbShowEditUndo);
            this.gbMenuEdit.Controls.Add(this.cbShowEditRedo);
            this.gbMenuEdit.Controls.Add(this.cbShowEditCut);
            this.gbMenuEdit.Controls.Add(this.cbShowEditCopy);
            this.gbMenuEdit.Controls.Add(this.cbShowEditPaste);
            this.gbMenuEdit.Controls.Add(this.cbShowEditDelete);
            this.gbMenuEdit.Controls.Add(this.cbShowEditSelectAll);
            this.gbMenuEdit.Controls.Add(this.cbShowEditClearContents);
            this.gbMenuEdit.Location = new System.Drawing.Point(168, 8);
            this.gbMenuEdit.Name = "gbMenuEdit";
            this.gbMenuEdit.Size = new System.Drawing.Size(152, 192);
            this.gbMenuEdit.TabIndex = 1;
            this.gbMenuEdit.TabStop = false;
            this.gbMenuEdit.Text = "Menu Edit";
            // 
            // cbShowEdit
            // 
            this.cbShowEdit.Checked = true;
            this.cbShowEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEdit.Location = new System.Drawing.Point(8, 16);
            this.cbShowEdit.Name = "cbShowEdit";
            this.cbShowEdit.Size = new System.Drawing.Size(136, 16);
            this.cbShowEdit.TabIndex = 0;
            this.cbShowEdit.Text = "Edit";
            // 
            // cbShowEditUndo
            // 
            this.cbShowEditUndo.Checked = true;
            this.cbShowEditUndo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditUndo.Location = new System.Drawing.Point(8, 32);
            this.cbShowEditUndo.Name = "cbShowEditUndo";
            this.cbShowEditUndo.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditUndo.TabIndex = 1;
            this.cbShowEditUndo.Text = "Undo";
            // 
            // cbShowEditRedo
            // 
            this.cbShowEditRedo.Checked = true;
            this.cbShowEditRedo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditRedo.Location = new System.Drawing.Point(8, 48);
            this.cbShowEditRedo.Name = "cbShowEditRedo";
            this.cbShowEditRedo.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditRedo.TabIndex = 2;
            this.cbShowEditRedo.Text = "Redo";
            // 
            // cbShowEditCut
            // 
            this.cbShowEditCut.Checked = true;
            this.cbShowEditCut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditCut.Location = new System.Drawing.Point(8, 64);
            this.cbShowEditCut.Name = "cbShowEditCut";
            this.cbShowEditCut.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditCut.TabIndex = 3;
            this.cbShowEditCut.Text = "Cut";
            // 
            // cbShowEditCopy
            // 
            this.cbShowEditCopy.Checked = true;
            this.cbShowEditCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditCopy.Location = new System.Drawing.Point(8, 80);
            this.cbShowEditCopy.Name = "cbShowEditCopy";
            this.cbShowEditCopy.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditCopy.TabIndex = 4;
            this.cbShowEditCopy.Text = "Copy";
            // 
            // cbShowEditPaste
            // 
            this.cbShowEditPaste.Checked = true;
            this.cbShowEditPaste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditPaste.Location = new System.Drawing.Point(8, 96);
            this.cbShowEditPaste.Name = "cbShowEditPaste";
            this.cbShowEditPaste.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditPaste.TabIndex = 5;
            this.cbShowEditPaste.Text = "Paste";
            // 
            // cbShowEditDelete
            // 
            this.cbShowEditDelete.Checked = true;
            this.cbShowEditDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditDelete.Location = new System.Drawing.Point(8, 112);
            this.cbShowEditDelete.Name = "cbShowEditDelete";
            this.cbShowEditDelete.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditDelete.TabIndex = 6;
            this.cbShowEditDelete.Text = "Delete";
            // 
            // cbShowEditSelectAll
            // 
            this.cbShowEditSelectAll.Checked = true;
            this.cbShowEditSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditSelectAll.Location = new System.Drawing.Point(8, 128);
            this.cbShowEditSelectAll.Name = "cbShowEditSelectAll";
            this.cbShowEditSelectAll.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditSelectAll.TabIndex = 7;
            this.cbShowEditSelectAll.Text = "SelectAll";
            // 
            // cbShowEditClearContents
            // 
            this.cbShowEditClearContents.Checked = true;
            this.cbShowEditClearContents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowEditClearContents.Location = new System.Drawing.Point(8, 144);
            this.cbShowEditClearContents.Name = "cbShowEditClearContents";
            this.cbShowEditClearContents.Size = new System.Drawing.Size(136, 16);
            this.cbShowEditClearContents.TabIndex = 8;
            this.cbShowEditClearContents.Text = "ClearContents";
            // 
            // gbMenuView
            // 
            this.gbMenuView.Controls.Add(this.cbShowView);
            this.gbMenuView.Controls.Add(this.cbShowViewNormal);
            this.gbMenuView.Controls.Add(this.cbShowViewPageBreakPreview);
            this.gbMenuView.Controls.Add(this.cbShowViewShowGrid);
            this.gbMenuView.Controls.Add(this.cbShowViewAlignToGrid);
            this.gbMenuView.Controls.Add(this.cbShowViewShowHeaders);
            this.gbMenuView.Controls.Add(this.cbShowViewShowRulers);
            this.gbMenuView.Controls.Add(this.cbShowViewShowOrder);
            this.gbMenuView.Controls.Add(this.cbShowViewToolbars);
            this.gbMenuView.Controls.Add(this.cbShowViewPanels);
            this.gbMenuView.Location = new System.Drawing.Point(328, 8);
            this.gbMenuView.Name = "gbMenuView";
            this.gbMenuView.Size = new System.Drawing.Size(152, 192);
            this.gbMenuView.TabIndex = 2;
            this.gbMenuView.TabStop = false;
            this.gbMenuView.Text = "Menu View";
            // 
            // cbShowView
            // 
            this.cbShowView.Checked = true;
            this.cbShowView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowView.Location = new System.Drawing.Point(8, 16);
            this.cbShowView.Name = "cbShowView";
            this.cbShowView.Size = new System.Drawing.Size(136, 16);
            this.cbShowView.TabIndex = 0;
            this.cbShowView.Text = "View";
            // 
            // cbShowViewNormal
            // 
            this.cbShowViewNormal.Checked = true;
            this.cbShowViewNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewNormal.Location = new System.Drawing.Point(8, 32);
            this.cbShowViewNormal.Name = "cbShowViewNormal";
            this.cbShowViewNormal.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewNormal.TabIndex = 1;
            this.cbShowViewNormal.Text = "Normal";
            // 
            // cbShowViewPageBreakPreview
            // 
            this.cbShowViewPageBreakPreview.Checked = true;
            this.cbShowViewPageBreakPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewPageBreakPreview.Location = new System.Drawing.Point(8, 48);
            this.cbShowViewPageBreakPreview.Name = "cbShowViewPageBreakPreview";
            this.cbShowViewPageBreakPreview.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewPageBreakPreview.TabIndex = 2;
            this.cbShowViewPageBreakPreview.Text = "PageBreakPreview";
            // 
            // cbShowViewShowGrid
            // 
            this.cbShowViewShowGrid.Checked = true;
            this.cbShowViewShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewShowGrid.Location = new System.Drawing.Point(8, 64);
            this.cbShowViewShowGrid.Name = "cbShowViewShowGrid";
            this.cbShowViewShowGrid.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewShowGrid.TabIndex = 3;
            this.cbShowViewShowGrid.Text = "ShowGrid";
            // 
            // cbShowViewAlignToGrid
            // 
            this.cbShowViewAlignToGrid.Checked = true;
            this.cbShowViewAlignToGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewAlignToGrid.Location = new System.Drawing.Point(8, 80);
            this.cbShowViewAlignToGrid.Name = "cbShowViewAlignToGrid";
            this.cbShowViewAlignToGrid.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewAlignToGrid.TabIndex = 4;
            this.cbShowViewAlignToGrid.Text = "AlignToGrid";
            // 
            // cbShowViewShowHeaders
            // 
            this.cbShowViewShowHeaders.Checked = true;
            this.cbShowViewShowHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewShowHeaders.Location = new System.Drawing.Point(8, 96);
            this.cbShowViewShowHeaders.Name = "cbShowViewShowHeaders";
            this.cbShowViewShowHeaders.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewShowHeaders.TabIndex = 5;
            this.cbShowViewShowHeaders.Text = "ShowHeaders";
            // 
            // cbShowViewShowRulers
            // 
            this.cbShowViewShowRulers.Checked = true;
            this.cbShowViewShowRulers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewShowRulers.Location = new System.Drawing.Point(8, 112);
            this.cbShowViewShowRulers.Name = "cbShowViewShowRulers";
            this.cbShowViewShowRulers.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewShowRulers.TabIndex = 6;
            this.cbShowViewShowRulers.Text = "ShowRulers";
            // 
            // cbShowViewShowOrder
            // 
            this.cbShowViewShowOrder.Checked = true;
            this.cbShowViewShowOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewShowOrder.Location = new System.Drawing.Point(8, 128);
            this.cbShowViewShowOrder.Name = "cbShowViewShowOrder";
            this.cbShowViewShowOrder.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewShowOrder.TabIndex = 7;
            this.cbShowViewShowOrder.Text = "ShowOrder";
            // 
            // cbShowViewToolbars
            // 
            this.cbShowViewToolbars.Checked = true;
            this.cbShowViewToolbars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewToolbars.Location = new System.Drawing.Point(8, 146);
            this.cbShowViewToolbars.Name = "cbShowViewToolbars";
            this.cbShowViewToolbars.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewToolbars.TabIndex = 10;
            this.cbShowViewToolbars.Text = "Toolbars";
            // 
            // cbShowViewPanels
            // 
            this.cbShowViewPanels.Checked = true;
            this.cbShowViewPanels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowViewPanels.Location = new System.Drawing.Point(8, 162);
            this.cbShowViewPanels.Name = "cbShowViewPanels";
            this.cbShowViewPanels.Size = new System.Drawing.Size(136, 16);
            this.cbShowViewPanels.TabIndex = 11;
            this.cbShowViewPanels.Text = "Panels";
            // 
            // gbMenuTools
            // 
            this.gbMenuTools.Controls.Add(this.cbShowTools);
            this.gbMenuTools.Controls.Add(this.cbShowToolsDataStore);
            this.gbMenuTools.Controls.Add(this.cbShowToolsPagesManager);
            this.gbMenuTools.Controls.Add(this.cbShowToolsOptions);
            this.gbMenuTools.Location = new System.Drawing.Point(488, 8);
            this.gbMenuTools.Name = "gbMenuTools";
            this.gbMenuTools.Size = new System.Drawing.Size(152, 88);
            this.gbMenuTools.TabIndex = 3;
            this.gbMenuTools.TabStop = false;
            this.gbMenuTools.Text = "Menu Tools";
            // 
            // cbShowTools
            // 
            this.cbShowTools.Checked = true;
            this.cbShowTools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowTools.Location = new System.Drawing.Point(8, 16);
            this.cbShowTools.Name = "cbShowTools";
            this.cbShowTools.Size = new System.Drawing.Size(136, 16);
            this.cbShowTools.TabIndex = 0;
            this.cbShowTools.Text = "Tools";
            // 
            // cbShowToolsDataStore
            // 
            this.cbShowToolsDataStore.Checked = true;
            this.cbShowToolsDataStore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowToolsDataStore.Location = new System.Drawing.Point(8, 32);
            this.cbShowToolsDataStore.Name = "cbShowToolsDataStore";
            this.cbShowToolsDataStore.Size = new System.Drawing.Size(136, 16);
            this.cbShowToolsDataStore.TabIndex = 1;
            this.cbShowToolsDataStore.Text = "DataStore";
            // 
            // cbShowToolsPagesManager
            // 
            this.cbShowToolsPagesManager.Checked = true;
            this.cbShowToolsPagesManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowToolsPagesManager.Location = new System.Drawing.Point(8, 48);
            this.cbShowToolsPagesManager.Name = "cbShowToolsPagesManager";
            this.cbShowToolsPagesManager.Size = new System.Drawing.Size(136, 16);
            this.cbShowToolsPagesManager.TabIndex = 3;
            this.cbShowToolsPagesManager.Text = "PagesManager";
            // 
            // cbShowToolsOptions
            // 
            this.cbShowToolsOptions.Checked = true;
            this.cbShowToolsOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowToolsOptions.Location = new System.Drawing.Point(8, 64);
            this.cbShowToolsOptions.Name = "cbShowToolsOptions";
            this.cbShowToolsOptions.Size = new System.Drawing.Size(136, 16);
            this.cbShowToolsOptions.TabIndex = 5;
            this.cbShowToolsOptions.Text = "Options";
            // 
            // gbMenuHelp
            // 
            this.gbMenuHelp.Controls.Add(this.cbShowHelp);
            this.gbMenuHelp.Controls.Add(this.cbShowHelpProductHomePage);
            this.gbMenuHelp.Controls.Add(this.cbShowHelpFaqPage);
            this.gbMenuHelp.Controls.Add(this.cbShowHelpSupport);
            this.gbMenuHelp.Controls.Add(this.cbShowHelpAboutProgramm);
            this.gbMenuHelp.Location = new System.Drawing.Point(488, 96);
            this.gbMenuHelp.Name = "gbMenuHelp";
            this.gbMenuHelp.Size = new System.Drawing.Size(152, 104);
            this.gbMenuHelp.TabIndex = 4;
            this.gbMenuHelp.TabStop = false;
            this.gbMenuHelp.Text = "Menu Help";
            // 
            // cbShowHelp
            // 
            this.cbShowHelp.Checked = true;
            this.cbShowHelp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHelp.Location = new System.Drawing.Point(8, 16);
            this.cbShowHelp.Name = "cbShowHelp";
            this.cbShowHelp.Size = new System.Drawing.Size(136, 16);
            this.cbShowHelp.TabIndex = 0;
            this.cbShowHelp.Text = "Help";
            // 
            // cbShowHelpProductHomePage
            // 
            this.cbShowHelpProductHomePage.Checked = true;
            this.cbShowHelpProductHomePage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHelpProductHomePage.Location = new System.Drawing.Point(8, 32);
            this.cbShowHelpProductHomePage.Name = "cbShowHelpProductHomePage";
            this.cbShowHelpProductHomePage.Size = new System.Drawing.Size(136, 16);
            this.cbShowHelpProductHomePage.TabIndex = 1;
            this.cbShowHelpProductHomePage.Text = "ProductHomePage";
            // 
            // cbShowHelpFaqPage
            // 
            this.cbShowHelpFaqPage.Checked = true;
            this.cbShowHelpFaqPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHelpFaqPage.Location = new System.Drawing.Point(8, 48);
            this.cbShowHelpFaqPage.Name = "cbShowHelpFaqPage";
            this.cbShowHelpFaqPage.Size = new System.Drawing.Size(136, 16);
            this.cbShowHelpFaqPage.TabIndex = 2;
            this.cbShowHelpFaqPage.Text = "FaqPage";
            // 
            // cbShowHelpSupport
            // 
            this.cbShowHelpSupport.Checked = true;
            this.cbShowHelpSupport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHelpSupport.Location = new System.Drawing.Point(8, 64);
            this.cbShowHelpSupport.Name = "cbShowHelpSupport";
            this.cbShowHelpSupport.Size = new System.Drawing.Size(136, 16);
            this.cbShowHelpSupport.TabIndex = 3;
            this.cbShowHelpSupport.Text = "Support";
            // 
            // cbShowHelpAboutProgramm
            // 
            this.cbShowHelpAboutProgramm.Checked = true;
            this.cbShowHelpAboutProgramm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowHelpAboutProgramm.Location = new System.Drawing.Point(8, 80);
            this.cbShowHelpAboutProgramm.Name = "cbShowHelpAboutProgramm";
            this.cbShowHelpAboutProgramm.Size = new System.Drawing.Size(136, 16);
            this.cbShowHelpAboutProgramm.TabIndex = 5;
            this.cbShowHelpAboutProgramm.Text = "AboutProgramm";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMainMenu);
            this.tabControl1.Controls.Add(this.tbContextMenu);
            this.tabControl1.Controls.Add(this.tbToolbars);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tbMainMenu
            // 
            this.tbMainMenu.Controls.Add(this.groupBox10);
            this.tbMainMenu.Controls.Add(this.gbMenuFile);
            this.tbMainMenu.Controls.Add(this.gbMenuEdit);
            this.tbMainMenu.Controls.Add(this.gbMenuView);
            this.tbMainMenu.Controls.Add(this.gbMenuTools);
            this.tbMainMenu.Controls.Add(this.gbMenuHelp);
            this.tbMainMenu.Location = new System.Drawing.Point(4, 22);
            this.tbMainMenu.Name = "tbMainMenu";
            this.tbMainMenu.Size = new System.Drawing.Size(650, 470);
            this.tbMainMenu.TabIndex = 0;
            this.tbMainMenu.Text = "Main Menu";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lbProductHomePage);
            this.groupBox10.Controls.Add(this.tbSupport);
            this.groupBox10.Controls.Add(this.lbSupport);
            this.groupBox10.Controls.Add(this.lbFaqPage);
            this.groupBox10.Controls.Add(this.tbProductHomePage);
            this.groupBox10.Controls.Add(this.tbFaqPage);
            this.groupBox10.Controls.Add(this.gbAboutBoxType);
            this.groupBox10.Location = new System.Drawing.Point(168, 216);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(472, 176);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Help Menu Management";
            // 
            // lbProductHomePage
            // 
            this.lbProductHomePage.Location = new System.Drawing.Point(8, 16);
            this.lbProductHomePage.Name = "lbProductHomePage";
            this.lbProductHomePage.Size = new System.Drawing.Size(144, 20);
            this.lbProductHomePage.TabIndex = 9;
            this.lbProductHomePage.Text = "Product Home Page";
            this.lbProductHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSupport
            // 
            this.tbSupport.Location = new System.Drawing.Point(168, 64);
            this.tbSupport.Name = "tbSupport";
            this.tbSupport.Size = new System.Drawing.Size(296, 20);
            this.tbSupport.TabIndex = 12;
            this.tbSupport.Text = "mailto:support@stimulsoft.com";
            // 
            // lbSupport
            // 
            this.lbSupport.Location = new System.Drawing.Point(8, 64);
            this.lbSupport.Name = "lbSupport";
            this.lbSupport.Size = new System.Drawing.Size(144, 20);
            this.lbSupport.TabIndex = 11;
            this.lbSupport.Text = "Support";
            this.lbSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFaqPage
            // 
            this.lbFaqPage.Location = new System.Drawing.Point(8, 40);
            this.lbFaqPage.Name = "lbFaqPage";
            this.lbFaqPage.Size = new System.Drawing.Size(144, 20);
            this.lbFaqPage.TabIndex = 10;
            this.lbFaqPage.Text = "Faq Page";
            this.lbFaqPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProductHomePage
            // 
            this.tbProductHomePage.Location = new System.Drawing.Point(168, 16);
            this.tbProductHomePage.Name = "tbProductHomePage";
            this.tbProductHomePage.Size = new System.Drawing.Size(296, 20);
            this.tbProductHomePage.TabIndex = 13;
            this.tbProductHomePage.Text = "http://www.stimulsoft.com";
            // 
            // tbFaqPage
            // 
            this.tbFaqPage.Location = new System.Drawing.Point(168, 40);
            this.tbFaqPage.Name = "tbFaqPage";
            this.tbFaqPage.Size = new System.Drawing.Size(296, 20);
            this.tbFaqPage.TabIndex = 14;
            this.tbFaqPage.Text = "http://www.stimulsoft.com/FAQ_SR.aspx";
            // 
            // gbAboutBoxType
            // 
            this.gbAboutBoxType.Controls.Add(this.rbAboutBoxTypeStandard);
            this.gbAboutBoxType.Controls.Add(this.rbAboutBoxTypeMyAboutBox);
            this.gbAboutBoxType.Location = new System.Drawing.Point(168, 96);
            this.gbAboutBoxType.Name = "gbAboutBoxType";
            this.gbAboutBoxType.Size = new System.Drawing.Size(152, 72);
            this.gbAboutBoxType.TabIndex = 15;
            this.gbAboutBoxType.TabStop = false;
            this.gbAboutBoxType.Text = "About Box Type";
            // 
            // rbAboutBoxTypeStandard
            // 
            this.rbAboutBoxTypeStandard.Checked = true;
            this.rbAboutBoxTypeStandard.Location = new System.Drawing.Point(8, 16);
            this.rbAboutBoxTypeStandard.Name = "rbAboutBoxTypeStandard";
            this.rbAboutBoxTypeStandard.Size = new System.Drawing.Size(104, 24);
            this.rbAboutBoxTypeStandard.TabIndex = 0;
            this.rbAboutBoxTypeStandard.TabStop = true;
            this.rbAboutBoxTypeStandard.Text = "Standard";
            // 
            // rbAboutBoxTypeMyAboutBox
            // 
            this.rbAboutBoxTypeMyAboutBox.Location = new System.Drawing.Point(8, 40);
            this.rbAboutBoxTypeMyAboutBox.Name = "rbAboutBoxTypeMyAboutBox";
            this.rbAboutBoxTypeMyAboutBox.Size = new System.Drawing.Size(104, 24);
            this.rbAboutBoxTypeMyAboutBox.TabIndex = 0;
            this.rbAboutBoxTypeMyAboutBox.Text = "My About Box";
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
            // tbToolbars
            // 
            this.tbToolbars.Controls.Add(this.groupBox1);
            this.tbToolbars.Controls.Add(this.groupBox2);
            this.tbToolbars.Controls.Add(this.groupBox3);
            this.tbToolbars.Controls.Add(this.groupBox4);
            this.tbToolbars.Controls.Add(this.groupBox5);
            this.tbToolbars.Controls.Add(this.groupBox6);
            this.tbToolbars.Controls.Add(this.groupBox7);
            this.tbToolbars.Controls.Add(this.groupBox8);
            this.tbToolbars.Controls.Add(this.groupBox9);
            this.tbToolbars.Location = new System.Drawing.Point(4, 22);
            this.tbToolbars.Name = "tbToolbars";
            this.tbToolbars.Size = new System.Drawing.Size(650, 470);
            this.tbToolbars.TabIndex = 3;
            this.tbToolbars.Text = "Toolbars";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbStandard);
            this.groupBox1.Controls.Add(this.tbStandardReportNew);
            this.groupBox1.Controls.Add(this.tbStandardReportOpen);
            this.groupBox1.Controls.Add(this.tbStandardReportSave);
            this.groupBox1.Controls.Add(this.tbStandardPageDelete);
            this.groupBox1.Controls.Add(this.tbStandardReportPreview);
            this.groupBox1.Controls.Add(this.tbStandardPageSetup);
            this.groupBox1.Controls.Add(this.tbStandardFormNew);
            this.groupBox1.Controls.Add(this.tbStandardPageNew);
            this.groupBox1.Controls.Add(this.tbStandardUndo);
            this.groupBox1.Controls.Add(this.tbStandardRedo);
            this.groupBox1.Controls.Add(this.tbStandardCut);
            this.groupBox1.Controls.Add(this.tbStandardPaste);
            this.groupBox1.Controls.Add(this.tbStandardDelete);
            this.groupBox1.Controls.Add(this.tbStandardSelectAll);
            this.groupBox1.Controls.Add(this.tbStandardCopy);
            this.groupBox1.Controls.Add(this.tbStandardShowGrid);
            this.groupBox1.Controls.Add(this.tbStandardAlignToGrid);
            this.groupBox1.Controls.Add(this.tbStandardShowHeaders);
            this.groupBox1.Controls.Add(this.tbStandardShowRulers);
            this.groupBox1.Controls.Add(this.tbStandardShowOrder);
            this.groupBox1.Controls.Add(this.tbStandardTableMode);
            this.groupBox1.Controls.Add(this.tbStandardClose);
            this.groupBox1.Controls.Add(this.tbStandardZoom);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Toolbar";
            // 
            // tbStandard
            // 
            this.tbStandard.Checked = true;
            this.tbStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandard.Location = new System.Drawing.Point(8, 16);
            this.tbStandard.Name = "tbStandard";
            this.tbStandard.Size = new System.Drawing.Size(136, 16);
            this.tbStandard.TabIndex = 0;
            this.tbStandard.Text = "Toolbar Visible";
            // 
            // tbStandardReportNew
            // 
            this.tbStandardReportNew.Checked = true;
            this.tbStandardReportNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardReportNew.Location = new System.Drawing.Point(8, 32);
            this.tbStandardReportNew.Name = "tbStandardReportNew";
            this.tbStandardReportNew.Size = new System.Drawing.Size(136, 16);
            this.tbStandardReportNew.TabIndex = 1;
            this.tbStandardReportNew.Text = "Report New";
            // 
            // tbStandardReportOpen
            // 
            this.tbStandardReportOpen.Checked = true;
            this.tbStandardReportOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardReportOpen.Location = new System.Drawing.Point(8, 48);
            this.tbStandardReportOpen.Name = "tbStandardReportOpen";
            this.tbStandardReportOpen.Size = new System.Drawing.Size(136, 16);
            this.tbStandardReportOpen.TabIndex = 2;
            this.tbStandardReportOpen.Text = "Report Open";
            // 
            // tbStandardReportSave
            // 
            this.tbStandardReportSave.Checked = true;
            this.tbStandardReportSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardReportSave.Location = new System.Drawing.Point(8, 64);
            this.tbStandardReportSave.Name = "tbStandardReportSave";
            this.tbStandardReportSave.Size = new System.Drawing.Size(136, 16);
            this.tbStandardReportSave.TabIndex = 3;
            this.tbStandardReportSave.Text = "Report Save";
            // 
            // tbStandardPageDelete
            // 
            this.tbStandardPageDelete.Checked = true;
            this.tbStandardPageDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardPageDelete.Location = new System.Drawing.Point(8, 128);
            this.tbStandardPageDelete.Name = "tbStandardPageDelete";
            this.tbStandardPageDelete.Size = new System.Drawing.Size(136, 16);
            this.tbStandardPageDelete.TabIndex = 7;
            this.tbStandardPageDelete.Text = "Page Delete";
            // 
            // tbStandardReportPreview
            // 
            this.tbStandardReportPreview.Checked = true;
            this.tbStandardReportPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardReportPreview.Location = new System.Drawing.Point(8, 80);
            this.tbStandardReportPreview.Name = "tbStandardReportPreview";
            this.tbStandardReportPreview.Size = new System.Drawing.Size(136, 16);
            this.tbStandardReportPreview.TabIndex = 4;
            this.tbStandardReportPreview.Text = "Report Preview";
            // 
            // tbStandardPageSetup
            // 
            this.tbStandardPageSetup.Checked = true;
            this.tbStandardPageSetup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardPageSetup.Location = new System.Drawing.Point(8, 144);
            this.tbStandardPageSetup.Name = "tbStandardPageSetup";
            this.tbStandardPageSetup.Size = new System.Drawing.Size(136, 16);
            this.tbStandardPageSetup.TabIndex = 8;
            this.tbStandardPageSetup.Text = "Page Setup";
            // 
            // tbStandardFormNew
            // 
            this.tbStandardFormNew.Checked = true;
            this.tbStandardFormNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardFormNew.Location = new System.Drawing.Point(8, 112);
            this.tbStandardFormNew.Name = "tbStandardFormNew";
            this.tbStandardFormNew.Size = new System.Drawing.Size(136, 16);
            this.tbStandardFormNew.TabIndex = 6;
            this.tbStandardFormNew.Text = "Form New";
            // 
            // tbStandardPageNew
            // 
            this.tbStandardPageNew.Checked = true;
            this.tbStandardPageNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardPageNew.Location = new System.Drawing.Point(8, 96);
            this.tbStandardPageNew.Name = "tbStandardPageNew";
            this.tbStandardPageNew.Size = new System.Drawing.Size(136, 16);
            this.tbStandardPageNew.TabIndex = 5;
            this.tbStandardPageNew.Text = "Page New";
            // 
            // tbStandardUndo
            // 
            this.tbStandardUndo.Checked = true;
            this.tbStandardUndo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardUndo.Location = new System.Drawing.Point(8, 160);
            this.tbStandardUndo.Name = "tbStandardUndo";
            this.tbStandardUndo.Size = new System.Drawing.Size(136, 16);
            this.tbStandardUndo.TabIndex = 9;
            this.tbStandardUndo.Text = "Undo";
            // 
            // tbStandardRedo
            // 
            this.tbStandardRedo.Checked = true;
            this.tbStandardRedo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardRedo.Location = new System.Drawing.Point(8, 176);
            this.tbStandardRedo.Name = "tbStandardRedo";
            this.tbStandardRedo.Size = new System.Drawing.Size(136, 16);
            this.tbStandardRedo.TabIndex = 10;
            this.tbStandardRedo.Text = "Redo";
            // 
            // tbStandardCut
            // 
            this.tbStandardCut.Checked = true;
            this.tbStandardCut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardCut.Location = new System.Drawing.Point(8, 192);
            this.tbStandardCut.Name = "tbStandardCut";
            this.tbStandardCut.Size = new System.Drawing.Size(136, 16);
            this.tbStandardCut.TabIndex = 11;
            this.tbStandardCut.Text = "Cut";
            // 
            // tbStandardPaste
            // 
            this.tbStandardPaste.Checked = true;
            this.tbStandardPaste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardPaste.Location = new System.Drawing.Point(8, 224);
            this.tbStandardPaste.Name = "tbStandardPaste";
            this.tbStandardPaste.Size = new System.Drawing.Size(136, 16);
            this.tbStandardPaste.TabIndex = 13;
            this.tbStandardPaste.Text = "Paste";
            // 
            // tbStandardDelete
            // 
            this.tbStandardDelete.Checked = true;
            this.tbStandardDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardDelete.Location = new System.Drawing.Point(8, 240);
            this.tbStandardDelete.Name = "tbStandardDelete";
            this.tbStandardDelete.Size = new System.Drawing.Size(136, 16);
            this.tbStandardDelete.TabIndex = 14;
            this.tbStandardDelete.Text = "Delete";
            // 
            // tbStandardSelectAll
            // 
            this.tbStandardSelectAll.Checked = true;
            this.tbStandardSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardSelectAll.Location = new System.Drawing.Point(8, 256);
            this.tbStandardSelectAll.Name = "tbStandardSelectAll";
            this.tbStandardSelectAll.Size = new System.Drawing.Size(136, 16);
            this.tbStandardSelectAll.TabIndex = 15;
            this.tbStandardSelectAll.Text = "Select All";
            // 
            // tbStandardCopy
            // 
            this.tbStandardCopy.Checked = true;
            this.tbStandardCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardCopy.Location = new System.Drawing.Point(8, 208);
            this.tbStandardCopy.Name = "tbStandardCopy";
            this.tbStandardCopy.Size = new System.Drawing.Size(136, 16);
            this.tbStandardCopy.TabIndex = 12;
            this.tbStandardCopy.Text = "Copy";
            // 
            // tbStandardShowGrid
            // 
            this.tbStandardShowGrid.Checked = true;
            this.tbStandardShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardShowGrid.Location = new System.Drawing.Point(8, 272);
            this.tbStandardShowGrid.Name = "tbStandardShowGrid";
            this.tbStandardShowGrid.Size = new System.Drawing.Size(136, 16);
            this.tbStandardShowGrid.TabIndex = 16;
            this.tbStandardShowGrid.Text = "Show Grid";
            // 
            // tbStandardAlignToGrid
            // 
            this.tbStandardAlignToGrid.Checked = true;
            this.tbStandardAlignToGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardAlignToGrid.Location = new System.Drawing.Point(8, 288);
            this.tbStandardAlignToGrid.Name = "tbStandardAlignToGrid";
            this.tbStandardAlignToGrid.Size = new System.Drawing.Size(136, 16);
            this.tbStandardAlignToGrid.TabIndex = 17;
            this.tbStandardAlignToGrid.Text = "Align to Grid";
            // 
            // tbStandardShowHeaders
            // 
            this.tbStandardShowHeaders.Checked = true;
            this.tbStandardShowHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardShowHeaders.Location = new System.Drawing.Point(8, 304);
            this.tbStandardShowHeaders.Name = "tbStandardShowHeaders";
            this.tbStandardShowHeaders.Size = new System.Drawing.Size(136, 16);
            this.tbStandardShowHeaders.TabIndex = 18;
            this.tbStandardShowHeaders.Text = "Show Headers";
            // 
            // tbStandardShowRulers
            // 
            this.tbStandardShowRulers.Checked = true;
            this.tbStandardShowRulers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardShowRulers.Location = new System.Drawing.Point(8, 320);
            this.tbStandardShowRulers.Name = "tbStandardShowRulers";
            this.tbStandardShowRulers.Size = new System.Drawing.Size(136, 16);
            this.tbStandardShowRulers.TabIndex = 19;
            this.tbStandardShowRulers.Text = "Show Rulers";
            // 
            // tbStandardShowOrder
            // 
            this.tbStandardShowOrder.Checked = true;
            this.tbStandardShowOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardShowOrder.Location = new System.Drawing.Point(8, 336);
            this.tbStandardShowOrder.Name = "tbStandardShowOrder";
            this.tbStandardShowOrder.Size = new System.Drawing.Size(136, 16);
            this.tbStandardShowOrder.TabIndex = 20;
            this.tbStandardShowOrder.Text = "Show Order";
            // 
            // tbStandardTableMode
            // 
            this.tbStandardTableMode.Checked = true;
            this.tbStandardTableMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardTableMode.Location = new System.Drawing.Point(8, 352);
            this.tbStandardTableMode.Name = "tbStandardTableMode";
            this.tbStandardTableMode.Size = new System.Drawing.Size(136, 16);
            this.tbStandardTableMode.TabIndex = 21;
            this.tbStandardTableMode.Text = "Table Mode";
            // 
            // tbStandardClose
            // 
            this.tbStandardClose.Checked = true;
            this.tbStandardClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardClose.Location = new System.Drawing.Point(8, 384);
            this.tbStandardClose.Name = "tbStandardClose";
            this.tbStandardClose.Size = new System.Drawing.Size(136, 16);
            this.tbStandardClose.TabIndex = 23;
            this.tbStandardClose.Text = "Close";
            // 
            // tbStandardZoom
            // 
            this.tbStandardZoom.Checked = true;
            this.tbStandardZoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStandardZoom.Location = new System.Drawing.Point(8, 368);
            this.tbStandardZoom.Name = "tbStandardZoom";
            this.tbStandardZoom.Size = new System.Drawing.Size(136, 16);
            this.tbStandardZoom.TabIndex = 22;
            this.tbStandardZoom.Text = "Zoom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLayoutAlignRight);
            this.groupBox2.Controls.Add(this.tbLayoutMoveForward);
            this.groupBox2.Controls.Add(this.tbLayoutCenterHorizontally);
            this.groupBox2.Controls.Add(this.tbLayoutMakeSameSize);
            this.groupBox2.Controls.Add(this.tbLayoutCenterVertically);
            this.groupBox2.Controls.Add(this.tbLayoutBringToFront);
            this.groupBox2.Controls.Add(this.tbLayoutAlignTop);
            this.groupBox2.Controls.Add(this.tbLayoutMakeSameWidth);
            this.groupBox2.Controls.Add(this.tbLayoutSendToBack);
            this.groupBox2.Controls.Add(this.tbLayoutMakeHorizontalSpacingEqual);
            this.groupBox2.Controls.Add(this.tbLayoutAlignBottom);
            this.groupBox2.Controls.Add(this.tbLayoutAlignMiddle);
            this.groupBox2.Controls.Add(this.tbLayoutMoveBackward);
            this.groupBox2.Controls.Add(this.tbLayoutMakeSameHeight);
            this.groupBox2.Controls.Add(this.tbLayoutAlignToGrid);
            this.groupBox2.Controls.Add(this.tbLayoutMakeVerticalSpacingEqual);
            this.groupBox2.Controls.Add(this.tbLayoutAlignLeft);
            this.groupBox2.Controls.Add(this.tbLayoutAlignCenter);
            this.groupBox2.Controls.Add(this.tbLayoutLink);
            this.groupBox2.Controls.Add(this.tbLayoutLock);
            this.groupBox2.Controls.Add(this.tbLayout);
            this.groupBox2.Location = new System.Drawing.Point(168, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Layout Toolbar";
            // 
            // tbLayoutAlignRight
            // 
            this.tbLayoutAlignRight.Checked = true;
            this.tbLayoutAlignRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignRight.Location = new System.Drawing.Point(8, 80);
            this.tbLayoutAlignRight.Name = "tbLayoutAlignRight";
            this.tbLayoutAlignRight.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignRight.TabIndex = 4;
            this.tbLayoutAlignRight.Text = "Align Right";
            // 
            // tbLayoutMoveForward
            // 
            this.tbLayoutMoveForward.Checked = true;
            this.tbLayoutMoveForward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMoveForward.Location = new System.Drawing.Point(8, 288);
            this.tbLayoutMoveForward.Name = "tbLayoutMoveForward";
            this.tbLayoutMoveForward.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMoveForward.TabIndex = 17;
            this.tbLayoutMoveForward.Text = "Move Forward";
            // 
            // tbLayoutCenterHorizontally
            // 
            this.tbLayoutCenterHorizontally.Checked = true;
            this.tbLayoutCenterHorizontally.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutCenterHorizontally.Location = new System.Drawing.Point(8, 240);
            this.tbLayoutCenterHorizontally.Name = "tbLayoutCenterHorizontally";
            this.tbLayoutCenterHorizontally.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutCenterHorizontally.TabIndex = 14;
            this.tbLayoutCenterHorizontally.Text = "Center Horizontally";
            // 
            // tbLayoutMakeSameSize
            // 
            this.tbLayoutMakeSameSize.Checked = true;
            this.tbLayoutMakeSameSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMakeSameSize.Location = new System.Drawing.Point(8, 144);
            this.tbLayoutMakeSameSize.Name = "tbLayoutMakeSameSize";
            this.tbLayoutMakeSameSize.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMakeSameSize.TabIndex = 8;
            this.tbLayoutMakeSameSize.Text = "Make Same Size";
            // 
            // tbLayoutCenterVertically
            // 
            this.tbLayoutCenterVertically.Checked = true;
            this.tbLayoutCenterVertically.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutCenterVertically.Location = new System.Drawing.Point(8, 224);
            this.tbLayoutCenterVertically.Name = "tbLayoutCenterVertically";
            this.tbLayoutCenterVertically.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutCenterVertically.TabIndex = 13;
            this.tbLayoutCenterVertically.Text = "Center Vertically";
            // 
            // tbLayoutBringToFront
            // 
            this.tbLayoutBringToFront.Checked = true;
            this.tbLayoutBringToFront.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutBringToFront.Location = new System.Drawing.Point(8, 256);
            this.tbLayoutBringToFront.Name = "tbLayoutBringToFront";
            this.tbLayoutBringToFront.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutBringToFront.TabIndex = 15;
            this.tbLayoutBringToFront.Text = "Bring to Front";
            // 
            // tbLayoutAlignTop
            // 
            this.tbLayoutAlignTop.Checked = true;
            this.tbLayoutAlignTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignTop.Location = new System.Drawing.Point(8, 96);
            this.tbLayoutAlignTop.Name = "tbLayoutAlignTop";
            this.tbLayoutAlignTop.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignTop.TabIndex = 5;
            this.tbLayoutAlignTop.Text = "Align Top";
            // 
            // tbLayoutMakeSameWidth
            // 
            this.tbLayoutMakeSameWidth.Checked = true;
            this.tbLayoutMakeSameWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMakeSameWidth.Location = new System.Drawing.Point(8, 160);
            this.tbLayoutMakeSameWidth.Name = "tbLayoutMakeSameWidth";
            this.tbLayoutMakeSameWidth.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMakeSameWidth.TabIndex = 9;
            this.tbLayoutMakeSameWidth.Text = "Make Same Width";
            // 
            // tbLayoutSendToBack
            // 
            this.tbLayoutSendToBack.Checked = true;
            this.tbLayoutSendToBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutSendToBack.Location = new System.Drawing.Point(8, 272);
            this.tbLayoutSendToBack.Name = "tbLayoutSendToBack";
            this.tbLayoutSendToBack.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutSendToBack.TabIndex = 16;
            this.tbLayoutSendToBack.Text = "Send to Back";
            // 
            // tbLayoutMakeHorizontalSpacingEqual
            // 
            this.tbLayoutMakeHorizontalSpacingEqual.Checked = true;
            this.tbLayoutMakeHorizontalSpacingEqual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMakeHorizontalSpacingEqual.Location = new System.Drawing.Point(8, 208);
            this.tbLayoutMakeHorizontalSpacingEqual.Name = "tbLayoutMakeHorizontalSpacingEqual";
            this.tbLayoutMakeHorizontalSpacingEqual.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMakeHorizontalSpacingEqual.TabIndex = 12;
            this.tbLayoutMakeHorizontalSpacingEqual.Text = "Make Horizontal Spacing Equal";
            // 
            // tbLayoutAlignBottom
            // 
            this.tbLayoutAlignBottom.Checked = true;
            this.tbLayoutAlignBottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignBottom.Location = new System.Drawing.Point(8, 128);
            this.tbLayoutAlignBottom.Name = "tbLayoutAlignBottom";
            this.tbLayoutAlignBottom.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignBottom.TabIndex = 7;
            this.tbLayoutAlignBottom.Text = "Align Bottom";
            // 
            // tbLayoutAlignMiddle
            // 
            this.tbLayoutAlignMiddle.Checked = true;
            this.tbLayoutAlignMiddle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignMiddle.Location = new System.Drawing.Point(8, 112);
            this.tbLayoutAlignMiddle.Name = "tbLayoutAlignMiddle";
            this.tbLayoutAlignMiddle.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignMiddle.TabIndex = 6;
            this.tbLayoutAlignMiddle.Text = "Align Middle";
            // 
            // tbLayoutMoveBackward
            // 
            this.tbLayoutMoveBackward.Checked = true;
            this.tbLayoutMoveBackward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMoveBackward.Location = new System.Drawing.Point(8, 304);
            this.tbLayoutMoveBackward.Name = "tbLayoutMoveBackward";
            this.tbLayoutMoveBackward.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMoveBackward.TabIndex = 18;
            this.tbLayoutMoveBackward.Text = "Move Backward";
            // 
            // tbLayoutMakeSameHeight
            // 
            this.tbLayoutMakeSameHeight.Checked = true;
            this.tbLayoutMakeSameHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMakeSameHeight.Location = new System.Drawing.Point(8, 176);
            this.tbLayoutMakeSameHeight.Name = "tbLayoutMakeSameHeight";
            this.tbLayoutMakeSameHeight.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMakeSameHeight.TabIndex = 10;
            this.tbLayoutMakeSameHeight.Text = "Make Same Height";
            // 
            // tbLayoutAlignToGrid
            // 
            this.tbLayoutAlignToGrid.Checked = true;
            this.tbLayoutAlignToGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignToGrid.Location = new System.Drawing.Point(8, 32);
            this.tbLayoutAlignToGrid.Name = "tbLayoutAlignToGrid";
            this.tbLayoutAlignToGrid.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignToGrid.TabIndex = 1;
            this.tbLayoutAlignToGrid.Text = "Align to Grid";
            // 
            // tbLayoutMakeVerticalSpacingEqual
            // 
            this.tbLayoutMakeVerticalSpacingEqual.Checked = true;
            this.tbLayoutMakeVerticalSpacingEqual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutMakeVerticalSpacingEqual.Location = new System.Drawing.Point(8, 192);
            this.tbLayoutMakeVerticalSpacingEqual.Name = "tbLayoutMakeVerticalSpacingEqual";
            this.tbLayoutMakeVerticalSpacingEqual.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutMakeVerticalSpacingEqual.TabIndex = 11;
            this.tbLayoutMakeVerticalSpacingEqual.Text = "Make Vertical Spacing Equal";
            // 
            // tbLayoutAlignLeft
            // 
            this.tbLayoutAlignLeft.Checked = true;
            this.tbLayoutAlignLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignLeft.Location = new System.Drawing.Point(8, 48);
            this.tbLayoutAlignLeft.Name = "tbLayoutAlignLeft";
            this.tbLayoutAlignLeft.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignLeft.TabIndex = 2;
            this.tbLayoutAlignLeft.Text = "Align Left";
            // 
            // tbLayoutAlignCenter
            // 
            this.tbLayoutAlignCenter.Checked = true;
            this.tbLayoutAlignCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutAlignCenter.Location = new System.Drawing.Point(8, 64);
            this.tbLayoutAlignCenter.Name = "tbLayoutAlignCenter";
            this.tbLayoutAlignCenter.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutAlignCenter.TabIndex = 3;
            this.tbLayoutAlignCenter.Text = "Align Center";
            // 
            // tbLayoutLink
            // 
            this.tbLayoutLink.Checked = true;
            this.tbLayoutLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutLink.Location = new System.Drawing.Point(8, 336);
            this.tbLayoutLink.Name = "tbLayoutLink";
            this.tbLayoutLink.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutLink.TabIndex = 20;
            this.tbLayoutLink.Text = "Link";
            // 
            // tbLayoutLock
            // 
            this.tbLayoutLock.Checked = true;
            this.tbLayoutLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayoutLock.Location = new System.Drawing.Point(8, 320);
            this.tbLayoutLock.Name = "tbLayoutLock";
            this.tbLayoutLock.Size = new System.Drawing.Size(136, 16);
            this.tbLayoutLock.TabIndex = 19;
            this.tbLayoutLock.Text = "Lock";
            // 
            // tbLayout
            // 
            this.tbLayout.Checked = true;
            this.tbLayout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbLayout.Location = new System.Drawing.Point(8, 16);
            this.tbLayout.Name = "tbLayout";
            this.tbLayout.Size = new System.Drawing.Size(136, 16);
            this.tbLayout.TabIndex = 0;
            this.tbLayout.Text = "Toolbar Visible";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbFormatting);
            this.groupBox3.Controls.Add(this.tbFormattingAlignCenter);
            this.groupBox3.Controls.Add(this.tbFormattingAlignLeft);
            this.groupBox3.Controls.Add(this.tbFormattingAlignRight);
            this.groupBox3.Controls.Add(this.tbFormattingAlignWidth);
            this.groupBox3.Controls.Add(this.tbFormattingAlignMiddle);
            this.groupBox3.Controls.Add(this.tbFormattingAlignBottom);
            this.groupBox3.Controls.Add(this.tbFormattingAlignTop);
            this.groupBox3.Controls.Add(this.tbFormattingFont);
            this.groupBox3.Controls.Add(this.tbFormattingBold);
            this.groupBox3.Controls.Add(this.tbFormattingFontSize);
            this.groupBox3.Controls.Add(this.tbFormattingItalic);
            this.groupBox3.Controls.Add(this.tbFormattingUnderline);
            this.groupBox3.Controls.Add(this.tbFormattingTextBrush);
            this.groupBox3.Controls.Add(this.tbFormattingRotateText);
            this.groupBox3.Controls.Add(this.tbFormattingConditions);
            this.groupBox3.Location = new System.Drawing.Point(328, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 281);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formatting Toolbar";
            // 
            // tbFormatting
            // 
            this.tbFormatting.Checked = true;
            this.tbFormatting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormatting.Location = new System.Drawing.Point(8, 16);
            this.tbFormatting.Name = "tbFormatting";
            this.tbFormatting.Size = new System.Drawing.Size(136, 16);
            this.tbFormatting.TabIndex = 0;
            this.tbFormatting.Text = "Toolbar Visible";
            // 
            // tbFormattingAlignCenter
            // 
            this.tbFormattingAlignCenter.Checked = true;
            this.tbFormattingAlignCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignCenter.Location = new System.Drawing.Point(8, 144);
            this.tbFormattingAlignCenter.Name = "tbFormattingAlignCenter";
            this.tbFormattingAlignCenter.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignCenter.TabIndex = 8;
            this.tbFormattingAlignCenter.Text = "Align Center";
            // 
            // tbFormattingAlignLeft
            // 
            this.tbFormattingAlignLeft.Checked = true;
            this.tbFormattingAlignLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignLeft.Location = new System.Drawing.Point(8, 128);
            this.tbFormattingAlignLeft.Name = "tbFormattingAlignLeft";
            this.tbFormattingAlignLeft.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignLeft.TabIndex = 7;
            this.tbFormattingAlignLeft.Text = "Align Left";
            // 
            // tbFormattingAlignRight
            // 
            this.tbFormattingAlignRight.Checked = true;
            this.tbFormattingAlignRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignRight.Location = new System.Drawing.Point(8, 160);
            this.tbFormattingAlignRight.Name = "tbFormattingAlignRight";
            this.tbFormattingAlignRight.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignRight.TabIndex = 9;
            this.tbFormattingAlignRight.Text = "Align Right";
            // 
            // tbFormattingAlignWidth
            // 
            this.tbFormattingAlignWidth.Checked = true;
            this.tbFormattingAlignWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignWidth.Location = new System.Drawing.Point(8, 176);
            this.tbFormattingAlignWidth.Name = "tbFormattingAlignWidth";
            this.tbFormattingAlignWidth.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignWidth.TabIndex = 10;
            this.tbFormattingAlignWidth.Text = "Align Width";
            // 
            // tbFormattingAlignMiddle
            // 
            this.tbFormattingAlignMiddle.Checked = true;
            this.tbFormattingAlignMiddle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignMiddle.Location = new System.Drawing.Point(8, 208);
            this.tbFormattingAlignMiddle.Name = "tbFormattingAlignMiddle";
            this.tbFormattingAlignMiddle.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignMiddle.TabIndex = 12;
            this.tbFormattingAlignMiddle.Text = "Align Middle";
            // 
            // tbFormattingAlignBottom
            // 
            this.tbFormattingAlignBottom.Checked = true;
            this.tbFormattingAlignBottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignBottom.Location = new System.Drawing.Point(8, 224);
            this.tbFormattingAlignBottom.Name = "tbFormattingAlignBottom";
            this.tbFormattingAlignBottom.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignBottom.TabIndex = 13;
            this.tbFormattingAlignBottom.Text = "Align Bottom";
            // 
            // tbFormattingAlignTop
            // 
            this.tbFormattingAlignTop.Checked = true;
            this.tbFormattingAlignTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingAlignTop.Location = new System.Drawing.Point(8, 192);
            this.tbFormattingAlignTop.Name = "tbFormattingAlignTop";
            this.tbFormattingAlignTop.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingAlignTop.TabIndex = 11;
            this.tbFormattingAlignTop.Text = "Align Top";
            // 
            // tbFormattingFont
            // 
            this.tbFormattingFont.Checked = true;
            this.tbFormattingFont.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingFont.Location = new System.Drawing.Point(8, 32);
            this.tbFormattingFont.Name = "tbFormattingFont";
            this.tbFormattingFont.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingFont.TabIndex = 1;
            this.tbFormattingFont.Text = "Font";
            // 
            // tbFormattingBold
            // 
            this.tbFormattingBold.Checked = true;
            this.tbFormattingBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingBold.Location = new System.Drawing.Point(8, 80);
            this.tbFormattingBold.Name = "tbFormattingBold";
            this.tbFormattingBold.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingBold.TabIndex = 4;
            this.tbFormattingBold.Text = "Bold";
            // 
            // tbFormattingFontSize
            // 
            this.tbFormattingFontSize.Checked = true;
            this.tbFormattingFontSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingFontSize.Location = new System.Drawing.Point(8, 48);
            this.tbFormattingFontSize.Name = "tbFormattingFontSize";
            this.tbFormattingFontSize.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingFontSize.TabIndex = 2;
            this.tbFormattingFontSize.Text = "FontSize";
            // 
            // tbFormattingItalic
            // 
            this.tbFormattingItalic.Checked = true;
            this.tbFormattingItalic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingItalic.Location = new System.Drawing.Point(8, 96);
            this.tbFormattingItalic.Name = "tbFormattingItalic";
            this.tbFormattingItalic.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingItalic.TabIndex = 5;
            this.tbFormattingItalic.Text = "Italic";
            // 
            // tbFormattingUnderline
            // 
            this.tbFormattingUnderline.Checked = true;
            this.tbFormattingUnderline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingUnderline.Location = new System.Drawing.Point(8, 112);
            this.tbFormattingUnderline.Name = "tbFormattingUnderline";
            this.tbFormattingUnderline.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingUnderline.TabIndex = 6;
            this.tbFormattingUnderline.Text = "Underline";
            // 
            // tbFormattingTextBrush
            // 
            this.tbFormattingTextBrush.Checked = true;
            this.tbFormattingTextBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingTextBrush.Location = new System.Drawing.Point(8, 64);
            this.tbFormattingTextBrush.Name = "tbFormattingTextBrush";
            this.tbFormattingTextBrush.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingTextBrush.TabIndex = 3;
            this.tbFormattingTextBrush.Text = "Text Brush";
            // 
            // tbFormattingRotateText
            // 
            this.tbFormattingRotateText.Checked = true;
            this.tbFormattingRotateText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingRotateText.Location = new System.Drawing.Point(8, 240);
            this.tbFormattingRotateText.Name = "tbFormattingRotateText";
            this.tbFormattingRotateText.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingRotateText.TabIndex = 14;
            this.tbFormattingRotateText.Text = "Rotate Text";
            // 
            // tbFormattingConditions
            // 
            this.tbFormattingConditions.Checked = true;
            this.tbFormattingConditions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbFormattingConditions.Location = new System.Drawing.Point(8, 256);
            this.tbFormattingConditions.Name = "tbFormattingConditions";
            this.tbFormattingConditions.Size = new System.Drawing.Size(136, 16);
            this.tbFormattingConditions.TabIndex = 15;
            this.tbFormattingConditions.Text = "Conditions";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbTools);
            this.groupBox4.Controls.Add(this.tbToolsModifiers);
            this.groupBox4.Controls.Add(this.tbToolsPagesManager);
            this.groupBox4.Controls.Add(this.tbToolsDataStore);
            this.groupBox4.Location = new System.Drawing.Point(328, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 88);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tools Toolbar";
            // 
            // tbTools
            // 
            this.tbTools.Checked = true;
            this.tbTools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbTools.Location = new System.Drawing.Point(8, 16);
            this.tbTools.Name = "tbTools";
            this.tbTools.Size = new System.Drawing.Size(136, 16);
            this.tbTools.TabIndex = 0;
            this.tbTools.Text = "Toolbar Visible";
            // 
            // tbToolsModifiers
            // 
            this.tbToolsModifiers.Checked = true;
            this.tbToolsModifiers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbToolsModifiers.Location = new System.Drawing.Point(8, 32);
            this.tbToolsModifiers.Name = "tbToolsModifiers";
            this.tbToolsModifiers.Size = new System.Drawing.Size(136, 16);
            this.tbToolsModifiers.TabIndex = 1;
            this.tbToolsModifiers.Text = "Modifiers";
            // 
            // tbToolsPagesManager
            // 
            this.tbToolsPagesManager.Checked = true;
            this.tbToolsPagesManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbToolsPagesManager.Location = new System.Drawing.Point(8, 48);
            this.tbToolsPagesManager.Name = "tbToolsPagesManager";
            this.tbToolsPagesManager.Size = new System.Drawing.Size(136, 16);
            this.tbToolsPagesManager.TabIndex = 2;
            this.tbToolsPagesManager.Text = "Pages Manager";
            // 
            // tbToolsDataStore
            // 
            this.tbToolsDataStore.Checked = true;
            this.tbToolsDataStore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbToolsDataStore.Location = new System.Drawing.Point(8, 64);
            this.tbToolsDataStore.Name = "tbToolsDataStore";
            this.tbToolsDataStore.Size = new System.Drawing.Size(136, 16);
            this.tbToolsDataStore.TabIndex = 3;
            this.tbToolsDataStore.Text = "Data Store";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbDockStyleFill);
            this.groupBox5.Controls.Add(this.tbDockStyleNone);
            this.groupBox5.Controls.Add(this.tbDockStyleLeft);
            this.groupBox5.Controls.Add(this.tbDockStyleBottom);
            this.groupBox5.Controls.Add(this.tbDockStyleRight);
            this.groupBox5.Controls.Add(this.tbDockStyleTop);
            this.groupBox5.Controls.Add(this.tbDockStyle);
            this.groupBox5.Location = new System.Drawing.Point(488, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 137);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DockStyle Toolbar";
            // 
            // tbDockStyleFill
            // 
            this.tbDockStyleFill.Checked = true;
            this.tbDockStyleFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyleFill.Location = new System.Drawing.Point(8, 32);
            this.tbDockStyleFill.Name = "tbDockStyleFill";
            this.tbDockStyleFill.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyleFill.TabIndex = 1;
            this.tbDockStyleFill.Text = "DockStyle All";
            // 
            // tbDockStyleNone
            // 
            this.tbDockStyleNone.Checked = true;
            this.tbDockStyleNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyleNone.Location = new System.Drawing.Point(8, 48);
            this.tbDockStyleNone.Name = "tbDockStyleNone";
            this.tbDockStyleNone.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyleNone.TabIndex = 2;
            this.tbDockStyleNone.Text = "DockStyle None";
            // 
            // tbDockStyleLeft
            // 
            this.tbDockStyleLeft.Checked = true;
            this.tbDockStyleLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyleLeft.Location = new System.Drawing.Point(8, 80);
            this.tbDockStyleLeft.Name = "tbDockStyleLeft";
            this.tbDockStyleLeft.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyleLeft.TabIndex = 4;
            this.tbDockStyleLeft.Text = "DockStyle Left";
            // 
            // tbDockStyleBottom
            // 
            this.tbDockStyleBottom.Checked = true;
            this.tbDockStyleBottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyleBottom.Location = new System.Drawing.Point(8, 96);
            this.tbDockStyleBottom.Name = "tbDockStyleBottom";
            this.tbDockStyleBottom.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyleBottom.TabIndex = 5;
            this.tbDockStyleBottom.Text = "DockStyle Bottom";
            // 
            // tbDockStyleRight
            // 
            this.tbDockStyleRight.Checked = true;
            this.tbDockStyleRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyleRight.Location = new System.Drawing.Point(8, 112);
            this.tbDockStyleRight.Name = "tbDockStyleRight";
            this.tbDockStyleRight.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyleRight.TabIndex = 6;
            this.tbDockStyleRight.Text = "DockStyle Right";
            // 
            // tbDockStyleTop
            // 
            this.tbDockStyleTop.Checked = true;
            this.tbDockStyleTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyleTop.Location = new System.Drawing.Point(8, 64);
            this.tbDockStyleTop.Name = "tbDockStyleTop";
            this.tbDockStyleTop.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyleTop.TabIndex = 3;
            this.tbDockStyleTop.Text = "DockStyle Top";
            // 
            // tbDockStyle
            // 
            this.tbDockStyle.Checked = true;
            this.tbDockStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDockStyle.Location = new System.Drawing.Point(8, 16);
            this.tbDockStyle.Name = "tbDockStyle";
            this.tbDockStyle.Size = new System.Drawing.Size(136, 16);
            this.tbDockStyle.TabIndex = 0;
            this.tbDockStyle.Text = "Toolbar Visible";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbBordersAll);
            this.groupBox6.Controls.Add(this.tbBordersNone);
            this.groupBox6.Controls.Add(this.tbBordersLeft);
            this.groupBox6.Controls.Add(this.tbBordersBottom);
            this.groupBox6.Controls.Add(this.tbBordersRight);
            this.groupBox6.Controls.Add(this.tbBordersTop);
            this.groupBox6.Controls.Add(this.tbBordersShadow);
            this.groupBox6.Controls.Add(this.tbBordersFillBrush);
            this.groupBox6.Controls.Add(this.tbBordersColor);
            this.groupBox6.Controls.Add(this.tbBordersStyle);
            this.groupBox6.Controls.Add(this.tbBorders);
            this.groupBox6.Location = new System.Drawing.Point(488, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(152, 200);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Borders Toolbar";
            // 
            // tbBordersAll
            // 
            this.tbBordersAll.Checked = true;
            this.tbBordersAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersAll.Location = new System.Drawing.Point(8, 32);
            this.tbBordersAll.Name = "tbBordersAll";
            this.tbBordersAll.Size = new System.Drawing.Size(136, 16);
            this.tbBordersAll.TabIndex = 1;
            this.tbBordersAll.Text = "Border All";
            // 
            // tbBordersNone
            // 
            this.tbBordersNone.Checked = true;
            this.tbBordersNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersNone.Location = new System.Drawing.Point(8, 48);
            this.tbBordersNone.Name = "tbBordersNone";
            this.tbBordersNone.Size = new System.Drawing.Size(136, 16);
            this.tbBordersNone.TabIndex = 2;
            this.tbBordersNone.Text = "Border None";
            // 
            // tbBordersLeft
            // 
            this.tbBordersLeft.Checked = true;
            this.tbBordersLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersLeft.Location = new System.Drawing.Point(8, 80);
            this.tbBordersLeft.Name = "tbBordersLeft";
            this.tbBordersLeft.Size = new System.Drawing.Size(136, 16);
            this.tbBordersLeft.TabIndex = 4;
            this.tbBordersLeft.Text = "Border Left";
            // 
            // tbBordersBottom
            // 
            this.tbBordersBottom.Checked = true;
            this.tbBordersBottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersBottom.Location = new System.Drawing.Point(8, 96);
            this.tbBordersBottom.Name = "tbBordersBottom";
            this.tbBordersBottom.Size = new System.Drawing.Size(136, 16);
            this.tbBordersBottom.TabIndex = 5;
            this.tbBordersBottom.Text = "Border Bottom";
            // 
            // tbBordersRight
            // 
            this.tbBordersRight.Checked = true;
            this.tbBordersRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersRight.Location = new System.Drawing.Point(8, 112);
            this.tbBordersRight.Name = "tbBordersRight";
            this.tbBordersRight.Size = new System.Drawing.Size(136, 16);
            this.tbBordersRight.TabIndex = 6;
            this.tbBordersRight.Text = "Border Right";
            // 
            // tbBordersTop
            // 
            this.tbBordersTop.Checked = true;
            this.tbBordersTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersTop.Location = new System.Drawing.Point(8, 64);
            this.tbBordersTop.Name = "tbBordersTop";
            this.tbBordersTop.Size = new System.Drawing.Size(136, 16);
            this.tbBordersTop.TabIndex = 3;
            this.tbBordersTop.Text = "Border Top";
            // 
            // tbBordersShadow
            // 
            this.tbBordersShadow.Checked = true;
            this.tbBordersShadow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersShadow.Location = new System.Drawing.Point(8, 128);
            this.tbBordersShadow.Name = "tbBordersShadow";
            this.tbBordersShadow.Size = new System.Drawing.Size(136, 16);
            this.tbBordersShadow.TabIndex = 7;
            this.tbBordersShadow.Text = "Border Shadow";
            // 
            // tbBordersFillBrush
            // 
            this.tbBordersFillBrush.Checked = true;
            this.tbBordersFillBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersFillBrush.Location = new System.Drawing.Point(8, 144);
            this.tbBordersFillBrush.Name = "tbBordersFillBrush";
            this.tbBordersFillBrush.Size = new System.Drawing.Size(136, 16);
            this.tbBordersFillBrush.TabIndex = 8;
            this.tbBordersFillBrush.Text = "Fill Brush";
            // 
            // tbBordersColor
            // 
            this.tbBordersColor.Checked = true;
            this.tbBordersColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersColor.Location = new System.Drawing.Point(8, 160);
            this.tbBordersColor.Name = "tbBordersColor";
            this.tbBordersColor.Size = new System.Drawing.Size(136, 16);
            this.tbBordersColor.TabIndex = 9;
            this.tbBordersColor.Text = "Border Color";
            // 
            // tbBordersStyle
            // 
            this.tbBordersStyle.Checked = true;
            this.tbBordersStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBordersStyle.Location = new System.Drawing.Point(8, 176);
            this.tbBordersStyle.Name = "tbBordersStyle";
            this.tbBordersStyle.Size = new System.Drawing.Size(136, 16);
            this.tbBordersStyle.TabIndex = 10;
            this.tbBordersStyle.Text = "Border Style";
            // 
            // tbBorders
            // 
            this.tbBorders.Checked = true;
            this.tbBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbBorders.Location = new System.Drawing.Point(8, 16);
            this.tbBorders.Name = "tbBorders";
            this.tbBorders.Size = new System.Drawing.Size(136, 16);
            this.tbBorders.TabIndex = 0;
            this.tbBorders.Text = "Toolbar Visible";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbStyleDesigner);
            this.groupBox7.Controls.Add(this.tbStyle);
            this.groupBox7.Controls.Add(this.tbStyleStyles);
            this.groupBox7.Location = new System.Drawing.Point(488, 360);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(152, 72);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Style Toolbar";
            // 
            // tbStyleDesigner
            // 
            this.tbStyleDesigner.Checked = true;
            this.tbStyleDesigner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStyleDesigner.Location = new System.Drawing.Point(8, 32);
            this.tbStyleDesigner.Name = "tbStyleDesigner";
            this.tbStyleDesigner.Size = new System.Drawing.Size(136, 16);
            this.tbStyleDesigner.TabIndex = 1;
            this.tbStyleDesigner.Text = "Style Designer";
            // 
            // tbStyle
            // 
            this.tbStyle.Checked = true;
            this.tbStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStyle.Location = new System.Drawing.Point(8, 16);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(136, 16);
            this.tbStyle.TabIndex = 0;
            this.tbStyle.Text = "Toolbar Visible";
            // 
            // tbStyleStyles
            // 
            this.tbStyleStyles.Checked = true;
            this.tbStyleStyles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbStyleStyles.Location = new System.Drawing.Point(8, 48);
            this.tbStyleStyles.Name = "tbStyleStyles";
            this.tbStyleStyles.Size = new System.Drawing.Size(136, 16);
            this.tbStyleStyles.TabIndex = 3;
            this.tbStyleStyles.Text = "Styles";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbTextFormat);
            this.groupBox8.Location = new System.Drawing.Point(168, 376);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(152, 40);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "TextFormat Toolbar";
            // 
            // tbTextFormat
            // 
            this.tbTextFormat.Checked = true;
            this.tbTextFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbTextFormat.Location = new System.Drawing.Point(8, 16);
            this.tbTextFormat.Name = "tbTextFormat";
            this.tbTextFormat.Size = new System.Drawing.Size(136, 16);
            this.tbTextFormat.TabIndex = 0;
            this.tbTextFormat.Text = "Toolbar Visible";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbToolbox);
            this.groupBox9.Location = new System.Drawing.Point(168, 424);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(152, 40);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Toolbox Toolbar";
            // 
            // tbToolbox
            // 
            this.tbToolbox.Checked = true;
            this.tbToolbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbToolbox.Location = new System.Drawing.Point(8, 16);
            this.tbToolbox.Name = "tbToolbox";
            this.tbToolbox.Size = new System.Drawing.Size(136, 16);
            this.tbToolbox.TabIndex = 0;
            this.tbToolbox.Text = "Toolbar Visible";
            // 
            // Form1
            // 
            this.AcceptButton = this.btRunDesigner;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btRunDesigner;
            this.ClientSize = new System.Drawing.Size(658, 540);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btRunDesigner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Reports Designer";
            this.gbMenuFile.ResumeLayout(false);
            this.gbMenuEdit.ResumeLayout(false);
            this.gbMenuView.ResumeLayout(false);
            this.gbMenuTools.ResumeLayout(false);
            this.gbMenuHelp.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbMainMenu.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.gbAboutBoxType.ResumeLayout(false);
            this.tbContextMenu.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tbToolbars.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}


		private void btRunDesigner_Click(object sender, System.EventArgs e)
		{
			StiReport report = new StiReport();

			#region Update Config
			StiMainMenuService mainMenu = StiConfig.Services.GetService(typeof(StiMainMenuService)) as 
				StiMainMenuService;

			#region Help Menu Management
			if (mainMenu != null)
			{
				mainMenu.FaqPage = tbFaqPage.Text;
				mainMenu.ProductHomePage = tbProductHomePage.Text;
				mainMenu.Support = tbSupport.Text;

				if (rbAboutBoxTypeStandard.Checked)mainMenu.AboutForm = new StiAboutForm();
				else mainMenu.AboutForm = new MyAboutForm();
			}
			#endregion

			#region Main Menu
			if (mainMenu != null)
			{
				#region File
				mainMenu.ShowFile =					cbShowFile.Checked;
				mainMenu.ShowFileReportNew =		cbShowFileReportNew.Checked;
				mainMenu.ShowFilePageNew =			cbShowFilePageNew.Checked;
				mainMenu.ShowFileFormNew =			cbShowFileFormNew.Checked;
				mainMenu.ShowFileReportOpen =		cbShowFileReportOpen.Checked;
				mainMenu.ShowFilePageOpen =			cbShowFilePageOpen.Checked;
				mainMenu.ShowFileReportSave =		cbShowFileReportSave.Checked;
				mainMenu.ShowFileReportSaveAs =		cbShowFileReportSaveAs.Checked;
				mainMenu.ShowFilePageSaveAs =		cbShowFilePageSaveAs.Checked;
				mainMenu.ShowFilePageDelete =		cbShowFilePageDelete.Checked;
				mainMenu.ShowFileReportPreview =	cbShowFileReportPreview.Checked;
				mainMenu.ShowFilePageSetup =		cbShowFilePageSetup.Checked;
				mainMenu.ShowFileReportSetup =		cbShowFileReportSetup.Checked;
				mainMenu.ShowFileRecentFiles =		cbShowFileRecentFiles.Checked;
				mainMenu.ShowFileExit =				cbShowFileExit.Checked;
				#endregion

				#region Edit
				mainMenu.ShowEdit =					cbShowEdit.Checked;
				mainMenu.ShowEditUndo =				cbShowEditUndo.Checked;
				mainMenu.ShowEditRedo =				cbShowEditRedo.Checked;
				mainMenu.ShowEditCut =				cbShowEditCut.Checked;
				mainMenu.ShowEditCopy =				cbShowEditCopy.Checked;
				mainMenu.ShowEditPaste =			cbShowEditPaste.Checked;
				mainMenu.ShowEditDelete =			cbShowEditDelete.Checked;
				mainMenu.ShowEditSelectAll =		cbShowEditSelectAll.Checked;
				mainMenu.ShowEditClearContents =	cbShowEditClearContents.Checked;
				#endregion

				#region View
				mainMenu.ShowView =						cbShowView.Checked;
				mainMenu.ShowViewNormal =				cbShowViewNormal.Checked;
				mainMenu.ShowViewPageBreakPreview =		cbShowViewPageBreakPreview.Checked;
				mainMenu.ShowViewShowGrid =				cbShowViewShowGrid.Checked;
				mainMenu.ShowViewAlignToGrid =			cbShowViewAlignToGrid.Checked;
				mainMenu.ShowViewShowHeaders =			cbShowViewShowHeaders.Checked;
				mainMenu.ShowViewShowRulers =			cbShowViewShowRulers.Checked;
				mainMenu.ShowViewShowOrder =			cbShowViewShowOrder.Checked;
				mainMenu.ShowViewToolbars =				cbShowViewToolbars.Checked;
				mainMenu.ShowViewPanels =				cbShowViewPanels.Checked;
				#endregion

				#region Tools
				mainMenu.ShowTools =						cbShowTools.Checked;
				mainMenu.ShowToolsDataStore =				cbShowToolsDataStore.Checked;
				mainMenu.ShowToolsPagesManager =			cbShowToolsPagesManager.Checked;
				mainMenu.ShowToolsOptions =					cbShowToolsOptions.Checked;
				#endregion

				#region Help
				mainMenu.ShowHelp =					cbShowHelp.Checked;
				mainMenu.ShowHelpProductHomePage =	cbShowHelpProductHomePage.Checked;
				mainMenu.ShowHelpFaqPage =			cbShowHelpFaqPage.Checked;
				mainMenu.ShowHelpSupport =			cbShowHelpSupport.Checked;
				mainMenu.ShowHelpAboutProgramm =	cbShowHelpAboutProgramm.Checked;
				#endregion
			}
			#endregion

			#region Toolbars
			#region Standard Toolbar
			StiStandardToolbarService standardToolbar = StiStandardToolbarService.GetService();
			
			if (standardToolbar != null)
			{
				standardToolbar.ServiceEnabled = tbStandard.Checked;
			
				standardToolbar.ShowReportNew =		tbStandardReportNew.Checked;
				standardToolbar.ShowReportOpen =	tbStandardReportOpen.Checked;
				standardToolbar.ShowReportSave =	tbStandardReportSave.Checked;
				standardToolbar.ShowReportPreview = tbStandardReportPreview.Checked;
				standardToolbar.ShowPageNew =		tbStandardPageNew.Checked;
				standardToolbar.ShowFormNew =		tbStandardFormNew.Checked;
				standardToolbar.ShowPageDelete =	tbStandardPageDelete.Checked;
				standardToolbar.ShowPageSetup =		tbStandardPageSetup.Checked;
				standardToolbar.ShowUndo =			tbStandardUndo.Checked;
				standardToolbar.ShowRedo =			tbStandardRedo.Checked;
				standardToolbar.ShowCut =			tbStandardCut.Checked;
				standardToolbar.ShowCopy =			tbStandardCopy.Checked;
				standardToolbar.ShowPaste =			tbStandardPaste.Checked;
				standardToolbar.ShowDelete =		tbStandardDelete.Checked;
				standardToolbar.ShowSelectAll =		tbStandardSelectAll.Checked;
				standardToolbar.ShowShowGrid =		tbStandardShowGrid.Checked;
				standardToolbar.ShowAlignToGrid =	tbStandardAlignToGrid.Checked;
				standardToolbar.ShowShowHeaders =	tbStandardShowHeaders.Checked;
				standardToolbar.ShowShowRulers =	tbStandardShowRulers.Checked;
				standardToolbar.ShowShowOrder =		tbStandardShowOrder.Checked;
				standardToolbar.ShowZoom =			tbStandardZoom.Checked;
				standardToolbar.ShowClose =			tbStandardClose.Checked;
			}
			#endregion

			#region Layout Toolbar
			StiLayoutToolbarService layoutToolbar = StiLayoutToolbarService.GetService();

			if (layoutToolbar != null)
			{			
				layoutToolbar.ServiceEnabled =					tbLayout.Checked;
			
				layoutToolbar.ShowAlignToGrid =					tbLayoutAlignToGrid.Checked;
				layoutToolbar.ShowAlignLeft =					tbLayoutAlignLeft.Checked;
				layoutToolbar.ShowAlignCenter =					tbLayoutAlignCenter.Checked;
				layoutToolbar.ShowAlignRight =					tbLayoutAlignRight.Checked;
				layoutToolbar.ShowAlignTop =					tbLayoutAlignTop.Checked;
				layoutToolbar.ShowAlignMiddle =					tbLayoutAlignMiddle.Checked;
				layoutToolbar.ShowAlignBottom =					tbLayoutAlignBottom.Checked;
				layoutToolbar.ShowMakeSameSize =				tbLayoutMakeSameSize.Checked;
				layoutToolbar.ShowMakeSameWidth =				tbLayoutMakeSameWidth.Checked;
				layoutToolbar.ShowMakeSameHeight =				tbLayoutMakeSameHeight.Checked;
				layoutToolbar.ShowMakeHorizontalSpacingEqual =	tbLayoutMakeHorizontalSpacingEqual.Checked;
				layoutToolbar.ShowMakeVerticalSpacingEqual =	tbLayoutMakeVerticalSpacingEqual.Checked;
				layoutToolbar.ShowCenterHorizontally =			tbLayoutCenterHorizontally.Checked;
				layoutToolbar.ShowCenterVertically =			tbLayoutCenterVertically.Checked;
				layoutToolbar.ShowBringToFront =				tbLayoutBringToFront.Checked;
				layoutToolbar.ShowSendToBack =					tbLayoutSendToBack.Checked;
				layoutToolbar.ShowMoveForward =					tbLayoutMoveForward.Checked;
				layoutToolbar.ShowMoveBackward =				tbLayoutMoveBackward.Checked;
				layoutToolbar.ShowLink =						tbLayoutLink.Checked;
				layoutToolbar.ShowLock =						tbLayoutLock.Checked;
			}
			#endregion

			#region Formatting Toolbar
			StiFormattingToolbarService formattingToolbar = StiFormattingToolbarService.GetService();
			
			if (formattingToolbar != null)
			{
				formattingToolbar.ServiceEnabled = tbFormatting.Checked;
			
				formattingToolbar.ShowFont =				tbFormattingFont.Checked;
				formattingToolbar.ShowFontSize =			tbFormattingFontSize.Checked;
				formattingToolbar.ShowTextBrush =			tbFormattingTextBrush.Checked;
				formattingToolbar.ShowBold =				tbFormattingBold.Checked;
				formattingToolbar.ShowItalic =				tbFormattingItalic.Checked;
				formattingToolbar.ShowUnderline =			tbFormattingUnderline.Checked;
				formattingToolbar.ShowAlignLeft =			tbFormattingAlignLeft.Checked;
				formattingToolbar.ShowAlignCenter =			tbFormattingAlignCenter.Checked;
				formattingToolbar.ShowAlignRight =			tbFormattingAlignRight.Checked;
				formattingToolbar.ShowAlignWidth =			tbFormattingAlignWidth.Checked;
				formattingToolbar.ShowAlignTop =			tbFormattingAlignTop.Checked;
				formattingToolbar.ShowAlignMiddle =			tbFormattingAlignMiddle.Checked;
				formattingToolbar.ShowAlignBottom =			tbFormattingAlignBottom.Checked;
				formattingToolbar.ShowRotateText =			tbFormattingRotateText.Checked;
				formattingToolbar.ShowConditions =			tbFormattingConditions.Checked;
			}
			#endregion

			#region Borders Toolbar
			StiBordersToolbarService bordersToolbar = StiBordersToolbarService.GetService();
			
			if (bordersToolbar != null)
			{
				bordersToolbar.ServiceEnabled = tbBorders.Checked;
			
				bordersToolbar.ShowBorderAll =		tbBordersAll.Checked;
				bordersToolbar.ShowBorderNone =		tbBordersNone.Checked;
				bordersToolbar.ShowBorderTop =		tbBordersTop.Checked;
				bordersToolbar.ShowBorderLeft =		tbBordersLeft.Checked;
				bordersToolbar.ShowBorderBottom =	tbBordersBottom.Checked;
				bordersToolbar.ShowBorderRight =	tbBordersRight.Checked;
				bordersToolbar.ShowBorderShadow =	tbBordersShadow.Checked;
				bordersToolbar.ShowFillBrush =		tbBordersFillBrush.Checked;
				bordersToolbar.ShowBorderColor =	tbBordersColor.Checked;
				bordersToolbar.ShowBorderStyle =	tbBordersStyle.Checked;
			}			
			#endregion

			#region DockStyle Toolbar
			StiDockStyleToolbarService dockStyleToolbar = StiDockStyleToolbarService.GetService();

			if (dockStyleToolbar != null)
			{			
				dockStyleToolbar.ServiceEnabled = tbDockStyle.Checked;
			
				dockStyleToolbar.ShowDockStyleFill =	tbDockStyleFill.Checked;
				dockStyleToolbar.ShowDockStyleNone =	tbDockStyleNone.Checked;
				dockStyleToolbar.ShowDockStyleTop =		tbDockStyleTop.Checked;
				dockStyleToolbar.ShowDockStyleLeft =	tbDockStyleLeft.Checked;
				dockStyleToolbar.ShowDockStyleBottom =	tbDockStyleBottom.Checked;
				dockStyleToolbar.ShowDockStyleRight =	tbDockStyleRight.Checked;
			}
			#endregion

			#region Style Toolbar
			StiStyleToolbarService styleToolbar = StiStyleToolbarService.GetService();
			
			if (styleToolbar != null)
			{
				styleToolbar.ServiceEnabled = tbStyle.Checked;
			
				styleToolbar.ShowStyleDesigner = tbStyleDesigner.Checked;
				styleToolbar.ShowStyles =	tbStyleStyles.Checked;
			}
			#endregion

			#region Tools Toolbar
			StiToolsToolbarService toolsToolbar = StiToolsToolbarService.GetService();

			if (toolsToolbar != null)
			{
				toolsToolbar.ServiceEnabled = tbTools.Checked;
			
				toolsToolbar.ShowModifiers =	tbToolsModifiers.Checked;
				toolsToolbar.ShowPagesManager =	tbToolsPagesManager.Checked;
				toolsToolbar.ShowDataStore =	tbToolsDataStore.Checked;
			}
			#endregion

			#region TextFormat Toolbar
			StiTextFormatToolbarService textFormatToolbar = StiTextFormatToolbarService.GetService();

			if (textFormatToolbar != null)
			{
				textFormatToolbar.ServiceEnabled = tbTextFormat.Checked;
			}
			#endregion

			#region Toolbox Toolbar
			StiToolboxToolbarService toolboxToolbar = StiToolboxToolbarService.GetService();
			
			if (toolboxToolbar != null)
			{
				toolboxToolbar.ServiceEnabled = tbToolbox.Checked;
			}
			#endregion
			#endregion

			#region Context Menu
			StiDesignComponentCTService designComponentCT = StiDesignComponentCTService.GetService();
			if (designComponentCT != null)designComponentCT.ServiceEnabled = cbContextDesignComponent.Checked;

			StiOrderCTService orderCT = StiOrderCTService.GetService();
			if (orderCT != null)orderCT.ServiceEnabled = cbContextOrder.Checked;

			StiAlignCTService alignCT = StiAlignCTService.GetService();
			if (alignCT != null)alignCT.ServiceEnabled = cbContextAlign.Checked;

			StiObjectCutCTService objectCutCT = StiObjectCutCTService.GetService();
			if (objectCutCT != null)objectCutCT.ServiceEnabled = cbContextCut.Checked;

			StiObjectCopyCTService objectCopyCT = StiObjectCopyCTService.GetService();
			if (objectCopyCT != null)objectCopyCT.ServiceEnabled = cbContextCopy.Checked;

			StiObjectPasteCTService objectPasteCT = StiObjectPasteCTService.GetService();
			if (objectPasteCT != null)objectPasteCT.ServiceEnabled = cbContextPaste.Checked;

			StiObjectDeleteCTService objectDeleteCT = StiObjectDeleteCTService.GetService();
			if (objectDeleteCT != null)objectDeleteCT.ServiceEnabled = cbContextDelete.Checked;

			StiObjectSelectAllCTService objectSelectAllCT = StiObjectSelectAllCTService.GetService();
			if (objectSelectAllCT != null)objectSelectAllCT.ServiceEnabled = cbContextSelectAll.Checked;
			#endregion
			#endregion
			
			report.Design();
		}

	}
}
