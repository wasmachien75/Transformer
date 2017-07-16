using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Saxon.Api;
using System.IO;
using System.Windows.Forms;

namespace TransformerApp
{
    public class SaxonTransformer : Transformer
    {
        ///<summary>
        ///Performs a Saxon transformation.
        /// </summary>
        /// 
        public bool Transform(Stream source, XmlReader xsl, StreamWriter destination, MainForm form)
        {

            try
            {
                Uri uri = new Uri("http://mediagenix.tv");
                
                //set XSLT stylesheet
                Processor p = new Processor();
                XsltCompiler c = p.NewXsltCompiler();
                c.BaseUri = uri;
                XsltExecutable e = c.Compile(xsl);
                XsltTransformer t = e.Load();

                //set output
                XmlWriter w = XmlWriter.Create(destination.BaseStream);
                XmlDestination d = new TextWriterDestination(w);

                source.Position = 0;
                t.SetInputStream(source, uri);
                t.Run(d);
                source.Flush();
 
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
