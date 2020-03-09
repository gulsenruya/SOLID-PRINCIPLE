using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class DBLogger : ILogger
    {
        public void WriteLog(string Message)
        {
            Console.WriteLine(String.Format("DBLogger : {0}", Message));
        }
    }
}
