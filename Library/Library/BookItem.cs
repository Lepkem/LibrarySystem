using System;

namespace Library
{
    public class BookItem
    {
        public BookItem(Book sourcebook, bool bookItemAvailable = true, DateTime BookItemAvailableWhen=DateTime.Now )
        {
            SourceBook = sourcebook;
            BookItemAvailable = bookItemAvailable;
            this.BookItemAvailableWhen = bookItemAvailable;
            ID = Guid.NewGuid();
        }
        public Guid ID;
        public Book SourceBook;
        public bool BookItemAvailable;
        public DateTime BookItemAvailableWhen;


    }
}