using System;
using System.IO;
using System.Xml;

namespace TransformerApp
{

    public class XslTransformer
    {
        string _elapsedSecs;

        MemoryStream _xmlStream;
        MemoryStream _xslStream;
        Stream _result;

        public Stream Result { get { return _result; } }
        public string ElapsedSecs { get { return _elapsedSecs; } }

        public XslTransformer(MemoryStream source, MemoryStream xsl)
        {
            _xmlStream = source;
            _xslStream = xsl;
        }

        public void Transform(XslProcessor processor)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            TransformerFactory factory = new TransformerFactory();
            AbstractTransformer xformer = factory.CreateTransformer(processor);
            _result = xformer.Transform(_xmlStream, _xslStream);

            watch.Stop();
            _elapsedSecs = ((double)watch.ElapsedMilliseconds / 1000).ToString("0.00");
        }

    }
}
