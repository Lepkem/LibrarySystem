namespace LibraryStandard.Menu
{
    using EasyConsole;


    public class SearchBookByAuthor : Page
    {
        //menu 1Aa
        public SearchBookByAuthor(Program program)
            : base("Search a book by the Author", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page: Search a book by the Author");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}