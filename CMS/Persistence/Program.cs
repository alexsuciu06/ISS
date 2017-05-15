
using Model;
using Persistence.DAO;
using Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistence
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            // AbstractMapTest m = new AbstractMapTest();
            //m.CanGenerateXmlMapping();
            // AbstractRepositoryTest a = new AbstractRepositoryTest();
            // a.CreateSchema();
            //AuthorRepositoryTest a = new AuthorRepositoryTest();
            //a.CreateSchema();

            //  AuthorRepository authr = new AuthorRepository();
            // authr.Save(new Author("b", "aff"));
            //   UserRepositoryTest u = new UserRepositoryTest();
            //u.CreateSchema();
            //UserRepository n = new UserRepository();

            // n.Save(new User("username", "pass", "email", "Author"));
            /*   DbUtils c = new DbUtils();
               c.CreateSchema();
               /*PaperMetaInfRepository r = new PaperMetaInfRepository();
               r.Save(new PaperMetaInformation("a", "a,s,a"));
               TopicsRepository a = new TopicsRepository();
               a.Save(new Topic("vara"));
             MetaInformationTopicsRepository repo = new MetaInformationTopicsRepository();
             Topic t = a.Get(2);


             PaperMetaInformation paper = r.Get(1);
             repo.Save(new MetaInformationTopics(t, paper));
             AbstractRepository arepo = new AbstractRepository();
             arepo.Save(new Abstract("a1"));

             
             p.Save(new Paper("", arepo.Get(1), paper));
               PaperMetaInfRepository r = new PaperMetaInfRepository();
               AbstractRepository arepo = new AbstractRepository();
               PaperMetaInformation paper = r.Get(1);*/
            PresentationRepository pre = new PresentationRepository();
            //Abstract ab = arepo.Get(1);
            PaperRepository p = new PaperRepository();
            Paper pa = p.Get(2);
            DateTime tm = new DateTime(2017, 1, 18);
            Presentation pres = new Presentation(pa, tm);
            pre.Save(pres);
           
          
        }
    }
}
