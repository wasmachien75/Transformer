using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TransformerApp
{
    public class XFormer
    {
        private string Source;
        private string XslString;
        public string Result;
        public double ElapsedTime;

        public XFormer(string source, string xsl)
        {
            this.Source = source;
            this.XslString = xsl;
        }

        public string Transform(bool saxon=true)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string result;
            try
            {
                if (saxon)
                {
                    result = SaxonTransform();
                }
                else
                {
                    result = DotNetTransform();
                }
                watch.Stop();
                ElapsedTime = watch.ElapsedMilliseconds;

                return result;
            }
            catch (OutOfMemoryException)
            {
                throw new OutOfMemoryException("I ran out of memory. The XML is too large or there is a mistake in your stylesheet.");
            }
           
        }

        private string SaxonTransform()
        {
            SaxonTransformer saxon = new SaxonTransformer();
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            sw.Write(Source);
            sw.Flush();
            ms.Position = 0;

            MemoryStream res = new MemoryStream();
            StreamWriter writer = new StreamWriter(res);

            TextReader tr = new StringReader(XslString);
            XmlReader xsl = XmlReader.Create(tr);
            string result = saxon.Transform(ms, xsl);
            return result;

        }
        private string DotNetTransform()
        {
            XmlReader sourceReader = XmlReader.Create(new StringReader(Source));
            XmlReader xslReader = XmlReader.Create(new StringReader(XslString));
            DotNetTransformer xformer = new DotNetTransformer();

            MemoryStream stream = new MemoryStream();
            string result = xformer.Transform(sourceReader, xslReader);
            return result;
        }
    }
}
