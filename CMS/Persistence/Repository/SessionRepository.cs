using Model;
using NHibernate;
using NHibernate.Linq;
using Persistence.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class SessionRepository : GenericRepository<Session>
    {
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Session>().RowCountInt64();
            }
        }

        public override List<Session> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Session>().ToList();
            }
        }
    }
}
