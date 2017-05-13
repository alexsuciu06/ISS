using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Presentation
    {
        private int idPresentation;
        private int idPaper;
        private DateTime time;

        public Presentation()
        {
        }

        public Presentation(int idPresentation, int idPaper, DateTime time)
        {
            this.idPresentation = idPresentation;
            this.idPaper = idPaper;
            this.time = time;
        }


        public virtual int IdPresentation
        {
            get { return IdPresentation; }
            set { idPresentation = value; }
        }

        public virtual int IdPaper
        {
            get { return idPaper; }
            set { idPaper = value; }
        }

        public virtual DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public override string ToString()
        {
            return idPresentation + " " + IdPaper + " " + Time + "\n";
        }



    }

    
}
