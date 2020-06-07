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
            : base("Search a book by the title", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            var searchRes = LibraryStandard.Catalog.Instance.SearchBookByTitle(Console.ReadLine());
            StandardMessages.ResultsCount(searchRes.Count());
            searchRes.ForEach(book => book.ShowBookProp());
            StandardMessages.ResultsCount(searchRes.Count());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}