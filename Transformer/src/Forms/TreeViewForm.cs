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
            ImageList imglist = new ImageList();
            imglist.Images.Add(Transformer.Properties.Resources.Folder_32xMD);
            imglist.Images.Add(Transformer.Properties.Resources.Attribute_32xMD);
            imglist.Images.Add(Transformer.Properties.Resources.WebFolder_16x);
            InitializeComponent();
            treeView1.ImageList = imglist;
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
            TreeNode root = new TreeNode(dom.DocumentElement.Name);
            root.ImageIndex = 2;
            root.SelectedImageIndex = 2;
            treeView1.Nodes.Add(root);
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
                    inTreeNode.Nodes[inTreeNode.Nodes.Count - 1].ImageIndex = 1;
                    inTreeNode.Nodes[inTreeNode.Nodes.Count - 1].SelectedImageIndex = 1;
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
    }
}
