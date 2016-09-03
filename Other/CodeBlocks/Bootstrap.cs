using EmpiricaContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class Bootstrap
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
            Container.Register<ILogger, ConsoleLogger>(Lifetime.Singleton);
            Container.Register<ISpamFilter, MySpamFilter>(Lifetime.Transient);
        }
    }
}
