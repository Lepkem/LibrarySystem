namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    public class ModifyBook : MenuPage
    {
        //Menu 1A todo nothing
        public ModifyBook(Program program)
            : base("Modify the books", program,
                new Option("Add new book", () => program.NavigateTo<AddNewBook>())
                , new Option("Add existing book", () => program.NavigateTo<AddExistingBook>())
                , new Option("Delete book", () => program.NavigateTo<DeleteBook>())
                , new Option("Delete all books", () => program.NavigateTo<DeleteAllBooks>())
            )
        { }
    }
}