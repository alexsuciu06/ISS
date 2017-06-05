using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Room
    {
        private int idRoom;
        private int roomNr;
        private int seats;

        public Room(int roomNr, int seats)
        {
            this.RoomNr = roomNr;
            this.Seats = seats;
        }

        public virtual int IdRoom
        {
            get
            {
                return idRoom;
            }

            set
            {
                idRoom = value;
            }
        }

        public virtual int RoomNr
        {
            get
            {
                return roomNr;
            }

            set
            {
                roomNr = value;
            }
        }

        public virtual int Seats
        {
            get
            {
                return seats;
            }

            set
            {
                seats = value;
            }
        }

        public Room()
        {
            this.IdRoom = 0;
            this.RoomNr = 0;
            this.Seats = 0;
        }
        public override string ToString()
        {
            return IdRoom + " " + RoomNr + " " + Seats;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Room))
                return false;
            Room r = (Room)obj;
            if (r.idRoom != this.idRoom ||   r.roomNr != this.roomNr || r.seats != this.seats) 
                return false;
            return true;
        }
    }
}
