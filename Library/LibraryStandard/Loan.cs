namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;

    public class Loan : ILoan
    {
        public Loan()
        {
            ID = $"LID{Guid.NewGuid()}";
        }

        public readonly string ID;
        public string BookID { get; set; }
        public string PersonID { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// MakeLoanActive is a private method to make the Loan active 
        /// </summary>
        /// <param name="loan"></param>
         public void  SetLoanStatus(bool active)
        {
            IsActive = active;
        }

        /// <summary>
        /// SetReturnDate sets the return date of the book 
        /// </summary>
        /// <param name="loan"></param>
         public void  SetReturnDate()
        {
            ReturnDate = DateTime.Now.AddDays(14);
        }

        public void ShowLoanProp()
        {
            Console.WriteLine($"\n*********** {this.GetType().ToString()} details **********");
            Console.WriteLine($"Book ID:       {BookID}");
            Console.WriteLine($"Person ID:     {PersonID}");
            Console.WriteLine($"Loan activity: {IsActive}");
            Console.WriteLine($"Return date:   {ReturnDate}");
            Console.WriteLine($"Loan ID:       {ID}\n");
        }

        public int DaysTooLate()
        {
            return ReturnDate.Day - DateTime.Now.Day;
        }
    }
}