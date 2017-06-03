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
    public class ReviewerMap : ClassMapping<Reviewer>
    {
        public ReviewerMap()
        {
            Id(x => x.IdReviewer, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            Property(x => x.Name);
            Property(x => x.Affilation);
        }
    }
}
