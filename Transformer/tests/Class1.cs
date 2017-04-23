using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer.tests
{
    
    public class XmlIndenterTest
    {
        public void test()
        {
            string xmlstr = "<?xml version ='1.0'?><root>hello</root>";
            XMLIndenter XMLid = new XMLIndenter(xmlstr);
            XMLid.ReadXml(XMLid.sr);
            MessageBox.Show(XMLid.ReadStream(XMLid.output));
        }
        
    }
}
