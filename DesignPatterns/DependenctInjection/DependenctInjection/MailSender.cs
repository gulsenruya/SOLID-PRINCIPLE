using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class MailSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine(String.Format("MailSender : {0}", Message));
        }
    }
}
