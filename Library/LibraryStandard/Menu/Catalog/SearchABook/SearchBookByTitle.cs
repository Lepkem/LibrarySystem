namespace LibraryStandard.Menu
{
    using System;
    using System.Linq;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class SearchBookByTitle : Page
    {
        //menu 1Aa
        public SearchBookByTitle(Program program)
            : base("Search a book by the Author", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            var searchRes = LibraryStandard.Catalog.Instance.SearchBookByTitle(Console.ReadLine());
            StandardMessages.ResultsCount(searchRes.Count());
            searchRes.ForEach(book => book.ShowBookProp());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}