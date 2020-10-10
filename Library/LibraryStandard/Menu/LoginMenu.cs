namespace LibraryStandard.Menu
{
    using EasyConsole;

    using LibraryStandard.Menu.Login;
    using LibraryStandard.Menu.Login.Backup;

    public class LoginMenu : MenuPage
    {
        public LoginMenu(Program program)
            : base("Login menu.", program
                , new Option("Modify menu", () => program.NavigateTo<Modify>())
                , new Option("Loan administration menu", () => program.NavigateTo<LoanAdministrationMenu>())
                , new Option("Search a person", () => program.NavigateTo<SearchPerson>())
                , new Option("Search a loan", () => program.NavigateTo<SearchLoan>())
                , new Option("Search a book", () => program.NavigateTo<SearchBook>())
                , new Option("Create a backup", () => program.NavigateTo<CreateBackup>())
                , new Option("Load a backup", () => program.NavigateTo<LoadBackup>())
               
                )
        { }
    }
}