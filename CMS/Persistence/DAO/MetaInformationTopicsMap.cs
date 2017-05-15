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
    class MetaInformationTopicsMap : ClassMapping<MetaInformationTopics>
    {
        public MetaInformationTopicsMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            this.ManyToOne(
            x => x.Topic,
            map =>
            {
          map.Column("Topic");
          map.Fetch(FetchKind.Join);
          map.ForeignKey("none");
          map.Lazy(LazyRelation.NoLazy);
            });
            this.ManyToOne(
            x => x.MetaInformation,
            map =>
            {
                map.Column("MetaInformation");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });
        }
    }
}
