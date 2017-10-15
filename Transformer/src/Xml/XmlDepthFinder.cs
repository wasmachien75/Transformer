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

        public int GetDepth(string frag)
        {
            int openedNodes = Regex.Matches(frag, XmlUtilities.OpenXmlTagRegex).Count;
            int closedNodes = Regex.Matches(frag, XmlUtilities.ClosedXmlTagRegex).Count;
            return Math.Max(openedNodes - closedNodes, 0);
        }

    }
}
