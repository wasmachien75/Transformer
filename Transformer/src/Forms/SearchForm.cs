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

        public SearchForm(MainForm mainForm)
        {
            InitializeComponent();
            form = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.scintillaSource.FindSomething(textBox1.Text);
        }
    }
}
