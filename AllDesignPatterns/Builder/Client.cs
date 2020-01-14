using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Builder
{
    class Client
    {
        static void TestBuilder()
        {
            Director dir = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            dir.Builder = builder;
            dir.BuildMinimalProduct();
            //builder.GetProduct().ListParts();
            dir.BuildFullProduct();
            //builder.GetProduct().ListParts();
        }
    }
}
