using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransformerApp;
using System.Linq;
using System.Xml;
using System.IO;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void doesSaxonWork()
        {
            SaxonTransformer t = new SaxonTransformer();

            MemoryStream stream = new MemoryStream();
            StreamWriter sw = new StreamWriter(stream);
            sw.Write("<hello>Michael</hello>");

            sw.Flush();
            stream.Position = 0;

            XmlReader xsl = XmlReader.Create("file://C:/Temp/transform.xsl");

            MainForm form = new MainForm();
            MemoryStream result = new MemoryStream();
            StreamWriter writer = new StreamWriter(result);
            writer.Flush();
            result.Position = 0;
            t.Transform(stream, xsl, writer, form);
            Assert.IsTrue(writer.BaseStream.Length != 0);
            writer.BaseStream.Position = 0;
            Console.WriteLine(new StreamReader(writer.BaseStream).ReadToEnd());
        }
    }
}
