using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Prototype
{
    class InvitationCard
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime date { get; set; }

        public Address addr;

        public InvitationCard ShallowCopy()
        {
            return (InvitationCard)this.MemberwiseClone();
        }

        public InvitationCard DeepCopy()
        {
            InvitationCard card =  (InvitationCard)this.MemberwiseClone();
            card.addr = new Address(addr.unit, addr.streetName);
            return card;
        }
    }

    class Address
    {
        public int unit;
        public string streetName;
        public Address(int u,string sn)
        {
            this.unit = u;
            this.streetName = sn;
        }
    }
}
