namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class ModifyPerson : MenuPage
    {
        //Menu 1A 
        public ModifyPerson(Program program)
            : base("Modify the persons", program,
                new Option("Books", () => program.NavigateTo<ModifyBook>())
                , new Option("People", () => program.NavigateTo<ModifyPerson>())
                , new Option("Loans", () => program.NavigateTo<ModifyLoan>())
            )
        { }
    }
}