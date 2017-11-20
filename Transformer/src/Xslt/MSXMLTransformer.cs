using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSXML2;

namespace TransformerApp
{
    public class MSXMLTransformer
    {
        public MSXMLTransformer()
        {

        }

        public string Transform(string xml, string xsl)
        {
            XSLTemplate60 xslt = new XSLTemplate60();
            FreeThreadedDOMDocument60 xsltDoc = new FreeThreadedDOMDocument60();
            xsltDoc.loadXML(xsl);
            xslt.stylesheet = xsltDoc;

            FreeThreadedDOMDocument60 xmlDoc = new FreeThreadedDOMDocument60();
            xmlDoc.loadXML(xml);
            var proc = xslt.createProcessor();
            proc.input = xmlDoc;
            proc.transform();
            return proc.output;
        }
    }
}
