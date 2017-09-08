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

namespace TransformerApp
{
    public class DotNetTransformer
    {

        public virtual bool Transform(XmlReader source, XmlReader xsl, StreamWriter writer, MainForm form)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();
            try
            {
                transformer.Load(xsl);
                transformer.Transform(source, new XsltArgumentList(), writer);

            }

            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("Out of memory! The source XML is either too big, or there's a mistake in the XSL.", "Out of Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                source = null;
                GC.Collect();
                return false;
            }

            catch (XmlException e)
            {
                form.statusLabel.Text = "☹️ There's a mistake in the source XML: " + e.Message;
                return false;
           } 

            catch (XsltException e)
            {
                form.statusLabel.Text = "☹️ XSLT Compile Exception. Check your stylesheet for mistakes. (" + e.Message + " Line " + e.LineNumber + ", col " + e.LinePosition + ")";
                return false;
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return true;
        }



        public StreamWriter createWriter(Stream stream)
        {

            StreamWriter writer = new StreamWriter(stream);
            return writer;



        }

    }

}
