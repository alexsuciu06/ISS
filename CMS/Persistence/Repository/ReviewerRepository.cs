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
    public class ReviewerRepository : GenericRepository<Reviewer>
    {
       
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Reviewer>().RowCountInt64();
            }
        }

        public override List<Reviewer> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Reviewer>().ToList();
            }
        }
    }
}
