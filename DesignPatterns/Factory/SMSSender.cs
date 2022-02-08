using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SMSSender : IMessageSender //Concrete Product : Product
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS Sent {message}");
        }
    }
}
