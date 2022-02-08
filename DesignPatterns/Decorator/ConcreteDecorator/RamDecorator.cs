using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class RamDecorator : DesktopDecorator
    {
        public string Ram { get; set; }
        public RamDecorator(Computer computer, string ram) : base(computer)
        {
            this.Ram = ram; 
        }

        public override string GetConfiguration()
        {
            return $"{base.GetConfiguration()}, RAM : {Ram}";
        }
    }
}
