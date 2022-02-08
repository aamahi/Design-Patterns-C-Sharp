using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class GpuDecorator : DesktopDecorator
    {
        public string Gpu { get; set; }
        public GpuDecorator(Computer computer, string gpu) : base(computer)
        {
            this.Gpu = gpu;
        }

        public override string GetConfiguration()
        {
            return $"{base.GetConfiguration()}, GPU : {Gpu}";
        }
    }
}
