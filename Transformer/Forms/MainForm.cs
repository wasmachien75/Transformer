using System;
using System.IO;
using System.Windows.Forms;
using ScintillaNET;

namespace TransformerApp
{
    public partial class MainForm : Form
    {
        static XslProcessor processor = XslProcessor.Saxon; //Saxon is our default XSLT processor

        public MainForm()
        {
            InitializeComponent();
        }

        private void PrintPosition(object sender, EventArgs e)
        {
            ScintillaXml sc = sender as ScintillaXml;
            int pos = sc.GetColumn(sc.CurrentPosition) + 1;
            int line = sc.CurrentLine + 1;
            posLabel.Text = "Line " + line.ToString() + ", Col " + pos.ToString();
        }
       

        private string ChooseFile(string filter)
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

        public void PrintOutput(Stream stream, Scintilla sc)
        {
            sc.ReadOnly = false;
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            string output = reader.ReadToEnd();
            sc.Text = output;
            sc.ReadOnly = true;
        }

        private void Transform()
        {
            XslTransformer transformer = new XslTransformer(this);
            try
            {
                transformer.TransformIt(processor);
                scintillaOutput.Text = transformer.Result;
                UpdateStatusBar(String.Format("Transformation succeeded in {0} s", transformer.ElapsedSecs));
                statusLabel.Image =  Transformer.Properties.Resources.GreenCheckMark;
            }

            catch(Exception e)
            {
                UpdateStatusBar(e.Message);
                statusLabel.Image = Transformer.Properties.Resources.RedCross;
            }
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Transform();
        }

        private void UpdateStatusBar(string str)
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
            string filename = ChooseFile("XSLT Stylesheets (*.xsl;*.xslt)|*.xsl;*.xslt");
            loadAndPrintFile(filename, scintillaXSL);
        }

        private void loadSourceXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = ChooseFile("XML Documents (*.xml)|*.xml");
            loadAndPrintFile(filename, scintillaSource);
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
            wrapLinesToolStripMenuItem1.Checked = !wrapLinesToolStripMenuItem1.Checked;
            
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

        private void indentClick(object sender, EventArgs e)
        {
            scintillaSource.Indent();
            scintillaXSL.Indent();
            if (scintillaOutput.ContentIsXml())
            {
                scintillaOutput.ReadOnly = false;
                scintillaOutput.Indent();
                scintillaOutput.ReadOnly = true;
            }
        }

        private void saxonOptionsClick(object sender, EventArgs e)
        {
            processor = XslProcessor.Saxon;
            dotNetSelect.Checked = false;
        }

        private void dotNetSelect_Click(object sender, EventArgs e)
        {
            processor = XslProcessor.DotNet;
            saxonSelect.Checked = false;
        }
    }
}
