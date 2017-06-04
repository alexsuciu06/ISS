using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Reviewer
    {
        private int idReviewer;
        private string name;
        private string affilation;

        public Reviewer(int idReviewer, string name, string affilation)
        {
            this.IdReviewer = idReviewer;
            this.Name = name;
            this.Affilation = affilation;
        }
        public Reviewer()
        {
            this.IdReviewer = 0;
            this.Name = "";
            this.Affilation = "";
        }

        public virtual int IdReviewer
        {
            get
            {
                return idReviewer;
            }

            set
            {
                idReviewer = value;
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

        public virtual string Affilation
        {
            get
            {
                return affilation;
            }

            set
            {
                affilation = value;
            }
        }

        public override string ToString()
        {
            return this.idReviewer + " " + this.name + this.affilation;
        }

        public override bool Equals(object other)
        {
            if (other != null && other.GetType()==this.GetType())
            {
                Reviewer v = (Reviewer)other;
                if (v.idReviewer != this.idReviewer || 
                    !(v.name.Equals(this.name)) || 
                    !(v.affilation.Equals(this.affilation))
                )
                    return false;
                return true;
            }
            return false;
        }
    }
}
