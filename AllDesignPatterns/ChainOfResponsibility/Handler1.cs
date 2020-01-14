using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.ChainOfResponsibility
{
    class Handler1 : Handler
    {
        public override void HandleRequest(int num)
        {
            if (num <= 10)
            {
                //print number
            } else if (next != null)
            {
                next.HandleRequest(num);
            }
        }
    }
}
