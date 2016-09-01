using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class RepositoryConsumer
    {
        public void Consume()
        {
            ILogger logger = new ConsoleLogger();
            Repository repository = new Repository(logger);
        }
    }
}
