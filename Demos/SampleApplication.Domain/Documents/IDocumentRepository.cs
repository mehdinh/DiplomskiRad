using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Domain.Documents
{
    public interface IDocumentRepository
    {
        Document GetById(int id);

        Document GetByName(string name);

        IList<Document> GetAll();
    }
}
