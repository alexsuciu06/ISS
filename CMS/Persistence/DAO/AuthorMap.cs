﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Model;

namespace Persistence.DAO
{
    class AuthorMap : ClassMapping<Author>
    {
        public AuthorMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity)/* m => m.Generator(Generators.Identity)*/);
            Property(x => x.Name);
            Property(x => x.Affiliation);
        }
    }
}