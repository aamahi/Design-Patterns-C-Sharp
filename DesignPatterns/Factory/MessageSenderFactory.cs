using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class MessageSenderFactory // The Creator Abstract Class
    {
        abstract public IMessageSender CreateMessageSender(string type); //Factory Method
    }
}
