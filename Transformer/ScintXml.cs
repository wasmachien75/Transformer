using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;
using System.Xml;

namespace TransformerApp
{
    public partial class ScintillaXml : Scintilla
    {
        public ScintillaXml()
        {
            //No wrapping by default
            this.WrapMode = WrapMode.None;

            // Set the XML Lexer
            this.Lexer = Lexer.Xml;

            // Show line numbers
            this.Margins[0].Width = 30;

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
            this.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            this.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            this.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            this.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            this.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            this.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            this.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            this.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            this.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;

            // Set the Styles
            this.StyleResetDefault();
            this.Styles[Style.Default].Font = "Consolas";
            this.Styles[Style.Default].Size = 10;
            this.StyleClearAll();
            this.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            this.Styles[Style.Xml.Entity].ForeColor = Color.Red;
            this.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            this.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            this.Styles[Style.Xml.TagEnd].ForeColor = Color.Blue;
            this.Styles[Style.Xml.DoubleString].ForeColor = Color.DeepPink;
            this.Styles[Style.Xml.SingleString].ForeColor = Color.DeepPink;
            InitializeComponent();
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

        private bool ContentIsXml()
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
                return false;
            }
            return true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
