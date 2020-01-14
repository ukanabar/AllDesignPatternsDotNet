using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Factory
{
    class CreditCard : Card
    {
        private string _cardType;

        private int _cardLimit;

        public CreditCard(int CardLimit)
        {
            this._cardType = "Credit";
            this._cardLimit = CardLimit;
        }
        public override string CardType
        {
            get
            {
                return _cardType;
            }
        }

        public override int CardLimit
        {
            get { return _cardLimit; }
            set { _cardLimit = value; }
        }
    }
}
