using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public interface IExtension
    {
        string[] GetMenuItems();

        void MenuItemSelected(string menuItem);
    }

    public interface IExtensionFactory
    {
        IEnumerable<IExtension> GetAllInstances();
    }

    public class ExtensionFactory : IExtensionFactory
    {
        public IEnumerable<IExtension> GetAllInstances()
        {
            return Bootstrap.Container.ResolveAll<IExtension>();
        }
    }
}
