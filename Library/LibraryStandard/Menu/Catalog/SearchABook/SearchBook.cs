namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchBook : MenuPage
    {
        //Menu 1A =>a
        public SearchBook(Program program)
            : base("Search a book", program
                , new Option("Search a book by the name of the author", () => program.NavigateTo<SearchBookByAuthor>())
                ,new Option("Search a book by ISBN", () => program.NavigateTo<SearchBookByISBN>())
                , new Option("Search a book by title", () => program.NavigateTo<SearchBookByTitle>())
                , new Option("Search a book by ID", () => program.NavigateTo<SearchBookByID>())
            )
        { }
    }
}