using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainer
{
    public interface IContainer
    {
        void Register<TContract, TImplementation>(Lifetime lifetime = Lifetime.Singleton);

        void Register<TContract, TImplementation>(string name, Lifetime lifetime = Lifetime.Singleton);

        T Resolve<T>();

        T Resolve<T>(string name);

        IEnumerable<T> ResolveAll<T>();
    }
}
