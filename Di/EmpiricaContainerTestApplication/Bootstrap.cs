using EmpiricaContainer;
using EmpiricaContainerTestApplication.Infrastructure.Logging;
using EmpiricaContainerTestApplication.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainerTestApplication
{
    public static class Bootstrap
    {
        private static IContainer container = new Container();

        public static IContainer Container
        {
            get
            {
                return container;
            }
        }

        public static void Configure()
        {
            Container.Register<ILogger, ConsoleLogger>(Lifetime.Transient);
            Container.Register<ILogger, ConsoleLogger>("ConsoleLogger", Lifetime.Singleton);
            Container.Register<ILogger, FileLogger>("FileLogger", Lifetime.Singleton);
            Container.Register<ILoggerFactory, LoggerFactory>(Lifetime.Singleton);
        }
    }
}
