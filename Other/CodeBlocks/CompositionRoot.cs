using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class CompositionRoot
    {
        public void Run()
        {
            ILogger logger = new FileLogger();
            Repository repository = new Repository(logger);
            RepositoryConsumer consumer = new RepositoryConsumer(repository);
        }

        public static void Main()
        {
            ILogger logger = new FileLogger();
            Repository repository = new Repository(logger);
            RepositoryConsumer consumer = new RepositoryConsumer(repository);
            ISpamFilter spamFilter = new MySpamFilter(logger); // Logger je proslijeđen konstrukoru klase MySpamFilter
            EmailService emailService = new CodeBlocks.EmailService(spamFilter, logger);

            Bootstrap.Configure();
        }
    }
}
