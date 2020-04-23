namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Library.Interfaces;

    using Newtonsoft.Json;

    public class Catalog : ICatalog
    {
        ///
        public Catalog()
        {
            //???? heh???
        }

        public List<Book> Books { get; set; }

        /// <summary>
        /// LoadBookFile loads content of filename as instances of Book
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// AddNewBook adds new Book to List Books
        /// </summary>
        public bool RemoveBook(Book book)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// SearchBookByName searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// SearchBookByName searches through Books by ID returns Book since ID's are unique
        /// </summary>
        public Book SearchBookByID()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// SearchBookByAuthor searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByAuthor(Book book) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// SearchBookByISBN searches through Books by ISBN returns List<Book> of books that comply
        /// </summary>
        public List<Book> SearchBookByISBN(int ISBN)
        {
            throw new NotImplementedException();
        }



    }
}


