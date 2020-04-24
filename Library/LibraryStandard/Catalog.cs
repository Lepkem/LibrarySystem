namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Library.Interfaces;

    using Newtonsoft.Json;

    public class Catalog : ICatalog
    {
        /// <summary>
        /// 
        /// </summary>
        public Catalog()
        {
            //???? heh??? Do I need a constructor?
        }

        public List<Book> Books { get; set; }

        /// <summary>
        /// LoadBookFile loads content of filename as instances of Book
        /// I think that the properties IsAvailable and AvailableWhen: should be added to each book upon init in this function
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadBookFile(string fileName)
        {
            string FileContentString = "";
            try
            {
                FileContentString = File.ReadAllText(fileName);
                Books = JsonConvert.DeserializeObject<List<Book>>(FileContentString); // here I made instances of classes from a JSON string in a list of class movie

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}, so something is not dobra :(");
            }
        }


        /// <summary>
        /// AddNewBook adds new Book to List Books (and updates JSON??)
        /// </summary>
        public bool AddNewBook(Book book)
        {
            Books.Add(book);
            return true;
        }

        /// <summary>
        /// AddNewBook adds new Book to List Books
        /// </summary>
        public bool RemoveBook(string id)
        {
            foreach (Book book in Books)
            {
                if (book.ID == id)
                {
                    Books.Remove(book);
                    return true;
                }

            }

            return false;
        }

        /// <summary>
        /// SearchBookByName searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByName( string title)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Title == title)
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }

        /// <summary>
        /// SearchBookByName searches through Books by ID returns Book since ID's are unique
        /// </summary>
        public Book SearchBookByID(string id)
        {
            foreach (Book book in Books)
            {
                if (book.ID == id)
                {
                    return book;
                }

            }

            return new Book();
        }

        /// <summary>
        /// SearchBookByAuthor searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByAuthor(string name) 
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.AuthorName.Contains(name))
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }

        /// <summary>
        /// SearchBookByISBN searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByISBN(string ISBN)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.ISBN == ISBN)
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }

        

        

    }
}


