namespace InvoiceCreator
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.toolStripPrint = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDesign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.treeViewReports = new System.Windows.Forms.TreeView();
            this.contextMenuStripPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPrint.SuspendLayout();
            this.contextMenuStripPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripButtonDesign,
            this.toolStripSeparator1,
            this.toolStripButtonClose});
            this.toolStripPrint.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(260, 25);
            this.toolStripPrint.TabIndex = 0;
            this.toolStripPrint.Text = "toolStrip1";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonPrint.Text = "Print";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripButtonDesign
            // 
            this.toolStripButtonDesign.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDesign.Image")));
            this.toolStripButtonDesign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDesign.Name = "toolStripButtonDesign";
            this.toolStripButtonDesign.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonDesign.Text = "Design";
            this.toolStripButtonDesign.Click += new System.EventHandler(this.toolStripButtonDesign_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.AutoSize = false;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonClose.Text = "Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // treeViewReports
            // 
            this.treeViewReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewReports.Location = new System.Drawing.Point(2, 27);
            this.treeViewReports.Name = "treeViewReports";
            this.treeViewReports.ShowPlusMinus = false;
            this.treeViewReports.ShowRootLines = false;
            this.treeViewReports.Size = new System.Drawing.Size(256, 371);
            this.treeViewReports.TabIndex = 2;
            this.treeViewReports.DoubleClick += new System.EventHandler(this.toolStripButtonPrint_Click);
            this.treeViewReports.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewReports_MouseDown);
            // 
            // contextMenuStripPrint
            // 
            this.contextMenuStripPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.designToolStripMenuItem});
            this.contextMenuStripPrint.Name = "contextMenuStripPrint";
            this.contextMenuStripPrint.Size = new System.Drawing.Size(111, 48);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("designToolStripMenuItem.Image")));
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.designToolStripMenuItem.Text = "Design";
            this.designToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonDesign_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 400);
            this.Controls.Add(this.treeViewReports);
            this.Controls.Add(this.toolStripPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "PrintForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintForm_KeyDown);
            this.toolStripPrint.ResumeLayout(false);
            this.toolStripPrint.PerformLayout();
            this.contextMenuStripPrint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonDesign;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView treeViewReports;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrint;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
    }
}