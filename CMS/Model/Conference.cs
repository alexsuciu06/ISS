using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Conference
    {
        private int idConference;
        private string name;

        public Conference(int idConference, string name)
        {
            this.IdConference = idConference;
            this.Name = name;
        }

        public Conference(string name)
        {
            this.Name = name;
        }

        public virtual int IdConference
        {
            get
            {
                return idConference;
            }

            set
            {
                idConference = value;
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

        public Conference()
        {
            this.IdConference = 0;
            this.Name = "";
        }

        public override string ToString()
        {
            return IdConference + " " + Name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Conference))
                return false;
            Conference c = (Conference)obj;
            if (c.idConference != this.idConference || c.name != this.name)
                return false;
            return true;
        }
    }
}
