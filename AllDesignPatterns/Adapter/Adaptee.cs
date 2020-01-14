using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Adapter
{
    class Adaptee
    {
        public void GetDiiferentRequest()
        {
            Console.WriteLine("Different Request");
        }
    }
}
