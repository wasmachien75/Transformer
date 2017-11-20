using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using MSXML2;

namespace TransformerApp
{
    public class DotNetTransformer
    {

        public virtual string Transform(XmlReader source, XmlReader xsl)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();
            try
            {
                StreamWriter writer = CreateWriter();
                transformer.Load(xsl);
                transformer.Transform(source, new XsltArgumentList(), writer);
                writer.BaseStream.Position = 0;
                StreamReader reader = new StreamReader(writer.BaseStream);
                return reader.ReadToEnd();

            }

            catch (OutOfMemoryException)
            {
                MessageBox.Show("Out of memory! The source XML is either too big, or there's a mistake in the XSL.", "Out of Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                source = null;
                GC.Collect();
                return "";
            }

            catch (XmlException e)
            {
                throw new Exception("There's a mistake in the source XML: (" + e.Message + " Line " + e.LineNumber + ", col " + e.LinePosition + ")") ;
           } 

            catch (XsltException e)
            {
                throw new Exception("XSLT Compile Exception. Check your stylesheet for mistakes. (" + e.Message + " Line " + e.LineNumber + ", col " + e.LinePosition + ")");
            }

            catch(Exception)
            {
                throw;
            }
        }



        public StreamWriter CreateWriter()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            return writer;
        }

    }       

}
