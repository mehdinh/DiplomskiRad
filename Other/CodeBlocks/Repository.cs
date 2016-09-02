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

        public Person GetById(int id)
        {
            // Ako želimo koristiti ispis na konzolu koristimo ConsoleLogger
            ILogger logger = new ConsoleLogger();

            // Ako želimo koristiti ispis u datoteku koristimo TextLogger
            // ILogger logger = new FileLogger();
            logger.Log("Učitavanje podataka o osobi čiji je ID " + id.ToString());
            throw new NotImplementedException();
        }
    }
}
