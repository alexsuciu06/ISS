using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Participation
    {
        private User participant;
        private Session session;

        public virtual User Participant { get => participant; set => participant = value; }
        public virtual Session Session { get => session; set => session = value; }
    }
}
