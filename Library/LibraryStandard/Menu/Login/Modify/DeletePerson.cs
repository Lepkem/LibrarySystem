namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;

    public class DeletePerson : Page
    {
        public DeletePerson(Program program)
            : base("Delete a person", program)
        {
        }

        public override void Display()
        {
            base.Display();
            string personId = StandardMessages.GetInputForParam("person ID");
            StandardMessages.AreYouSure();
            CatalogPerson.Instance.DeletePerson(personId);
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateBack();
        }
    }
}
