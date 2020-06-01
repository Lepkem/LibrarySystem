﻿namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchBookByID : Page
    {
        public SearchBookByID(Program program)
            : base("Search a book by the ISBN", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page: Search a book by the ISBN");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}