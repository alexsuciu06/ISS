using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Persistence.utils;
using NHibernate.Linq;

namespace Persistence.Repository
{
    public class AuthorRepository : GenericRepository<Author>
    { 
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Author>().RowCountInt64();
            }
        }

        public override List<Author> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Author>().ToList();
            }
        }
    }
}

