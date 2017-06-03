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
    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            Property(x => x.Username);
            Property(x => x.Password);
            Property(x => x.Email);
            Property(x => x.Rol);
            Property(x => x.Affilation);
            Property(x => x.First_name);
            Property(x => x.Last_name);
            Property(x => x.Is_validated);
        }
    }
}
