using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine(String.Format("SMSSender : {0}", Message));
        }
    }
}
