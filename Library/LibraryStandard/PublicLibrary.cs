namespace Library
{
    using System.Collections.Generic;

    using Library.Interfaces;

    using LibraryStandard.Helpers;

    public class PublicLibrary 
    {
        public static void Init()
        {
            Catalog.Instance.SetBookList(DataOperator.Instance.DeserializeJson<List<Book>>(DataOperator.Instance.ReadFromFile(@"Data\Books.json")));
        }
    }
}