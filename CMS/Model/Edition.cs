using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Edition
    {
        private int idEdition;
        private string name;
        private Conference conference;

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

        public Edition(int idEdition, string name, Conference conference)
        {
            this.IdEdition = idEdition;
            this.Name = name;
            this.Conference = conference;
        }

        public Edition(string name, Conference conference)
        {
            this.Name = name;
            this.Conference = conference;
        }

        public Edition()
        {
            this.IdEdition = 0;
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
