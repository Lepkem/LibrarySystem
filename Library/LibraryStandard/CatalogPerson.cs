namespace LibraryStandard
{
    using System;

    using LibraryStandard.Interfaces;
    using LibraryStandard.People;
    using System.Collections.Generic;
    using System.Linq;

    using LibraryStandard.Helpers;

    public sealed class CatalogPerson : ICatalogPerson
    {
        private static readonly CatalogPerson instance = new CatalogPerson();

        static CatalogPerson()
        {

        }

        private CatalogPerson()
        {

        }

        public static CatalogPerson Instance
        {
            get
            {
                return instance;
            }
        }


        private List<Person> persons = new List<Person>();



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetPersonByID(string id)
        {
            Person foundPerson = persons.First(person => person.ID.Equals(id));
            return foundPerson;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Person> SearchPersonByName(string name)
        {
            try
            {
                List<Person> foundPersonList = new List<Person>();
                foundPersonList = persons.Where(person => person.Firstname.ToLower().Contains(name) | person.Surname.ToLower().Contains(name)).ToList();
                return foundPersonList;
            }
            catch (Exception)
            {
                StandardMessages.NoSearchResults();
                return new List<Person>();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPersonList()
        {
            return persons;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newList"></param>
        public void SetPersonList(List<Person> newList)
        {
            persons = newList;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteAllPersons()
        {
            persons.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool AddNewPerson(Person person)
        {
            persons.Add(person);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public bool DeletePerson(string personId)
        {
            persons.Remove(persons.Where(person => person.ID.Equals(personId)).First());
            return true;
        }

        /// <summary>
        /// returns a list of persons of which the first or last name contain the input
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <returns></returns>
        public List<Person> SearchPersonByName(string firstname, string lastname)
        {
            //todo
            //only if !isnullorempty
            return persons.Where(person => person.Firstname.Equals(firstname) || person.Surname.Equals(lastname)).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public Person SearchByID(string personId)
        {
            try
            {
                return persons.Where(person => person.ID.Equals(personId)).First();
            }
            catch (Exception)
            {
                StandardMessages.NoSearchResults();
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="streetname"></param>
        /// <returns></returns>
        public List<Person> SearchPersonByStreetname(string streetname)
        {
            List<Person> results = new List<Person>();
            results = persons.Where(person => person.StreetName.Equals(streetname)).ToList();
            return results;
        }

    }
}