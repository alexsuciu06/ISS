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
    public class BidMap : ClassMapping<Bid>
    {
        public BidMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            this.ManyToOne(
            x => x.Paper,
            map =>
            {
                map.Column("Paper");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });

            this.ManyToOne(
            x => x.User,
            map =>
            {
                map.Column("User");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });

            Property(x => x.BID);
        }
    }
}
