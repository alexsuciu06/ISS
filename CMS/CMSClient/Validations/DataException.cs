using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Validations
{
    class DataException:Exception
    {
        private string message;
        public DataException(string m) : base(m) { }
   
    }
}
