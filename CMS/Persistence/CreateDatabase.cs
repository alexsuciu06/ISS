using Model;
using Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    class CreateDatabase
    {
        DbUtils db;
        
        public CreateDatabase()
        {
            db = new DbUtils();
            db.CreateSchema();
        }

        public void generate()
        {
            AbstractRepository abstractRepo = new AbstractRepository();
            AuthorRepository authorRepo = new AuthorRepository();
            TopicsRepository topicsRepo = new TopicsRepository();
            UserRepository userRepo = new UserRepository();
            PaperMetaInfRepository paperMetaRepo = new PaperMetaInfRepository();
            MetaInformationTopicsRepository metaInfRepo = new MetaInformationTopicsRepository();
            PaperRepository paperRepo = new PaperRepository();
            PresentationRepository presentationRepo = new PresentationRepository();

            userRepo.Save(new User("user1", "pass1"));
            userRepo.Save(new User("user2", "pass2"));
            userRepo.Save(new User("user3", "pass3"));
            userRepo.Save(new User("user4", "pass4"));
        }

    }
}
