using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Topic
    {
        private int idTopic;
        private string name;

        public Topic() { }

        public Topic(string name)
        {
            Name = name;
        }

        public virtual int Id
        {
            get
            {
                return idTopic;
            }

            protected set
            {
                idTopic = value;
            }
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
