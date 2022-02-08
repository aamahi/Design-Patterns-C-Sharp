using AbstractFactory.Concrete_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete_Factory
{
    public class AppleFactory : GadgetFactory
    {
        public override Phone GetPhone()
        {
            return new ApplePhone("IPhone 13", "15 mega pixel");
        }

        public override Tablet GetTablet()
        {
            return new AppleTablet("IPAD 5", "10 inch");
        }
    }
}
