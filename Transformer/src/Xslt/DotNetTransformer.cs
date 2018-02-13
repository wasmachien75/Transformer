using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using MSXML2;

namespace TransformerApp
{
    public class DotNetTransformer : AbstractTransformer
    {

        public override Stream Transform(Stream source, Stream xsl)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();
            try
            {
                XmlReader sourceReader = XmlReader.Create(source);
                XmlReader xslReader = XmlReader.Create(xsl);

                MemoryStream ms = new MemoryStream();
                transformer.Load(xslReader);
                transformer.Transform(sourceReader, new XsltArgumentList(), ms);
                ms.Position = 0;
                return ms;

            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.Write(e.Message);
                throw;
            }
        }

    }       

}
