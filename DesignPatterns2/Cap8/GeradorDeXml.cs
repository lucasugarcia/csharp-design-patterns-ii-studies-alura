using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2.Cap8
{
    class GeradorDeXml
    {
        public string GeraXML(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter sw = new StringWriter();

            serializer.Serialize(sw, o);

            return sw.ToString();
        }
    }
}
