using EmpiricaContainerTestApplication.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainerTestApplication.Infrastructure.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(DateTime.Now.ToString() + " - " + text);
        }
    }
}
