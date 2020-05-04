namespace LibraryStandard.Helpers
{
    using System;

    public class StandardMessages
    {
      
    
        public static void EnterNumber()
        {
            Console.WriteLine($"Please only enter a number!");
        }

        public static void GivenOptions()
        {
            Console.WriteLine($"Only choose from the given options.");
        }

        public static void FilePathError(string filePath = "")
        {
            Console.WriteLine($"Oops! Something went wrong. {filePath} was not found.");
        }

        public static void PressAnyKey()
        {
            Console.WriteLine($"Press any key to continue.");
        }
    
        public static void WelcomeImage()
        {
            Console.WriteLine(@"  ____________________________________________________");
            Console.WriteLine(@"  |____________________________________________________|");
            Console.WriteLine(@"  | __     __   ____   ___ ||  ____    ____     _  __  |");
            Console.WriteLine(@"  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |");
            Console.WriteLine(@"  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |");
            Console.WriteLine(@"  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |");
            Console.WriteLine(@"  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|");
            Console.WriteLine(@"  ||_______________________||__________________________|");
            Console.WriteLine(@"  | _____________________  ||      __   __  _  __    _ |");
            Console.WriteLine(@"  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|");
            Console.WriteLine(@"  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |");
            Console.WriteLine(@"  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|");
            Console.WriteLine(@"  |____________________ /\~()/()~//\ __________________|");
            Console.WriteLine(@"  | __   __    _  _     \_  (_ .  _/ _    ___     _____|");
            Console.WriteLine(@"  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |");
            Console.WriteLine(@"  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|");
            Console.WriteLine(@"  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|");
            Console.WriteLine(@"  |_________________ _/    \/\/\/    \_ _______________|");
            Console.WriteLine(@"  | _____   _   __  |/      \../      \|  __   __   ___|");
            Console.WriteLine(@"  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||");
            Console.WriteLine(@"  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||");
            Console.WriteLine(@"  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||");
            Console.WriteLine(@"  |_________ __________\___\____/___/___________ ______|");
            Console.WriteLine(@"  |__    _  /    ________     ______           /| _ _ _|");
            Console.WriteLine(@"  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|");
            Console.WriteLine(@"  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|");
            Console.WriteLine(@"__|  \/\|/   /(____|/ //                    /  /||~|~|~|__");
            Console.WriteLine(@"  |___\_/   /________//   ________         /  / ||_|_|_|");
            Console.WriteLine(@"  |___ /   (|________/   |\_______\       /  /| |______|");
            Console.WriteLine(@"      /                  \|________)     /  / | |");
        }
    }
}