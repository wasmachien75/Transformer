namespace Transformer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scintillaSource = new ScintillaNET.Scintilla();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scintillaXSL = new ScintillaNET.Scintilla();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scintillaOutput = new ScintillaNET.Scintilla();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSourceXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStylesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrapLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingElseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scintillaSource);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source XML";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // scintillaSource
            // 
            this.scintillaSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaSource.Location = new System.Drawing.Point(3, 3);
            this.scintillaSource.Name = "scintillaSource";
            this.scintillaSource.ScrollWidth = 7409;
            this.scintillaSource.Size = new System.Drawing.Size(821, 465);
            this.scintillaSource.TabIndex = 1;
            this.scintillaSource.Text = resources.GetString("scintillaSource.Text");
            this.scintillaSource.WrapMode = ScintillaNET.WrapMode.Word;
            this.scintillaSource.Click += new System.EventHandler(this.scintilla2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.scintillaXSL);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stylesheet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // scintillaXSL
            // 
            this.scintillaXSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaXSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaXSL.Location = new System.Drawing.Point(3, 3);
            this.scintillaXSL.Name = "scintillaXSL";
            this.scintillaXSL.ScrollWidth = 1354;
            this.scintillaXSL.Size = new System.Drawing.Size(821, 465);
            this.scintillaXSL.TabIndex = 0;
            this.scintillaXSL.Text = resources.GetString("scintillaXSL.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.scintillaOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // scintillaOutput
            // 
            this.scintillaOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintillaOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaOutput.Location = new System.Drawing.Point(3, 3);
            this.scintillaOutput.Name = "scintillaOutput";
            this.scintillaOutput.ScrollWidth = 1354;
            this.scintillaOutput.Size = new System.Drawing.Size(821, 465);
            this.scintillaOutput.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSourceXMLToolStripMenuItem,
            this.loadStylesheetToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadSourceXMLToolStripMenuItem
            // 
            this.loadSourceXMLToolStripMenuItem.Name = "loadSourceXMLToolStripMenuItem";
            this.loadSourceXMLToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.loadSourceXMLToolStripMenuItem.Text = "Load Source XML";
            this.loadSourceXMLToolStripMenuItem.Click += new System.EventHandler(this.loadSourceXMLToolStripMenuItem_Click);
            // 
            // loadStylesheetToolStripMenuItem
            // 
            this.loadStylesheetToolStripMenuItem.Name = "loadStylesheetToolStripMenuItem";
            this.loadStylesheetToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.loadStylesheetToolStripMenuItem.Text = "Load Stylesheet";
            this.loadStylesheetToolStripMenuItem.Click += new System.EventHandler(this.loadStylesheetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
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
            this.somethingElseToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // wrapLinesToolStripMenuItem
            // 
            this.wrapLinesToolStripMenuItem.CheckOnClick = true;
            this.wrapLinesToolStripMenuItem.Name = "wrapLinesToolStripMenuItem";
            this.wrapLinesToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.wrapLinesToolStripMenuItem.Text = "Wrap Lines";
            // 
            // somethingElseToolStripMenuItem
            // 
            this.somethingElseToolStripMenuItem.Name = "somethingElseToolStripMenuItem";
            this.somethingElseToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.somethingElseToolStripMenuItem.Text = "Something Else";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(333, 20);
            this.toolStripStatusLabel1.Text = "Press \'Transform\' to transform the XML document";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(853, 600);
            this.Name = "MainForm";
            this.Text = "Transformer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ScintillaNET.Scintilla scintillaXSL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSourceXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStylesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private ScintillaNET.Scintilla scintillaOutput;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public ScintillaNET.Scintilla scintillaSource;
        private System.Windows.Forms.ToolStripMenuItem wrapLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingElseToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}