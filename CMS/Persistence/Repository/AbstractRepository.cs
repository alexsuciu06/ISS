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
    class AbstractRepository : IRepository<Abstract>
    {
            public void Save(Abstract person)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(person);
                    transaction.Commit();
                }
            }

            public Abstract Get(int id)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                    return session.Get<Abstract>(id);
            }

            public void Update(Abstract person)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(person);
                    transaction.Commit();
                }
            }

            public void Delete(Abstract person)
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
                    return session.QueryOver<Abstract>().RowCountInt64();
                }
            }
    }
}
