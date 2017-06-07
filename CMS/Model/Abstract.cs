using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    [Serializable]
    public class Abstract
    {
        private int idAbstract;
        private string file;

        public virtual int Id
        {
            get { return idAbstract; }
            protected set { idAbstract = value; }
        }
        public virtual string File
        {
            get { return file; }
            set { file = value; }
        }

        public Abstract()
        {
            this.idAbstract = 0;
            this.file = "";
        }

        public Abstract(string file)
        {
            this.file = file;
        }

        public override string ToString()
        {
            if(file == "")
            {
                return "Not available";
            } else
            {
                return Path.GetFileNameWithoutExtension(file);
            }
            
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Abstract))
                return false;
            Abstract a = (Abstract)obj;
            return idAbstract == a.idAbstract && file == a.file;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
