using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace TransformerApp
{
    public partial class XPathQueryForm : Form
    {
        private XPathDocument dom;
        private string query;
        private XPathNodeIterator result;

        public XPathQueryForm(string sourceText)
        {
            InitializeComponent();
            StringReader sr = new StringReader(sourceText);
            XmlReader xr = XmlReader.Create(sr);
            dom = new XPathDocument(xr);

        }

        private string BuildXPathStringFromAncestors(XPathNodeIterator xpn)
        {
            List<string> ancestors = new List<string>();
            foreach (XPathNavigator node in xpn)
            {
                ancestors.Add(node.Name);
            }
            ancestors.Reverse();
            StringBuilder sb = new StringBuilder();

            foreach (string item in ancestors)
            {
                if (item != "")
                {
                    sb.AppendFormat("/{0}", item);
                }
            }

            return sb.ToString();
        }

        private void UpdateLabel(string message)
        {

            statusLabel.Text = message;
        }
        private void ExecuteQuery(string query)
        {
            XPathNavigator xpn = dom.CreateNavigator();
            try
            {
                XPathNodeIterator xpni = (XPathNodeIterator)xpn.Evaluate(query);
                string resultSingleOrMultiple = (xpni.Count == 1) ? " result" : " results";
                UpdateLabel(xpni.Count.ToString() + resultSingleOrMultiple + " found.");
                result = xpni;
            }

            catch (XPathException e)
            {
                UpdateLabel(e.Message);
            }

            catch (InvalidCastException)
            {
                object result = xpn.Evaluate(query);
                ListViewItem lvi = new ListViewItem(new string[] { "", result.ToString(), "" });
                xPathList.Items.Add(lvi);
            }

        }

        private string GetNodeValue(XPathNavigator node)
        {
            if (node.NodeType == XPathNodeType.Attribute)
            {
                return node.Value;
            }
            else if (node.NodeType == XPathNodeType.Element)
            {
                XPathNavigator xpn = node.SelectSingleNode("text()");
                if (xpn != null)
                {
                    return xpn.Value;
                }

            }
            return "";
        }

        private void ParseResult(XPathNodeIterator xpi)
        {
            xPathList.Items.Clear();
            foreach (XPathNavigator node in xpi)
            {
                XPathNodeIterator ancestors = node.SelectAncestors(XPathNodeType.All, true);
                string xPathString = BuildXPathStringFromAncestors(ancestors);
                string value = GetNodeValue(node);

                ListViewItem item = new ListViewItem(new string[] { (xPathList.Items.Count + 1).ToString(), xPathString, value, node.NodeType.ToString() });
                xPathList.Items.Add(item);
                xPathList.Items[xPathList.Items.Count - 1].ToolTipText = xPathString;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            query = xpathQueryTextbox.Text;
            xPathList.Items.Clear();
            ExecuteQuery(query);
            if (result != null)
            {
                ParseResult(result);
            }

            this.Height = 450;
            this.xPathList.Visible = true;
            xPathList.Columns[0].Width = -2;
            xPathList.ShowItemToolTips = true;

        }
    }
}
