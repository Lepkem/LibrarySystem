namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class LendOutManyBooks : Page
    {

        public LendOutManyBooks(Program program)
            : base("Catalog a loan by book ID", program)
        {
        }

        public override void Display()
        {
            base.Display();
            string persid = StandardMessages.GetInputForParam("Person ID");
            var bookIdlist = LoanAdministration.MakeBookIDList();
            LoanAdministration.Instance.BorrowMany(bookIdlist, persid);
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}
