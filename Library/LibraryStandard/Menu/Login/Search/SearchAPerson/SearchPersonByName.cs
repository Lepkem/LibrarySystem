namespace LibraryStandard.Menu
{
    using System;
    using System.Collections.Generic;

    using EasyConsole;

    using LibraryStandard.Helpers;
    using LibraryStandard.People;

    public class SearchPersonByName : Page
    {
        public SearchPersonByName(Program program)
            : base("Search a person by name", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            List<Person> searchRes = CatalogPerson.Instance.SearchPersonByName(Console.ReadLine());
            StandardMessages.ResultsCount(searchRes.Count);
            searchRes.ForEach(person => person.ShowPersonProps());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}