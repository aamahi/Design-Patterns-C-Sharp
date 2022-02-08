using Decorator.Component;
using Decorator.ConcreteComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class DesktopDecorator : Computer
    {
        protected Computer _computer;

        public DesktopDecorator(Computer computer)
        {
            this._computer = computer;
        }

        public override string GetConfiguration()
        {
            return _computer.GetConfiguration();
        }
    }
}
