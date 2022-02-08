using AbstractFactory.Concrete_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete_Factory
{
    public class SamsungFactory : GadgetFactory
    {
        public override Phone GetPhone()
        {
            return new SamsungPhone("M31", "20 mega pixel");
        }

        public override Tablet GetTablet()
        {
            return new SamsungTablet("Galaxy 5", "12 inch");
        }
    }
}
