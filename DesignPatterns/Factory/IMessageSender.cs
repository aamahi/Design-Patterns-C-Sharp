using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IMessageSender // Prooduct Class
    {
        void SendMessage(string message);
    }
}
