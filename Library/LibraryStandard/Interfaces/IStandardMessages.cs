namespace LibraryStandard.Interfaces
{
    public interface IStandardMessages
    {
        void TryAgain();

        /// <summary>
        /// 
        /// </summary>
        void NoSearchResults();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool AreYouSure();

        void ResultsCount(int input);

        void NewLine();

        /// <summary>
        /// WriteInputBelow prints a request of input
        /// </summary>
        void WriteInputBelow();

        /// <summary>
        /// EnterNumber prints a request of input of number
        /// </summary>
        void EnterNumber();

        /// <summary>
        /// GivenOptions prints a request of input of given options
        /// </summary>
        void GivenOptions();

        /// <summary>
        /// FilePathError shows path error message and with input of filepath can be specified
        /// </summary>
        /// <param name="filePath"></param>
        void FilePathError(string filePath = "");

        /// <summary>
        /// PressAnyKey prints to press any key
        /// </summary>
        void PressAnyKey();

        /// <summary>
        /// PressKeyToContinue requires you to press any key and after that clears the screen.
        /// </summary>
        void PressKeyToContinue();

        /// <summary>
        /// WelcomeImage prints a welcome image from source https://www.asciiart.eu/books/books
        /// </summary>
        void WelcomeImage();
    }
}