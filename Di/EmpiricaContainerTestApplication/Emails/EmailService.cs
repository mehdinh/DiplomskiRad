using EmpiricaContainerTestApplication.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainerTestApplication.Emails
{
    public class EmailService
    {
        public EmailService(ILogger logger)
        {
            this.logger = logger;
        }

        private ILogger logger;

        public void SendEmail(string email, string subject, string body)
        {
            logger.Log(String.Format("Sending email to {0}: {1} - {2}", email, subject, body));
        }
    }
}
