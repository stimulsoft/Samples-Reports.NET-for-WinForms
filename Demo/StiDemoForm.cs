#region Copyright (C) 2003-2012 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports												}
{	                         										}
{																	}
{	Copyright (C) 2003-2012 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2012 Stimulsoft

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Stimulsoft.Report.Viewer;
using Stimulsoft.Controls.Win.DotNetBar;
using System.Reflection;
using System.Collections;
using Stimulsoft.Report;
using System.IO;
using System.Xml;
using System.Drawing.Drawing2D;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Base.Localization;

namespace Demo
{
    public partial class StiDemoForm : Form
    {
        #region enum ReportAction
        public enum ReportAction
        {
            Preview,
            PreviewInWindow,
            Print
        }
        #endregion

        #region class reportInfo
        private class reportInfo
        {
            public string description = string.Empty;

            public List<videoInfo> videos = new List<videoInfo>();
            public List<sampleInfo> samples = new List<sampleInfo>();
        }

        private class videoInfo
        {
            public string name;
            public string description;
            public string hyperlink;
        }

        private class sampleInfo
        {
            public string name;
            public string description;
            public string path;
            public bool isVB;
        }
        #endregion

        #region Fields
        private bool blockApplyStyle;
        private MethodInfo[] assemblys;
        private StiWelcomeScreenControl welcomeScreen;
        private string applicationPath = "..\\..\\";
        private Hashtable reportsHelper = new Hashtable();
        private Hashtable demoLocalization = new Hashtable();
        private Bitmap videoBitmap = global::Demo.Properties.Resources.Video;
        private ButtonItem buttonHelpResources;
        private ButtonItem buttonDesign;
        #endregion

        #region Methods override
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Stimulsoft.Report.Helpers.StiFormHelper.SaveStateForm(this, "DemoWindow");
            StiSettings.Save();
        }
        #endregion

        #region Methods
        private void RenderReport(ReportAction reportAction)
        {
            if (tvReports.SelectedNode != null && tvReports.SelectedNode.Parent != null)
            {
                string file = applicationPath + "Reports\\" + tvReports.SelectedNode.Tag as string;

                if (File.Exists(file))
                {
                    #region Show Animation in taskbar
                    Stimulsoft.Controls.DesktopIntegration.Windows7Taskbar.ShowTaskbarProgress(this.Handle,
                        Stimulsoft.Controls.DesktopIntegration.Windows7Taskbar.ThumbnailProgressState.Indeterminate);
                    #endregion

                    StiReport report = new StiReport();
                    report.Load(file);
                    reportInfo info = reportsHelper[tvReports.SelectedNode.Tag] as reportInfo;
                    if (info != null)
                    {
                        report.ReportDescription = info.description;
                    }

                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    folder = Path.Combine(folder, "Stimulsoft\\CompiledReports");
                    folder = Path.Combine(folder, System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion().ToString());
                    string compiledReportFile = Path.Combine(folder, report.GetReportAssemblyCacheName());


                    if (File.Exists(compiledReportFile))
                    {
                        lbStatus.Text = "Loading report from assembly";
                        Application.DoEvents();
                        report = StiReport.GetReportFromAssembly(compiledReportFile, true);

                        RegData(report, (string)tvReports.SelectedNode.Tag);

                        lbStatus.Text = "Rendering report";
                        Application.DoEvents();
                        report.Rendering += new EventHandler(OnRendering);
                        int tick = Environment.TickCount;

                        report.Render(false);
                    }
                    else
                    {
                        lbStatus.Text = "Loading report";
                        Application.DoEvents();

                        RegData(report, (string)tvReports.SelectedNode.Tag);

                        lbStatus.Text = "Compiling report";
                        Application.DoEvents();

                        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                        report.Compile(compiledReportFile);

                        lbStatus.Text = "Rendering report";
                        Application.DoEvents();
                        if (report.CalculationMode == StiCalculationMode.Compilation)
                        {
                            report.CompiledReport.Rendering += new EventHandler(OnRendering);
                        }
                        else
                        {
                            report.Rendering += new EventHandler(OnRendering);
                        }
                        int tick = Environment.TickCount;
                        report.Render(false);
                    }

                    if (!report.IsStopped)
                    {
                        if (reportAction == ReportAction.PreviewInWindow)
                        {
                            report.Show(true);
                        }
                        else if (reportAction == ReportAction.Preview)
                        {
                            viewerControl.Report = report;
                        }
                        else if (reportAction == ReportAction.Print) report.Print();
                    }

                    lbStatus.Text = "";

                    #region Hide Animation in taskbar
                    Stimulsoft.Controls.DesktopIntegration.Windows7Taskbar.HideTaskbarProgress();
                    #endregion
                }
                else MessageBox.Show("'" + tvReports.SelectedNode.Tag as string + "' not found");
            }
        }

        private void RegData(StiReport report, string file)
        {
            report.RegData("Demo", dataSet1);

            if (file == "IEnumerableData.mrt" ||
                file == "SingleRowBusinessObject.mrt" ||
                file == "SimpleListBusinessObjects.mrt" ||
                file == "Master-DetailBusinessObjects.mrt" ||
                file == "Master-Detail-SubdetailBusinessObjects.mrt" ||
                file == "CollectionOfBusinessObjects.mrt")
            {
                report.RegData("HatchStyleEnum", Enum.GetNames(typeof(HatchStyle)));
                report.RegData("EmployeeOne", CreateBusinessObjects.GetEmployee());
                report.RegData("EmployeesCollection", CreateBusinessObjects.GetEmployees());

                report.RegBusinessObject("DataSet's", "Demo", dataSet1);
            }

            if (file == "UserData.mrt")
            {
                Type type = typeof(Graphics);
                assemblys = type.GetMethods();
                stiUserData1.Count = assemblys.Length;
                report.RegData("UserData", stiUserData1);
            }

            if (file == "SQLSimpleQuery.mrt" ||
                file == "SQLSubReportWithParameters.mrt" ||
                file == "SQLParameters.mrt" ||
                file == "SQLMasterDetail.mrt" ||
                file == "CrossTabImages.mrt" ||
                file == "ParametersDateRange.mrt")
            {
                var connection =
                    new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" +
                        StiOptions.Configuration.ApplicationDirectory + "\\Data\\Nwind.mdb");

                report.RegData("NorthWind", connection);
            }
        }

        private void ApplyStyle()
        {
            if (blockApplyStyle) return;

            blockApplyStyle = true;

            this.viewerControl.ApplyStyle(StiGlobalGuiStyle.Office2010Silver);

            this.viewerControl.View.BackColor =
            this.viewerControl.BackColor = Color.FromArgb(255, 0xdc, 0xe2, 0xe8);

            blockApplyStyle = false;
        }
        #endregion

        #region Methods.CreateTree
        private LabelItem labelHelp;
        private void ReadReportsInfo()
        {
            #region Load
            string fileName = StiLocalization.CultureName;

            switch (fileName)
            {
                case "ua":
                case "be":
                case "ru":
                    fileName = "ReportsRu.xml";
                    break;

                default:
                    fileName = "ReportsEn.xml";
                    break;
            }

            StreamReader sr = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Demo." + fileName));
            XmlTextReader tr = new XmlTextReader(sr);
            #endregion

            TreeNode categoryNode = null;

            bool is64Bit = IntPtr.Size == 8;

            tr.Read();
            while (!tr.EOF)
            {
                if (tr.IsStartElement())
                {
                    bool isNew = tr.GetAttribute("new") == "True";

                    #region Category
                    if (tr.Name == "Category")
                    {
                        bool x86Only = tr.GetAttribute("x86Only") == "True";
                        if (!(x86Only && is64Bit))
                        {
                            categoryNode = new TreeNode(tr.GetAttribute("name"), 0, 0);
                            categoryNode.Tag = tr.GetAttribute("name");
                            tvReports.Nodes.Add(categoryNode);
                        }
                    }
                    #endregion

                    #region Report
                    else if (tr.Name == "Report")
                    {
                        bool x86Only = tr.GetAttribute("x86Only") == "True";
                        if (!(x86Only && is64Bit))
                        {
                            TreeNode reportNode = new TreeNode(tr.GetAttribute("name"), 1, 1);
                            reportNode.Tag = tr.GetAttribute("file");

                            if (tr.NodeType == XmlNodeType.Element)
                            {
                                reportInfo rptInfo = reportsHelper[reportNode.Tag] as reportInfo;
                                if (rptInfo == null)
                                {
                                    rptInfo = new reportInfo();
                                    reportsHelper[reportNode.Tag] = rptInfo;
                                }

                                tr.Read();
                                int depth = tr.Depth;
                                tr.Read();
                                while (tr.Depth >= depth && tr.NodeType != XmlNodeType.EndElement)
                                {
                                    switch (tr.Name)
                                    {
                                        case "desc":
                                            rptInfo.description = tr.ReadElementContentAsString();
                                            break;

                                        case "video":
                                            videoInfo video = new videoInfo();

                                            video.name = tr.GetAttribute("name");
                                            video.description = tr.GetAttribute("desc");
                                            video.hyperlink = tr.ReadElementContentAsString();
                                            rptInfo.videos.Add(video);
                                            break;

                                        case "sample":
                                            sampleInfo csSample = new sampleInfo();

                                            csSample.name = tr.GetAttribute("name");
                                            csSample.description = tr.GetAttribute("desc");
                                            csSample.isVB = tr.GetAttribute("vb") == "True";
                                            csSample.path = tr.ReadElementContentAsString();
                                            rptInfo.samples.Add(csSample);
                                            break;
                                    }

                                    tr.Read();
                                }

                                tr.Read();
                            }
                            categoryNode.Nodes.Add(reportNode);
                        }
                    }
                    #endregion

                    #region Localization
                    else if (tr.Name == "Localization")
                    {
                        tr.Read();
                        int depth = tr.Depth;
                        tr.Read();
                        while (tr.Depth >= depth && tr.NodeType != System.Xml.XmlNodeType.EndElement)
                        {
                            string key = tr.Name;
                            string content = tr.ReadElementContentAsString();
                            demoLocalization.Add(key, content);

                            tr.Read();
                        }
                    }
                    #endregion
                }
                tr.Read();
            }

            tr.Close();
            sr.Close();
            tvReports.Nodes[0].Expand();
        }

        private void CreateHelpResourcesMenu()
        {
            buttonHelpResources = new ButtonItem();
            buttonHelpResources.BeginGroup = true;
            buttonHelpResources.AutoExpandOnClick = true;
            buttonHelpResources.ItemAlignment = eItemAlignment.Far;
            buttonHelpResources.ColorTable = eButtonColor.OrangeWithBackground;
            buttonHelpResources.Text = (string)demoLocalization["ButtonHelpResources"];
            buttonHelpResources.Name = "buttonHelpResources";

            Size buttonSize = TextRenderer.MeasureText((string)demoLocalization["ButtonHelpResources"], this.viewerControl.ToolBar.Font, new Size(110, 22));
            buttonHelpResources.FixedSize = new Size(buttonSize.Width + 25, 22);

            #region Other buttons
            labelHelp = new LabelItem();
            labelHelp.BackColor = System.Drawing.Color.FromArgb(221, 231, 238);
            labelHelp.BorderSide = Stimulsoft.Controls.Win.DotNetBar.eBorderSide.All;
            labelHelp.BorderType = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
            labelHelp.ForeColor = System.Drawing.Color.FromArgb(0, 21, 110);
            labelHelp.PaddingBottom = 1;
            labelHelp.PaddingLeft = 1;
            labelHelp.PaddingTop = 1;
            labelHelp.SingleLineColor = System.Drawing.Color.FromArgb(197, 197, 197);
            labelHelp.Text = (string)demoLocalization["LabelHelp"];

            ButtonItem buttonDocumentation = new ButtonItem();
            buttonDocumentation.Image = global::Demo.Properties.Resources.Documentation;
            buttonDocumentation.Tag = "http://www.stimulsoft.com/Documentation.aspx";
            buttonDocumentation.Text = (string)demoLocalization["ButtonDocumentation"];
            buttonDocumentation.Name = "buttonDocumentation";
            buttonDocumentation.Click += new EventHandler(buttonHyperlink_Click);

            ButtonItem buttonSupport = new ButtonItem();
            buttonSupport.Image = global::Demo.Properties.Resources.Support;
            buttonSupport.Tag = "http://www.stimulsoft.com/support.aspx";
            buttonSupport.Text = (string)demoLocalization["ButtonSupport"];
            buttonSupport.Name = "buttonSupport";
            buttonSupport.Click += new EventHandler(buttonHyperlink_Click);

            ButtonItem buttonForum = new ButtonItem();
            buttonForum.Image = global::Demo.Properties.Resources.Forum;
            buttonForum.Tag = "http://forum.stimulsoft.com/";
            buttonForum.Text = (string)demoLocalization["ButtonForum"];
            buttonForum.Name = "buttonForum";
            buttonForum.Click += new EventHandler(buttonHyperlink_Click);

            ButtonItem buttonKnowledgebase = new ButtonItem();
            buttonKnowledgebase.Image = global::Demo.Properties.Resources.Knowledgebase;
            buttonKnowledgebase.Tag = "http://stimulsoft.helpserve.com/index.php?_m=knowledgebase&_a=view";
            buttonKnowledgebase.Text = (string)demoLocalization["ButtonKnowledgebase"];
            buttonKnowledgebase.Name = "buttonKnowledgebase";
            buttonKnowledgebase.Click += new EventHandler(buttonHyperlink_Click);

            ButtonItem buttonPurchase = new ButtonItem();
            buttonPurchase.Image = global::Demo.Properties.Resources.Purchase;
            buttonPurchase.Tag = "http://www.stimulsoft.com/Purchase.aspx";
            buttonPurchase.Text = (string)demoLocalization["ButtonPurchase"];
            buttonPurchase.Name = "buttonPurchase";
            buttonPurchase.Click += new EventHandler(buttonHyperlink_Click);

            ButtonItem buttonAllVideos = new ButtonItem();
            buttonAllVideos.Image = global::Demo.Properties.Resources.Video;
            buttonAllVideos.Tag = "http://www.stimulsoft.com/Videos.aspx";
            buttonAllVideos.Text = (string)demoLocalization["ButtonVideos"];
            buttonAllVideos.Name = "buttonVideos";
            buttonAllVideos.Click += new EventHandler(buttonHyperlink_Click);

            buttonHelpResources.SubItems.Add(labelHelp);
            buttonHelpResources.SubItems.Add(buttonDocumentation);
            buttonHelpResources.SubItems.Add(buttonKnowledgebase);
            buttonHelpResources.SubItems.Add(buttonForum);
            buttonHelpResources.SubItems.Add(buttonSupport);
            buttonHelpResources.SubItems.Add(buttonPurchase);
            buttonHelpResources.SubItems.Add(buttonAllVideos);
            #endregion

            this.viewerControl.ToolBar.Items.Add(buttonHelpResources);

            #region Design
            buttonDesign = new ButtonItem();
            buttonDesign.ItemAlignment = eItemAlignment.Far;
            buttonDesign.ColorTable = eButtonColor.OrangeWithBackground;
            buttonDesign.Text = (string)demoLocalization["ButtonDesign"];
            buttonDesign.Name = "buttonDesign";
            buttonDesign.Click += new EventHandler(btDesign_Click);

            buttonSize = TextRenderer.MeasureText((string)demoLocalization["ButtonDesign"], this.viewerControl.ToolBar.Font, new Size(130, 22));
            buttonDesign.FixedSize = new Size(buttonSize.Width + 15, 22);

            ButtonItem buttonGotoStartPage = new ButtonItem();
            buttonGotoStartPage.Image = global::Demo.Properties.Resources.Help;
            buttonGotoStartPage.Tooltip = (string)demoLocalization["JumpToWelcomeScreen"];
            buttonGotoStartPage.Click += new EventHandler(buttonGotoStartPage_Click);

            this.viewerControl.ToolBar.Items.Add(buttonDesign);
            #endregion

            this.viewerControl.ToolBar.Items.Add(buttonGotoStartPage);
        }
        #endregion

        #region Methods.Show
        private void ShowViewerControl()
        {
            this.welcomeScreen.Visible = false;
            panel1.Visible = true;
            viewerControl.Visible = true;
        }

        private void ShowStartPage()
        {
            StiDemoForm_SizeChanged(null, null);
            this.SizeChanged += new EventHandler(StiDemoForm_SizeChanged);
            this.welcomeScreen.Visible = true;
            panel1.Visible = false;
            viewerControl.Visible = false;
        }
        #endregion

        #region Handlers
        private void viewerControl_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnRendering(object sender, EventArgs e)
        {
            lbStatus.Text = ((StiReport)sender).StatusString;
            Application.DoEvents();
        }

        private void btDesign_Click(object sender, System.EventArgs e)
        {
            var report = new StiReport();

            StiOptions.Dictionary.AutoSynchronize = StiAutoSynchronizeMode.None;

            if (tvReports.SelectedNode != null && tvReports.SelectedNode.Parent != null)
            {
                var file = applicationPath + "Reports\\" + tvReports.SelectedNode.Tag;

                if (File.Exists(file)) report.Load(file);
                else MessageBox.Show("File \"" + file + "\" not found");
            }
            RegData(report, (string)tvReports.SelectedNode.Tag);

            reportInfo info = reportsHelper[tvReports.SelectedNode.Tag] as reportInfo;
            if (info != null)
            {
                report.ReportDescription = info.description;
            }
            report.Design();

            ApplyStyle();
        }

        private void btClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            string hyperlink = (string)btn.Tag;

            try
            {
                if (hyperlink.StartsWith("http:"))
                {
                    System.Diagnostics.Process.Start(hyperlink);
                }
                else
                {
                    string path = "C:\\Program Files (x86)\\Stimulsoft Reports\\Samples" + hyperlink;
                    if (File.Exists(path))
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("Sample is not found!");
                    }
                }
            }
            catch { }
        }

        private void buttonHyperlink_Click(object sender, EventArgs e)
        {
            string tag = (string)((ButtonItem)sender).Tag;
            System.Diagnostics.Process.Start(tag);
        }

        private void btPreview_Click(object sender, System.EventArgs e)
        {
            RenderReport(ReportAction.Preview);
        }

        private void tvReports_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region Clear
            while (true)
            {
                if (buttonHelpResources.SubItems[0] == labelHelp) break;
                buttonHelpResources.SubItems.RemoveAt(0);
            }
            #endregion

            reportInfo info = reportsHelper[e.Node.Tag] as reportInfo;
            if (info != null && (info.videos.Count > 0 || info.samples.Count > 0))
            {
                int indexSubItems = 0;
                // Video
                if (info.videos.Count > 0)
                {
                    LabelItem labelVideos = new LabelItem();
                    labelVideos.BackColor = System.Drawing.Color.FromArgb(221, 231, 238);
                    labelVideos.BorderSide = Stimulsoft.Controls.Win.DotNetBar.eBorderSide.All;
                    labelVideos.BorderType = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
                    labelVideos.ForeColor = System.Drawing.Color.FromArgb(0, 21, 110);
                    labelVideos.PaddingBottom = 1;
                    labelVideos.PaddingLeft = 1;
                    labelVideos.PaddingTop = 1;
                    labelVideos.SingleLineColor = System.Drawing.Color.FromArgb(197, 197, 197);
                    labelVideos.Text = (string)demoLocalization["LabelVideos"];
                    buttonHelpResources.SubItems.Insert(indexSubItems++, labelVideos);

                    int index = -1;
                    while(++index < info.videos.Count)
                    {
                        videoInfo vi = info.videos[index];

                        ButtonItem button = new ButtonItem();
                        button.Image = videoBitmap;
                        button.Text = "<b>" + vi.name + "</b><br>" + vi.description + "</br>";
                        button.Tag = vi.hyperlink;
                        button.Click += new EventHandler(infoButton_Click);

                        buttonHelpResources.SubItems.Insert(indexSubItems++, button);
                    }
                }

                // Samples
                if (info.samples.Count > 0)
                {
                    LabelItem labelSamples = new LabelItem();
                    labelSamples.BackColor = System.Drawing.Color.FromArgb(221, 231, 238);
                    labelSamples.BorderSide = Stimulsoft.Controls.Win.DotNetBar.eBorderSide.All;
                    labelSamples.BorderType = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine;
                    labelSamples.ForeColor = System.Drawing.Color.FromArgb(0, 21, 110);
                    labelSamples.PaddingBottom = 1;
                    labelSamples.PaddingLeft = 1;
                    labelSamples.PaddingTop = 1;
                    labelSamples.SingleLineColor = System.Drawing.Color.FromArgb(197, 197, 197);
                    labelSamples.Text = (string)demoLocalization["LabelSamples"];
                    buttonHelpResources.SubItems.Insert(indexSubItems++, labelSamples);

                    int index = -1;
                    while(++index < info.samples.Count)
                    {
                        sampleInfo si = info.samples[index];

                        ButtonItem button = new ButtonItem();
                        button.Image = (si.isVB) ? global::Demo.Properties.Resources.VBProject : global::Demo.Properties.Resources.CSharpProject;
                        button.Text = "<b>" + si.name + "</b><br>" + si.description + "</br>";
                        button.Tag = si.path;
                        button.Click += new EventHandler(infoButton_Click);

                        buttonHelpResources.SubItems.Insert(indexSubItems++, button);
                    }
                }
            }
        }

        private void tvReports_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                RenderReport(ReportAction.Preview);
            }
        }

        private void stiUserData1_GetData(object sender, Stimulsoft.Report.Dictionary.StiUserGetDataEventArgs e)
        {
            if (e.ColumnName == "DataName") e.Data = assemblys[e.Position].Name;
            if (e.ColumnName == "ReturnType") e.Data = assemblys[e.Position].ReturnType.Name;
            if (e.ColumnName == "IsStatic") e.Data = assemblys[e.Position].IsStatic;
            if (e.ColumnName == "Parameters")
            {
                ParameterInfo[] pars = assemblys[e.Position].GetParameters();

                string s = string.Empty;
                foreach (ParameterInfo par in pars) s += par.ParameterType.Name + " " + par.Name + "\n";

                e.Data = s;
            }
        }

        private void separator1_Paint(object sender, PaintEventArgs e)
        {
            Control control = sender as Control;
            e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);
            using (Pen pen = new Pen(Color.FromArgb(0xaa, 0xb7, 0xbb, 0xbf), 1))
            {
                pen.DashStyle = DashStyle.Dash;
                e.Graphics.DrawLine(pen, 0, 0, control.Width, 0);
            }
        }

        private void border_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(4, 0, 4, border.Height);

            using (SolidBrush brush1 = new SolidBrush(Color.FromArgb(255, 0xdc, 0xe2, 0xe8)))
                e.Graphics.FillRectangle(brush1, rect);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                Color.FromArgb(0x99, 0xb7, 0xbb, 0xbf),
                Color.FromArgb(0x99, 0xdc, 0xe2, 0xe8),
                0f))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.stimulsoft.com");
        }

        private void checkBoxDisplayWelcomeScreenAgain_CheckedChanged(object sender, EventArgs e)
        {
            StiSettings.Set(this.Name, "DisplayWelcomeScreenAgain", welcomeScreen.checkBoxDisplayWelcomeScreenAgain.Checked);
            StiSettings.Save();
        }
        #endregion

        #region Handlers.WelcomeScreen
        private void buttonDemo_Click(object sender, EventArgs e)
        {
            this.SizeChanged -= new EventHandler(StiDemoForm_SizeChanged);

            ShowViewerControl();
        }

        private void buttonGotoStartPage_Click(object sender, EventArgs e)
        {
            ShowStartPage();
        }

        private void StiDemoForm_SizeChanged(object sender, EventArgs e)
        {
            int xPos = (this.ClientSize.Width - welcomeScreen.Width) / 2;
            int yPos = (this.ClientSize.Height - welcomeScreen.Height) / 2;

            welcomeScreen.Location = new Point(xPos, yPos);
        }
        #endregion

        public StiDemoForm()
        {
            InitializeComponent();

            #region Read Data
            if (File.Exists(applicationPath + "Data\\Demo.xsd")) dataSet1.ReadXmlSchema(applicationPath + "Data\\Demo.xsd");
            else MessageBox.Show("File \"Demo.xsd\" not found");

            if (File.Exists(applicationPath + "Data\\Demo.xml")) dataSet1.ReadXml(applicationPath + "Data\\Demo.xml");
            else MessageBox.Show("File \"Demo.xml\" not found");

            dataSet1.DataSetName = "Demo";
            #endregion

            ReadReportsInfo();
            tvReports.SelectedNode = tvReports.Nodes[0];

#if Debug
			btTest.Visible = true;
#endif

            #region Create Welcome Screen
            this.welcomeScreen = new StiWelcomeScreenControl();
            this.welcomeScreen.Location = new Point(50, 50);
            this.welcomeScreen.Size = new Size(900, 550);
            this.welcomeScreen.Visible = false;
            this.Controls.Add(this.welcomeScreen);

            StiSettings.Load();
            bool displayWelcomeScreenAgain = StiSettings.GetBool(this.Name, "DisplayWelcomeScreenAgain", true);
            this.welcomeScreen.checkBoxDisplayWelcomeScreenAgain.Checked = displayWelcomeScreenAgain;
            this.welcomeScreen.checkBoxDisplayWelcomeScreenAgain.CheckedChanged += new EventHandler(checkBoxDisplayWelcomeScreenAgain_CheckedChanged);

            this.welcomeScreen.buttonDemo.Click += new EventHandler(buttonDemo_Click);

            this.welcomeScreen.welcome = (string)demoLocalization["Welcome"];
            this.welcomeScreen.welcomeDescription = (string)demoLocalization["WelcomeDesc"];
            
            this.welcomeScreen.SetDemoButtonText(this.welcomeScreen.buttonDemo, (string)demoLocalization["DescDemo"]);
            this.welcomeScreen.SetDemoButtonText(this.welcomeScreen.buttonSupport, (string)demoLocalization["DescSupport"]);
            this.welcomeScreen.SetDemoButtonText(this.welcomeScreen.buttonVideo, (string)demoLocalization["DescVideo"]);
            this.welcomeScreen.SetDemoButtonText(this.welcomeScreen.buttonDocumentation, (string)demoLocalization["DescDocumentation"]);
            this.welcomeScreen.SetDemoButtonText(this.welcomeScreen.buttonForum, (string)demoLocalization["DescForum"]);
            this.welcomeScreen.SetDemoButtonText(this.welcomeScreen.buttonSampleProject, (string)demoLocalization["DescSampleProject"]);

            this.welcomeScreen.checkBoxDisplayWelcomeScreenAgain.Text = (string)demoLocalization["DisplayWelcomeScreenAgain"];
            #endregion

            #region Viewer
            this.viewerControl.IgnoreApplyStyle = true;
            this.viewerControl.View.BorderStyle = BorderStyle.None;
            this.viewerControl.ToolBar.RoundCorners = true;
            this.viewerControl.StatusBar.RoundCorners = true;
            this.viewerControl.FindBar.RoundCorners = true;
            viewerControl.Close += new EventHandler(viewerControl_Close);
            this.viewerControl.GlobalGuiStyleChanged += delegate
            {
                ApplyStyle();
            };
            ApplyStyle();

            CreateHelpResourcesMenu();
            #endregion

            #region Get Position
            Point position = Point.Empty;
            Size size = new Size(960, 588);
            Stimulsoft.Report.Helpers.StiFormHelper.LoadStateForm(this, "DemoWindow", ref position, ref size);
            this.StartPosition = FormStartPosition.Manual;
            base.SetBoundsCore(position.X, position.Y, size.Width, size.Height, BoundsSpecified.All);
            #endregion

            if (displayWelcomeScreenAgain)
                ShowStartPage();
            else
                ShowViewerControl();
        }
    }
}