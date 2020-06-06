namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class Modify : MenuPage
    {
        //Menu 1A todo nothing
        public Modify(Program program)
            : base("Modify menu", program,
                new Option("Books", () => program.NavigateTo<SearchLoanByPerson>())
                , new Option("People", () => program.NavigateTo<SearchLoanByBook>())
                ,new Option("Loans", () => program.NavigateTo<>())
            )
        { }
    }
}
}