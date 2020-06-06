namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoanByBook :Page
    {
        
            public SearchLoanByBook(Program program)
                : base("Catalog a loan by book ID", program)
            {
            }

            public override void Display()
            {
                base.Display();

                Output.WriteLine("Hello from Page: Catalog a loan by book ID");

                Input.ReadString("Press [Enter] to navigate back");
                Program.NavigateBack();
            }
        
    }
}