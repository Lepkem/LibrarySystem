namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class LendOutBook : Page
    {

        public LendOutBook(Program program)
            : base("Catalog a loan by book ID", program)
        {
        }

        public override void Display()
        {
            base.Display();
            string bid = StandardMessages.GetInputForParam("Book ID");
            string persid = StandardMessages.GetInputForParam("Person ID");
            LoanAdministration.Instance.BorrowOne(bid, persid);
            LoanAdministration.Instance.GetLoansList().ForEach(loan => loan.ShowLoanProp());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}
