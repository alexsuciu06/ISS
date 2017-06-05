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
    class PaperMetaInformationMap : ClassMapping<PaperMetaInformation>
    {
        public PaperMetaInformationMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            this.ManyToOne(
               x => x.Author,
               map =>
               {
                   map.Column("Author");
                   map.Fetch(FetchKind.Join);
                   map.ForeignKey("none");
                   map.Lazy(LazyRelation.NoLazy);
           });
            Property(x => x.CoAuthors);
            Property(x => x.Name);
            Property(x => x.Keywords);
        }
    }
}
