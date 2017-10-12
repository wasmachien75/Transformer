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
            dom.LoadXml(xml);
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
            if (inXmlNode.Attributes != null)
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
                for (i = inXmlNode.Attributes.Count; i < nodeList.Count; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }

            else
            {
                inTreeNode.Text = (inXmlNode.Name).Trim();
            }
        }

    }
}
