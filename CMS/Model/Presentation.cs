using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Presentation
    {
      
        private int idPresentation;
        private Paper paper;
        private DateTime time;

        public Presentation()
        {
        }

        public Presentation(Paper idPaper, DateTime time)
        {
            this.paper = idPaper;
            this.time = time;
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

        public override string ToString()
        {
            return idPresentation + " " + Paper + " " + Time + "\n";
        }



    }

    
}
