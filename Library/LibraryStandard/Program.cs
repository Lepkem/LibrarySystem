using System;
using System.Collections.Generic;

using LibraryStandard.Helpers;

namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Authentication.ExtendedProtection;

    using EasyConsole;

    using LibraryStandard.Helpers;
    using LibraryStandard.Menu;
    using LibraryStandard.Menu.Login;
    using LibraryStandard.Menu.Login.Backup;
    using LibraryStandard.People;




    class DemoProgram : Program
    {
            //menu 1
        public DemoProgram()
            : base("EasyConsole Demo", breadcrumbHeader: true)
        {
            AddPage(new MainMenu(this));

            AddPage(new Help(this));
            AddPage(new LibraryInfo(this));
            AddPage(new Menu.CatalogMenu(this));
                AddPage(new ShowAllBooks(this));
                AddPage(new SearchBook(this));
                AddPage(new SearchBookByAuthor(this));
                    AddPage(new SearchBookByISBN(this));
                    AddPage(new SearchBookByID(this));
                    AddPage(new SearchBookByTitle(this));
            AddPage(new LoginMenu(this));
                AddPage(new CreateBackup(this));
                AddPage(new LoadBackup(this));
                AddPage(new CatalogMenu(this));
                AddPage(new LendOutBook(this));
                AddPage(new LendOutManyBooks(this));
                AddPage(new ReturnBook(this));
                AddPage(new ReturnManyBooks(this));
                AddPage(new SearchBook(this));
                    AddPage(new SearchBookByAuthor(this));
                    AddPage(new SearchBookByISBN(this));
                    AddPage(new SearchBookByID(this));
                    AddPage(new SearchBookByTitle(this));
                AddPage(new SearchLoan(this));
                    AddPage(new SearchLoanByPerson(this));
                    AddPage(new SearchLoanByBook(this));
                AddPage(new SearchPerson(this));
                    AddPage(new SearchPersonByID(this));
                    AddPage(new SearchPersonByName(this));
                    AddPage(new SearchPersonByStreetname(this));


            //AddPage(new MenuSearchPerson(this));
            //AddPage((new LoginScreen(this)));
            SetPage<MainMenu>();
        }
    }

    class Runner
    {
        

        static void Main(string[] args)
        {
            PublicLibrary.Init();
            StandardMessages.WelcomeImage();
            StandardMessages.PressAnyKey();
            StandardMessages.PressKeyToContinue();

            Catalog.Instance.GetBookList().ForEach(
                        b =>
                        {
                            b.GenerateISBN();
                        });
            new DemoProgram().Run();
        }
    }
}




/*
string StrBooks = DataOperator.ReadFromFile(Constants.BooksDataFile);
Console.WriteLine(StrBooks);


List<Book> BookList = new List<Book>();
BookList = DataOperator.DeserializeJson<List<Book>>(StrBooks);
BookList.First().ShowBookProp();
Catalog.Instance.SetBookList(BookList);

DataOperator.WriteToFile(StrBooks, Constants.bookbackup2);


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
catalog.LoadBookFile(@"Data\Books.json");
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
                    .WithAvailability(true)
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








