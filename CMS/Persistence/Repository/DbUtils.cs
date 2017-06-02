using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Tool.hbm2ddl;
using Persistence.utils;
using System.IO;

namespace Persistence.Repository
{
    public class DbUtils
    {
        
        public void CreateSchema()
        {
           // DeleteDatabaseIfExists();

            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(false, true);

        }

       
        public void DeleteDatabaseIfExists()
        {
            if (File.Exists("ISSDatabase.db"))
                File.Delete("ISSDatabase.db");
        }
    }
}
