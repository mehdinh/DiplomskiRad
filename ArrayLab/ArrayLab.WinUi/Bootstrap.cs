using ArrayLab.WinUi.ExtensionAbstractions;
using EmpiricaContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.WinUi
{
    public static class Bootstrap
    {
        private static IContainer container = new Container();

        public static IContainer Container
        {
            get
            {
                return container;
            }
        }

        public static void Configure()
        {
            Container.Register<IExtensionFactory, ExtensionFactory>(Lifetime.Singleton);
            Container.Register<IArrayLoaderExtension, FormEntryExtension.Extension>("FormEntryExtension");
            Container.Register<IArrayLoaderExtension, CsvLoaderExtension.Extension>("CsvLoaderExtension");
        }
    }
}
