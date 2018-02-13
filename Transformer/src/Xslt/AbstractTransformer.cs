using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TransformerApp
{
    public abstract class AbstractTransformer
    {
        public abstract Stream Transform(Stream xml, Stream xsl);
    }
}
