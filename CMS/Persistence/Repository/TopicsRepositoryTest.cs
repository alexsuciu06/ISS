using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using System.IO;
using Persistence.utils;

namespace Persistence.Repository
{
    class TopicsRepositoryTest
    {
        [SetUp]
        public void CreateSchema()
        {
            DeleteDatabaseIfExists();

            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(false, true);
        }

       
        [TearDown]
        public void DeleteDatabaseIfExists()
        {
            if (File.Exists("test.db"))
                File.Delete("test.db");
        }
    }
}
