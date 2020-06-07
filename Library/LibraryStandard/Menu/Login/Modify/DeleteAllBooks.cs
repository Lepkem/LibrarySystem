namespace LibraryStandard.Menu.Login
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class DeleteAllBooks : Page
    {
        public DeleteAllBooks(Program program)
            : base("Delete all books", program)
        {
        }

        public override void Display()
        {
            base.Display();
            if (StandardMessages.AreYouSure().Equals(true))
            {
                Catalog.Instance.DeleteAllBooks();
            }

            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}