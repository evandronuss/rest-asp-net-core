using rest_asp_net_core.Model;
using System.Collections.Generic;
using System.Threading;

namespace rest_asp_net_core.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public IList<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                persons.Add(MockPerson());
            }

            return persons;
        }

        public Person FindById(long id)
        {

            return MockPerson();
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson()
        {
            var id = IncrementAndGet();

            return new Person
            {
                Id = id,
                FirstName = $"Person Name {id}",
                LastName = $"Person Lastname {id}",
                Address = $"Some Address {id}",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
