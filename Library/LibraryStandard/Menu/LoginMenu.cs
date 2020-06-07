namespace LibraryStandard.Menu
{
    using EasyConsole;

    using LibraryStandard.Menu.Login;
    using LibraryStandard.Menu.Login.Backup;

    public class LoginMenu : MenuPage
    {
        public LoginMenu(Program program)
            : base("Login menu.", program
                , new Option("Search a person", () => program.NavigateTo<SearchPerson>())
                , new Option("Search a loan", () => program.NavigateTo<SearchLoan>())
                , new Option("Lend out a book", () => program.NavigateTo<LendOutBook>())
                , new Option("Lend out multiple books", () => program.NavigateTo<LendOutManyBooks>())
                , new Option("Return a book", () => program.NavigateTo<ReturnBook>())
                , new Option("Return multiple books", () => program.NavigateTo<ReturnManyBooks>())
                , new Option("Create a backup", () => program.NavigateTo<CreateBackup>())
                , new Option("Load a backup", () => program.NavigateTo<LoadBackup>())
                )
        { }
    }
}