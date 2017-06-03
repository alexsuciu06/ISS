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
    public class AbstractRepository : GenericRepository<Abstract>
    {
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                    return session.QueryOver<Abstract>().RowCountInt64();
            }
        }

        public override List<Abstract> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Abstract>().ToList();
            }
        }
    }
}
