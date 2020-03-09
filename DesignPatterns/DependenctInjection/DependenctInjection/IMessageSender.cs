using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IMessageSender
    {
        void SendMessage(string Message);
    }
}
