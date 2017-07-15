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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransformerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void printPosition(object sender, EventArgs e)
        {
            ScintillaXml sc = sender as ScintillaXml;
            int pos = sc.GetColumn(sc.CurrentPosition) + 1;
            int line = sc.CurrentLine + 1;
            posLabel.Text = "Line " + line.ToString() + ", Col " + pos.ToString();
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
            Transformer xformer = new Transformer();
          
                MemoryStream stream = new MemoryStream();
                StreamWriter writer =  xformer.createWriter(stream); // writer will write to the stream

            if (xformer.Transform(XmlReader.Create(source), XmlReader.Create(xsl), writer, this))
            {
                printOutput(stream, scintillaOutput);
                scintillaOutput.ReadOnly = true;
                watch.Stop();
                string elapsedSecs = ((double) watch.ElapsedMilliseconds / 1000).ToString("0.00");
                updateStatusBar("😃 Transformation succeeded in " + elapsedSecs + " s");
                writer = null;
            }
            
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Transform();
        }

        private void updateStatusBar(string str)
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

        private void loadAndPrintFile(string filename, ScintillaXml scintilla)
        {
            if (filename != "")
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    try
                    {
                        // Read the stream to a string, and write the string to the console.
                        string line = sr.ReadToEnd();
                        scintilla.Text = line;
                    }

                    catch(Exception e)
                    {
                        statusLabel.Text = e.Message;
                    }
                }
            }
        }

        private void loadStylesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = chooseFile("XSLT Stylesheets (*.xsl;*.xslt)|*.xsl;*.xslt");
            loadAndPrintFile(filename, scintillaXSL);
            
        }

        private void loadSourceXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = chooseFile("XML Documents (*.xml)|*.xml");
            loadAndPrintFile(filename, scintillaSource);
        }

        private void somethingElseToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openTestFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm testform = new TestForm();
            testform.Show();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void wrapLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintillaSource.ToggleWrap();
            scintillaXSL.ToggleWrap();
            scintillaOutput.ToggleWrap();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            scintillaOutput.SaveOutput();
        }

        private void saveOutputAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintillaOutput.SaveOutput();
        }

        private void xSLTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.w3schools.com/xml/xsl_intro.asp");
        }

        private void reportDevWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wiki.mediagenix.tv/display/Webdev"); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            scintillaSource.Indent();
            scintillaXSL.Indent();
            System.Diagnostics.Debug.Write(scintillaOutput.ContentIsXml());
            if (scintillaOutput.ContentIsXml())
            {
                scintillaOutput.ReadOnly = false;
                scintillaOutput.Indent();
                scintillaOutput.ReadOnly = true;
            }
        }
    }
}
