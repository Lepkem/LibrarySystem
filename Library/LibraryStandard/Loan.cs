namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;

    public class Loan 
    {
        public Loan()
        {

        }

        public string BookID { get; set; }
        public string PersonID { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}