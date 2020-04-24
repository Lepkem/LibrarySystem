namespace Library
{
    using System.Collections.Generic;

    public interface ICatalog
    {
        List<Book> Books { get; set; }

        /// <summary>
        /// LoadBookFile loads content of filename as instances of Book
        /// </summary>
        /// <param name="fileName"></param>
        void LoadBookFile(string fileName);

        /// <summary>
        /// AddNewBook adds new Book to List Books (and updates JSON??)
        /// </summary>
        bool AddNewBook(Book book);

        /// <summary>
        /// AddNewBook adds new Book to List Books
        /// </summary>
        bool RemoveBook(string id);

        /// <summary>
        /// SearchBookByName searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        List<Book> SearchBookByName(string title);

        /// <summary>
        /// SearchBookByName searches through Books by ID returns Book since ID's are unique
        /// </summary>
        Book SearchBookByID(string id);

        /// <summary>
        /// SearchBookByAuthor searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        List<Book> SearchBookByAuthor(string name);

        /// <summary>
        /// SearchBookByISBN searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        List<Book> SearchBookByISBN(string ISBN);
    }
}