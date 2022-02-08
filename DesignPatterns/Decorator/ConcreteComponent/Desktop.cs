using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class Desktop : Computer
    {
        public string Processor { get; set; }
        public string Motherboard { get; set; }

        public Desktop(string processor, string motherboard)
        {
            this.Processor = processor;
            this.Motherboard = motherboard;
        }


        public override string GetConfiguration()
        {
            return $"Configuration : CPU : {Processor}, Motherboard : {Motherboard}";
        }
    }
}
