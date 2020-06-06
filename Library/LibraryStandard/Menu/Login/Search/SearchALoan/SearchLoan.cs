namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class SearchLoan : MenuPage
    {
        
        public SearchLoan(Program program)
            : base("Search a loan", program,
                new Option("Search a loan by person ID", () => program.NavigateTo<SearchLoanByPerson>())
                ,new Option("Search a loan by book ID", () => program.NavigateTo<SearchLoanByBook>())
            )
        { }
    }
}
