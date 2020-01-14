using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Facade
{
    class SubSystem
    {
        SubSystem1 ss1;
        SubSystem2 ss2;

        public SubSystem(SubSystem1 system1, SubSystem2 system2)
        {
            ss1 = system1;
            ss2 = system2;
        }

        public void Operation()
        {
            ss1.operation1();
            ss1.operation2();
            ss2.operation1();
            ss2.operation2();
        }
    }
}
