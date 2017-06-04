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
    public class ReviewMap : ClassMapping<Review>
    {
        public ReviewMap()
        {
            Id(x => x.IdReview, m => m.Generator(Generators.Identity));
            this.ManyToOne(
              x => x.Reviewer,
              map =>
              {
                  map.Column("Reviewer");
                  map.Fetch(FetchKind.Join);
                  map.ForeignKey("none");
                  map.Lazy(LazyRelation.NoLazy);
                  map.NotFound(NotFoundMode.Ignore);
              });
            Property(x => x.Grade);
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
            x => x.Recomandation,
            map =>
            {
                map.Column("Recommandation");
                map.Fetch(FetchKind.Join);
                map.ForeignKey("none");
                map.Lazy(LazyRelation.NoLazy);
            });
        }
    }
}
