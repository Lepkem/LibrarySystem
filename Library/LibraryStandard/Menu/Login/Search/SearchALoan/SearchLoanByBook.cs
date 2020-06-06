namespace LibraryStandard.Menu
{
    using System;
    using System.Linq;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class SearchLoanByBook :Page
    {
        
            public SearchLoanByBook(Program program)
                : base("Search a loan by book ID", program)
            {
            }

            public override void Display()
            {
                base.Display();
                StandardMessages.WriteInputBelow();
                var searchRes = LoanAdministration.Instance.SearchLoansByBook(StandardMessages.GetInputForParam("book ID"));
                StandardMessages.ResultsCount(searchRes.Count());
                searchRes.ForEach(book => book.ShowLoanProp());
                StandardMessages.PressAnyKey();
                StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
            }
        
    }
}