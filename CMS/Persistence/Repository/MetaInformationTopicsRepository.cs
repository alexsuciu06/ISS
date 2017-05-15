using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Persistence.utils;
using Model;

namespace Persistence.Repository
{
    class MetaInformationTopicsRepository : IRepository<MetaInformationTopics>
    {
        public void Save(MetaInformationTopics person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(person);
                transaction.Commit();
            }
        }
        public MetaInformationTopics Get(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<MetaInformationTopics>(id);
        }

        public void Update(MetaInformationTopics person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(person);
                transaction.Commit();
            }
        }

        public void Delete(MetaInformationTopics person)
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
                return session.QueryOver<MetaInformationTopics>().RowCountInt64();
            }
        }
    }
}
