namespace LibraryStandard
{
    using System.Collections.Generic;

    using LibraryStandard.Interfaces;
    using LibraryStandard.People;

    public interface ICatalogPerson
    {
        Person GetPersonByID(string id);

        List<Person> SearchPersonByName(string name);
    }

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

        public Person GetPersonByID(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> SearchPersonByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}