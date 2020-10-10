namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class ModifyPerson : MenuPage
    {
        //Menu 1A 
        public ModifyPerson(Program program)
            : base("Modify the persons", program,
                new Option("Add a person", () => program.NavigateTo<AddPerson>())
                , new Option("Delete person", () => program.NavigateTo<DeletePerson>())
                , new Option("Delete all persons", () => program.NavigateTo<DeleteAllPersons>())
            )
        { }
    }
}