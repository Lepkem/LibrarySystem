namespace LibraryStandard.Menu
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;
    using LibraryStandard.People;

    public class SearchPersonByID : Page
    {
        public SearchPersonByID(Program program)
            : base("Search a person by ID", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            Person searchRes = CatalogPerson.Instance.SearchByID(Console.ReadLine());
            if(searchRes != null) searchRes.ShowPersonProps();
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}