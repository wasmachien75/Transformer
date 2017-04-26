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
    public partial class Options : Form
    {
        private MainForm form;

        public Options(MainForm form)
        {
            InitializeComponent();
            this.form = form;
            
        }

        private void EvaluateOptions()
        {
            Properties.Settings.Default.wrap = checkBoxTextWrap.Checked;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            EvaluateOptions();
            form.Refresh();
        }
    }
}
