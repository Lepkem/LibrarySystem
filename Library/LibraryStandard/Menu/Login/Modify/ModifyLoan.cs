namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class ModifyLoan : MenuPage
    {
        //Menu 1A 
        public ModifyLoan(Program program)
            : base("Modify the loans", program,
                new Option("Delete all lones", () => program.NavigateTo<DeleteAllLones>())
                

            )
        { }
    }
}