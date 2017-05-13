using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaperMetaInformation
    {
        private int idPaperMetaInformation;
        private string name;
        private List<string> keywords;
        private List<string> topics;

        public PaperMetaInformation()
        {
            this.idPaperMetaInformation = 0;
            this.name = "";
            this.keywords = null;
            this.topics = null;
        }

        public PaperMetaInformation(int idPaperMetaInformation, string name, List<string> keywords, List<string> topics)
        {
            this.idPaperMetaInformation = idPaperMetaInformation;
            this.name = name;
            this.keywords = keywords;
            this.topics = topics;
        }

        public virtual int IdPaperMetaInformation
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

        public virtual List<string> Keywords
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

        public virtual List<string> Topics
        {
            get
            {
                return topics;
            }

            set
            {
                topics = value;
            }
        }

        public override string ToString()
        {
            return idPaperMetaInformation + " " + name + " " + keywords + " " + topics;
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
