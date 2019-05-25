using rest_asp_net_core.Model;
using System.Collections.Generic;

namespace rest_asp_net_core.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        IList<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long? id);
    }
}
