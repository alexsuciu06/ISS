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
    public class RecomandationRepository : GenericRepository<Recomandation>
    {
        
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Recomandation>().RowCountInt64();
            }
        }

        public override List<Recomandation> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Recomandation>().ToList();
            }
        }
    }
}
