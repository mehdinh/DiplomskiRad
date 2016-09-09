using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks.ContainerSamples
{
    public class NinjectSamples
    {
        public void Sample()
        {
            IKernel kernel = new Ninject.StandardKernel();
            kernel.Bind<ILogger>().To<ConsoleLogger>();
            ILogger logger = kernel.Get<ILogger>();
        }
    }
}
