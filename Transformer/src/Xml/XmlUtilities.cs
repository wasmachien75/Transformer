using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerApp
{
    public static class XmlUtilities
    {
        public static string OpenXmlTagRegex = @"<[^/?!][^<]+[^/]>";
        public static string ClosedXmlTagRegex = @"<\/.*>";
    }
}
