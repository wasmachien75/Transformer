using System;
using System.Text.RegularExpressions;

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
