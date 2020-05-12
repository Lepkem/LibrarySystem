namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LibraryStandard.Helpers;
    using LibraryStandard.Interfaces;
    using LibraryStandard.People;

    public class LoanAdministration 
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
        /// 
        /// </summary>
        /// <returns></returns>
        /// todo this is program responsibility :O
        public List<string> MakeBookIDList()
        {
            List<string> BookIDList = new List<string>();
            int borrowBooksAmount;
            Console.WriteLine($"How many books do you want to borrow?");
            bool works = int.TryParse(Console.ReadLine(), out borrowBooksAmount);
            if (works)
            {
                for (int i = 1; i < borrowBooksAmount+1; i++)
                {
                    //todo consider ui from end user - maybe less info ?
                    Console.WriteLine($"Please enter a Book ID. \nYou are at book {i}/{borrowBooksAmount}");
                    BookIDList.Add(Console.ReadLine());
                }
                return BookIDList;
            }
            else
            {
                StandardMessages.Instance.EnterNumber();
                StandardMessages.Instance.TryAgain();
                return new List<string>();
            }
        }
        //not loanadministration's responsibility



        /// <summary>
        /// 
        /// </summary>
        /// <param name="BookID"></param>
        /// <param name="PersonID"></param>
        public void BorrowOne(string BookID, string PersonID)
        {
            Loan loan = new Loan();
            Book book = Catalog.Instance.SearchBookByID(BookID);
            if(!(String.IsNullOrEmpty(book.AuthorName)) && !(String.IsNullOrEmpty(book.Title)))
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
                StandardMessages.Instance.NoSearchResults();
                StandardMessages.Instance.TryAgain();
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="BookID"></param>
        public void ReturnOne(string BookID)
        {
            var loanToRemove = Loans.Where(loan => loan.BookID.ToLower().Equals(BookID.ToLower()));
            // Are you sure ? For history purposes you should maybve think of somethjing else ?
            //Loans.Remove(loanToRemove);
            //book.IsAvailable = true;
            //book.ReturnDate = DateTime.Now;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BookAmount"></param>
        /// <param name="BookID"></param>
        /// <param name="PersonID"></param>
        /// todo remove book amount and move to list
        public void ReturnMany(int BookAmount, string BookID, string PersonID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Loan> GetLoansList()
        {
            return Loans;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loans"></param>
        public void SetLoansList(List<Loan> loans)
        {
            Loans = loans;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteAllRecords()
        {
            //books.Clear();
            throw new NotImplementedException();
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

    }
}