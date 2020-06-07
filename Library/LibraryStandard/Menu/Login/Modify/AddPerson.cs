namespace LibraryStandard.Menu.Login
{
    using EasyConsole;

    using LibraryStandard.Helpers;
    using LibraryStandard.People;

    public class AddPerson : Page
    {
        public AddPerson(Program program)
            : base("Add a person", program)
        {
        }

        public override void Display()
        {
            base.Display();
            PersonBuilder pb = new PersonBuilder();
            pb.WithFirstName(StandardMessages.GetInputForParam("first name"))
                .WithLastName(StandardMessages.GetInputForParam("last name"))
                .WithEmailAddress(StandardMessages.GetInputForParam("email address"))
                .WithNationality(StandardMessages.GetInputForParam("nationality"))
                .WithCity(StandardMessages.GetInputForParam("city of residence"))
                .WithStreetName(StandardMessages.GetInputForParam("streetname"))
                .WithStreetnumber(StandardMessages.GetInputForParam("house number"))
                .WithStreetnumberAdd(StandardMessages.GetInputForParam("house number addition (optional)"))
                .WithZipCode(StandardMessages.GetInputForParam("zipcode"))
                .WithPassword(StandardMessages.GetInputForParam("password"));

            Person newPerson;
            if ((newPerson = pb.Create()) != null)
            {
                CatalogPerson.Instance.AddNewPerson(newPerson);
                newPerson.ShowPersonProps();
            }
            else
            {
                StandardMessages.TryAgain();
            }
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();
            Program.NavigateHome();
        }
    }
}



