namespace LibraryStandard.Interfaces
{
    using System.Collections.Generic;

    using LibraryStandard.People;

    public interface ICatalogPerson
    {
        Person GetPersonByID(string id);
        List<Person> SearchPersonByName(string name);
        
    }
}