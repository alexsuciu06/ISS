using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Persistence.DAO
{
    public class RoomMap : ClassMapping<Room>
    {
        public RoomMap()
        {
            Id(x => x.IdRoom, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            Property(x => x.RoomNr);
            Property(x => x.Seats);
        }
    }
}
