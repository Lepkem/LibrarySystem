namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class Modify : MenuPage
    {
        //Menu 1A todo nothing
        public Modify(Program program)
            : base("Modify a single or multiple:", program,
                new Option("Books", () => program.NavigateTo<ModifyBook>())
                , new Option("People", () => program.NavigateTo<ModifyPerson>())
                ,new Option("Loans", () => program.NavigateTo<ModifyLoan>())
            )
        { }
    }
}
