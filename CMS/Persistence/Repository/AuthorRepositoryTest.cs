using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using System.IO;
using Persistence.utils;
using Model;

namespace Persistence.Repository
{
    class AuthorRepositoryTest
    {
        private AuthorRepository _personRepo;

        [SetUp]
        public void CreateSchema()
        {
            DeleteDatabaseIfExists();

            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(false, true);

            _personRepo = new AuthorRepository();
        }

        [Test]
        public void CanSavePerson()
        {
            _personRepo.Save(new Author());
            Assert.AreEqual(1, _personRepo.RowCount());
        }

        [Test]
        public void CanGetPerson()
        {
            var person = new Author();
            _personRepo.Save(person);
            Assert.AreEqual(1, _personRepo.RowCount());

            //person = _personRepo.Get(person.Id);
            Assert.IsNotNull(person);
        }

        [Test]
        public void CanUpdatePerson()
        {
            var person = new Author();
            _personRepo.Save(person);
            Assert.AreEqual(1, _personRepo.RowCount());

            // person = _personRepo.Get(person.Id);
            person.Name = "Test";
            _personRepo.Update(person);

            Assert.AreEqual(1, _personRepo.RowCount());
            //   Assert.AreEqual("Test", _personRepo.Get(person.Id).FirstName);
        }

        [Test]
        public void CanDeletePerson()
        {
            var person = new Author();
            _personRepo.Save(person);
            Assert.AreEqual(1, _personRepo.RowCount());

            _personRepo.Delete(person);
            Assert.AreEqual(0, _personRepo.RowCount());
        }

        [TearDown]
        public void DeleteDatabaseIfExists()
        {
            if (File.Exists("test.db"))
                File.Delete("test.db");
        }
    }
}

