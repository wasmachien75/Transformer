using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TransformerApp
{
    public partial class SearchForm : Form
    {
        private MainForm form;
        private ScintillaXml source;
        private ScintillaXml xsl;
        private ScintillaXml output;
        private int searchStart = -1;

        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();
            form = mainForm;
            source = form.scintillaSource;
            xsl = form.scintillaXSL;
            output = form.scintillaOutput;
        }

        private ScintillaXml getView()
        {
            if (sourceRadio.Checked) return source;
            if (xslRadio.Checked) return xsl;
            if (outputRadio.Checked) return output;
            return null;
        }

        private int getSearchStart(ScintillaXml sc)
        {
            if (searchStart == -1)
            {
                return sc.CurrentPosition;
            }
            else
            {
                return searchStart;
            }
        }

        private void findPrevButton_Click(object sender, EventArgs e)
        {
            ScintillaXml sc = getView();
            if (textBox1.Text.Trim() != "")
            {
                searchStart = sc.FindPrevious(textBox1.Text, getSearchStart(sc));
                form.Activate();
            }
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            ScintillaXml sc = getView();
            if (textBox1.Text.Trim() != "")
            {
                searchStart = sc.FindNext(textBox1.Text, getSearchStart(sc));
                form.Activate();
            }
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            ScintillaXml sc = getView();
            if (textBox1.Text.Trim() != "")
            {
                int resultCount = sc.FindAll(textBox1.Text);
                string occurrencesString = (resultCount == 1) ? "occurrence" : "occurrences";
                searchStatus.Text = String.Format("{0} {1} found.", resultCount.ToString(), occurrencesString);
                form.Activate();
            }
        }

        private void ResetOpacity(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void LowerOpacity(object sender, EventArgs e)
        {
            try
            {
                Opacity = 0.8;
            }
            catch (Win32Exception)
            {
                // search form has been closed, don't do anything
            }
            
        }

        private void ClearIndicator(object sender, FormClosingEventArgs e)
        {
            source.ClearSearchIndication();
            xsl.ClearSearchIndication();
            output.ClearSearchIndication();
        }
    }
}
