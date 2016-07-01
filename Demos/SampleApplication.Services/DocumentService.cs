using SampleApplication.Domain.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Services
{
    public class DocumentService
    {
        public DocumentService(IDocumentRepository repository, IDocumentLoader loader, IDocumentProcessor processor)
        {
            this.repository = repository;
            this.loader = loader;
            this.processor = processor;
        }

        private IDocumentRepository repository;
        private IDocumentLoader loader;
        private IDocumentProcessor processor;
    }
}
