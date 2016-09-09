using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks.ContainerSamples
{
    public class CastleWindsorSamples
    {
        public void Sample()
        {
            var container = new Castle.Windsor.WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component
                .For<ILogger>()
                .ImplementedBy<ConsoleLogger>());
            ILogger logger = container.Resolve<ILogger>();

            container.Register(Castle.MicroKernel.Registration.Types
                .FromThisAssembly()                
                .BasedOn<ILogger>());
        }
    }
}
