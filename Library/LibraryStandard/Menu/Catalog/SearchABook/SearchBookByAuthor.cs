namespace LibraryStandard.Menu
{
    using System;
    using System.Linq;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class SearchBookByAuthor : Page
    {
        //menu 1Aa
        public SearchBookByAuthor(Program program)
            : base("Search a book by the name of the author", program)
        {
        }

        public override void Display()
        {
            StandardMessages.WriteInputBelow();
            var searchRes = LibraryStandard.Catalog.Instance.SearchBookByAuthor(Console.ReadLine());
            StandardMessages.ResultsCount(searchRes.Count());
            searchRes.ForEach(book => book.ShowBookProp());
            StandardMessages.ResultsCount(searchRes.Count());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}