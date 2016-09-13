using ArrayLab.WinUi.ExtensionAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab.FormEntryExtension
{
    public class Extension : IArrayLoaderExtension
    {
        public string Name
        {
            get
            {
                return "FormEntryExtension";
            }
        }

        public string MenuItemTitle
        {
            get
            {
                return "Enter array elements...";
            }
        }

        public double[] Load()
        {
            return new double[] { 1, 2, 5, 7 };
        }
    }
}
