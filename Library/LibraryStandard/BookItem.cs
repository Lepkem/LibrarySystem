namespace Library
{
    using System;

    public class BookItem
    {
        // Author = author;
        // Title = title;
        // Country = "unknown";
        // ImageLink = "unknown";
        // Language = "unknown";
        // Link = "unknown";
        // Pages = 0;
        // Year = DateTime.Now;
        //
        // ISBN = "ISBN" + Guid.NewGuid();

        public BookItem(Book sourcebook, bool bookItemAvailable = true, DateTime bookItemAvailableWhen = default )
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