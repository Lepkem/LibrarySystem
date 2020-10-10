namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class DeleteAllPersons : Page
    {
        public DeleteAllPersons(Program program)
            : base("Delete all persons", program)
        {
        }

        public override void Display()
        {
            base.Display();
            if (StandardMessages.AreYouSure().Equals(true))
            {
                CatalogPerson.Instance.DeleteAllPersons();
            }

            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}
