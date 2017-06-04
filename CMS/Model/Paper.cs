using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Paper
    {
        private int idPaper;
        private string file;
        private Abstract abs;
        private PaperMetaInformation meta;

        public virtual int Id
        {
            get
            {
                return idPaper;
            }

            protected set
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
            this.Id = 0;
            this.File = "";
            this.Abs = null;
            this.Meta = null;
        }

        public Paper(string file, Abstract abs, PaperMetaInformation meta)
        {
            this.Id = idPaper;
            this.File = file;
            this.Abs = abs;
            this.Meta = meta;
        }

        public override string ToString()
        {
            return Meta.Name;
        }
    }
}
