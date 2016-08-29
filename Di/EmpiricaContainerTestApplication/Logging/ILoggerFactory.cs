using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainerTestApplication.Logging
{
    public interface ILoggerFactory
    {
        ILogger GetInstance();

        ILogger GetInstance(string name);

        IEnumerable<ILogger> GetAllInstances();
    }
}
