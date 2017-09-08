using System.IO;
using System.Xml;

namespace TransformerApp
{

    public class XslTransformer
    {
        ScintillaXml source;
        ScintillaXml xsl;
        ScintillaXml output;
        MainForm form;
        public string ElapsedSecs;
        public string Result;

        public XslTransformer(MainForm mainForm)
        {
            form = mainForm;
            source = form.scintillaSource;
            xsl = form.scintillaXSL;
            output = form.scintillaOutput;
        }

        public void TransformIt(XslProcessor processor)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (processor == XslProcessor.Saxon)
            {
                Result = SaxonTransform();
            }

            else
            {
                Result = DotNetTransform();
            }

            watch.Stop();
            ElapsedSecs = ((double)watch.ElapsedMilliseconds / 1000).ToString("0.00");

        }

        private string SaxonTransform()
        {
            SaxonTransformer saxon = new SaxonTransformer();
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            sw.Write(source.Text);
            sw.Flush();
            ms.Position = 0;

            MemoryStream res = new MemoryStream();
            StreamWriter writer = new StreamWriter(res);

            TextReader tr = new StringReader(xsl.Text);
            XmlReader xslReader = XmlReader.Create(tr);

           return saxon.Transform(ms, xslReader);
            

        }

        private string DotNetTransform()
        {
            TextReader sourceReader = new StringReader(source.Text);
            TextReader xslReader = new StringReader(xsl.Text);
            DotNetTransformer xformer = new DotNetTransformer();

            MemoryStream stream = new MemoryStream();
            StreamWriter writer = xformer.CreateWriter(); // writer will write to the stream
            return xformer.Transform(XmlReader.Create(sourceReader), XmlReader.Create(xslReader));
            

        }
    }
}
