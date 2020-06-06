namespace LibraryStandard.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class SearchBookByISBN : Page
    {
        public SearchBookByISBN(Program program)
            : base("Search a book by the ISBN", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            List<Book> searchRes = LibraryStandard.Catalog.Instance.SearchBookByIsbn(Console.ReadLine());
            StandardMessages.ResultsCount(searchRes.Count());
            searchRes.ForEach(book => book.ShowBookProp());
            StandardMessages.ResultsCount(searchRes.Count());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}