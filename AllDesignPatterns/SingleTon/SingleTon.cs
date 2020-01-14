using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.SingleTon
{
    public sealed class SingleTon
    {
        private static readonly SingleTon instance = new SingleTon();

        static SingleTon()
        {

        }

        private SingleTon()
        {

        }

        public static SingleTon GetInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
