using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MSXML2;

namespace TransformerApp
{
    public class MSXMLTransformer : AbstractTransformer
    {
        public override Stream Transform(Stream xml, Stream xsl)
        {
            StreamReader xmlStreamReader = new StreamReader(xml);
            StreamReader xslStreamReader = new StreamReader(xsl);

            XSLTemplate60 xslt = new XSLTemplate60();
            FreeThreadedDOMDocument60 xsltDoc = new FreeThreadedDOMDocument60();
            xsltDoc.loadXML(xslStreamReader.ReadToEnd());
            xslt.stylesheet = xsltDoc;

            FreeThreadedDOMDocument60 xmlDoc = new FreeThreadedDOMDocument60();
            xmlDoc.loadXML(xmlStreamReader.ReadToEnd());

            var proc = xslt.createProcessor();
            proc.input = xmlDoc;
            proc.transform();

            return Helper.createStream(proc.output);
        }
    }
}
