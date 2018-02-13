using System;
using System.Xml;
using Saxon.Api;
using System.IO;

namespace TransformerApp
{
    public class SaxonTransformer : AbstractTransformer
    {
        ///<summary>
        ///Performs a Saxon transformation.
        /// </summary>
        /// 
        public override Stream Transform(Stream source, Stream xsl)
        {
                MemoryStream result = new MemoryStream();

                Uri uri = new Uri("file://C:/");

                //set XSLT stylesheet
                Processor p = new Processor();
                XsltCompiler c = p.NewXsltCompiler();
                c.BaseUri = uri;
                XsltExecutable e = c.Compile(xsl);
                XsltTransformer t = e.Load();

                //set output

                var destination = new Serializer();
                destination.SetOutputStream(result);
                t.SetInputStream(source, uri);
                t.Run(destination);

                result.Position = 0;
                result.Flush();
                return result;
               
        }
    }
}
