using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public class RepositoryConsumer
    {
        public RepositoryConsumer(Repository repository)
        {
            this.repository = repository;
        }

        private Repository repository;

        public void Consume()
        {
            // Upotreba repository klase je spremna.    
        }
    }
}
