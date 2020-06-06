namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoan : MenuPage
    {
        //Menu 1A todo nothing
        public SearchLoan(Program program)
            : base("Search a loan by name", program,
                new Option("Search a loan by person ID", () => program.NavigateTo<SearchLoanByPerson>())
                ,new Option("Search a loan by book ID", () => program.NavigateTo<SearchLoanByBook>())
                //,new Option("Catalog a book by ID", () => program.NavigateTo<>())
            )
        { }
    }
}
