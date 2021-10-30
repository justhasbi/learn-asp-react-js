using NETCore.Models;
using System.Collections.Generic;

namespace NETCore.Repository.Interface
{
    interface IPersonRepository
    {
        IEnumerable<Person> GetAll();

        Person GetById(string id);

        int Insert(Person person);

        int Update(Person person);

        int Delete(string id);
    }
}
