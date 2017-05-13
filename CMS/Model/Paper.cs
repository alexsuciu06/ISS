using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paper
    {
        private int idPaper;
        private string file;
        private Abstract abs;
        private PaperMetaInformation meta;

        public virtual int IdPaper
        {
            get
            {
                return idPaper;
            }

            set
            {
                idPaper = value;
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

        public virtual Abstract Abs
        {
            get
            {
                return abs;
            }

            set
            {
                abs = value;
            }
        }

        public virtual PaperMetaInformation Meta
        {
            get
            {
                return meta;
            }

            set
            {
                meta = value;
            }
        }

        public Paper()
        {
            this.IdPaper = 0;
            this.File = "";
            this.Abs = null;
            this.Meta = null;
        }

        public Paper(int idPaper, string file, Abstract abs, PaperMetaInformation meta)
        {
            this.IdPaper = idPaper;
            this.File = file;
            this.Abs = abs;
            this.Meta = meta;
        }

        public override string ToString()
        {
            return this.idPaper +" " + this.File + " " + this.abs.ToString() + " " + this.meta.ToString();
        }
    }
}
