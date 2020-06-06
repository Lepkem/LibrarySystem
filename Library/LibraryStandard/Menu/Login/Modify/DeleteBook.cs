namespace LibraryStandard.Menu.Login
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class DeleteBook : Page
    {
        public DeleteBook(Program program)
            : base("Delete a book", program)
        {
        }

        public override void Display()
        {
            base.Display();
            string bookId = StandardMessages.GetInputForParam("book ID");
            if (StandardMessages.AreYouSure().Equals(true))
            {
                Catalog.Instance.RemoveBook(bookId);
            }

            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}