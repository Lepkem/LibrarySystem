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

        public static LoanAdministration Instance;

        protected List<Loan> Loans = new List<Loan>();




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

        public void BorrowOne(string BookID, string PersonID)
        {
            Loan loan = new Loan();
            Book book = Catalog.Instance.SearchBookByID(BookID);
            if(!(String.IsNullOrEmpty(book.AuthorName)) && !(String.IsNullOrEmpty(book.Title)))
            {
                book.IsAvailable = false;
                loan.ReturnDate = DateTime.Now.AddDays(14);
                loan.PersonID = PersonID;
                loan.BookID = BookID;
                loan.IsActive = true;
                Loans.Add(loan);
            }
            else
            {
                StandardMessages.Instance.NoSearchResults();
                StandardMessages.Instance.TryAgain();
            }
        }


        public void BorrowMany(List<string> BookIDs, string PersonID)
        {
            
        }

        public void ReturnOne(string BookID, string PersonID)
        {
            var loanToRemove = Loans.Where(loan => loan.BookID.ToLower().Equals(BookID.ToLower()));
            // Are you sure ? For history purposes you should maybve think of somethjing else ?
            Loans.Remove(loanToRemove);
            book.IsAvailable = true;
            book.ReturnDate = DateTime.Now;
        }


        public void ReturnMany(int BookAmount, string BookID, string PersonID)
        {
            ReturnOne();
        }


        public List<LoanAdministration> GetLoanAdminList()
        {
            //naming ;
        }

        public void SetBookList(List<LoanAdministration> newLoanAdmin)
        {
            books = newLoanAdmin;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteLoanAdminList()
        {
            books.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        public bool AddNewLoan(Loan loan)
        {
            Loans.Add(loan);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookID"></param>
        public void SearchLoansByBook(string bookID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PersonID"></param>
        public void SearchLoansByPerson(string PersonID)
        {
            throw new NotImplementedException();
        }
    }
}

/*
 * LoanAdministration.Instance.Borrow(BookID,PersonID)
 *
 */
