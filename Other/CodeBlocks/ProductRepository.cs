using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class ProductRepository
    {
        private ILogger logger;

        public Product GetById(int id)
        {
            //logger = ServiceLocator.Resolve<ILogger>();
            logger = Bootstrap.Container.Resolve<ILogger>();
            throw new NotImplementedException();
        }
    }
}
