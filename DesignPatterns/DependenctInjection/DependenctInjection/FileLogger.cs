using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class FileLogger : ILogger
    {
        public void WriteLog(string Message)
        {
            Console.WriteLine(String.Format("FileLogger : {0}", Message));
        }
    }
}
