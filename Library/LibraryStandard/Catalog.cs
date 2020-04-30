namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Library.Interfaces;

    using Newtonsoft.Json;

    public class Catalog : ICatalog
    {
        /// <summary>
        /// 
        /// </summary>
        public Catalog()
        {

        }

        public List<Book> books;


        /// <summary>
        /// AddNewBook adds new Book to List Books (and updates JSON??)
        /// </summary>
        public bool AddNewBook(Book book)
        {
            books.Add(book);
            return true;
        }

        /// <summary>
        /// AddNewBook adds new Book to List Books
        /// </summary>
        public bool RemoveBook(string id)
        {
            Book forRemoval;
            //    1 Solution
            books = books.Where(book => book.ID.ToLower()!=id.ToLower()).ToList();
            return true;


            // 2 solution 
            try
            {
                forRemoval = books.Single(s => String.Equals(s.ID, id, StringComparison.CurrentCultureIgnoreCase));
                this.books.Remove(forRemoval);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return false;
        }

        /// <summary>
        /// SearchBookByName searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByTitle( string title)
        {
            List<Book> foundBooks = new List<Book>();
            foundBooks = books.Where(book => book.Title.ToLower().Equals(title.ToLower())).ToList();
            return foundBooks;
        }

        /// <summary>
        /// SearchBookByName searches through Books by ID returns Book since ID's are unique
        /// </summary>
        public Book SearchBookByID(string id)
        {
            IEnumerable<Book> foundBook;
            foundBook = books.Where(book => book.ID.ToLower().Equals(id.ToLower()));
            
            // foreach (Book book in Books)
            // {
            //     if (book.ID.ToLower().Equals(id.ToLower()))
            //     {
            //         return book;
            //     }
            //
            // }

            return new Book();
        }

        /// <summary>
        /// SearchBookByAuthor searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByAuthor(string name) 
        {
            List<Book> foundBooks = new List<Book>();
            foundBooks = books.Where(book => book.AuthorName.ToLower().Equals(name.ToLower())).ToList();
            return foundBooks;
        }

        /// <summary>
        /// SearchBookByISBN searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByIsbn(string isbn)
        {
            List<Book> foundBooks = new List<Book>();
            foundBooks = books.Where(book => book.ISBN.ToLower().Equals(isbn.ToLower())).ToList();
            return foundBooks;
        }

        public List<Book> GetBookList()
        {
            return books;
        }

        public void SetBookList(List<Book> newbooks)
        {
            books = newbooks;
        }
    }
}


