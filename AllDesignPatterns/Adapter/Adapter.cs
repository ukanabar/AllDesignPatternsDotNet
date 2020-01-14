using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Adapter
{
    class Adapter : IAdapter
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }
        public void GetRequest()
        {
            this._adaptee.GetDiiferentRequest();
        }
    }
}
