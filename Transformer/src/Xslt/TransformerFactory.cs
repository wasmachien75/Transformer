using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerApp
{
    public class TransformerFactory
    {
        public AbstractTransformer CreateTransformer(XslProcessor p)
        {
                if (p == XslProcessor.Saxon)
                {
                    return new SaxonTransformer();
                }

                else if (p == XslProcessor.DotNet)
                {
                    return new DotNetTransformer();
                }

                else if (p == XslProcessor.MSXML)
                {
                    return new MSXMLTransformer();
                }

                throw new ArgumentException("XslProcessor is undefined");
        }
    }
}
