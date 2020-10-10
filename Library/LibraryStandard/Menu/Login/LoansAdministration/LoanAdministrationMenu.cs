namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class LoanAdministrationMenu : MenuPage
    {
        public LoanAdministrationMenu(Program program)
            : base(
                "Catalog menu",
                program,
                new Option("Lend out a book", () => program.NavigateTo<LendOutBook>()),
                new Option("Lend out multiple books", () => program.NavigateTo<LendOutManyBooks>()),
                new Option("Return a book", () => program.NavigateTo<ReturnBook>()),
                new Option("Return multiple books", () => program.NavigateTo<ReturnManyBooks>()))
        {
        }
    }
}