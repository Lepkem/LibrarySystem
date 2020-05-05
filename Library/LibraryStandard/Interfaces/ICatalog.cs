namespace Library
{
    using System.Collections.Generic;

    public interface ICatalog
    {

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

        /// <summary>
        /// GetBookList returns books list for other classes. It doesn't need param, because there is 1 books, 1 catalog (should be singleton)
        /// </summary>
        /// <returns></returns>
        List<Book> GetBookList();

        /// <summary>
        /// SetBookList replaces the entire list of books by a newly chosen list of books
        /// </summary>
        /// <param name="newbooks"></param>
        void SetBookList(List<Book> newbooks);

        /// <summary>
        /// DeleteAllBooks deletes all books from the booklist
        /// </summary>
        void DeleteAllBooks();
    }
}