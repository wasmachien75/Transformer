using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerApp
{
    public partial class SearchForm : Form
    {
        private MainForm form;
        private ScintillaXml sc;
        private int searchStart;

        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();
            form = mainForm;
            sc = form.scintillaSource;
            searchStart = sc.CurrentPosition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                searchStart = sc.FindPrevious(textBox1.Text, searchStart);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim() != "")
            {
                searchStart = sc.FindNext(textBox1.Text, searchStart);
            }
        }
    }
}
