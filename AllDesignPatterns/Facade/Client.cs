using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Facade
{
    class Client
    {
        public void PerformOperation(SubSystem ss)
        {
            ss.Operation();
        }
    }
}
