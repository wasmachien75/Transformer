using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer.tests
{

    public class XmlIndenterTest
    {
        public string test(string xmlstr)
        {
            XmlIndenter XMLid = new XmlIndenter();
            XMLid.Load(xmlstr);
            return XMLid.Indent();
        }
        
    }
}
