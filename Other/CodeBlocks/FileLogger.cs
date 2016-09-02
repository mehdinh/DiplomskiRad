using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class FileLogger : ILogger
    {
        public void Log(string text)
        {
            System.IO.File.AppendAllText("log.txt", DateTime.Now.ToString() + " " + text + Environment.NewLine);
        }
    }
}
