namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class MainMenu : MenuPage
    {
        public MainMenu(Program program)
            : base("Main Menu", program
                , new Option("Catalog", () => program.NavigateTo<CatalogMenu>()) 
                , new Option("Log in", () => program.NavigateTo<LoginMenu>())
                , new Option("Help", () => program.NavigateTo<Help>())
                , new Option("Library information", () => program.NavigateTo<LibraryInfo>())


        )
        {}
        
    }


}
