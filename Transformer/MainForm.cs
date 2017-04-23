//TODO: 
//- Status bar
//- Auto XML tag closing
//- Buttons
//- Options (Wrap)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using ScintillaNET;

namespace Transformer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void setScintillaStyle(Scintilla scintilla)
        {
            // Set line wrap
            if (Properties.Settings.Default.wrap) scintilla.WrapMode = WrapMode.Word;
            else scintilla.WrapMode = WrapMode.None;
            System.Diagnostics.Debug.WriteLine("Wrap set to: " + scintilla.WrapMode);
            
            
            // Set the XML Lexer
            scintilla.Lexer = Lexer.Xml;

            // Show line numbers
            scintilla.Margins[0].Width = 30;

            // Enable folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");
            scintilla.SetProperty("fold.html", "1");
            scintilla.SetProperty("read.only", "1");

            // Use Margin 2 for fold markers
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;

            // Reset folder markers
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Style the folder markers
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;

            // Set the Styles
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();
            scintilla.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            scintilla.Styles[Style.Xml.Entity].ForeColor = Color.Red;
            scintilla.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            scintilla.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.TagEnd].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.DoubleString].ForeColor = Color.DeepPink;
            scintilla.Styles[Style.Xml.SingleString].ForeColor = Color.DeepPink;
        }

        public string chooseFile(string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            ofd.InitialDirectory = "C:\\";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return "";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Scintilla[] sc = new Scintilla[] { scintillaXSL, scintillaSource, scintillaOutput };
            for (int i = 0; i < sc.Length; i++)
            {
                setScintillaStyle(sc[i]);
            }
        }

        private void printOutput(MemoryStream stream, Scintilla sc)
        {
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            string output = reader.ReadToEnd();
            sc.Text = output;
        }

        private void Transform()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            scintillaOutput.ReadOnly = false; // Remove read-only status from output so we can write to it

            TextReader source = new StringReader(scintillaSource.Text);
            TextReader xsl = new StringReader(scintillaXSL.Text);
            Console.Write(source.ToString(), xsl.ToString());
            Transformer xformer = new Transformer();
          
                MemoryStream stream = new MemoryStream();
                StreamWriter writer =  xformer.createWriter(stream); // writer will write to the stream

            if (xformer.Transform(XmlReader.Create(source), XmlReader.Create(xsl), writer, this))
            {
                printOutput(stream, scintillaOutput); // print output to tabpage
                scintillaOutput.ReadOnly = true; // Set output back to read-only
                watch.Stop();
                string elapsedSecs = ((double) watch.ElapsedMilliseconds / 1000).ToString("0.00");
                updateStatusBar("😃 Transformation succeeded in " + elapsedSecs + " s");
            }
            
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Transform();
            

        }

        public void updateStatusBar(string str)
        {
            statusLabel.Text = str;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void loadStylesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chooseFile("XSLT Stylesheets (*.xsl;*.xslt)|*.xsl;*.xslt") ;
        }

        private void loadSourceXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chooseFile("XML Documents (*.xml)|*.xml");
        }

        public static Options options = null; // using this boolean to check if an options window is already opened

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (options != null)
            {
                options.BringToFront();
            }
            else {
                options = new Options(this);
                options.Show();
                setScintillaStyle(scintillaXSL);
            }

        }

    }

}
