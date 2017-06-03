using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Session
    {
        private int idSession;
        private Room room;
        private Presentation presentation;
        private User user;
        private Edition edition;

        public virtual int IdSession
        {
            get
            {
                return idSession;
            }

            set
            {
                idSession = value;
            }
        }

        public virtual Room Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        public virtual Presentation Presentation
        {
            get
            {
                return presentation;
            }

            set
            {
                presentation = value;
            }
        }

        public virtual User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public virtual Edition Edition
        {
            get
            {
                return edition;
            }

            set
            {
                edition = value;
            }
        }

        public Session(int idSession, Room room, Presentation presentation, User user, Edition edition)
        {
            this.IdSession = idSession;
            this.Room = room;
            this.Presentation = presentation;
            this.User = user;
            this.Edition = edition;
        }

        public Session()
        {
            this.IdSession = 0;
            this.Room = null;
            this.Presentation = null;
            this.User = null;
            this.Edition = null;
        }

        public override string ToString()
        {
            return IdSession + " " + Room + " " + Presentation + " " + User + " " + Edition;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Session))
                return false;
            Session s = (Session)obj;
            if (s.idSession != this.idSession || s.room != this.room || s.presentation != this.presentation || s.user != this.user || s.edition != this.edition )
                return false;
            return true;
        }
    }
}
