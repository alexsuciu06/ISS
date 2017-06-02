using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MetaInformationTopics
    {
        private int id;
        private Topic topic;
        private PaperMetaInformation metaInformation;

        public MetaInformationTopics()
        {
        }

        public MetaInformationTopics(Topic topic, PaperMetaInformation metaInfor)
        {
            this.topic = topic;
            this.metaInformation = metaInfor;
        }

        public virtual int Id
        {
            get
            {
                return id;
            }
            protected set
            {
                this.id = value;
            }
        }

        public virtual Topic Topic
        {
            get
            {
                return topic;
            }

            set
            {
                topic = value;
            }
        }

        public virtual PaperMetaInformation MetaInformation
        {
            get
            {
                return metaInformation;
            }
            set
            {
                metaInformation = value;
            }

        }



    }
}
