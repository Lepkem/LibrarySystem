namespace LibraryStandard.Menu.Login
{
    using System;

    using EasyConsole;

    using LibraryStandard.Helpers;

    public class AddNewBook : Page
    {
        public AddNewBook(Program program)
            : base("Add a new book", program)
        {
        }

        public override void Display()
        {
            base.Display();
            BookBuilder bb = new BookBuilder();
            bb.WithTitle(StandardMessages.GetInputForParam("title"))
                .WithAuthorName(StandardMessages.GetInputForParam("name of the author"))
                .WithYear(StandardMessages.GetInputForParam("year"))
                .WithPages(StandardMessages.GetInputForParam("pages"))
                .WithCountry(StandardMessages.GetInputForParam("country"))
                .WithLink(StandardMessages.GetInputForParam("link"))
                .WithImageLink(StandardMessages.GetInputForParam("link of the image"))
                .WithLanguage(StandardMessages.GetInputForParam("language"));


            Book bk;
            if ((bk = bb.Create()) != null)
            {
                bk.ShowBookProp();
                Catalog.Instance.AddNewBook(bk);
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