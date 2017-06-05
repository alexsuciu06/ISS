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
    public class BidRepository : GenericRepository<Bid>
    {
        
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Bid>().RowCountInt64();
            }
        }

        public override List<Bid> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Bid>().ToList();
            }
        }

        public List<Bid> GetAllRewersById(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<Bid> b = session.Query<Bid>().Where(u => u.Paper.Id.Equals(id)).ToList();
                return b;
            }
        }
    }
}
