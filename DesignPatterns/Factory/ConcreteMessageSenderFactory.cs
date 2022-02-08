using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConcreteMessageSenderFactory : MessageSenderFactory //Concrete creator class
    {
        public override IMessageSender CreateMessageSender(string type)
        {
            switch (type)
            {
                case "email":
                    return new EmailSender();
                case "sms":
                    return new SMSSender();
                default: 
                    throw new ArgumentException("this type of message sender isn't available yet");
                
            }
        }
    }
}
