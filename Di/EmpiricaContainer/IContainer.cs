using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainer
{
    public interface IContainer
    {
        void Register<TContract, TImplementation>(Lifetime lifetime = Lifetime.Transient);

        void Register<TContract, TImplementation>(string name, Lifetime lifetime = Lifetime.Transient);

        T Resolve<T>();

        T Resolve<T>(string name);

        IEnumerable<T> ResolveAll<T>();
    }
}
