namespace LibraryStandard
{
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

        public string PersonID { get; set; }
        public string BookID { get; set; }

        public void Borrow(string BookID, string PersonID)
        {

        }

        public void Borrow(Book book, Person person)
        {

        }
    }
}

/*
 * LoanAdministration.Instance.Borrow(BookID,PersonID)
 *
 */
