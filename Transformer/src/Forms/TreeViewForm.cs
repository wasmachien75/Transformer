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

namespace TransformerApp
{
    public partial class TreeViewForm : Form
    {
        private int _nodeCount;
        private string xml;
        public int NodeCount { get { return _nodeCount; } set { } }
        public TreeViewForm(string xml)
        {
            InitializeComponent();
            this.xml = xml;
            XmlReader reader = LoadXml();
            AddNodes(reader);
        }

        public XmlReader LoadXml()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter sw = new StreamWriter(stream);
            sw.Write(xml);
            sw.Flush();
            stream.Position = 0;
            XmlReader xreader = XmlReader.Create(stream);
            return xreader;
        }

        public void AddNodes(XmlReader reader)
        {
            while (reader.Read())
            {
                treeView1.Nodes.Add(reader.Value);
               
            }
            System.Diagnostics.Debug.Write(treeView1.Nodes.Count);
            this._nodeCount = treeView1.Nodes.Count;
        }

    }
}
