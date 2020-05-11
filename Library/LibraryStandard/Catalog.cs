namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LibraryStandard.Helpers;

    public sealed class Catalog : ICatalog
    {
        private static readonly Catalog instance = new Catalog();

        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit  
        static Catalog()
        {
        }

        private Catalog()
        {
        }

        public static Catalog Instance
        {
            get
            {
                return instance;
            }
        }

        // necessary singleton code^
        
        
        private List<Book> books;

        /// <summary>
        /// AddNewBook adds new Book to List Books 
        /// </summary>
        public bool AddNewBook(Book book)
        {
            books.Add(book);
            return true;
        }

        public  void AddExistingBook(string isbn)
        {
            Book book = SearchBookByIsbn(isbn).First();
            BookBuilder bb = new BookBuilder();

            books.Add(bb.WithAuthorName(book.AuthorName)
                .WithTitle(book.Title)
                .WithYear(book.Year)
                .WithPages(book.Pages)
                .WithLanguage(book.Language)
                .WithImageLink(book.ImageLink)
                .WithLink(book.Link)
                .WithCountry(book.Country)
                .CreateBook());
        }

        /// <summary>
        /// AddNewBook adds new Book to List Books
        /// </summary>
        public bool RemoveBook(string id)
        {
            Book forRemoval;
            //    1 Solution
            books = books.Where(book => book.ID.ToLower() != id.ToLower()).ToList();
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
        public List<Book> SearchBookByTitle(string title)
        {
            try
            {
                List<Book> foundBooks = new List<Book>();
                foundBooks = books.Where(book => book.Title.ToLower().Equals(title.ToLower())).ToList();
                return foundBooks;
            }
            catch (Exception )
            {
                StandardMessages.Instance.NoSearchResults();
                return new List<Book>();
            }
        }

        /// <summary>
        /// SearchBookByName searches through Books by ID returns Book since ID's are unique
        /// </summary>
        public Book SearchBookByID(string id)
        {
            try
            {
                IEnumerable<Book> foundBook;
                foundBook = books.Where(book => book.ID.ToLower().Equals(id.ToLower()));
                foundBook.First().ShowBookProp();
                return foundBook.First();
            }
            catch (Exception)
            {
                StandardMessages.Instance.NoSearchResults();
                return new Book();
            }
        }

        /// <summary>
        /// SearchBookByAuthor searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByAuthor(string name)
        {
            try
            {
                return books.Where(book => book.AuthorName.ToLower().Contains(name.ToLower())).ToList();
            }
            catch (Exception)
            {
                StandardMessages.Instance.NoSearchResults();
                return new List<Book>();
            }
        }

        /// <summary>
        /// SearchBookByISBN searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByIsbn(string isbn)
        {
            try
            {
                List<Book> foundBooks = new List<Book>();
                foundBooks = books.Where(book => book.ISBN.ToLower().Equals(isbn.ToLower())).ToList();
                return foundBooks;
            }
            catch (Exception )
            {
                StandardMessages.Instance.NoSearchResults();
                return new List<Book>();
            }
            
        }

        public List<Book> GetBookList()
        {
            return books;
        }

        public void SetBookList(List<Book> newbooks)
        {
            books = newbooks;
        }

        public void DeleteAllBooks()
        {
            books.Clear();
        }
    }
}


