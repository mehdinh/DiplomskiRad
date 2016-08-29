using EmpiricaContainerTestApplication.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainerTestApplication.Infrastructure.Logging
{
    public class FileLogger : ILogger
    {
        public void Log(string text)
        {
            File.AppendAllText("dnevnik.log", DateTime.Now.ToString() + " - " + text + Environment.NewLine);
        }
    }
}
