using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            buildLabel.Text += System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString(" yyyyMMddHH");
            this.linkLabel1.Links.Add(68, 5, "http://www.saxonica.com");
            this.linkLabel1.Links.Add(78, 12, "https://github.com/jacobslusser/ScintillaNET");
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }
    }
}
