namespace TransformerApp
{
    partial class XPathQueryForm
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
            this.xpathQueryTextbox = new System.Windows.Forms.TextBox();
            this.xPathList = new System.Windows.Forms.ListView();
            this.xPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xpathQueryTextbox
            // 
            this.xpathQueryTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xpathQueryTextbox.Location = new System.Drawing.Point(141, 51);
            this.xpathQueryTextbox.Multiline = true;
            this.xpathQueryTextbox.Name = "xpathQueryTextbox";
            this.xpathQueryTextbox.Size = new System.Drawing.Size(248, 75);
            this.xpathQueryTextbox.TabIndex = 0;
            // 
            // xPathList
            // 
            this.xPathList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.xPathColumn,
            this.columnHeader1});
            this.xPathList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xPathList.Location = new System.Drawing.Point(0, 185);
            this.xPathList.Name = "xPathList";
            this.xPathList.Size = new System.Drawing.Size(493, 239);
            this.xPathList.TabIndex = 2;
            this.xPathList.UseCompatibleStateImageBehavior = false;
            this.xPathList.View = System.Windows.Forms.View.Details;
            // 
            // xPathColumn
            // 
            this.xPathColumn.DisplayIndex = 1;
            this.xPathColumn.Text = "XPath";
            this.xPathColumn.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "XPath query:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(314, 142);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // XPathQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 424);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xpathQueryTextbox);
            this.Controls.Add(this.xPathList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "XPathQueryForm";
            this.Text = "XPathQueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xpathQueryTextbox;
        private System.Windows.Forms.ListView xPathList;
        private System.Windows.Forms.ColumnHeader xPathColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
    }
}