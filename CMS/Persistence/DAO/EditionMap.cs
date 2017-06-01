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
    public class EditionMap : ClassMapping<Edition>
    {
        public EditionMap()
        {
            Id(x => x.IdEdition, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            this.ManyToOne(
            x => x.Conference,
            map =>
            {
                map.Column("Conference");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });
            Property(x => x.Name);
        }

    }
}
