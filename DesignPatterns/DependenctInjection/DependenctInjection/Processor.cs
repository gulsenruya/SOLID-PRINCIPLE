using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Processor
    {
        ILogger logger = null;
        IMessageSender messageSender;
        public Processor(ILogger _logger, IMessageSender _messageSender)
        {
            logger = _logger;
            messageSender = _messageSender;
        }
        public void Process()
        {
            logger.WriteLog("Log Text");                             
            messageSender.SendMessage("Message Text");
        }
        
    }
}
