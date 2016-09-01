using EmpiricaContainerTestApplication.Emails;
using EmpiricaContainerTestApplication.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpiricaContainerTestApplication
{
    public partial class FMain : Form
    {
        public FMain(EmailService emailService, ILogger logger, ILoggerFactory loggerFactory)
        {
            InitializeComponent();

            this.emailService = emailService;
            this.logger = logger;
            this.loggerFactory = loggerFactory;            
        }

        private EmailService emailService;
        private ILogger logger;
        private ILoggerFactory loggerFactory;

        private void FMain_Load(object sender, EventArgs e)
        {
            logger.Log("Logger");

            var loggers = loggerFactory.GetAllInstances();
            foreach (var logger in loggers)
            {
                logger.Log("Named logger, iteration");
            }

            loggerFactory.GetInstance("ConsoleLogger").Log("Named logger, call by name");
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            emailService.SendEmail("mehdin.hodzic@empirica.edu.ba", "Test", "Testing injection into a service...");
        }
    }
}
