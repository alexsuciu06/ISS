using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Persistence.utils;
using Model;
using NHibernate.Linq;

namespace Persistence.Repository
{
    public class PresentationRepository : GenericRepository<Presentation>
    {

        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Presentation>().RowCountInt64();
            }
        }

        public override List<Presentation> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Presentation>().ToList();
            }
        }

        public List<Presentation> AllForSession(int id_session)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Presentation>()
                    .Where(p => p.Session.IdSession.Equals(id_session))
                    .ToList();
            }
        }
    }
}
