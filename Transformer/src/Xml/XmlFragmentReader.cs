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
    public class XmlFragmentReader
    {
        private string fragment;

        public void ReadIncompleteXml()
        {
            System.Diagnostics.Debug.Write(GetDepth(@"<books><book>"));
        }

        public int GetDepth(string frag)
        {
            return Regex.Matches(frag, "/<[a-z0-9]*>/g").Count;
        }

    }
}
