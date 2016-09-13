using ArrayLab.WinUi.ExtensionAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.WinUi
{
    public class ExtensionFactory : IExtensionFactory
    {
        public IEnumerable<IArrayLoaderExtension> GetAllLoaderExtensions()
        {
            return Bootstrap.Container.ResolveAll<IArrayLoaderExtension>();
        }

        public IEnumerable<IArrayFunctionExtension> GetAllFunctionExtensions()
        {
            return Bootstrap.Container.ResolveAll<IArrayFunctionExtension>();
        }
    }
}
