using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDesignPatterns.Builder
{
    class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            get { return _builder; }
            set { _builder = value; }
        }

        public void BuildMinimalProduct()
        {
            _builder.BuildPartA();
        }

        public void BuildFullProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}
