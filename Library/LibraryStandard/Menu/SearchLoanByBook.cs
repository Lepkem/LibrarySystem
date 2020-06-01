namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoanByBook :Page
    {
        
            public SearchLoanByBook(Program program)
                : base("Search a loan by book ID", program)
            {
            }

            public override void Display()
            {
                base.Display();

                Output.WriteLine("Hello from Page: Search a loan by book ID");

                Input.ReadString("Press [Enter] to navigate home");
                Program.NavigateHome();
            }
        
    }
}