namespace TransformerApp
{
    partial class SearchForm
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
            this.findPrevButton = new System.Windows.Forms.Button();
            this.findNextButton = new System.Windows.Forms.Button();
            this.findAllButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.searchStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sourceRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.outputRadio = new System.Windows.Forms.RadioButton();
            this.xslRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // findPrevButton
            // 
            this.findPrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findPrevButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.findPrevButton.Location = new System.Drawing.Point(54, 140);
            this.findPrevButton.Name = "findPrevButton";
            this.findPrevButton.Size = new System.Drawing.Size(87, 29);
            this.findPrevButton.TabIndex = 1;
            this.findPrevButton.Text = "Find prev.";
            this.findPrevButton.UseVisualStyleBackColor = true;
            this.findPrevButton.Click += new System.EventHandler(this.findPrevButton_Click);
            // 
            // findNextButton
            // 
            this.findNextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findNextButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.findNextButton.Location = new System.Drawing.Point(54, 100);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(87, 29);
            this.findNextButton.TabIndex = 2;
            this.findNextButton.Text = "Find next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // findAllButton
            // 
            this.findAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.findAllButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAllButton.Location = new System.Drawing.Point(216, 100);
            this.findAllButton.Name = "findAllButton";
            this.findAllButton.Size = new System.Drawing.Size(87, 29);
            this.findAllButton.TabIndex = 3;
            this.findAllButton.Text = "Find all";
            this.findAllButton.UseVisualStyleBackColor = true;
            this.findAllButton.Click += new System.EventHandler(this.findAllButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 175);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // searchStatus
            // 
            this.searchStatus.Name = "searchStatus";
            this.searchStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // sourceRadio
            // 
            this.sourceRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sourceRadio.AutoSize = true;
            this.sourceRadio.Checked = true;
            this.sourceRadio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceRadio.Location = new System.Drawing.Point(9, 24);
            this.sourceRadio.Name = "sourceRadio";
            this.sourceRadio.Size = new System.Drawing.Size(103, 23);
            this.sourceRadio.TabIndex = 5;
            this.sourceRadio.TabStop = true;
            this.sourceRadio.Text = "Source XML";
            this.sourceRadio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radioGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 94);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // radioGroup
            // 
            this.radioGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioGroup.Controls.Add(this.outputRadio);
            this.radioGroup.Controls.Add(this.xslRadio);
            this.radioGroup.Controls.Add(this.sourceRadio);
            this.radioGroup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup.Location = new System.Drawing.Point(13, 3);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(333, 55);
            this.radioGroup.TabIndex = 7;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Select view";
            // 
            // outputRadio
            // 
            this.outputRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputRadio.AutoSize = true;
            this.outputRadio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRadio.Location = new System.Drawing.Point(252, 24);
            this.outputRadio.Name = "outputRadio";
            this.outputRadio.Size = new System.Drawing.Size(75, 23);
            this.outputRadio.TabIndex = 7;
            this.outputRadio.TabStop = true;
            this.outputRadio.Text = "Output";
            this.outputRadio.UseVisualStyleBackColor = true;
            // 
            // xslRadio
            // 
            this.xslRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xslRadio.AutoSize = true;
            this.xslRadio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xslRadio.Location = new System.Drawing.Point(144, 24);
            this.xslRadio.Name = "xslRadio";
            this.xslRadio.Size = new System.Drawing.Size(52, 23);
            this.xslRadio.TabIndex = 6;
            this.xslRadio.TabStop = true;
            this.xslRadio.Text = "XSL";
            this.xslRadio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 25);
            this.textBox1.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 197);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.findPrevButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findAllButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Search";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.ResetOpacity);
            this.Deactivate += new System.EventHandler(this.LowerOpacity);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClearIndicator);
            this.Click += new System.EventHandler(this.ResetOpacity);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findPrevButton;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button findAllButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel searchStatus;
        private System.Windows.Forms.RadioButton sourceRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton xslRadio;
        private System.Windows.Forms.RadioButton outputRadio;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.TextBox textBox1;
    }
}