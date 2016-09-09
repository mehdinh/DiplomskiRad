using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks.ContainerSamples
{
    public class AutofacSamples
    {
        public void Sample()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();

            builder.RegisterAssemblyTypes(this.GetType().Assembly)
                   .AsImplementedInterfaces();

            var container = builder.Build();

            ILogger logger = container.Resolve<ILogger>();
        }
    }
}
