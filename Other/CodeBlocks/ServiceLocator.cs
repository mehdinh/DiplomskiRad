using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public static class ServiceLocator
    {
        public static T Resolve<T>()
        {
            return Bootstrap.Container.Resolve<T>();
        }

        public static T Resolve<T>(string name)
        {
            return Bootstrap.Container.Resolve<T>(name);
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return Bootstrap.Container.ResolveAll<T>();
        }
    }
}
