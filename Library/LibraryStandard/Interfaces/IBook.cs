namespace LibraryStandard.Interfaces
{
    public interface IBook
    {
        void GenerateISBN();
        void ShowBookProp();
        bool ChangeLink(string link);


    }
}