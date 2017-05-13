﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    public class Abstract
    {
        private int idAbstract;
        private string file;

        public virtual int IdAbstract
        {
            get { return idAbstract; }
            set { idAbstract = value; }
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

        public Abstract(int idAbstract, string file)
        {
            this.idAbstract = idAbstract;
            this.file = file;
        }

        public override string ToString()
        {
            return idAbstract + " " + file;
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