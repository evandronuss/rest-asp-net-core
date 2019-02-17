using rest_asp_net_core.Model;
using System.Collections.Generic;

namespace rest_asp_net_core.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        IList<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
