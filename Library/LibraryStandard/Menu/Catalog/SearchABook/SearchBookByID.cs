namespace LibraryStandard.Menu
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class SearchBookByID : Page
    {
        public SearchBookByID(Program program)
            : base("Search a book by the ISBN", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            LibraryStandard.Catalog.Instance.SearchBookByID(Console.ReadLine());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}