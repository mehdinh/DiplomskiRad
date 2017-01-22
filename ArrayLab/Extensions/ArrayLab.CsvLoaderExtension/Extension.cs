using ArrayLab.WinUi.ExtensionAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.CsvLoaderExtension
{
    public class Extension : IArrayLoaderExtension
    {
        public string Name
        {
            get
            {
                return "CsvLoaderExtension";
            }
        }

        public string MenuItemTitle
        {
            get
            {
                return "Load array from...";
            }
        }

        public double[] Load()
        {
            return new double[] { 10, 20, 50, 70 };
        }
    }
}
