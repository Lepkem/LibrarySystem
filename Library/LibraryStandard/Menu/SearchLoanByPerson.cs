namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoanByPerson : Page
    {
        public SearchLoanByPerson(Program program)
            : base("Search a loan by person ID", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page: Search a loan by person ID");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}