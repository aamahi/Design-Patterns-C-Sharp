using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class GadgetFactory //abstract factory
    {
        public abstract Phone GetPhone();
        public abstract Tablet GetTablet();
    }
}
