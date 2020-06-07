namespace LibraryStandard.Menu
{
    using System;
    using System.Collections.Generic;

    using EasyConsole;

    using LibraryStandard.Helpers;
    using LibraryStandard.People;

    public class SearchPersonByStreetname : Page
    {
        public SearchPersonByStreetname(Program program)
            : base("search a person by street name", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            List<Person> searchRes = CatalogPerson.Instance.SearchPersonByStreetname(StandardMessages.GetInputForParam("street name"));
            StandardMessages.ResultsCount(searchRes.Count);
            searchRes.ForEach(person => person.ShowPersonProps());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}
