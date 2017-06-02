using Model;
using Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class CreateDatabase
    {
        private DbUtils db;

        public CreateDatabase()
        {
            db = new DbUtils();
            db.CreateSchema();
        }

    }
}
