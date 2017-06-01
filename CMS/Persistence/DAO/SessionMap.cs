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
    public class SessionMap : ClassMapping<Session>
    {
        public SessionMap()
        {
            Id(x => x.IdSession, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            this.ManyToOne(
            x => x.Room,
            map =>
            {
                map.Column("Room");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });

            this.ManyToOne(
                x => x.Presentation,
                map =>
                {
                    map.Column("Presentation");
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

            this.ManyToOne(
            x => x.Edition,
            map =>
            {
                map.Column("Edition");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });
        }
    }
}
