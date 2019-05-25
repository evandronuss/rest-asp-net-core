using rest_asp_net_core.Model;
using rest_asp_net_core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace rest_asp_net_core.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        private IPersonRepository _repository;

        public PersonServiceImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public IList<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            if (!_repository.Exists(person.Id)) return null;

            return _repository.Update(person);
        }
    }
}
