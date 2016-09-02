using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class EmailService
    {
        public EmailService(ISpamFilter spamFilter, ILogger logger)
        {
            this.spamFilter = spamFilter;
            this.logger = logger;
        }

        private ISpamFilter spamFilter;
        private ILogger logger;
    }
}
