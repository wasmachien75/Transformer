namespace TransformerApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preloadSourceAndStylesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSourceXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStylesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingElseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.runButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.scintillaSource = new TransformerApp.ScintillaXml();
            this.scintillaXSL = new TransformerApp.ScintillaXml();
            this.scintillaOutput = new TransformerApp.ScintillaXml();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preloadSourceAndStylesheetToolStripMenuItem,
            this.loadSourceXMLToolStripMenuItem,
            this.loadStylesheetToolStripMenuItem,
            this.saveOutputAsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preloadSourceAndStylesheetToolStripMenuItem
            // 
            this.preloadSourceAndStylesheetToolStripMenuItem.Name = "preloadSourceAndStylesheetToolStripMenuItem";
            this.preloadSourceAndStylesheetToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.preloadSourceAndStylesheetToolStripMenuItem.Text = "Preload Source and Stylesheet";
            // 
            // loadSourceXMLToolStripMenuItem
            // 
            this.loadSourceXMLToolStripMenuItem.Name = "loadSourceXMLToolStripMenuItem";
            this.loadSourceXMLToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.loadSourceXMLToolStripMenuItem.Text = "Load Source XML";
            this.loadSourceXMLToolStripMenuItem.Click += new System.EventHandler(this.loadSourceXMLToolStripMenuItem_Click);
            // 
            // loadStylesheetToolStripMenuItem
            // 
            this.loadStylesheetToolStripMenuItem.Name = "loadStylesheetToolStripMenuItem";
            this.loadStylesheetToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.loadStylesheetToolStripMenuItem.Text = "Load Stylesheet";
            this.loadStylesheetToolStripMenuItem.Click += new System.EventHandler(this.loadStylesheetToolStripMenuItem_Click);
            // 
            // saveOutputAsToolStripMenuItem
            // 
            this.saveOutputAsToolStripMenuItem.Name = "saveOutputAsToolStripMenuItem";
            this.saveOutputAsToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.saveOutputAsToolStripMenuItem.Text = "Save Output As";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.transformToolStripMenuItem.Text = "Transform";
            this.transformToolStripMenuItem.Click += new System.EventHandler(this.transformToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wrapLinesToolStripMenuItem,
            this.somethingElseToolStripMenuItem,
            this.resetPositionToolStripMenuItem,
            this.openTestFormToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // wrapLinesToolStripMenuItem
            // 
            this.wrapLinesToolStripMenuItem.CheckOnClick = true;
            this.wrapLinesToolStripMenuItem.Name = "wrapLinesToolStripMenuItem";
            this.wrapLinesToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.wrapLinesToolStripMenuItem.Text = "Wrap Lines";
            this.wrapLinesToolStripMenuItem.Click += new System.EventHandler(this.wrapLinesToolStripMenuItem_Click);
            // 
            // somethingElseToolStripMenuItem
            // 
            this.somethingElseToolStripMenuItem.Name = "somethingElseToolStripMenuItem";
            this.somethingElseToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.somethingElseToolStripMenuItem.Text = "Dark Mode";
            this.somethingElseToolStripMenuItem.Click += new System.EventHandler(this.somethingElseToolStripMenuItem_Click);
            // 
            // resetPositionToolStripMenuItem
            // 
            this.resetPositionToolStripMenuItem.Name = "resetPositionToolStripMenuItem";
            this.resetPositionToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.resetPositionToolStripMenuItem.Text = "Reset Position";
            // 
            // openTestFormToolStripMenuItem
            // 
            this.openTestFormToolStripMenuItem.Name = "openTestFormToolStripMenuItem";
            this.openTestFormToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.openTestFormToolStripMenuItem.Text = "Open Test Form";
            this.openTestFormToolStripMenuItem.Click += new System.EventHandler(this.openTestFormToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1371, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(333, 20);
            this.statusLabel.Text = "Press \'Transform\' to transform the XML document";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scintillaOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1371, 554);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.scintillaSource);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.scintillaXSL);
            this.splitContainer2.Size = new System.Drawing.Size(1371, 360);
            this.splitContainer2.SplitterDistance = 685;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runButton,
            this.saveButton,
            this.toolStripButton3});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1371, 30);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // runButton
            // 
            this.runButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runButton.Image = ((System.Drawing.Image)(resources.GetObject("runButton.Image")));
            this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(24, 24);
            this.runButton.Text = "toolStripButton1";
            this.runButton.ToolTipText = "Transform";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(24, 24);
            this.saveButton.Text = "toolStripButton2";
            this.saveButton.ToolTipText = "Save Output";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // scintillaSource
            // 
            this.scintillaSource.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaSource.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaSource.Location = new System.Drawing.Point(0, 0);
            this.scintillaSource.Name = "scintillaSource";
            this.scintillaSource.ScrollWidth = 585;
            this.scintillaSource.Size = new System.Drawing.Size(685, 360);
            this.scintillaSource.TabIndex = 0;
            this.scintillaSource.Text = resources.GetString("scintillaSource.Text");
            // 
            // scintillaXSL
            // 
            this.scintillaXSL.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaXSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaXSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaXSL.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaXSL.Location = new System.Drawing.Point(0, 0);
            this.scintillaXSL.Name = "scintillaXSL";
            this.scintillaXSL.ScrollWidth = 711;
            this.scintillaXSL.Size = new System.Drawing.Size(682, 360);
            this.scintillaXSL.TabIndex = 0;
            this.scintillaXSL.Text = resources.GetString("scintillaXSL.Text");
            // 
            // scintillaOutput
            // 
            this.scintillaOutput.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaOutput.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaOutput.Location = new System.Drawing.Point(0, 0);
            this.scintillaOutput.Name = "scintillaOutput";
            this.scintillaOutput.Size = new System.Drawing.Size(1371, 190);
            this.scintillaOutput.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 637);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(853, 600);
            this.Name = "MainForm";
            this.Text = "Transformer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSourceXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStylesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrapLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingElseToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem resetPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preloadSourceAndStylesheetToolStripMenuItem;
        private ScintillaXml scintillaXSL;
        private ScintillaXml scintillaOutput;
        public ScintillaXml scintillaSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton runButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}