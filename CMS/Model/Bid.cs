using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum BidEnum
    {
        PLEASED_TO_REVIEW,
        COULD_EVALUATE,
        REFUZE_TO_EVALUATE,
        NULL
    };

    public class Bid
    {
        private int id;
        private User user;
        private BidEnum bid;
        private Paper paper;


        public virtual int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public virtual Paper Paper
        {
            get
            {
                return paper;
            }

            set
            {
                paper = value;
            }
        }

        public virtual BidEnum BID
        {
            get
            {
                return bid;
            }

            set
            {
                bid = value;
            }
        }

        public Bid(User usr,BidEnum bid,Paper paper)
        {
            this.User = usr;
            this.BID = bid;
            this.Paper = paper;
        }

        public Bid()
        {
            this.User = null;
            this.BID = BidEnum.NULL;
            this.Paper = null;
        }

        public override string ToString()
        {
            return User.ToString() + " " + BID.ToString() + " " + Paper.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Bid))
                return false;
            Bid a = (Bid)obj;
            if (a.User.Equals( this.User) || a.BID.Equals( this.BID) || a.Paper.Equals(this.Paper))
                return false;
            return true;
        }
    }
}
