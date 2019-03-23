using CSharp_04.Models;
using CSharp_04.Tools.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp_04.Tools.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<Person> _persons;

        internal SerializedDataStorage()
        {
            try
            {
                _persons = SerializationManager.Deserialize<List<Person>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _persons = new List<Person>();
                for (int i = 0; i < 50; i++)
                {
                    _persons.Add(new Person("Person_" + i, "Person_" + i, "user_" + i + "@gmail.com", DateTime.Today));
                }
                SaveChanges();
            }
        }

        public bool PersonExists(string email)
        {
            return _persons.Exists(u => u.Email == email);
        }

        public Person GetPersonByEmail(string email)
        {
            return _persons.FirstOrDefault(u => u.Email == email);
        }

        public void RemovePerson(Person person)
        {
            _persons.Remove(person);
            SaveChanges();
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
            SaveChanges();
        }

        public List<Person> PersonsList
        {
            get { return _persons.ToList(); }
        }

        private void SaveChanges()
        {
            SerializationManager.Serialize(_persons, FileFolderHelper.StorageFilePath);
        }

    }
}
