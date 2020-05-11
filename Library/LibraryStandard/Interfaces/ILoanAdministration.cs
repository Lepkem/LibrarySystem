namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;

    public interface ILoanAdministration
    {
        void BorrowOne(string BookID, string PersonID);

        void BorrowMany(List<string> BookIDs, string PersonID);

        void ReturnOne(string BookID, string PersonID);

        void ReturnMany(List<string> BookIDs, string PersonID);

        List<LoanAdministration> GetLoanAdminList();

        void SetBookList(List<LoanAdministration> newLoanAdmin);

        void DeleteLoanAdminList();

        bool AddNewLoan(Loan loan);
    }
}