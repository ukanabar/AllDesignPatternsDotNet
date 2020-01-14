using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Adapter
{
    class Client
    {
        static void Test()
        {
            Adaptee adaptee = new Adaptee();
            IAdapter adapter = new Adapter(adaptee);
            adapter.GetRequest();
        }
        
    }
}
