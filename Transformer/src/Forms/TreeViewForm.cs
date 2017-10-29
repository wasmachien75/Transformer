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
        private string xml;
        public TreeViewForm(string xml)
        {
            InitializeComponent();
            this.xml = xml;
            XmlReader reader = LoadXml();
            AddNodes();
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

        public void AddNodes()
        {
            XmlDocument dom = new XmlDocument();
            try
            {
                dom.LoadXml(xml);
            }
            catch (XmlException)
            {
                MessageBox.Show("Could not load source tree because of invalid XML.");
                return;
            }
           
            treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
            TreeNode tnode = new TreeNode();
            tnode = treeView1.Nodes[0];
            AddNode(dom.DocumentElement, tnode);
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            if(inXmlNode.Attributes != null && inXmlNode.Attributes.Count > 0)
            {
                foreach (XmlAttribute attribute in inXmlNode.Attributes)
                {
                    inTreeNode.Nodes.Add(attribute.Name + " = " + attribute.Value);
                }
            }
            
            int i;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i < nodeList.Count;  i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i + inXmlNode.Attributes.Count];
                    AddNode(xNode, tNode);
                }
            }

            else
            {
                if (inXmlNode.HasChildNodes == false && inXmlNode.Value != null)
                {
                    inTreeNode.Text = (inXmlNode.OuterXml).Trim();
                }
                else
                {
                    inTreeNode.Text = (inXmlNode.Name).Trim();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void expandAllButton_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
