using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TransformerApp
{
    public abstract class XmlHelper
    {
        public XmlDocument xmlDoc = new XmlDocument();

        public bool LoadXml(string XmlString)
        {
            StringReader sr = new StringReader(XmlString);
            try
            {
                xmlDoc.Load(sr);
            }
            catch (XmlException e)
            {

                MessageBox.Show(String.Format("Source XML is not well-formed, please check ({0})", e.Message), "Invalid XML", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
        public bool LoadXml(XmlReader xmlReader)
        {
            try
            {
                xmlDoc.Load(xmlReader);
                return true;
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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

    public class XmlValidator: XmlHelper
    {
        
        public bool isValid()
        {
            XmlNamespaceManager mgr = new XmlNamespaceManager(xmlDoc.NameTable);
            mgr.AddNamespace("xsl", "http://www.w3.org/1999/XSL/Transform");

            XmlNode node = xmlDoc.SelectSingleNode("//xsl:stylesheet/@version", mgr);
            if (node.Value != "")
            {
                return (node.Value == "1.0");
            }
            return true;
        }
    }
}
