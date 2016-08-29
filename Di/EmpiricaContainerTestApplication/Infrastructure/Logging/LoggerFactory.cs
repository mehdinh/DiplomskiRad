using EmpiricaContainerTestApplication.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainerTestApplication.Infrastructure.Logging
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger GetInstance()
        {
            return Bootstrap.Container.Resolve<ILogger>();
        }

        public ILogger GetInstance(string name)
        {
            return Bootstrap.Container.Resolve<ILogger>(name);
        }

        public IEnumerable<ILogger> GetAllInstances()
        {
            return Bootstrap.Container.ResolveAll<ILogger>();
        }
    }
}
