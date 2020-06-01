namespace LibraryStandard.Menu
{
    using EasyConsole;

    public class MainMenu : MenuPage
    {
        public MainMenu(Program program)
            : base("Main Menu", program
                , new Option("Search", () => program.NavigateTo<Search>()) 
        //,new Option("Input", () => program.NavigateTo<InputPage>()))
        )
        {}
        
    }


}
