using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class MySpamFilter : ISpamFilter
    {
        public MySpamFilter(ILogger logger)
        {
            this.logger = logger;
        }

        private ILogger logger;
    }
}
