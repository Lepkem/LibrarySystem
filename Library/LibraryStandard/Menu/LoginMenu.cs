namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class LoginMenu : MenuPage
    {
        public LoginMenu(Program program)
            : base("Login menu.", program
                , new Option("Search a person", () => program.NavigateTo<SearchPerson>())
                , new Option("Search a loan", () => program.NavigateTo<SearchLoan>())
                , new Option("Catalog", () => program.NavigateTo<CatalogMenu>()))
        { }
    }
}