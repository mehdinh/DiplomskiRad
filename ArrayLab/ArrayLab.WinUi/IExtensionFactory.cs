using ArrayLab.WinUi.ExtensionAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.WinUi
{
    public interface IExtensionFactory
    {
        IEnumerable<IArrayLoaderExtension> GetAllLoaderExtensions();

        IEnumerable<IArrayFunctionExtension> GetAllFunctionExtensions();
    }
}
