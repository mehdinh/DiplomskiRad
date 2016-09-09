using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks.ContainerSamples
{
    public class UnitySamples
    {
        public void Sample()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, ConsoleLogger>();
            ILogger logger = container.Resolve<ILogger>();
        }

    }
}
