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
using Transformer.tests;

namespace TransformerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }

}
