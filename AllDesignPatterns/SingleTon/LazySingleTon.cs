using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.SingleTon
{
    public sealed class LazySingleTon
    {
        private static readonly Lazy<LazySingleTon> instance = new Lazy<LazySingleTon>(() => new LazySingleTon());

        private LazySingleTon()
        {

        }

        public static LazySingleTon GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
