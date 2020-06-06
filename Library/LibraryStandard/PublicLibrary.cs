namespace LibraryStandard
{
    using System.Collections.Generic;

    using LibraryStandard.Helpers;
    using LibraryStandard.Interfaces;

    public class PublicLibrary
    {
        public ILoanAdministration _loanAdministration { get; set; }

        public PublicLibrary(ILoanAdministration loanadministration, ICatalogPerson catalogperson, ICatalog catalog, IBackUp backup)
        {
            ILoanAdministration _loanAdministration = loanadministration;
            ICatalogPerson _catalogPerson = catalogperson;
            ICatalog _catalog = catalog;
            IBackUp _backup = backup;
        }

        public static void Init()
        {
            Catalog.Instance.SetBookList(DataOperator.Instance.DeserializeJson<List<Book>>(DataOperator.Instance.ReadFromFile(@"Data\Books.json")));
        }

    }
}