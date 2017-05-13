using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Author
    {
        private int idAuthor;
        private string name;
        private string affiliation;

        public virtual int IdAuthor
        {
            get
            {
                return idAuthor;
            }

            set
            {
                idAuthor = value;
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

        public virtual string Affiliation
        {
            get
            {
                return affiliation;
            }

            set
            {
                affiliation = value;
            }
        }

        public Author(int idAuthor, string name, string affiliation)
        {
            this.IdAuthor = idAuthor;
            this.Name = name;
            this.Affiliation = affiliation;
        }
        
        public Author()
        {
            this.IdAuthor = 0;
            this.Name = "";
            this.Affiliation = "";
        }
        public override string ToString()
        {
            return IdAuthor+ " " +Name+ " " +Affiliation;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Author))
                return false;
            Author a = (Author)obj;
            if (a.idAuthor != this.idAuthor || a.name != this.name || a.affiliation != this.affiliation)
                return false;
            return true;
        }

    }
}
