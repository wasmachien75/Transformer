using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace TransformerApp
{
    public class Validator
    {
        private String _documentString;
        private Tuple<int, int> _exceptionLocation;
        public Tuple<int, int> ExceptionLocation { get { return _exceptionLocation; } }

        public Validator(String text)
        {
            _documentString = text;
        }

        public bool Validate()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(_documentString);
                return true;
            }
            catch(XmlException e)
            {
                _exceptionLocation = new Tuple<int, int>(e.LineNumber, e.LinePosition);
                return false;
            }
            
        }

       
    }
}
