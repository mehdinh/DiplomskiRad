using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class Repository
    {
        public Repository(ILogger logger)
        {
            this.logger = logger;
        }

        private ILogger logger;        
    }
}
