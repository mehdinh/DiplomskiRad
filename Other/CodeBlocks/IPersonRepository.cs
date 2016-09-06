using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public interface IPersonRepository
    {
        void Add(Person person);

        void Update(Person person);

        void Delete(Person person);

        void Delete(int id);

        Person GetById(int id);

        ICollection<Person> GetAll();

        ICollection<Person> Find(string firstName, string lastName);
    }
}
