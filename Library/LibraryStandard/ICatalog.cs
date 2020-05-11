namespace LibraryStandard
{
    using System.Collections.Generic;

    public interface ICatalog
    {
        /// <summary>
        /// AddNewBook adds new Book to List Books 
        /// </summary>
        bool AddNewBook(Book book);

        void AddExistingBook(string isbn);

        /// <summary>
        /// AddNewBook adds new Book to List Books
        /// </summary>
        bool RemoveBook(string id);

        /// <summary>
        /// SearchBookByName searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        List<Book> SearchBookByTitle(string title);

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
        List<Book> SearchBookByIsbn(string isbn);

        List<Book> GetBookList();

        void SetBookList(List<Book> newbooks);

        void DeleteAllBooks();
    }
}