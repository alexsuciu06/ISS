using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Recomandation
    {
        private int idRecomandation;
        private string file;

        public Recomandation(int idRecomandation, string file)
        {
            this.IdRecomandation = idRecomandation;
            this.File = file;
        }
        public Recomandation()
        {
            this.IdRecomandation = 1;
            this.File = "";
        }

        public virtual int IdRecomandation
        {
            get
            {
                return idRecomandation;
            }

            set
            {
                idRecomandation = value;
            }
        }

        public virtual string File
        {
            get
            {
                return file;
            }

            set
            {
                file = value;
            }
        }

        public override string ToString()
        {
            return this.idRecomandation + " " + this.file;
        }
        public override bool Equals(object obj)
        {
            if(obj!=null && obj.GetType() == this.GetType())
            {
                Recomandation c = (Recomandation)obj;
                if (c.idRecomandation != this.idRecomandation || c.file != this.file)
                    return false;
                return true;
            }
            return false;
        }

    }
}
