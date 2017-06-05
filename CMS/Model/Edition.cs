using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Edition
    {
        private int idEdition;
        private string name;
        private Conference conference;
        private string deadline;
        private string startDateTime;
        private string endDateTime;

        public virtual int IdEdition
        {
            get
            {
                return idEdition;
            }

            set
            {
                idEdition = value;
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

        public virtual Conference Conference
        {
            get
            {
                return conference;
            }

            set
            {
                conference = value;
            }
        }

        public virtual string Deadline
        {
            get
            {
                return deadline;
            }
            set
            {
                deadline = value;
            }
        }

        public virtual string StartDateTime
        {
            get
            {
                return startDateTime;
            }
            set
            {
                startDateTime = value;
            }
        }

        public virtual string EndDateTime
        {
            get
            {
                return endDateTime;
            }
            set
            {
                endDateTime = value;
            }
        }

        public Edition(string name, Conference conference)
        {
            this.Name = name;
            this.Conference = conference;
        }

        public Edition(string name, Conference conference, string deadline, string start, string end)
        {
            this.deadline = deadline;
            this.startDateTime = start;
            this.endDateTime = end;
            this.Name = name;
            this.Conference = conference;
        }

        public Edition()
        {
            this.Name = "";
            this.Conference = null;
        }

        public override string ToString()
        {
            return IdEdition + " " + Name + " " + Conference;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Edition))
                return false;
            Edition e = (Edition)obj;
            if (e.idEdition != this.idEdition || e.name != this.name || e.conference != this.conference)
                return false;
            return true;
        }
    }
}
