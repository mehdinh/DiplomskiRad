using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.WinUi.ExtensionAbstractions
{
    public interface IArrayLoaderExtension : IExtension
    {
        string Name { get; }

        string MenuItemTitle { get; }

        double[] Load();
    }
}
