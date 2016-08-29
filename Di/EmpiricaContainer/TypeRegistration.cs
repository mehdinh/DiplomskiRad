using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainer
{
    internal class TypeRegistration
    {
        public Type ContractType { get; set; }

        public Type ImplementationType { get; set; }

        public Lifetime Lifetime { get; set; }
    }
}
