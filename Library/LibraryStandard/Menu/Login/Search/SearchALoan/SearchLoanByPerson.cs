namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoanByPerson : Page
    {
        public SearchLoanByPerson(Program program)
            : base("Catalog a loan by person ID", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page: Catalog a loan by person ID");

            Input.ReadString("Press [Enter] to navigate back");
            Program.NavigateBack();
        }
    }
}