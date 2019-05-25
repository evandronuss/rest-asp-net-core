using rest_asp_net_core.Model;
using rest_asp_net_core.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace rest_asp_net_core.Repository.Implementattions
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private MySqlContext _context;

        public PersonRepositoryImpl(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public void Delete(long id)
        {
            var person = FindById(id);

            try
            {
                if (Exists(id))
                {
                    _context.Persons.Remove(person);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            var result = FindById(person.Id.Value);

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public bool Exists(long? id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
