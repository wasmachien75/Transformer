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
                sb.AppendFormat("/{0}", item);
            }
            
            return sb.ToString();
        }
        private void ExecuteQuery(string query)
        {
            XPathNavigator xpn = dom.CreateNavigator();
            try
            {
                XPathNodeIterator xpni = xpn.Select(query);
                result = xpni;
            }

            catch(XPathException e)
            {
                MessageBox.Show("Your XPath query is invalid: " + e.Message);
            }

            catch(ArgumentException e)
            {
                MessageBox.Show("Your XPath query did not return a nodeset. Sorry!");
            }  

        }

        private void ParseResult(XPathNodeIterator xpi)
        {
            xPathList.Items.Clear();
            foreach (XPathNavigator node in xpi)
            {
                XPathNodeIterator ancestors = node.SelectAncestors(XPathNodeType.Element, true);
                string xPathString = BuildXPathStringFromAncestors(ancestors);
                xPathList.Items.Add(xPathString);
                xPathList.Items[xPathList.Items.Count - 1].SubItems.Add(xPathList.Items.Count.ToString());
                xPathList.Items[xPathList.Items.Count - 1].ToolTipText = xPathString;
            }
            xPathList.Columns[0].Width = -2;
            xPathList.ShowItemToolTips = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            query = xpathQueryTextbox.Text;
            ExecuteQuery(query);
            if(result != null)
            {
                ParseResult(result);
            }
            else
            {
                xPathList.Items.Clear();
            }
            
        }
    }
}
