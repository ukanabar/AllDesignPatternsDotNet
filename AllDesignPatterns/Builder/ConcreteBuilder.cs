using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public Product GetProduct()
        {
            var result = _product;
            this.Reset();
            return result;
        }
        public void BuildPartA()
        {
            //Add part to product
        }

        public void BuildPartB()
        {
            //Add part to product
        }

        public void BuildPartC()
        {
            //Add part to product
        }
    }
}
