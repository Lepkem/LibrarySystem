namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LibraryStandard.Helpers;
    using LibraryStandard.Interfaces;
    using LibraryStandard.People;

    public class LoanAdministration : ILoanAdministration
    {
        private static readonly LoanAdministration _instance = new LoanAdministration();

        static LoanAdministration()
        {

        }

        private LoanAdministration()
        {

        }

        public static LoanAdministration Instance
        {
            get
            {
                return _instance;
            }
        }

        protected List<Loan> Loans = new List<Loan>();

        /// <summary>
        /// BorrowOne takes in BookID and PersonID and handles necessary means to borrow a book.
        /// </summary>
        /// <param name="BookID"></param>
        /// <param name="PersonID"></param>
        public void BorrowOne(string BookID, string PersonID)
        {
            Loan loan = new Loan();
            Book book = Catalog.Instance.SearchBookByID(BookID);
            if(!(String.IsNullOrEmpty(book.AuthorName)) && !(String.IsNullOrEmpty(book.Title)) && book.IsAvailable == true)
            {
                book.SetAvailability(false);

                loan.SetReturnDate();
                loan.SetLoanStatus(true);

                //todo create a method
                loan.PersonID = PersonID;
                loan.BookID = BookID;

                Loans.Add(loan);
            }
            else
            {
                StandardMessages.NoSearchResults();
                StandardMessages.TryAgain();
            }
        }

        /// <summary>
        /// BorrowMany takes in a list of bookIDs and one personID. Best used with helper function MakeBookIDList
        /// </summary>
        /// <param name="BookIDs"></param>
        /// <param name="PersonID"></param>
        public void BorrowMany(List<string> BookIDs, string PersonID)
        {
            foreach (string BookID in BookIDs)
            {
                BorrowOne(BookID, PersonID);
            }
        }

        /// <summary>
        /// ReturnOne takes the BookID and handles all necessary means to return a book 
        /// </summary>
        /// <param name="BookID"></param>
        public void ReturnOne(string BookID)
        {
            try
            {
                var loanToInactivate = Loans.First(loan => loan.BookID.ToLower().Equals(BookID.ToLower()));
                if (loanToInactivate.ReturnDate > DateTime.Now)
                {
                    Console.WriteLine($"Please pay a fine of €{CreateFine(loanToInactivate.DaysTooLate())}");
                }
                Book bookToActivate = Catalog.Instance.SearchBookByID(BookID);
                bookToActivate.SetAvailability(true);
                loanToInactivate.SetLoanStatus(false);
            }
            catch (Exception e)
            {
                StandardMessages.TryAgain();
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// ReturnMany takes in a list of bookIDs and one personID. Best used with helper function MakeBookIDList
        /// </summary>
        /// <param name="BookID"></param>
        /// <param name="PersonID"></param>
        public void ReturnMany(List<string> BookID)
        {
            foreach (string bookID in BookID)
            {
                ReturnOne(bookID);
            }
            
        }

        /// <summary>
        /// GetLoansList returns the list of loans in LoanAdminstration
        /// </summary>
        /// <returns></returns>
        public List<Loan> GetLoansList()
        {
            return Loans;
        }

        /// <summary>
        /// SetLoansList takes a the list of loans to be the new version in LoanAdminstration
        /// </summary>
        /// <param name="loans"></param>
        public void SetLoansList(List<Loan> loans)
        {
            Loans = loans;
        }

        /// <summary>
        /// DeleteAllRecords deletes all loans in the running program
        /// </summary>
        public void DeleteAllRecords()
        {
            Loans.Clear();
        }


        /// <summary>
        /// MakeLoanActive returns a list of loans that were endured by this book
        /// </summary>
        /// <param name="bookID"></param>
        public List<Loan> SearchLoansByBook(string bookID)
        {
            return Loans.Where(loan => loan.PersonID.Equals(bookID)).ToList();
        }

        /// <summary>
        /// SearchLoansByPerson returns a list of loans that were made by this person
        /// </summary>
        /// <param name="PersonID"></param>
        public List<Loan> SearchLoansByPerson(string personID)
        {
            return Loans.Where(loan => loan.PersonID.Equals(personID)).ToList();
        }

        /// <summary>
        /// CreateFine calculates the hight of the fine, based on daysTooLate and multiplier
        /// </summary>
        /// <param name="daysTooLate"></param>
        /// <returns></returns>
        private int CreateFine(int daysTooLate, int multiplier =3)
        {
            return daysTooLate * multiplier;
        }

        /// <summary>
        /// MakeBookIDList is a helper function and makes a list of bookIDs 
        /// </summary>
        /// <returns></returns>
        public static List<string> MakeBookIDList()
        {
            List<string> BookIDList = new List<string>();
            int borrowBooksAmount;
            Console.WriteLine($"How many books do you want to borrow/return?");
            bool works = Int32.TryParse(Console.ReadLine(), out borrowBooksAmount);
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
    }
}