using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate;
using Persistence.DAO;

namespace Persistence.utils
{
    public static class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Configuration _configuration;
        private static HbmMapping _mapping;

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static Configuration Configuration
        {
            get
            {
                if (_configuration == null)
                {
           
                    _configuration = CreateConfiguration();
                }
                return _configuration;
            }
        }

        public static HbmMapping Mapping
        {
            get
            {
                if (_mapping == null)
                {
                    _mapping = CreateMapping();
                }
                return _mapping;
            }
        }

        private static Configuration CreateConfiguration()
        {
            var configuration = new Configuration();
            //Loads properties from hibernate.cfg.xml
            configuration.Configure();
            //Loads nhibernate mappings 
            configuration.AddDeserializedMapping(Mapping, null);

            return configuration;
        }

        private static HbmMapping CreateMapping()
        {
            var mapper = new ModelMapper();
            //Add the person mapping to the model mapper
            mapper.AddMappings(new List<System.Type> { typeof(AbstractMap) });
            mapper.AddMappings(new List<System.Type> { typeof(AuthorMap) });
            mapper.AddMappings(new List<System.Type> { typeof(UserMap) });
            mapper.AddMappings(new List<System.Type> { typeof(TopicsMap) });
            mapper.AddMappings(new List<System.Type> { typeof(PaperMetaInformationMap) });
            mapper.AddMappings(new List<System.Type> { typeof(MetaInformationTopicsMap) });
            mapper.AddMappings(new List<System.Type> { typeof(PaperMap) });
            mapper.AddMappings(new List<System.Type> { typeof(PresentationMap) });
            mapper.AddMappings(new List<System.Type> { typeof(ConferenceMap) });
            mapper.AddMappings(new List<System.Type> { typeof(EditionMap) });
            mapper.AddMappings(new List<System.Type> { typeof(BidMap) });
            mapper.AddMappings(new List<System.Type> { typeof(RoomMap) });
            mapper.AddMappings(new List<System.Type> { typeof(RecomandationMap) });
            mapper.AddMappings(new List<System.Type> { typeof(ReviewerMap) });
            mapper.AddMappings(new List<System.Type> { typeof(ReviewMap) });
            //Create and return a HbmMapping of the model mapping in code
            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }
    }
}
