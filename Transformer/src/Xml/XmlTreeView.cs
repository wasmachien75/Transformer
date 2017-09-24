using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TransformerApp
{
    class XmlTreeView
    {
        private XmlReader document;
        private TreeView tv;

        public XmlTreeView(XmlReader document, TreeView tv)
        {
            this.document = document;
            this.tv = tv;
            Load();
        }

        public void Load()
        {

            while (document.Read()){
                TreeNode node = new TreeNode(document.Value);
                tv.Nodes.Add(node);
            }
        }

    }
}
