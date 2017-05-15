using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NUnit.Framework;
using System.Xml.Serialization;

namespace Persistence.DAO
{
    [TestFixture]
    public class AbstractMapTest
    {
        [Test]
        public void CanGenerateXmlMapping()
        {
            var mapper = new ModelMapper();
            mapper.AddMapping<AbstractMap>();

            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            var xmlSerializer = new XmlSerializer(mapping.GetType());

            xmlSerializer.Serialize(Console.Out, mapping);
        }
    }
}
