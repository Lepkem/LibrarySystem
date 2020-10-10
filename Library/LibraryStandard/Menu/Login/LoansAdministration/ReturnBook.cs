namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class ReturnBook : Page
    {

        public ReturnBook(Program program)
            : base("Return a book", program)
        {
        }

        public override void Display()
        {
            base.Display();
            string bookid = StandardMessages.GetInputForParam("book ID");
            LoanAdministration.Instance.ReturnOne(bookid);
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}