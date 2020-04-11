using System;

namespace Library
{
    public class BookItem
    {
        public BookItem(Book sourcebook, bool bookItemAvailable = true, DateTime bookItemAvailableWhen = default(DateTime) )
        {
            SourceBook = sourcebook;
            BookItemAvailable = bookItemAvailable;
            BookItemAvailableWhen = bookItemAvailableWhen;
            ID = Guid.NewGuid();
        }
        public Guid ID;
        public Book SourceBook;
        public bool BookItemAvailable;
        public DateTime BookItemAvailableWhen;


    }
}