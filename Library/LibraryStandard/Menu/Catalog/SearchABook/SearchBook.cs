namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchBook : MenuPage
    {
        //Menu 1A =>a
        public SearchBook(Program program)
            : base("Search a book", program
                , new Option("Search a book by author", () => program.NavigateTo<SearchPersonByName>())
                ,new Option("Search a person by ISBN", () => program.NavigateTo<SearchPersonByID>())
                //, new Option("Catalog a book by ID", () => program.NavigateTo<>())
                //, new Option("Catalog a book by ID", () => program.NavigateTo<>())
                //, new Option("Catalog a book by ID", () => program.NavigateTo<>())

                )
        { }
    }
}