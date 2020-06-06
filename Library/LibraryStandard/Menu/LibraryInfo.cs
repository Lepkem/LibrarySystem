namespace LibraryStandard.Menu
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class LibraryInfo : Page
        {
        //menu 1Aa 
        public LibraryInfo(Program program)
            : base("Catalog a book by the Author", program)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"This is the very elaborate information page of the library system.");
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
        }
    }
}