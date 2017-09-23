using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace TransformerApp
{
    public class XmlDepthFinder
    {

        public XmlDepthFinder()
        {

        }

        public void ReadXmlString()
        {
            System.Diagnostics.Debug.Write(GetDepth(@"<books><book>"));
        }

        public int GetDepth(string frag)
        {
            int openedNodes =  Regex.Matches(frag, @"<[^</?]*>").Count;
            int closedNodes = Regex.Matches(frag, @"<\/.*>").Count;
            return Math.Max(openedNodes - closedNodes, 0);
        }

    }
}
