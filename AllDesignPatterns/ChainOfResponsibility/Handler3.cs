using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.ChainOfResponsibility
{
    class Handler3 : Handler
    {
        public override void HandleRequest(int num)
        {
            if (num >20)
            {
                //print number
            }
            else if (next != null)
            {
                next.HandleRequest(num);
            }
        }
    }
}
