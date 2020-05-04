namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Library;

    using LibraryStandard.Helpers;

    public class Program
    {
        public static void Main(string[] args)
        {
            //  [X] Use the data loader to load the books 
            //  [ ] Create a library (then the init function of library
            // should work with most things from this list implemented in it)
            //  [X] have a catalaog 
            //  [X] it should assign the serialized books from data loader into catalog 

            //  [X] Result == operational catalog!
            

            string StrBooks = DataOperator.ReadFromFile(Constants.BooksDataFile);
            Console.WriteLine(StrBooks);


            List<Book> BookList = new List<Book>();
            BookList = DataOperator.DeserializeJson<List<Book>>(StrBooks);
            BookList.First().ShowBookProp();
            Catalog.Instance.SetBookList(BookList);

            //DataOperator.WriteToFile(StrBooks, Constants.bookbackup2);
            Console.WriteLine($"making a book by rocky");
            Book testbook = new BookBuilder()
                .WithAuthorName("Rocky Dexter")
                .WithTitle("Love for Jordan")
                .WithYear(2009)
                .WithPages(5)
                .WithLanguage("bird")
                .WithImageLink("linklink")
                .WithLink("link")
                .WithISBN("34023529852")
                .WithCountry("Netherlands")
                .CreateBook();

            Console.WriteLine($"adding the rocky book to the list of books");
            Catalog.Instance.AddNewBook(testbook);
            Console.WriteLine($"showing some props of the book as first book from the list");
            Catalog.Instance.GetBookList().Last().ShowBookProp();
            Console.WriteLine($"Now making a backup instance");
            BackUp firstbackup = new BackUp();
            Console.WriteLine($"now writing the serialised booklist to a file (making a backup)");
            BackUp.Create(Constants.bookbackup2);
            Console.WriteLine($"Showing props from restored backup list");
            BackUp.RestoreFromBackup<List<Book>>(Constants.bookbackup2).First().ShowBookProp();









            //List<Book> newbooklist = new List<Book>();
            //newbooklist = DataOperator.Load<Book>("Data\\Books.json");

            //BackUp firstbackup = new BackUp();
            //firstbackup.Create(BackUp.backupnum.Backupnumber2);
            /*List<Book> testlist= new List<Book>();
            
            testlist.Add(testbook);
            firstbackup.TempCreateWritebackup(testlist);*/

            Console.WriteLine("I guess it worked");
            StandardMessages.PressAnyKey();
            Console.ReadLine();


            /*Console.WriteLine("Welcome User");
            //catalog.LoadBookFile(@"Data\Books.json");
            Book abc = new Book();
            foreach (Book bk in Catalog.Instance.SearchBookByAuthor("Andersen"))
            {
                Console.WriteLine("Found a book :)");
                bk.ShowBookProp();
                abc = bk;
            }

            Console.Write("before...");
            Console.ReadLine();
            
            catalog.RemoveBook(catalog.SearchBookByID(abc.ID).ID);

            Console.Write("after...");
            Console.ReadLine();*/
            
            /*
            foreach (Book bk in catalog.SearchBookByAuthor("Andersen"))
            {
                Console.WriteLine("Found a book :)");
                bk.ShowBookProp();
            }
            Console.Write(">");
            Console.ReadLine();

            BookBuilder Noordhoff = new BookBuilder();
            Book JRaf_see_stuff = Noordhoff
                                .WithAuthorName("JRAF")
                                //.WithAvailability(true)
                                .WithCountry("Netherlands")
                                .WithLanguage("English")
                                .WithPages(250)
                                .WithYear(2018)
                                .WithTitle("A whole life")
                                .WithImageLink("home")
                                .CreateBook();

            Book new_book_one = new BookBuilder()
                .WithAuthorName("Vincent Van Andersen")
                .WithCountry("Netherlands")
                .WithLanguage("English")
                .WithPages(250)
                .WithYear(2018)
                .WithTitle("A whole life of me")
                .WithImageLink("home")
                .CreateBook();

            Book new_book_two = new BookBuilder()
                .WithAuthorName("Vincent v. Andersen")
                .WithCountry("Netherlands")
                .WithLanguage("English")
                .WithPages(250)
                .WithYear(2018)
                .WithTitle("A whole life of me")
                .WithImageLink("home")
                .CreateBook();

            JRaf_see_stuff.ShowBookProp();

            Console.Write(">");
            Console.ReadLine();

            catalog.AddNewBook(JRaf_see_stuff);

            Console.WriteLine("Looking for freshly added book :)");
            foreach (Book book in catalog.SearchBookByAuthor("JRaf"))
            {
                Console.WriteLine("Found a book :)");
                book.ShowBookProp();
            }

    */
            Console.Write(">");
            Console.ReadLine();




        }
    }
}
