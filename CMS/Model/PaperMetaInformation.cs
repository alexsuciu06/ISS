using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class PaperMetaInformation
    {
        private int idPaperMetaInformation;
        private string name;
        private string keywords;

        public PaperMetaInformation()
        {
            this.idPaperMetaInformation = 0;
            this.name = "";
            this.keywords = "";
        }

        public PaperMetaInformation( string name, string keywords)
        {
            this.name = name;
            this.keywords = keywords;
        }

        public virtual int Id
        {
            get { return idPaperMetaInformation; }
            set { idPaperMetaInformation = value; }
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

        public virtual string Keywords
        {
            get
            {
                return keywords;
            }

            set
            {
                keywords = value;
            }
        }

       

        public override string ToString()
        {
            return idPaperMetaInformation + " " + name + " " + keywords;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Abstract))
                return false;
            PaperMetaInformation pmi = (PaperMetaInformation)obj;
            return idPaperMetaInformation == pmi.idPaperMetaInformation && name == pmi.name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
