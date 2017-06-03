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
                return  session.Query<User>().ToList();
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
                } else
                {
                    return users[0];
                }
            }
        }
    }
}
