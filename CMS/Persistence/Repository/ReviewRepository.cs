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
    public class ReviewRepository : GenericRepository<Review>
    {
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Review>().RowCountInt64();
            }
        }

        public override List<Review> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Review>().ToList();
            }
        }

        public List<Review> AssignedReviews(string reviewer_id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Review>()
                    .Where( r => r.Reviewer.Name.Equals(reviewer_id))
                    .ToList();
            }
        }



        public object GetForPaper(Paper p)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Review>()
                    .Where(r => r.Paper.Id.Equals(p.Id))
                    .ToList();
            }
        }

    }
}
