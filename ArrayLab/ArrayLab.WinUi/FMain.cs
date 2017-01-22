using ArrayLab.WinUi.ExtensionAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayLab.WinUi
{
    public partial class FMain : Form
    {
        public FMain(IExtensionFactory extensionFactory)
        {
            InitializeComponent();

            this.extensionFactory = extensionFactory;
            loadExtensions();
        }

        private IExtensionFactory extensionFactory;
        private IEnumerable<IArrayLoaderExtension> loaderExtensions;
        private IEnumerable<IArrayFunctionExtension> functionExtensions;

        private void loadExtensions()
        {
            loaderExtensions = extensionFactory.GetAllLoaderExtensions();
            functionExtensions = extensionFactory.GetAllFunctionExtensions();

            foreach (var extension in loaderExtensions)
            {
                var item = new ToolStripMenuItem();
                item.Name = extension.Name;
                item.Text = extension.MenuItemTitle;
                item.Tag = extension;
                item.Click += loaderMenuItem_Click;

                loadArrayToolStripDropDownButton.DropDownItems.Add(item);
            }
        }

        private void loaderMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var extension = (IArrayLoaderExtension)item.Tag;
            var arrayData = extension.Load();
        }
    }
}
