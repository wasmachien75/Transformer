using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Transformer
{
    class XmlIndenter
    {
        XmlDocument xmlDoc = new XmlDocument();

        public void Load(string XmlString)
        {
            StringReader sr = new StringReader(XmlString);
            xmlDoc.Load(sr);
            //System.Diagnostics.Debug.WriteLine(xmlDoc.InnerXml);

        }

        public string Indent()
        {
            MemoryStream output = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(output, settings);
            xmlDoc.WriteTo(writer);
            writer.Flush();
            StreamReader sr = new StreamReader(output);
            output.Position = 0;
            return sr.ReadToEnd();
        }
    }
}
