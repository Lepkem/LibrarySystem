namespace LibraryStandard
{
    using LibraryStandard.Interfaces;
    using LibraryStandard.People;
    using System.Collections.Generic;
    using System.Linq;


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
            List<Person> foundPersonList = new List<Person>();
            foundPersonList = persons.Where(person => person.Firstname.Contains(name) | person.Surname.Contains(name)).ToList();
            return foundPersonList;
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
    }
}