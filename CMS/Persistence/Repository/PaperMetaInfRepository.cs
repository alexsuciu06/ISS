using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Persistence.utils;

namespace Persistence.Repository
{
    class PaperMetaInfRepository : IRepository<PaperMetaInformation>
    {
        public void Save(PaperMetaInformation person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(person);
                transaction.Commit();
            }
        }
        public PaperMetaInformation Get(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<PaperMetaInformation>(id);
        }

        public void Update(PaperMetaInformation person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(person);
                transaction.Commit();
            }
        }

        public void Delete(PaperMetaInformation person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(person);
                transaction.Commit();
            }
        }

        public long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<PaperMetaInformation>().RowCountInt64();
            }
        }
    }
}
