namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class MainMenu : MenuPage
    { 
        public MainMenu(Program program)
            : base("Main Menu", program,
                new Option("Page 1", () => program.NavigateTo<Page1/*SearchABook*/>()), 
                new Option("Page 2", () => program.NavigateTo<Page2>()),
                new Option("Input", () => program.NavigateTo<InputPage>()))
        
        {
        }
    }
}