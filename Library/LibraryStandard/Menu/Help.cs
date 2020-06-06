namespace LibraryStandard.Menu
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class Help : Page
    {
        //menu 1Aa
        public Help(Program program)
            : base("Catalog a book by the Author", program)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"This is the very elaborate help page of the library system.");
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}
