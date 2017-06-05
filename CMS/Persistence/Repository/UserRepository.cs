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
    public class UserRepository : GenericRepository<User>
    {
        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<User>().RowCountInt64();
            }
        }

        public override List<User> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<User>().ToList();
            }
        }

        public User GetByUsernameAndRole(string username, string role)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                List<User> users = session.Query<User>()
                    .Where(u => u.Username.Equals(username) && u.Rol.Equals(role))
                    .ToList();
                if (users.Count.Equals(0))
                {
                    return null;
                }
                else
                {
                    return users[0];
                }
            }
        }

        public User UpdateValidationState(string email, string key)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                int int_key = 0;
                if (!int.TryParse(key, out int_key))
                    return null;

                List<User> list =
                    session.Query<User>()
                    .Where(u => u.Email.Equals(email) && u.Key.Equals(int_key))
                    .ToList();
                if (list.Count == 0)
                    return null;
                using(ITransaction tran= session.BeginTransaction())
                {
                    list[0].Is_validated = true;
                    session.SaveOrUpdate(list[0]);
                    tran.Commit();
                }
                
                
                //.Where(u => u.Email.Equals(email) && u.Key.Equals(key))
                return list[0];
            }
        }

        public User GetByEmail(string email)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IEnumerable<User> all = session.Query<User>()
                    .Where(u => u.Email.Equals(email))
                    .ToList();
                if (all.Count() == 0)
                    return null;
                return all.ElementAt(0);
            }
        }
    }
}
