using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Factory
{
    class CardFactory
    {
        public Card GetCard(string type)
        {
            if (type.Equals("Credit"))
            {
                return new CreditCard(5000);
            } else if (type.Equals("Debit"))
            {
                return new DebitCard(3000);
            } else
            {
                throw new ArgumentException("Invalid Type");
            }
        }
    }
}
