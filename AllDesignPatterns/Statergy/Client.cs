using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Statergy
{
    class Client
    {
        IStatergy statergy { get; set; }

        public string CallAlgorithm()
        {
            return statergy.Algorith();
        }
    }
}
