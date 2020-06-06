namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class ReturnManyBooks : Page
    {

        public ReturnManyBooks(Program program)
            : base("Return many books", program)
        {
        }

        public override void Display()
        {
            base.Display();
            var bookIdList = LoanAdministration.MakeBookIDList();
            LoanAdministration.Instance.ReturnMany(bookIdList);
            Program.NavigateBack();
        }
    }
}