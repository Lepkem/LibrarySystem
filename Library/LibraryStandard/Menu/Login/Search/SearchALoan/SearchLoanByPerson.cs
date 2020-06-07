namespace LibraryStandard.Menu
{
    using System.Linq;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class SearchLoanByPerson : Page
    {
        public SearchLoanByPerson(Program program)
            : base("Search a loan by person ID", program)
        {
        }

        public override void Display()
        {
            base.Display();
            StandardMessages.WriteInputBelow();
            var searchRes = LoanAdministration.Instance.SearchLoansByPerson(StandardMessages.GetInputForParam("person ID"));
            StandardMessages.ResultsCount(searchRes.Count());
            searchRes.ForEach(book => book.ShowLoanProp());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}