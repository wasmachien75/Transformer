using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransformerApp;
using System.Linq;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isValid()
        {
            XmlValidator validator = new XmlValidator();
            validator.Load("<?xml version='1.0'?><xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'><xsl:output method='xml' encoding='UTF-8'/><xsl:template match='/'><MgXParameters><ReportResultFileName><xsl:value-of select='domainModelAttributes/ES_WONDOMAINMODELATTRIBUTE/concept/ES_WONDOMAINMODELCONCEPT/@xmlTag'/>.html</ReportResultFileName></MgXParameters></xsl:template></xsl:stylesheet>");
            Assert.IsTrue(validator.isValid());
        }

        [TestMethod]
        public void IndentXML()
        {
            string xml = "<root><someothernode/></root>";
            XmlIndenter indenter = new XmlIndenter();
            indenter.Load(xml);
            string indentedXML = indenter.Indent();
            Assert.IsTrue(indentedXML.Contains((char)13));
        }
    }
}
