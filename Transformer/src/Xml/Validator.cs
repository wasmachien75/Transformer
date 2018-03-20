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
        XmlSchema schema;
        XmlDocument document;
        XmlReaderSettings settings;
        String schemaUri;

        public Validator(XmlDocument doc, String uri)
        {
            document = doc;
            schemaUri = uri;
            ValidationEventHandler schemaValidationEventHandler = new ValidationEventHandler(SchemaValidationEventHandler);
        }

        public void Validate()
        {
            XmlReader schema = XmlReader.Create(schemaUri);
            XmlSchema s = XmlSchema.Read(schema, SchemaValidationEventHandler);
            
            ValidationEventHandler validationEventHandler = new ValidationEventHandler(ValidationEventHandler);
            document.Schemas.Add(s);
            document.Validate(validationEventHandler);
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                throw e.Exception;
            }
        }

        static void SchemaValidationEventHandler(object sender, ValidationEventArgs e)
        {
            throw e.Exception;
        }
    }

    
}
