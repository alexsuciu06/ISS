using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Model;

namespace Persistence.DAO
{
    class TopicsMap : ClassMapping<Topic>
    {
        public TopicsMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            Property(x => x.Name);
        }
    }
}
