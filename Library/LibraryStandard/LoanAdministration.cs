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
            try
            {
                var loanToInactivate = Loans.First(loan => loan.BookID.ToLower().Equals(BookID.ToLower()));
                if (loanToInactivate.ReturnDate > DateTime.Now)
                {
                    Console.WriteLine($"Please pay a fine of €{3*(loanToInactivate.DaysTooLate())}");
                }
                Book bookToActivate = Catalog.Instance.SearchBookByID(BookID);
                bookToActivate.SetAvailability(true);
                loanToInactivate.SetLoanStatus(false);
            }
            catch (Exception e)
            {
                StandardMessages.Instance.TryAgain();
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BookAmount"></param>
        /// <param name="BookID"></param>
        /// <param name="PersonID"></param>
        /// todo remove book amount and move to list
        public void ReturnMany(List<string> BookID)
        {
            foreach (string bookID in BookID)
            {
                ReturnOne(bookID);
            }
            
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

        //todo daystoolate createfine function

        
    }
}