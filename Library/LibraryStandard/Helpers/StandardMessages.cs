namespace LibraryStandard.Helpers
{
    using System;

    public class StandardMessages
    {

        public static void TryAgain()
        {
            Console.WriteLine($"Please Try again.");
        }

        /// <summary>
        /// 
        /// </summary>
        public static void NoSearchResults()
        {
            Console.WriteLine($"Sorry, no search results were found with this input.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool AreYouSure()
        {
            Console.WriteLine("Are you sure?\n Please enter yes or no.");
            string yesorno = Console.ReadLine();
            if (yesorno.ToLower().Equals("yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void ResultsCount(int input)
        {
            if (input > 1)
            {
                Console.WriteLine($"There were {input} results.");
            }
            else
            {
                Console.WriteLine($"There was {input} result.");
            }
        }

        /// <summary>
        /// WriteInputBelow prints a request of input
        /// </summary>
        public static void WriteInputBelow()
        {
            Console.WriteLine($"Please write your input below.");
        }
        /// <summary>
        /// EnterNumber prints a request of input of number
        /// </summary>
        public static void EnterNumber()
        {
            Console.WriteLine($"Please only enter a number!");
        }

        /// <summary>
        /// GivenOptions prints a request of input of given options
        /// </summary>
        public static void GivenOptions()
        {
            Console.WriteLine($"Only choose from the given options.");
        }

        /// <summary>
        /// FilePathError shows path error message and with input of filepath can be specified
        /// </summary>
        /// <param name="filePath"></param>
        public static void FilePathError(string filePath = "")
        {
            Console.WriteLine($"Oops! Something went wrong. {filePath} was not found.");
        }

        /// <summary>
        /// PressAnyKey prints to press any key
        /// </summary>
        public static void PressAnyKey()
        {
            Console.WriteLine($"Press any key to continue.");
        }

        /// <summary>
        /// PressKeyToContinue requires you to press any key and after that clears the screen.
        /// </summary>
        public static void PressKeyToContinue()
        {
            Console.Write($">");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// WelcomeImage prints a welcome image from source https://www.asciiart.eu/books/books
        /// </summary>
        public static void WelcomeImage()
        {
            Console.WriteLine(@"  ____________________________________________________");
            Console.WriteLine(@"  |____________________________________________________|");
            Console.WriteLine(@"  | __     __   ____   ___ ||  ____    ____     _  __  |");
            Console.WriteLine(@"  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |");
            Console.WriteLine(@"  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |");
            Console.WriteLine(@"  ||  |##||  | | || | |Jor|||-|da|n|==|+|+||-|-|~||__| |");
            Console.WriteLine(@"  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|");
            Console.WriteLine(@"  ||_______________________||__________________________|");
            Console.WriteLine(@"  | _____________________  ||      __   __  _  __    _ |");
            Console.WriteLine(@"  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|               **** Library System by Jordan Guerrero ****");
            Console.WriteLine(@"  || | | | | | | | | | | |/\ \  \\|++|=|IT|| ||==| / / |                              INF1F 0887030");
            Console.WriteLine(@"  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|");
            Console.WriteLine(@"  |____________________ /\~()/()~//\ __________________|");
            Console.WriteLine(@"  | __   __    _  _     \_  (_ .  _/ _    ___     _____|");
            Console.WriteLine(@"  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |");
            Console.WriteLine(@"  ||--|+|<3|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|");
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
            Console.WriteLine(@"  |___\_/   /________//   ________         /  / ||R|a|f|");
            Console.WriteLine(@"  |___ /   (|________/   |\_______\       /  /| |______|");
            Console.WriteLine(@"      /                  \|________)     /  / | |");
        }
    }
}