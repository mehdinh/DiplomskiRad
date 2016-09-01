using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainer
{
    public class ContainerException : Exception
    {
        public ContainerException() : base()
        { }

        public ContainerException(string message) : base(message)
        { }
    }
}
