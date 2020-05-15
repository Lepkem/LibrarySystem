namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Authentication.ExtendedProtection;
    using LibraryStandard.Helpers;

    public class Program
    {
        /// <summary>
        /// MakeBookIDList is a helper function and makes a list of bookIDs 
        /// </summary>
        /// <returns></returns>
        public static List<string> MakeBookIDList()
        {
            List<string> BookIDList = new List<string>();
            int borrowBooksAmount;
            Console.WriteLine($"How many books do you want to borrow?");
            bool works = int.TryParse(Console.ReadLine(), out borrowBooksAmount);
            if (works)
            {
                for (int i = 1; i < borrowBooksAmount + 1; i++)
                {
                    BookIDList.Add(StandardMessages.GetInputForParam("book ID"));
                    Console.WriteLine($"{i}/{borrowBooksAmount}");
                }
                return BookIDList;
            }
            else
            {
                StandardMessages.EnterNumber();
                StandardMessages.TryAgain();
                return new List<string>();
            }
        }

        public static void Main(string[] args)
        {
            #region Init
            PublicLibrary.Init();
            StandardMessages.WelcomeImage();


            Catalog.Instance.GetBookList().ForEach(
                b =>
                {
                    b.GenerateISBN();
                });
            
            

            StandardMessages.PressKeyToContinue();

            #endregion

            #region menu

            var menu = new EasyConsole.Menu()
    .Add("View all the books", () =>
    {
        Catalog.Instance.GetBookList().OrderByDescending(o=>o.Year).ToList().ForEach(b => b.ShowBookProp());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Search a book through ID", () => //submenu
                {
        StandardMessages.WriteInputBelow();
        Catalog.Instance.SearchBookByID(Console.ReadLine());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Search a book through ISBN", () => //submenu
                {
        StandardMessages.WriteInputBelow();
        List<Book> searchRes = Catalog.Instance.SearchBookByIsbn(Console.ReadLine());
        StandardMessages.ResultsCount(searchRes.Count());
        searchRes.ForEach(book => book.ShowBookProp());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Search a book by the name of the author", () => //submenu
                {
        StandardMessages.WriteInputBelow();
        var searchRes = Catalog.Instance.SearchBookByAuthor(Console.ReadLine());
        StandardMessages.ResultsCount(searchRes.Count());
        searchRes.ForEach(book => book.ShowBookProp());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Search a book by title", () => //submenu
    {
        StandardMessages.WriteInputBelow();
        var searchRes = Catalog.Instance.SearchBookByTitle(Console.ReadLine());
        StandardMessages.ResultsCount(searchRes.Count());
        searchRes.ForEach(book => book.ShowBookProp());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Library information", () =>
    {
        Console.WriteLine($"This is the very elaborate information page of the library system.");
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Help", () =>
    {
        Console.WriteLine($"This is the very elaborate help page of the library system.");
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Delete a single book from the catalog", () =>
    {
        Console.WriteLine($"Please input the ID of the book that you want to delete from the catalog.");
        string input = Console.ReadLine();
        if (StandardMessages.AreYouSure().Equals(true))
        {
            Catalog.Instance.RemoveBook(input);
        }

        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Delete all books from the catalog", () =>
    {
        if (StandardMessages.AreYouSure().Equals(true))
        {
            Catalog.Instance.DeleteAllBooks();
        }

        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Add a new book to the catalog", () => //needs attention!!
    {
        BookBuilder bb = new BookBuilder();
        bb.WithTitle(StandardMessages.GetInputForParam("title"))
            .WithAuthorName(StandardMessages.GetInputForParam("name of the author"))
            .WithYear(StandardMessages.GetInputForParam("year"))
            .WithPages(StandardMessages.GetInputForParam("pages"))
            .WithCountry(StandardMessages.GetInputForParam("country"))
            .WithLink(StandardMessages.GetInputForParam("link"))
            .WithImageLink(StandardMessages.GetInputForParam("link of the image"))
            .WithLanguage(StandardMessages.GetInputForParam("language"));

        Book bk;
        if ((bk = bb.Create()) != null)
        {
            bk.ShowBookProp();
            Catalog.Instance.AddNewBook(bk);
        }

        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Add an existing book to the catalog", () =>
    {
        Catalog.Instance.AddExistingBook(Console.ReadLine());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Create a backup of the books", () =>
    {
        Console.WriteLine(@"Choose a filepath, for an instance ''.\Backups\Bookbackup2.json''");
        BackUp.Instance.Create(Console.ReadLine());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Load a backup of the books to the current program.", () =>
    {
        Console.WriteLine(@"Choose a filepath, for an instance ''.\Backups\Bookbackup2.json''");
        BackUp.Instance.RestoreFromBackup<List<Book>>(Console.ReadLine());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })
    .Add("Borrow a book", () =>
    {
        string bid = StandardMessages.GetInputForParam("Book ID");
        string persid = StandardMessages.GetInputForParam("Person ID");
        LoanAdministration.Instance.BorrowOne(bid, persid); 

        LoanAdministration.Instance.GetLoansList().ForEach(loan => loan.ShowLoanProp());
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();

    })
    .Add("Borrow multiple books.", () =>
    {
        string persid = StandardMessages.GetInputForParam("Person ID");
        var bookIdlist = MakeBookIDList();
        LoanAdministration.Instance.BorrowMany(bookIdlist, persid);
        StandardMessages.PressAnyKey();
        StandardMessages.PressKeyToContinue();
    })

    .Add("Return a book", () =>
    {
        string bookid = StandardMessages.GetInputForParam(" book ID.");
        LoanAdministration.Instance.ReturnOne(bookid);
    })
    .Add("Return multiple books", () =>
    {
        var bookIdList = MakeBookIDList();
        LoanAdministration.Instance.ReturnMany(bookIdList);
    })
    .Add("Exit", () =>
    {
        Environment.Exit(0);
    });

            
            #endregion


            while (true)
            {
                menu.Display();
            }
            
           
            // StandardMessages.WelcomeImage();
            // StandardMessages.PressAnyKey();
            




            /*
            string StrBooks = DataOperator.ReadFromFile(Constants.BooksDataFile);
            Console.WriteLine(StrBooks);


            List<Book> BookList = new List<Book>();
            BookList = DataOperator.DeserializeJson<List<Book>>(StrBooks);
            BookList.First().ShowBookProp();
            Catalog.Instance.SetBookList(BookList);

            //DataOperator.WriteToFile(StrBooks, Constants.bookbackup2);
            

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
            */









            //List<Book> newbooklist = new List<Book>();
            //newbooklist = DataOperator.Load<Book>("Data\\Books.json");

            //BackUp firstbackup = new BackUp();
            //firstbackup.Create(BackUp.backupnum.Backupnumber2);
            /*List<Book> testlist= new List<Book>();
            
            testlist.Add(testbook);
            firstbackup.TempCreateWritebackup(testlist);*/

            


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





        }
    }
}
