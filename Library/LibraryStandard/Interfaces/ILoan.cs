namespace LibraryStandard
{
    public interface ILoan
    {
        /// <summary>
        /// MakeLoanActive is a private method to make the Loan active 
        /// </summary>
        /// <param name="loan"></param>
        void  SetLoanStatus(bool active);

        /// <summary>
        /// SetReturnDate sets the return date of the book 
        /// </summary>
        /// <param name="loan"></param>
        void  SetReturnDate();

        void ShowLoanProp();

        int DaysTooLate();
    }
}