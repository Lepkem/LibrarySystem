namespace LibraryStandard.Menu
{
    using System.Linq;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class ShowAllBooks : Page
    {
        //menu 1
        public ShowAllBooks(Program program)
            : base("Catalog a book by the Author", program)
        {
        }

        public override void Display()
        {
            base.Display();
            LibraryStandard.Catalog.Instance.GetBookList().OrderByDescending(o => o.Year).ToList().ForEach(b => b.ShowBookProp());
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}