using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public abstract class Computer // The base Component interface defines operations that can be altered by
    // decorators.
    {
        abstract public string GetConfiguration();
    }
}
