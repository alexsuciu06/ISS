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
    public class MetaInformationTopicsRepository : GenericRepository<MetaInformationTopics>
    {
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<MetaInformationTopics>().RowCountInt64();
            }
        }

        public override List<MetaInformationTopics> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<MetaInformationTopics>().ToList();
            }
        }
    }
}
