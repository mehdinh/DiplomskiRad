using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.WinUi.ExtensionAbstractions
{
    public interface IArrayFunctionExtension : IExtension
    {
        bool ResultIsScalar { get; }

        object Execute(double[] array);
    }
}
