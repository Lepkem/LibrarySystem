using System;

namespace Library
{
    public class BookItem
    {
        public BookItem(Book sourcebook, bool bookItemAvailable = true, DateTime BookItemAvailableWhen=DateTime.Now )
        {
            this.SourceBook = sourcebook;
            this.BookItemAvailable = bookItemAvailable;
            this.BookItemAvailableWhen = bookItemAvailable;
            this.ID = Guid.NewGuid();
        }
        public Guid ID;
        public Book SourceBook;
        public bool BookItemAvailable;
        public DateTime BookItemAvailableWhen;


    }
}