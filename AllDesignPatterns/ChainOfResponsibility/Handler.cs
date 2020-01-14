using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.ChainOfResponsibility
{
    abstract class Handler
    {
        public abstract void HandleRequest(int num);
        protected Handler next;
        public void SetNextHandler(Handler handle)
        {
            this.next = handle;
        }
    }
}
