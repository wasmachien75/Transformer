using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Transformer
{
    public class Transformer
    {

        public bool Transform(XmlReader source, XmlReader xsl, StreamWriter writer)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();

            try
            {
                transformer.Load(xsl);
                transformer.Transform(source, new XsltArgumentList(), writer);

            }
            catch (IOException)
            {

                MessageBox.Show("I/O Exception :-(", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("I don't want badly formed XML, for now", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "XSL Load Exception", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

            //close writer and reader
      
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
