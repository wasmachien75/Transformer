using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;
using System.Xml;

namespace TransformerApp
{
    public partial class ScintillaXml : Scintilla
    {

        private void scintilla_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                object x = e.Data.GetData(DataFormats.FileDrop);
                string filename = ((string[])x)[0];
                LoadContent(filename);
            }

        }

        private void scintilla_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
       
        public ScintillaXml()
        {
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(scintilla_DragDrop);
            this.DragEnter += new DragEventHandler(scintilla_DragEnter);
            this.TextChanged += new EventHandler(this.ScintillaTextChanged);
            this.InsertCheck += new EventHandler<InsertCheckEventArgs>(OnInsertCheck);
            this.TabWidth = 2;

            //No wrapping by default
            this.WrapMode = WrapMode.None;

            // Set the XML Lexer
            this.Lexer = Lexer.Xml;

            // Show line numbers
            this.Margins[0].Width = 10;

            // Enable folding
            this.SetProperty("fold", "1");
            this.SetProperty("fold.compact", "1");
            this.SetProperty("fold.html", "1");
            this.SetProperty("read.only", "1");

            // Use Margin 2 for fold markers
            this.Margins[2].Type = MarginType.Symbol;
            this.Margins[2].Mask = Marker.MaskFolders;
            this.Margins[2].Sensitive = true;
            this.Margins[2].Width = 20;

            // Reset folder markers
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                this.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                this.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Style the folder markers
            this.Markers[Marker.Folder].Symbol = MarkerSymbol.Arrow;
            this.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.ArrowDown;
            this.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.Arrow;
            this.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            this.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.ArrowDown;
            this.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            this.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            this.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;

            // Set the Styles
            this.StyleResetDefault();
            this.Styles[Style.Default].Font = "Consolas";
            this.Styles[Style.Default].Size = 9;
            this.StyleClearAll();
            this.Styles[Style.Xml.Attribute].ForeColor = Color.FromArgb(1, 232, 98, 101);
            this.Styles[Style.Xml.Entity].ForeColor = Color.FromArgb(1, 232, 98, 101);
            this.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            this.Styles[Style.Xml.Tag].ForeColor = Color.FromArgb(1, 11, 102, 204);
            this.Styles[Style.Xml.TagEnd].ForeColor = Color.FromArgb(1, 11, 102, 204);
            this.Styles[Style.Xml.DoubleString].ForeColor = Color.FromArgb(1, 214, 32, 171);
            this.Styles[Style.Xml.SingleString].ForeColor = Color.FromArgb(1, 214, 32, 171);
            this.Styles[Style.LineNumber].Size = 9;
            this.Styles[Style.LineNumber].Font = "Consolas";
            InitializeComponent();
        }

        private int maxLineNumberCharLength;

        private void ScintillaTextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var scintilla = sender as ScintillaXml;
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        public void ToggleWrap()
        {
            if (this.WrapMode == WrapMode.Word)
            {
                this.WrapMode = WrapMode.None;
            }
            else
            {
                this.WrapMode = WrapMode.Word;
            }
        }

        public void SaveOutput()
        {
            string content = this.Text;
            if (content == "")
            {
                MessageBox.Show("Empty output, will not save.");
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (this.ContentIsXml()) dialog.Filter = "XML Document|*.xml|Text Document|*.txt|All Files|*.*";
                else dialog.Filter = "Text Document|*.txt|All Files|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string loc = dialog.FileName;
                        using(StreamWriter file = new StreamWriter(loc))
                        {
                            file.Write(content);
                        }

                    }
            }
            
            
        }

        public void Indent()
        {
            XmlIndenter indenter = new XmlIndenter();
            if (indenter.LoadXml(this.Text))
            {
                string indentedXML = indenter.Indent();
                this.Text = indentedXML;
            }
        }

        public void LoadContent(string path)
        {
            FileStream fs = File.OpenRead(path);
            StreamReader sr = new StreamReader(fs);
            Text = sr.ReadToEnd();
        }

        public bool ContentIsXml()
        {
            string content = this.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(content);
            MemoryStream stream = new MemoryStream(byteArray);
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(content);
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Exception thrown => not XML");
                return false;
            }
            return true;
        }

        private void OnInsertCheck(object sender, InsertCheckEventArgs e)
        {
            if ((e.Text.EndsWith("\r") || e.Text.EndsWith("\n")))
            {
                string fragment = this.Text.Substring(0, this.CurrentPosition);
                XmlDepthFinder depthfinder = new XmlDepthFinder();
                int tabs = depthfinder.GetDepth(fragment);
                e.Text += new string('\t', tabs);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
