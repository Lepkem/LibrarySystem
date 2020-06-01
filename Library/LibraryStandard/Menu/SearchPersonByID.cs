namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchPersonByID : Page
    {
        public SearchPersonByID(Program program)
            : base("Search a person by ID", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page: Search a person by name");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}