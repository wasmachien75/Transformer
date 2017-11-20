using System;
using System.Windows.Forms;

namespace TransformerApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.linkLabel1.Links.Add(68, 5, "http://www.saxonica.com");
            this.linkLabel1.Links.Add(78, 12, "https://github.com/jacobslusser/ScintillaNET");
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelClicked);
            string saxonVersion = new Saxon.Api.Processor().ProductVersion;
            this.linkLabel1.Text += saxonVersion;
            this.linkLabel1.Text += "\r\nBuild: " + System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString(" yyyyMMddHH");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=I9WMOOtjBxQ");
        }
    }
}
