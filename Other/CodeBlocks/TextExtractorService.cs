using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class TextExtractorService
    {
        public TextExtractorService(ITextExtractorFactory factory)
        {
            this.factory = factory;
        }

        private ITextExtractorFactory factory;

        public string Extract(string filename)
        {
            var extractor = ServiceLocator.Resolve<ITextExtractor>(getImplementationName(filename));
            //var extractor = factory.Resolve(getImplementationName(filename));
            if (extractor != null)
            {
                return extractor.Extract(filename);
            }
            else
            {
                throw new NullReferenceException("Extractor not found for a given file type.");
            }
        }

        private string getImplementationName(string filename)
        {
            return System.IO.Path.GetExtension(filename);
        }
    }
}
