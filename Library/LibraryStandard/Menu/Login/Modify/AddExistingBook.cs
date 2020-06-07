namespace LibraryStandard.Menu.Login
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class AddExistingBook : Page
    {
        public AddExistingBook(Program program)
            : base("Add an existing book", program)
        {
        }

        public override void Display()
        {
            base.Display();
            Catalog.Instance.AddExistingBook(Console.ReadLine());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}