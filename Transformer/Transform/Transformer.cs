using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TransformerApp;

namespace Transformer.Transform
{
    public class Transform
    {
        ScintillaXml source;
        ScintillaXml xsl;
        ScintillaXml output;
        MainForm form;

        public Transform(MainForm mainForm)
        {
            source = form.scintillaSource;
            xsl = form.scintillaXSL;
            output = form.scintillaOutput;
            form = mainForm;
        }

        public void TransformIt(Boolean saxon = false)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (saxon == true)
            {
                SaxonTransform();
            }

            else
            {
                DotNetTransform();
            }

            watch.Stop();
            string elapsedSecs = ((double)watch.ElapsedMilliseconds / 1000).ToString("0.00");

        }

        private void SaxonTransform()
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
            form.printOutput(saxon.Transform(ms, xslReader, form), output);

        }

        private void DotNetTransform()
        {
            TextReader sourceReader = new StringReader(source.Text);
            TextReader xslReader = new StringReader(xsl.Text);
            DotNetTransformer xformer = new DotNetTransformer();

            MemoryStream stream = new MemoryStream();
            StreamWriter writer = xformer.createWriter(stream); // writer will write to the stream

            if (xformer.Transform(XmlReader.Create(sourceReader), XmlReader.Create(xslReader), writer, form))
            {
                form.printOutput(stream, output);
                writer = null;
            }

        }
    }
}
