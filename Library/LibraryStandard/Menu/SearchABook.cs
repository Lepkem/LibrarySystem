namespace LibraryStandard.Menu
{
    using EasyConsole;

    using Program = LibraryStandard.Program;

    public class SearchABook
    {
        public SearchABook(Program program)
            : base("Page 1", program,
                new Option("Page 1A", () => program.NavigateTo<SearchABookByAuthor>()),
                new Option("Page 1B", () => program.NavigateTo<Page1B>()))
    }
}









