using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class StructureMapSamples
    {
        public void Sample()
        {
            var container = new StructureMap.Container();
            container.Configure(c => c.For<ILogger>().Use<ConsoleLogger>());
            ILogger logger = container.GetInstance<ILogger>();
        }
        public void Sample2()
        {             
            var container = new StructureMap.Container(c =>
            {
                c.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });
            });
        }
    }
}
