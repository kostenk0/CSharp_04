using CSharp_04.Models;
using System.Collections.Generic;

namespace CSharp_04.Tools.DataStorage
{
    internal interface IDataStorage
    {
        bool PersonExists(string email);

        Person GetPersonByEmail(string email);

        void RemovePerson(Person person);
        void AddPerson(Person person);
        List<Person> PersonsList { get; }
    }
}
