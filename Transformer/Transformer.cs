using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.Data;

namespace Transformer
{
    public class Transformer
    {

        public bool Transform(XmlReader source, XmlReader xsl, StreamWriter writer, MainForm form)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();

            try
            {
                transformer.Load(xsl);
                transformer.Transform(source, new XsltArgumentList(), writer);

            }

            catch (XsltException)
            {
                form.statusLabel.Text = "☹️ XSLT Compile Exception. Check your stylesheet for mistakes.";
                return false;
            }
            
            return true;
        }



        public StreamWriter createWriter(Stream stream)
        {
            //XmlWriterSettings settings = new XmlWriterSettings();
            //settings.Indent = true;
            //settings.IndentChars = "\t";

            StreamWriter writer = new StreamWriter(stream);
            return writer;



        }
    }

}
