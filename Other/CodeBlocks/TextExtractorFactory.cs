using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class TextExtractorFactory : ITextExtractorFactory
    {
        public ITextExtractor Resolve(string name)
        {
            try
            {
                return Bootstrap.Container.Resolve<ITextExtractor>(name);
            }
            catch (EmpiricaContainer.ContainerException)
            {
                return null;
            }
        }
    }
}
