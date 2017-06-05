using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Presentation
    {
      
        private int idPresentation;
        private Paper paper;
        private Session session;
        private DateTime time;

        public Presentation()
        {
        }

        public Presentation(Paper paper, DateTime time, Session session)
        {
            this.paper = paper;
            this.time = time;
            this.session = session;
        }


        public virtual int Id
        {
            get { return idPresentation; }
            protected set { idPresentation = value; }
        }

        public virtual Paper Paper
        {
            get { return paper; }
            set { paper = value; }
        }

        public virtual DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public virtual Session Session
        {
            get { return session; }
            set { session = value; }
        }

        public override string ToString()
        {
            return idPresentation + " " + Paper + " " + Time + "\n";
        }



    }

    
}
