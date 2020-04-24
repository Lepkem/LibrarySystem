namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;

    using Library;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome User");
            Catalog catalog = new Catalog();
            catalog.LoadBookFile(@"Data\Books.json");
            Book abc = new Book();
            foreach (Book bk in catalog.SearchBookByAuthor("Andersen"))
            {
                Console.WriteLine("Found a book :)");
                Console.WriteLine(bk.Title);
                Console.WriteLine(bk.ID);
                Console.WriteLine(bk.ISBN);
                Console.WriteLine(bk.AuthorName);
                Console.WriteLine(bk.Year);
                Console.WriteLine(bk.Pages);
                abc = bk;
            }

            
            catalog.RemoveBook(catalog.SearchBookByID(abc.ID).ID);
            foreach (Book bk in catalog.SearchBookByAuthor("Andersen"))
            {
                Console.WriteLine("Found a book :)");
                Console.WriteLine(bk.Title);
                Console.WriteLine(bk.ID);
                Console.WriteLine(bk.ISBN);
                Console.WriteLine(bk.AuthorName);
                Console.WriteLine(bk.Year);
                Console.WriteLine(bk.Pages);
            }
            Console.ReadLine();
        }
    }
}
