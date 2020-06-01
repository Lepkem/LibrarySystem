namespace LibraryStandard.Menu
{
    using System;

    using EasyConsole;

    //menu 1=>B
    public class Search : MenuPage
    {
        public Search(Program program)
            : base(
                "Search menu",
                program,
                new Option("Search a book", () => program.NavigateTo<SearchBook>())
                ,new Option("Search a person", () => program.NavigateTo<SearchPerson>())
                ,new Option("Search a Loan", () => program.NavigateTo<SearchLoan>()))
        {
        }


    }
}
