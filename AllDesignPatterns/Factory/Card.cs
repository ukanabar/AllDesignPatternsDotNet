using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Factory
{
    abstract class Card
    {
        public abstract string CardType { get; }
        public abstract int CardLimit { get; set; }
    }
}
