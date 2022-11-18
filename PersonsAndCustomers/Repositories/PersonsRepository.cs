using Persons.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repositories
{
    public class PersonsRepository : IRepository<Person>
    {
        private readonly List<Person> _repository;
        public PersonsRepository()
        {
            _repository = new List<Person>();
        }
        public IReadOnlyCollection<Person> Models => throw new NotImplementedException();

        public void Add(Person model)
        {
            throw new NotImplementedException();
        }

        public Person GetT(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remuve(Person model)
        {
            throw new NotImplementedException();
        }
    }
}
