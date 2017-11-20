using System.IO;
using System.Xml;

namespace TransformerApp
{
    public abstract class XmlHelper
    {
        public XmlDocument xmlDoc = new XmlDocument();

        public bool LoadXml(string XmlString)
        {
            StringReader sr = new StringReader(XmlString);
            if (XmlString.Trim() != "")
            {
                xmlDoc.Load(sr);
                return true;
            }
            else
            {
                return false;
            }  
        }
    }

    public class XmlIndenter: XmlHelper
    {
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
