namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class DeleteAllLones : Page
    {
        public DeleteAllLones(Program program)
            : base("Delete all loan records", program)
        {
        }

        public override void Display()
        {
            base.Display();
            if (StandardMessages.AreYouSure().Equals(true))
            {
                LoanAdministration.Instance.DeleteAllRecords();
            }

            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}
