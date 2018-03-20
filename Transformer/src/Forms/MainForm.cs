using System;
using System.IO;
using System.Windows.Forms;
using ScintillaNET;
using System.Linq;
using System.Diagnostics;

namespace TransformerApp
{
    public partial class MainForm : Form
    {
        private XslProcessor processor = Transformer.Properties.Settings.Default.XslProcessor;

        bool simpleMode = false;

        public MainForm(string[] args)
        {
            InitializeComponent();
            Setup();
            EvaluateArgs(args);
        }

        private string GetDebugInfo()
        {
            using (Process proc = Process.GetCurrentProcess())
            {
                RunStats runStats = new RunStats(proc, scintillaSource.Text, processor);
                return runStats.Stats;
            }

        }

        public void MainFormKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.P)
            {
                MessageBox.Show(GetDebugInfo(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Setup()
        {
            this.scintillaSource.UpdateUI += new EventHandler<UpdateUIEventArgs>(PrintPosition);
            this.scintillaXSL.UpdateUI += new EventHandler<UpdateUIEventArgs>(PrintPosition);
            this.scintillaOutput.UpdateUI += new EventHandler<UpdateUIEventArgs>(PrintPosition);
            this.splitContainer2.SplitterWidth = 2;
        }

        private void EvaluateArgs(string[] args)
        {
            string[] xmlExt = new string[] { ".xml", String.Empty };
            string[] xsltExt = new string[] { ".xsl", ".xslt" };
            if (args != null && args.Length != 0)
            {
                if (xmlExt.Contains(Path.GetExtension(args[0])))
                {
                    LoadAndPrintFile(args[0], scintillaSource);
                }

                else if (xsltExt.Contains(Path.GetExtension(args[0])))
                {
                    LoadAndPrintFile(args[0], scintillaXSL);
                }
            }
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

        public void PrintOutput(string output, Scintilla sc)
        {
            sc.ReadOnly = false;
            sc.Text = output;
            sc.ReadOnly = true;
        }

        private void Transform()
        {
            using (MemoryStream xmlStream = Helper.createStream(scintillaSource.Text))
            using (MemoryStream xslStream = Helper.createStream(scintillaXSL.Text))
            {
                XslTransformer transformer = new XslTransformer(xmlStream, xslStream);

                try
                {
                    transformer.Transform(processor);
                    using (Stream result = transformer.Result)
                    {
                        PrintOutput(new StreamReader(result).ReadToEnd(), scintillaOutput);
                        UpdateStatusBar(String.Format("Transformation succeeded in {0} s", transformer.ElapsedSecs));
                        statusLabel.Image = Transformer.Properties.Resources.GreenCheckMark;
                    };

                }

                catch (Exception e)
                {
                    UpdateStatusBar(e.Message.TrimEnd());
                    statusLabel.Image = Transformer.Properties.Resources.RedCross;
                }

            }
        }

        private void UpdateStatusBar(string str) => statusLabel.Text = str;

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void LoadAndPrintFile(string filename, ScintillaXml scintilla)
        {
            if (filename != "")
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    try
                    {
                        string line = sr.ReadToEnd();
                        scintilla.Text = line;
                    }

                    catch (Exception e)
                    {
                        statusLabel.Text = e.Message;
                    }
                }
            }
        }

        private void LoadStylesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = ChooseFile("XSLT Stylesheets (*.xsl;*.xslt)|*.xsl;*.xslt");
            LoadAndPrintFile(filename, scintillaXSL);
        }

        private void LoadSourceXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = ChooseFile("XML Documents (*.xml)|*.xml");
            LoadAndPrintFile(filename, scintillaSource);
        }

        private void RunButton_Click(object sender, EventArgs e) => Transform();

        private void WrapLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintillaSource.ToggleWrap();
            scintillaXSL.ToggleWrap();
            scintillaOutput.ToggleWrap();
            wrapLinesToolStripMenuItem1.Checked = !wrapLinesToolStripMenuItem1.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e) => scintillaOutput.SaveOutput();

        private void XSLTutorialToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("https://www.w3schools.com/xml/xsl_intro.asp");

        private void ReportDevWikiToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("https://wiki.mediagenix.tv/display/Webdev");

        private void IndentClick(object sender, EventArgs e)
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

        private void SaxonOptionsClick(object sender, EventArgs e) => SelectProcessor(XslProcessor.Saxon);

        private void DotNetSelect_Click(object sender, EventArgs e) => SelectProcessor(XslProcessor.DotNet);

        private void MSXML60ToolStripMenuItem_Click(object sender, EventArgs e) => SelectProcessor(XslProcessor.MSXML);

        private void SelectProcessor(XslProcessor processor)
        {
            this.processor = processor;
            saxonSelect.Checked = (processor == XslProcessor.Saxon);
            dotNetSelect.Checked = (processor == XslProcessor.DotNet);
            msxmlSelect.Checked = (processor == XslProcessor.MSXML);
        }

        private void PrintPosition(object sender, UpdateUIEventArgs e)
        {
            ScintillaXml sc = sender as ScintillaXml;
            int pos = sc.GetColumn(sc.CurrentPosition) + 1;
            int line = sc.CurrentLine + 1;
            posLabel.Text = "| Line " + line.ToString() + ", Col " + pos.ToString();
        }

        private void OpenTreeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scintillaSource.ContentIsXml())
            {
                TreeViewForm tvf = new TreeViewForm(scintillaSource.Text);
                tvf.Show();
            }

            else
            {
                MessageBox.Show("Could not load source tree because the source view does not contain valid XML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void XPathQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XPathQueryForm xqf = new XPathQueryForm(scintillaSource.Text);
            xqf.Show();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(this);
            sf.Show();
        }

        private void SimpleModeToolStripMenuItem_Click(object sender, EventArgs e) => ToggleSimpleMode();

        private void ToggleSimpleMode()
        {
            if (simpleMode)
            {
                scintillaSource.SetStyle();
                scintillaXSL.SetStyle();
                scintillaOutput.SetStyle();
            }
            else
            {
                scintillaSource.ClearStyle();
                scintillaXSL.ClearStyle();
                scintillaOutput.ClearStyle();
            }
            
            indentButton.Enabled = !indentButton.Enabled;
            formatAndIndentToolStripMenuItem.Enabled = !formatAndIndentToolStripMenuItem.Enabled;
            simpleMode = !simpleMode;
        }

        private void validateXSLTtestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintillaXSL.Validate();
        }
    }
}
