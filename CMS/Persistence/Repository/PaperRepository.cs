﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Persistence.utils;
using Model;
using NHibernate.Linq;
using System.Windows.Forms;

namespace Persistence.Repository
{
    public class PaperRepository : GenericRepository<Paper>
    {

        public override long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Paper>().RowCountInt64();
            }
        }

        public override List<Paper> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Paper>().ToList();
            }
        }

        public List<Paper> GetByEdition(int idEdition)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Paper>()
                    .Where(p => p.Edition.IdEdition.Equals(idEdition))
                    .ToList();
            };
        }
    }
}
