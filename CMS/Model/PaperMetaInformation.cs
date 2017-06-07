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
        private string co_authors;
        private User author;

        public PaperMetaInformation()
        {
            this.idPaperMetaInformation = 0;
            this.name = "";
            this.keywords = "";
        }

        public PaperMetaInformation( string name, string keywords, User author, string co_authors)
        {
            this.author = author;
            this.co_authors = co_authors;
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

        public virtual string CoAuthors
        {
            get
            {
                return co_authors;
            }
            set
            {
                co_authors = value;
            }
        }

        public virtual User Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public override string ToString()
        {
            return "Author: " + author.First_name + " " + author.Last_name + "\n"
                + "Co-Authors: " + co_authors + "\n" +
                "Paper name: " + name + "\n"
                + "Keywords: " + keywords + "\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Abstract))
                return false;
            PaperMetaInformation pmi = (PaperMetaInformation)obj;
            return idPaperMetaInformation == pmi.idPaperMetaInformation && name == pmi.name 
                &&pmi.co_authors.Equals(CoAuthors) && pmi.Author.Equals(Author);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
