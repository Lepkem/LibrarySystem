namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchPersonByName : Page
    {
        public SearchPersonByName(Program program)
            : base("Search a person by name", program)
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