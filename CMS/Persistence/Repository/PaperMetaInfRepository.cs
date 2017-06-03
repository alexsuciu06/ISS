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
    public class PaperMetaInfRepository : GenericRepository<PaperMetaInformation>
    {
        
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<PaperMetaInformation>().RowCountInt64();
            }
        }

        public override List<PaperMetaInformation> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<PaperMetaInformation>().ToList();
            }
        }
    }
}
