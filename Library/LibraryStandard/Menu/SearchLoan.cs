namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoan : MenuPage
    {
        //Menu 1A
        public SearchLoan(Program program)
            : base("Search a person by name", program,
                new Option("Search a person by name", () => program.NavigateTo<SearchPersonByName>())
                ,new Option("Search a person by ID", () => program.NavigateTo<SearchPersonByID>())
                //,new Option("Search a book by ID", () => program.NavigateTo<>())
                //,new Option("Search a book by ID", () => program.NavigateTo<>())
                //,new Option("Search a book by ID", () => program.NavigateTo<>())
                //,new Option("Search a book by ID", () => program.NavigateTo<>())
                )
        { }
    }
}
