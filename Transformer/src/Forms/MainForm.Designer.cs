using ScintillaNET;

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
            this.loadSourceXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStylesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapLinesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatAndIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setProcessorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saxonSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.dotNetSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.openTreeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xSLTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportDevWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.posLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.scintillaSource = new TransformerApp.ScintillaXml();
            this.scintillaXSL = new TransformerApp.ScintillaXml();
            this.scintillaOutput = new TransformerApp.ScintillaXml();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.runButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
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
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSourceXMLToolStripMenuItem,
            this.loadStylesheetToolStripMenuItem,
            this.saveOutputAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSourceXMLToolStripMenuItem
            // 
            this.loadSourceXMLToolStripMenuItem.Image = global::Transformer.Properties.Resources.FilterFolderOpen_32x;
            this.loadSourceXMLToolStripMenuItem.Name = "loadSourceXMLToolStripMenuItem";
            this.loadSourceXMLToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.loadSourceXMLToolStripMenuItem.Text = "Load Source XML";
            this.loadSourceXMLToolStripMenuItem.Click += new System.EventHandler(this.loadSourceXMLToolStripMenuItem_Click);
            // 
            // loadStylesheetToolStripMenuItem
            // 
            this.loadStylesheetToolStripMenuItem.Image = global::Transformer.Properties.Resources.LinkedFolderOpen_16x;
            this.loadStylesheetToolStripMenuItem.Name = "loadStylesheetToolStripMenuItem";
            this.loadStylesheetToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.loadStylesheetToolStripMenuItem.Text = "Load Stylesheet";
            this.loadStylesheetToolStripMenuItem.Click += new System.EventHandler(this.loadStylesheetToolStripMenuItem_Click);
            // 
            // saveOutputAsToolStripMenuItem
            // 
            this.saveOutputAsToolStripMenuItem.Image = global::Transformer.Properties.Resources.icons8_Save_96;
            this.saveOutputAsToolStripMenuItem.Name = "saveOutputAsToolStripMenuItem";
            this.saveOutputAsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.saveOutputAsToolStripMenuItem.Text = "Save Output As";
            this.saveOutputAsToolStripMenuItem.Click += new System.EventHandler(this.saveOutputAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Transformer.Properties.Resources.Exit_32x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformToolStripMenuItem,
            this.wrapLinesToolStripMenuItem1,
            this.formatAndIndentToolStripMenuItem,
            this.setProcessorToolStripMenuItem1,
            this.openTreeFormToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Image = global::Transformer.Properties.Resources.icons8_Circled_Play_96;
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.transformToolStripMenuItem.Text = "Transform";
            this.transformToolStripMenuItem.Click += new System.EventHandler(this.transformToolStripMenuItem_Click);
            // 
            // wrapLinesToolStripMenuItem1
            // 
            this.wrapLinesToolStripMenuItem1.Image = global::Transformer.Properties.Resources.WrapPanel_24x;
            this.wrapLinesToolStripMenuItem1.Name = "wrapLinesToolStripMenuItem1";
            this.wrapLinesToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.wrapLinesToolStripMenuItem1.Text = "Wrap Lines";
            this.wrapLinesToolStripMenuItem1.Click += new System.EventHandler(this.wrapLinesToolStripMenuItem_Click);
            // 
            // formatAndIndentToolStripMenuItem
            // 
            this.formatAndIndentToolStripMenuItem.Image = global::Transformer.Properties.Resources.icons8_Indent_Filled_100;
            this.formatAndIndentToolStripMenuItem.Name = "formatAndIndentToolStripMenuItem";
            this.formatAndIndentToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.formatAndIndentToolStripMenuItem.Text = "Format and Indent";
            this.formatAndIndentToolStripMenuItem.Click += new System.EventHandler(this.indentClick);
            // 
            // setProcessorToolStripMenuItem1
            // 
            this.setProcessorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saxonSelect,
            this.dotNetSelect});
            this.setProcessorToolStripMenuItem1.Image = global::Transformer.Properties.Resources.ProcessModel_32x;
            this.setProcessorToolStripMenuItem1.Name = "setProcessorToolStripMenuItem1";
            this.setProcessorToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.setProcessorToolStripMenuItem1.Text = "Set Processor";
            // 
            // saxonSelect
            // 
            this.saxonSelect.CheckOnClick = true;
            this.saxonSelect.Name = "saxonSelect";
            this.saxonSelect.Size = new System.Drawing.Size(124, 26);
            this.saxonSelect.Text = "Saxon";
            this.saxonSelect.Click += new System.EventHandler(this.saxonOptionsClick);
            // 
            // dotNetSelect
            // 
            this.dotNetSelect.Checked = true;
            this.dotNetSelect.CheckOnClick = true;
            this.dotNetSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dotNetSelect.Name = "dotNetSelect";
            this.dotNetSelect.Size = new System.Drawing.Size(124, 26);
            this.dotNetSelect.Text = ".NET";
            this.dotNetSelect.Click += new System.EventHandler(this.dotNetSelect_Click);
            // 
            // openTreeFormToolStripMenuItem
            // 
            this.openTreeFormToolStripMenuItem.Image = global::Transformer.Properties.Resources.DependencyGraph_16x;
            this.openTreeFormToolStripMenuItem.Name = "openTreeFormToolStripMenuItem";
            this.openTreeFormToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.openTreeFormToolStripMenuItem.Text = "Source Tree (experimental)";
            this.openTreeFormToolStripMenuItem.Click += new System.EventHandler(this.openTreeFormToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xSLTutorialToolStripMenuItem,
            this.reportDevWikiToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // xSLTutorialToolStripMenuItem
            // 
            this.xSLTutorialToolStripMenuItem.Name = "xSLTutorialToolStripMenuItem";
            this.xSLTutorialToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.xSLTutorialToolStripMenuItem.Text = "XSL Tutorial";
            this.xSLTutorialToolStripMenuItem.Click += new System.EventHandler(this.xSLTutorialToolStripMenuItem_Click);
            // 
            // reportDevWikiToolStripMenuItem
            // 
            this.reportDevWikiToolStripMenuItem.Name = "reportDevWikiToolStripMenuItem";
            this.reportDevWikiToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.reportDevWikiToolStripMenuItem.Text = "Report Dev Wiki";
            this.reportDevWikiToolStripMenuItem.Click += new System.EventHandler(this.reportDevWikiToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::Transformer.Properties.Resources.InformationSymbol_32xLG;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.posLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(333, 20);
            this.statusLabel.Text = "Press \'Transform\' to transform the XML document";
            // 
            // posLabel
            // 
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(89, 20);
            this.posLabel.Text = "Line 1, Col 4";
            this.posLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
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
            this.splitContainer1.Size = new System.Drawing.Size(1166, 557);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.scintillaSource);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.scintillaXSL);
            this.splitContainer2.Size = new System.Drawing.Size(1166, 361);
            this.splitContainer2.SplitterDistance = 583;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // scintillaSource
            // 
            this.scintillaSource.AllowDrop = true;
            this.scintillaSource.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaSource.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaSource.Location = new System.Drawing.Point(0, 0);
            this.scintillaSource.Name = "scintillaSource";
            this.scintillaSource.ScrollWidth = 1024;
            this.scintillaSource.Size = new System.Drawing.Size(583, 361);
            this.scintillaSource.TabIndex = 0;
            this.scintillaSource.TabWidth = 2;
            this.scintillaSource.Text = resources.GetString("scintillaSource.Text");
            this.scintillaSource.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.PrintPosition);
            // 
            // scintillaXSL
            // 
            this.scintillaXSL.AllowDrop = true;
            this.scintillaXSL.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaXSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaXSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaXSL.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaXSL.Location = new System.Drawing.Point(0, 0);
            this.scintillaXSL.Name = "scintillaXSL";
            this.scintillaXSL.ScrollWidth = 1248;
            this.scintillaXSL.Size = new System.Drawing.Size(578, 361);
            this.scintillaXSL.TabIndex = 0;
            this.scintillaXSL.TabWidth = 2;
            this.scintillaXSL.Text = resources.GetString("scintillaXSL.Text");
            this.scintillaXSL.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.PrintPosition);
            // 
            // scintillaOutput
            // 
            this.scintillaOutput.AllowDrop = true;
            this.scintillaOutput.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaOutput.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaOutput.Location = new System.Drawing.Point(0, 0);
            this.scintillaOutput.Name = "scintillaOutput";
            this.scintillaOutput.Size = new System.Drawing.Size(1166, 192);
            this.scintillaOutput.TabIndex = 0;
            this.scintillaOutput.TabWidth = 2;
            this.scintillaOutput.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.PrintPosition);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runButton,
            this.saveButton,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1166, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // runButton
            // 
            this.runButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runButton.Image = global::Transformer.Properties.Resources.icons8_Circled_Play_96;
            this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runButton.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(24, 24);
            this.runButton.Text = "toolStripButton1";
            this.runButton.ToolTipText = "Transform";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::Transformer.Properties.Resources.icons8_Save_96;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(24, 24);
            this.saveButton.Text = "toolStripButton2";
            this.saveButton.ToolTipText = "Save Output...";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Indent";
            this.toolStripButton1.Click += new System.EventHandler(this.indentClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Transformer.Properties.Resources.Search_32x;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 637);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(853, 600);
            this.Name = "MainForm";
            this.Text = "Transformer";
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
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem saveOutputAsToolStripMenuItem;
        public ScintillaXml scintillaSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton runButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripStatusLabel posLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xSLTutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportDevWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public ScintillaXml scintillaXSL;
        public ScintillaXml scintillaOutput;
        private System.Windows.Forms.ToolStripMenuItem wrapLinesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatAndIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setProcessorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saxonSelect;
        private System.Windows.Forms.ToolStripMenuItem dotNetSelect;
        private System.Windows.Forms.ToolStripMenuItem openTreeFormToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}