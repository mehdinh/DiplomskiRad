using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class LoggerDecorator : ILogger
    {
        public LoggerDecorator(ILogger logger)
        {
            this.logger = logger;
        }

        public ILogger logger;

        public void Log(string text)
        {
            logger.Log(text);
            Console.WriteLine(DateTime.Now.ToString() + " " + text);
        }
    }
}
