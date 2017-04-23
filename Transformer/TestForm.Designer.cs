namespace Transformer
{
    partial class TestForm
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
            this.scintillaXml1 = new ScintillaXml();
            this.SuspendLayout();
            // 
            // scintillaXml1
            // 
            this.scintillaXml1.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintillaXml1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaXml1.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaXml1.Location = new System.Drawing.Point(0, 0);
            this.scintillaXml1.Name = "scintillaXml1";
            this.scintillaXml1.Size = new System.Drawing.Size(506, 381);
            this.scintillaXml1.TabIndex = 0;
            this.scintillaXml1.Text = "scintillaXml1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 381);
            this.Controls.Add(this.scintillaXml1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaXml scintillaXml1;
    }
}